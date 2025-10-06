using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using FlutterAPI.Attributes;
using FlutterAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    /// <summary>
    /// Controller for managing consultation requests between students and faculty members
    /// </summary>
    /// <remarks>
    /// This controller provides endpoints for creating consultation requests, retrieving consultation history,
    /// and accessing student course information for consultation purposes.
    /// </remarks>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ConsultationController: ControllerBase
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the ConsultationController
        /// </summary>
        /// <param name="context">The database context for consultation operations</param>
        public ConsultationController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new consultation request between a student and faculty member
        /// </summary>
        /// <param name="ConsultationRequest">The consultation request details including student name, faculty name, course code, concern, and preferred date</param>
        /// <returns>A success message with the consultation ID if created successfully, or error details if validation fails</returns>
        /// <remarks>
        /// This endpoint allows students to request consultations with faculty members for specific courses.
        /// The system validates that both the student and faculty exist in the database before creating the request.
        /// The consultation date must be in the future, and all required fields must be provided.
        /// 
        /// **Business Rules:**
        /// - Student name, faculty name, course code, and concern are required
        /// - Consultation date must be in the future
        /// - Both student and faculty must exist in the system
        /// - Request is automatically set to "Pending" status
        /// - An action log entry is created for audit purposes
        /// </remarks>
        /// <response code="200">Consultation request created successfully</response>
        /// <response code="400">Invalid input data or validation errors</response>
        /// <response code="404">Student or faculty not found</response>
        /// <response code="500">Internal server error occurred</response>
        [HttpPost]
        [ApiAuthentication("Bearer", new[] { "Student" }, "JWT token required for creating consultation requests")]
        [ApiDocumentation(
            "Create consultation request",
            "Creates a new consultation request between a student and faculty member for a specific course"
        )]
        [ApiExample(typeof(ConsultationViewModel), "Sample consultation request with all required fields")]
        [ApiErrorResponse(401, "Unauthorized", 
            @"{""message"": ""Authentication required"", ""error"": ""Valid JWT token must be provided""}", "AUTHENTICATION_REQUIRED")]
        [ApiErrorResponse(403, "Forbidden", 
            @"{""message"": ""Access denied"", ""error"": ""Student role required""}", "INSUFFICIENT_PERMISSIONS")]
        [ApiErrorResponse(400, "Invalid request data", 
            @"{""message"": ""Student name is required."", ""error"": ""Validation failed""}", "VALIDATION_ERROR")]
        [ApiErrorResponse(404, "Student or faculty not found", 
            @"{""message"": ""Student not found"", ""error"": ""Entity not found""}", "ENTITY_NOT_FOUND")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while processing the consultation request"", ""error"": ""Database connection failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> RequestConsultation([FromBody] ConsultationViewModel ConsultationRequest)
        {
            try
            {
                // Validate model state
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

                // Validate request body
                if (ConsultationRequest == null)
                {
                    var errorResponse = new ApiErrorResponse
                    {
                        Message = "Invalid request",
                        Error = "Request body is empty or malformed",
                        TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                    };
                    return BadRequest(errorResponse);
                }

                // Validate required fields
                var validationErrorsList = new Dictionary<string, List<string>>();

                if (string.IsNullOrWhiteSpace(ConsultationRequest.StudentName))
                    validationErrorsList["StudentName"] = new List<string> { "Student name is required" };

                if (string.IsNullOrWhiteSpace(ConsultationRequest.FacultyName))
                    validationErrorsList["FacultyName"] = new List<string> { "Faculty name is required" };

                if (string.IsNullOrWhiteSpace(ConsultationRequest.CourseCode))
                    validationErrorsList["CourseCode"] = new List<string> { "Course code is required" };

                if (string.IsNullOrWhiteSpace(ConsultationRequest.Concern))
                    validationErrorsList["Concern"] = new List<string> { "Concern description is required" };

                // Validate date
                if (ConsultationRequest.DateOfConsultation <= DateTime.Now)
                    validationErrorsList["DateOfConsultation"] = new List<string> { "Consultation date must be in the future" };

                if (validationErrorsList.Any())
                {
                    var fieldValidationResponse = new ValidationErrorResponse
                    {
                        Message = "Validation failed",
                        Error = "Required fields are missing or invalid",
                        TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        ValidationErrors = validationErrorsList
                    };
                    return BadRequest(fieldValidationResponse);
                }

                // Query for student
                var student = await _context.Students
                    .Include(s => s.Users)
                    .FirstOrDefaultAsync(s => s.StudentName == ConsultationRequest.StudentName);

                // Query for faculty
                var faculty = await _context.Faculty
                    .FirstOrDefaultAsync(f => f.FacultyName == ConsultationRequest.FacultyName);

                if (student == null)
                {
                    var notFoundResponse = new ApiErrorResponse
                    {
                        Message = "Student not found",
                        Error = $"No student record found with name '{ConsultationRequest.StudentName}'",
                        TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                    };
                    return NotFound(notFoundResponse);
                }

                if (faculty == null)
                {
                    var notFoundResponse = new ApiErrorResponse
                    {
                        Message = "Faculty not found",
                        Error = $"No faculty record found with name '{ConsultationRequest.FacultyName}'",
                        TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                    };
                    return NotFound(notFoundResponse);
                }

                var consultation = new ConsultationRequest
                {
                    Student = student,
                    Faculty = faculty,
                    SubjectCode = ConsultationRequest.CourseCode,
                    DateSchedule = ConsultationRequest.DateOfConsultation,
                    DisapprovedReason = ConsultationRequest.DisapprovedReason,
                    Concern = ConsultationRequest.Concern,
                    DateRequested = DateTime.Now,
                    Status = Status.Pending
                };

                _context.ConsultationRequest.Add(consultation);

                string message = $"{student.StudentName} has requested consultation";
                var actionlogs = ActionLogController.ActionLogger(message, student.StudentName, 0, student.Users);

                _context.ActionLog.Add(actionlogs);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Consultation request submitted successfully", consultationId = consultation.ConsultationID });
            }
            catch (Exception ex)
            {
                var serverErrorResponse = new ApiErrorResponse
                {
                    Message = "Internal server error",
                    Error = "An error occurred while processing the consultation request",
                    TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                };
                return StatusCode(500, serverErrorResponse);
            }
        }

        /// <summary>
        /// Retrieves all consultation requests for a specific student
        /// </summary>
        /// <param name="studentId">The unique identifier of the student (must be greater than 0)</param>
        /// <returns>A list of consultation requests associated with the specified student, including student and faculty details</returns>
        /// <remarks>
        /// This endpoint returns all consultation requests (past and present) for a given student.
        /// /// The response includes full details of each consultation request with related student and faculty information.
        /// 
        /// **Usage Notes:**
        /// - Student ID must be a positive integer
        /// - Returns empty list if student has no consultation requests
        /// - Includes conion status, dates, concerns, and faculty responses
        /// - Results are not filtered by status - all requests are returned
        /// </remarks>
        /// <response code="200">List of consultation requests retrieved successfully</response>
        /// <response code="400">Invalid student ID provided</response>
        /// <response code="500">Internal server error occurred</response>
        [HttpGet]
        [ApiAuthentication("Bearer", new[] { "Student", "Faculty", "Admin" }, "JWT token required for accessing consultation data")]
        [ApiDocumentation(
            "Get student consultations",
            "Retrieves all consultation requests for a specific student with full details"
        )]
        [ApiExample("StudentConsultations", 
            @"[{""consultationID"": 1, ""studentName"": ""John Doe"", ""facultyName"": ""Dr. Smith"", ""status"": ""Approved"", ""dateSchedule"": ""2024-12-15T14:30:00""}]",
            "Example response showing student's consultation requests")]
        [ApiErrorResponse(401, "Unauthorized", 
            @"{""message"": ""Authentication required"", ""error"": ""Valid JWT token must be provided""}", "AUTHENTICATION_REQUIRED")]
        [ApiErrorResponse(403, "Forbidden", 
            @"{""message"": ""Access denied"", ""error"": ""Insufficient permissions to access consultation data""}", "INSUFFICIENT_PERMISSIONS")]
        [ApiErrorResponse(400, "Invalid student ID", 
            @"{""message"": ""Invalid student ID"", ""error"": ""Student ID must be greater than 0""}", "INVALID_STUDENT_ID")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while retrieving consultations"", ""error"": ""Database query failed""}", "SERVER_ERROR")]
        public async Task<ActionResult<IEnumerable<ConsultationRequest>>> ShowConsultation(int studentId)
        {
            try
            {
                if (studentId <= 0)
                {
                    var validationResponse = new ValidationErrorResponse
                    {
                        Message = "Invalid student ID",
                        Error = "Student ID must be a positive integer greater than 0",
                        TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        ValidationErrors = new Dictionary<string, List<string>>
                        {
                            ["studentId"] = new List<string> { "Student ID must be greater than 0" }
                        }
                    };
                    return BadRequest(validationResponse);
                }

                var result = await _context.ConsultationRequest
                    .Include(s => s.Student)
                    .Include(s => s.Faculty)
                    .Where(s => s.Student.StudentID == studentId)
                    .ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                var serverErrorResponse = new ApiErrorResponse
                {
                    Message = "Internal server error",
                    Error = "An error occurred while retrieving consultations",
                    TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                };
                return StatusCode(500, serverErrorResponse);
            }
        }

        /// <summary>
        /// Retrieves course information and school year details for a specific student
        /// </summary>
        /// <param name="studentId">The unique identifier of the student (must be greater than 0)</param>
        /// <returns>Student's current school year information and enrolled courses with instructor details</returns>
        /// <remarks>
        /// This endpoint provides essential information needed for consultation requests, including:
        /// - Current school year and semester information
        /// - List of enrolled courses with course codes and names
        /// /// - Assigned faculty/instructor for each course
        /// 
        /// **Data Structure:**
        /// - School year format: "{Semester} {StartYear}-{En(e.g., "First Semester 2024-2025")
        /// - Courses include code, name, and instructor information
        /// - Missing instructor information is displayed as "TBA" (To Be Announced)
        /// 
        /// **Audit Trail:**
        /// - Creates an action log entry when student accesses course information
        /// /// - Logs are used for tracking student engagement and system usage
        /// </remarks>
        /// /// <response code="200">Student course information reved successfully</response>
        /// <response code="400">Invalid student ID provided</response>
        /// <response code="404">Student not found or missing school year information</response>
        /// <response code="500">Internal server error occurred</response>
        [HttpGet("student-courses/{studentId}")]
        [ApiDocumentation(
            "Get student courses",
            "Retrieves current school year and enrolled course information for a student"
        )]
        [ApiExample("StudentCourses", 
            @"{""schoolYear"": ""First Semester 2024-2025"", ""courses"": [{""code"": ""CS101"", ""course"": ""Introduction to Programming"", ""instructor"": ""Dr. Johnson""}]}",
            "Example response showing student's course information")]
        [ApiErrorResponse(400, "Invalid student ID", 
            @"{""message"": ""Invalid student ID"", ""error"": ""Student ID must be greater than 0""}", "INVALID_STUDENT_ID")]
        [ApiErrorResponse(404, "Student not found", 
            @"{""message"": ""Student not found."", ""error"": ""No student record found with the provided ID""}", "STUDENT_NOT_FOUND")]
        [ApiErrorResponse(404, "School year not found", 
            @"{""message"": ""Current school year not found."", ""error"": ""Student has no associated school year information""}", "SCHOOL_YEAR_NOT_FOUND")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while retrieving student courses"", ""error"": ""Database query failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> GetStudentCourses(int studentId)
        {
            try
            {
                if (studentId <= 0)
                {
                    var validationResponse = new ValidationErrorResponse
                    {
                        Message = "Invalid student ID",
                        Error = "Student ID must be a positive integer greater than 0",
                        TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        ValidationErrors = new Dictionary<string, List<string>>
                        {
                            ["studentId"] = new List<string> { "Student ID must be greater than 0" }
                        }
                    };
                    return BadRequest(validationResponse);
                }

                var student = await _context.Students
                    .Include(s => s.SchoolYear)
                    .Include(s => s.EnrolledCourses)
                    .ThenInclude(c => c.Faculty)
                    .FirstOrDefaultAsync(s => s.StudentID == studentId);

                if (student == null)
                {
                    var notFoundResponse = new ApiErrorResponse
                    {
                        Message = "Student not found",
                        Error = $"No student record found with ID {studentId}",
                        TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                    };
                    return NotFound(notFoundResponse);
                }

                if (student.SchoolYear == null)
                {
                    var businessLogicResponse = new BusinessLogicErrorResponse
                    {
                        Message = "School year information missing",
                        Error = "Student has no associated school year information",
                        TrackingId = $"BIZ-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        BusinessRuleViolated = "SCHOOL_YEAR_REQUIRED",
                        ContextData = new Dictionary<string, object>
                        {
                            ["studentId"] = studentId,
                            ["studentName"] = student.StudentName
                        },
                        SuggestedActions = new List<string>
                        {
                            "Contact academic advisor to ensure proper school year enrollment",
                            "Verify student registration status for current academic period"
                        }
                    };
                    return NotFound(businessLogicResponse);
                }

                // Convert semester enum to string
                string semesterString = student.SchoolYear.Semester switch
                {
                    Semester.Semester1 => "First Semester",
                    Semester.Semester2 => "Second Semester",
                    Semester.Summer => "Summer",
                    _ => "Unknown Semester"
                };

                string schoolYearString = $"{semesterString} {student.SchoolYear.Year1}-{student.SchoolYear.Year2}";

                var courses = student.EnrolledCourses?.Select(ec => new CourseInfoViewModel
                {
                    Code = ec.CourseCode,
                    Course = ec.CourseName,
                    Instructor = ec.Faculty?.FacultyName ?? "TBA"
                }).ToList() ?? new List<CourseInfoViewModel>();

                var result = new RequestViewModel
                {
                    SchoolYear = schoolYearString,
                    Courses = courses
                };

                // Log the action
                string message = $"{student.StudentName} accessed course information";
                var actionlogs = ActionLogController.ActionLogger(message, student.StudentName, 0, student.Users);

                _context.ActionLog.Add(actionlogs);
                await _context.SaveChangesAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                var serverErrorResponse = new ApiErrorResponse
                {
                    Message = "Internal server error",
                    Error = "An error occurred while retrieving student courses",
                    TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                };
                return StatusCode(500, serverErrorResponse);
            }
        }
    }
}
