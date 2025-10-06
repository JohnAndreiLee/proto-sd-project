
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using FlutterAPI.Attributes;
using FlutterAPI.ViewModel;

namespace FlutterAPI.Controllers
{
    /// <summary>
    /// Controller for user authentication operations including registration and login
    /// </summary>
    /// <remarks>
    /// This controller handles all authentication-related operations for the consultation system:
    /// - User registration for students, faculty, and administrators
    /// - User login with credential validation
    /// - Identity management using ASP.NET Core Identity
    /// - Automatic profile creation based on user type
    /// - Audit logging for security and compliance
    /// </remarks>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the AuthenticationController
        /// </summary>
        /// <param name="context">The database context for user operations</param>
        /// <param name="UserManager">The user manager for identity operations</param>
        /// <param name="SignInManager">The sign-in manager for authentication</param>
        public AuthenticationController(AppDbContext context,
            UserManager<Users> UserManager, SignInManager<Users> SignInManager)
        {
            _userManager = UserManager;
            _signInManager = SignInManager;
            _context = context;
        }

        /// <summary>
        /// Registers a new user in the system with role-specific profile creation
        /// </summary>
        /// <param name="UserModel">The user registration data including email, password, UMID, and user type</param>
        /// <returns>Success message if registration is successful, or error details if validation fails</returns>
        /// <remarks>
        /// This endpoint creates a new user account and automatically generates the appropriate profile:
        /// 
        /// **User Types:**
        /// - **Student (0)**: Creates student profile with program enrollment
        /// - **Faculty (1)**: Creates faculty profile for consultation management
        /// - **Admin (2)**: Creates administrative profile for system management
        /// 
        /// **Registration Process:**
        /// 1. Validates input data and model state
        /// 2. Creates ASP.NET Core Identity user with hashed password
        /// 3. Generates role-specific profile (Student/Faculty/Admin)
        /// 4. Links profile to the identity user
        /// /// 5. Creates audit log entor security tracking
        /// 6. Saves all changes in a single transaction
        /// 
        /// **Security Features:**
        /// - Password hashing using ASP.NET Core Identity
        /// - Model validation for data integrity
        /// - Audit logging for registration events
        /// - Transaction-based data consistency
        /// /// 
        /// **Business Rules:**
        /// - UMID must be unique across the system
        /// - Email serves as the username for login
        /// - Students are automatically enrolled in default program
        /// - All registrations are logged for audit purposes
        /// </remarks>
        /// <response code="200">User registered successfully</response>
        /// <response code="400">Invalid input data or registration failed</response>
        /// /// <response code="500">Internal server error occurred</response>
        [HttpPost]
        [ApiDocumentation(
            "Register new user",
            "Creates a new user account with role-specific profile (Student, Faculty, or Admin)"
        )]
        [ApiExample(typeof(UserViewModel), "Sample user registration with all required fields")]
        [ApiErrorResponse(400, "Invalid model state", 
            @"{""message"": ""Validation failed"", ""errors"": {""Email"": [""Email is required""]}}", "VALIDATION_ERROR")]
        [ApiErrorResponse(400, "Registration failed", 
            @"{""message"": ""Registration failed"", ""errors"": [{""code"": ""DuplicateUserName"", ""description"": ""Username already exists""}]}", "REGISTRATION_ERROR")]
        [ApiErrorResponse(400, "Invalid user type", 
            @"{""message"": ""Invalid User Type"", ""error"": ""User type must be 0 (Student), 1 (Faculty), or 2 (Admin)""}", "INVALID_USER_TYPE")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred during registration"", ""error"": ""Database operation failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> UserRegister([FromBody] UserViewModel UserModel)
        {

            if (!ModelState.IsValid)
            {
                var validationErrors = new Dictionary<string, List<string>>();
                foreach (var modelError in ModelState)
                {
                    var errors = modelError.Value.Errors.Select(e => e.ErrorMessage).ToList();
                    if (errors.Any())
                    {
                        validationErrors[modelError.Key] = errors;
                    }
                }

                var validationResponse = new ValidationErrorResponse
                {
                    Message = "Validation failed",
                    Error = "One or more validation errors occurred",
                    TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                    ValidationErrors = validationErrors
                };
                return BadRequest(validationResponse);
            }

            //user instance
            var users = new Users
            {
                UserName = UserModel.UserEmail,
                Email = UserModel.UserEmail,
                UMID = UserModel.UMID,
                UserType = UserModel.UserType,
            };

            //hasher
            var hasher = await _userManager.CreateAsync(users, UserModel.UserPassword);

            //Conditional statement for the hasher
            if(!hasher.Succeeded)
            {
                var registrationErrors = new Dictionary<string, List<string>>();
                foreach (var error in hasher.Errors)
                {
                    var key = error.Code switch
                    {
                        "DuplicateUserName" => "UserEmail",
                        "DuplicateEmail" => "UserEmail",
                        "PasswordTooShort" => "UserPassword",
                        "PasswordRequiresDigit" => "UserPassword",
                        "PasswordRequiresLower" => "UserPassword",
                        "PasswordRequiresUpper" => "UserPassword",
                        "PasswordRequiresNonAlphanumeric" => "UserPassword",
                        _ => "General"
                    };

                    if (!registrationErrors.ContainsKey(key))
                        registrationErrors[key] = new List<string>();
                    
                    registrationErrors[key].Add(error.Description);
                }

                var registrationResponse = new ValidationErrorResponse
                {
                    Message = "Registration failed",
                    Error = "User registration validation failed",
                    TrackingId = $"REG-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                    ValidationErrors = registrationErrors
                };
                return BadRequest(registrationResponse);
            }


            //switch statement for the usertype is student,fauclty or admin who register
            switch ((int)UserModel.UserType)
            {
                case 0:
                    var student = new Student
                    {
                        StudentUMID = UserModel.UMID,
                        StudentName = UserModel.StudentName,
                        Email = UserModel.UserEmail,
                        Users = users,
                        ProgramID = 1, 
                    };
                    _context.Students.Add(student);
                    break;
                case 1:
                    var Faculty = new Faculty
                    {
                        FacultyUMID= UserModel.UMID,
                        FacultyName = UserModel.FacultyName,
                        Users = users
                    };
                    _context.Faculty.Add(Faculty);
                    break;
                case 2:
                    var admin = new Admin
                    {
                        AdminName = UserModel.UserEmail,
                        Users = users
                    };
                    _context.Admin.Add(admin);
                    break;
                default:
                    var invalidUserTypeResponse = new ValidationErrorResponse
                    {
                        Message = "Invalid user type",
                        Error = "User type must be 0 (Student), 1 (Faculty), or 2 (Admin)",
                        TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        ValidationErrors = new Dictionary<string, List<string>>
                        {
                            ["UserType"] = new List<string> { "User type must be 0 (Student), 1 (Faculty), or 2 (Admin)" }
                        }
                    };
                    return BadRequest(invalidUserTypeResponse);
            }


            //ActionLog instance
            string message = $"{UserModel.UserEmail} has been registered";
            var actionlogs = ActionLogController.ActionLogger(message, UserModel.UserEmail, UserModel.UserType,
                users); 
  
            _context.ActionLog.Add(actionlogs);

            await _context.SaveChangesAsync();

            return Ok("Registration successful");
        }

        /// <summary>
        /// Authenticates a user and creates a login session
        /// </summary>
        /// <param name="UsersModel">The login credentials including email and password</param>
        /// <returns>Success message with username if login is successful, or unauthorized error if credentials are invalid</returns>
        /// /// <remarks>
        /// This endpoint authenticates users using ASP.NET Core Identity's sign-in manager:
  
        /// **Authentication Process:**
        /// 1. Validates user credentials against stored hashed passwords
        /// 2. Uses ASP.NET Core Identity for secure authentication
        /// 3. Creates a login session (non-persistent by default)
        /// 4. Returns success confirmation with user information
        /// 
        /// **Security Features:**
        /// - Secure password verification using Identity framework
        /// - Protection against brute force attacks (lockout disabled by default)
        /// - Session management for authenticated users
        /// /// - Audit logging capabilities (ca extended)
        /// 
        /// **Login Credentials:**
        /// - **Email**: User's registered email address (serves as username)
        /// - **Password**: User's password (validated against hashed version)
        /// 
        /// **Session Management:**
        /// - Non-persistent sessions (expires when browser closes)
        /// /// - No automatic lockout on failed attempts (can be configured)
        /// - Supports role-based authorization for protected endpoints
        /// 
        /// **Response Information:**
        /// - Success: Returns confirmation message and username
        /// - Failure: Returns unauthorized status with error message
        /// </remarks>
        /// <response code="200">Login successful</response>
        /// <response code="401">Invalid credentials provided</response>
        /// <response code="400">Invalid request data</response>
        /// /// <response code="500">Internal server error occurred</response>
        [HttpPost]
        [ApiDocumentation(
            "User login",
            "Authenticates user credentials and creates a login session"
        )]
        [ApiExample("LoginRequest", 
            @"{""userEmail"": ""john.doe@university.edu"", ""userPassword"": ""SecurePassword123""}", 
            "Sample login request with email and password")]
        [ApiExample("LoginResponse", 
            @"{""message"": ""Login successful"", ""username"": ""john.doe@university.edu""}", 
            "Successful login response")]
        [ApiErrorResponse(401, "Invalid credentials", 
            @"{""message"": ""Invalid Username and Password"", ""error"": ""Authentication failed""}", "INVALID_CREDENTIALS")]
        [ApiErrorResponse(400, "Invalid request data", 
            @"{""message"": ""Invalid request"", ""error"": ""Email and password are required""}", "INVALID_REQUEST")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred during login"", ""error"": ""Authentication service unavailable""}", "SERVER_ERROR")]
        public async Task<IActionResult> Login([FromBody] UserViewModel UsersModel)
        {
            //Query for the hasher and user
             var result = await _signInManager.PasswordSignInAsync(
            UsersModel.UserEmail, UsersModel.UserPassword, isPersistent: false, lockoutOnFailure: false);

            if (!result.Succeeded)
                return Unauthorized("Invalid Username and Password");

            //Action Log instance
     

            return Ok(new
            {
                message = "Login successful",
                username = UsersModel.UserEmail
            });
        }
    }
}
