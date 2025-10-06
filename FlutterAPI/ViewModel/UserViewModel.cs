using Consultation.Domain;
using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for user registration and authentication operations
    /// </summary>
    /// <remarks>
    /// This comprehensive view model handles user account creation and authentication for all user types:
    /// - Student registration with academic profile creation
    /// - Faculty registration with teaching profile setup
    /// - Administrator registration with system access privileges
    /// 
    /// The model supports the complete user lifecycle from initial registration through
    /// authentication and profile management across different user roles.
    /// 
    /// **Security Features:**
    /// - Password validation and secure hashing
    /// - Email verification and validation
    /// - UMID (University Member ID) uniqueness enforcement
    /// - Role-based access control setup
    /// </remarks>
    /// <example>
    /// Example JSON for student registration:
    /// <code>
    /// {
    ///   "userEmail": "john.doe@university.edu",
    ///   "umid": "2024001",
    ///   "userPassword": "SecurePassword123!",
    ///   "userType": 0,
    ///   "studentName": "John Doe"
    /// }
    /// </code>
    /// </example>
    public class UserViewModel
    {
        /// <summary>
        /// Unique identifier for the user account (typically auto-generated)
        /// </summary>
        /// <remarks>
        /// System-generated unique identifier for user accounts. This field is primarily
        /// used for internal system operations and database relationships.
        /// During registration, this field is typically empty and populated by the system.
        /// </remarks>
        /// <example>12345</example>
        public string UserID { get; set; } = string.Empty;

        /// <summary>
        /// Email address serving as the primary username for authentication
        /// </summary>
        /// <remarks>
        /// The email address serves multiple purposes in the system:
        /// - Primary authentication username for login
        /// - Communication channel for system notifications
        /// - Unique identifier for user accounts
        /// - Contact information for consultation coordination
        /// 
        /// **Validation Requirements:**
        /// - Must be a valid email format
        /// - Must be unique across the system
        /// - Required for all user registrations
        /// - Used for password recovery and account verification
        /// </remarks>
        /// <example>john.doe@university.edu</example>
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(100, ErrorMessage = "Email address cannot exceed 100 characters")]
        public string UserEmail { get; set; } = string.Empty;

        /// <summary>
        /// University Member ID - unique institutional identifier for all users
        /// </summary>
        /// <remarks>
        /// The UMID (University Member ID) is the official institutional identifier:
        /// - Unique across the entire university system
        /// - Links to official academic records
        /// - Used for institutional reporting and compliance
        /// - Enables integration with other university systems
        /// 
        /// **Format and Validation:**
        /// - Typically numeric or alphanumeric format
        /// - Must be unique across all user types
        /// - Validated against institutional directory
        /// - Required for all user registrations
        /// 
        /// **Business Applications:**
        /// - Academic record linkage
        /// - Financial aid and billing integration
        /// - Library and campus services access
        /// - Official transcript and certification
        /// </remarks>
        /// <example>2024001</example>
        [Required(ErrorMessage = "University Member ID (UMID) is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "UMID must be between 4 and 20 characters")]
        public string UMID { get; set; } = string.Empty;

        /// <summary>
        /// User password for authentication (will be securely hashed before storage)
        /// </summary>
        /// <remarks>
        /// Password for user authentication with security requirements:
        /// 
        /// **Security Requirements:**
        /// - Minimum length enforced by system configuration
        /// - Complexity requirements (digits, special characters)
        /// - Securely hashed using ASP.NET Core Identity
        /// - Never stored in plain text
        /// 
        /// **Password Policy:**
        /// - Must contain at least one digit
        /// - Minimum 10 characters length (configurable)
        /// - Special characters recommended but not required
        /// - Regular password updates encouraged
        /// 
        /// **Security Features:**
        /// - Automatic hashing before database storage
        /// - Protection against common password attacks
        /// - Integration with account lockout policies
        /// - Support for password recovery workflows
        /// </remarks>
        /// <example>SecurePassword123!</example>
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
        public string UserPassword { get; set; } = string.Empty;

        /// <summary>
        /// Type of user account determining system access and functionality
        /// </summary>
        /// <remarks>
        /// Defines the user's role and access level within the system:
        /// 
        /// **User Type Values:**
        /// - **0 (Student)**: Access to consultation requests, course information, dashboard
        /// - **1 (Faculty)**: Access to consultation management, student requests, scheduling
        /// - **2 (Admin)**: Full system access, user management, system configuration
        /// 
        /// **Role-Based Access:**
        /// - Determines available system features and endpoints
        /// - Controls data visibility and modification permissions
        /// - Enables role-specific user interfaces and workflows
        /// - Supports hierarchical access control
        /// 
        /// **Profile Creation:**
        /// - Automatically creates appropriate profile (Student/Faculty/Admin)
        /// - Links to role-specific data and relationships
        /// - Enables role-based notification and communication
        /// - Supports role transition and management
        /// </remarks>
        /// <example>0</example>
        public UserType UserType { get; set; } = UserType.Student;

        /// <summary>
        /// Full name for student users (required when UserType is Student)
        /// </summary>
        /// <remarks>
        /// Student's full name used for:
        /// - Student profile creation and identification
        /// - Consultation request display and routing
        /// - Academic record linkage and reporting
        /// - Communication and notification personalization
        /// 
        /// **Usage Context:**
        /// - Required only when registering as a student (UserType = 0)
        /// - Used to create Student entity in the database
        /// - Displayed in faculty consultation request reviews
        /// - Linked to academic transcripts and records
        /// </remarks>
        /// <example>John Doe</example>
        [StringLength(100, ErrorMessage = "Student name cannot exceed 100 characters")]
        public string StudentName { get; set; } = string.Empty;

        /// <summary>
        /// Full name for faculty users (required when UserType is Faculty)
        /// </summary>
        /// <remarks>
        /// Faculty member's full name used for:
        /// - Faculty profile creation and identification
        /// - Course assignment and consultation management
        /// - Student-facing consultation request interfaces
        /// - Academic department and program association
        /// 
        /// **Usage Context:**
        /// - Required only when registering as faculty (UserType = 1)
        /// - Used to create Faculty entity in the database
        /// - Displayed in student course listings and consultation options
        /// - Linked to course assignments and academic schedules
        /// </remarks>
        /// <example>Dr. Jane Smith</example>
        [StringLength(100, ErrorMessage = "Faculty name cannot exceed 100 characters")]
        public string FacultyName { get; set; } = string.Empty;

        /// <summary>
        /// Full name for administrator users (required when UserType is Admin)
        /// </summary>
        /// <remarks>
        /// Administrator's full name used for:
        /// - Admin profile creation and identification
        /// - System audit logs and administrative tracking
        /// - User management and system configuration
        /// - Security and compliance reporting
        /// 
        /// **Usage Context:**
        /// - Required only when registering as administrator (UserType = 2)
        /// - Used to create Admin entity in the database
        /// - Displayed in system logs and administrative interfaces
        /// - Linked to system management and configuration activities
        /// </remarks>
        /// <example>System Administrator</example>
        [StringLength(100, ErrorMessage = "Admin name cannot exceed 100 characters")]
        public string AdminName { get; set; } = string.Empty;
    }
}