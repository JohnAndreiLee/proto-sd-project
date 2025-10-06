using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for student profile information and academic data display
    /// </summary>
    /// <remarks>
    /// This view model represents essential student information used throughout the system:
    /// - Student identification and contact information
    /// - Academic profile data for consultation context
    /// - Integration with university systems and records
    /// 
    /// **Usage Scenarios:**
    /// - Student profile display in dashboards and interfaces
    /// - Consultation request context and routing
    /// - Academic record integration and reporting
    /// - Communication and notification targeting
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "studentUMID": "2024001",
    ///   "studentName": "John Doe",
    ///   "email": "john.doe@university.edu"
    /// }
    /// </code>
    /// </example>
    public class StudentViewModel
    {
        /// <summary>
        /// University Member ID specific to the student's academic record
        /// </summary>
        /// <remarks>
        /// The student's unique institutional identifier linking to:
        /// - Official academic transcripts and records
        /// - Course enrollment and registration systems
        /// - Financial aid and billing information
        /// - Library and campus services access
        /// 
        /// **System Integration:**
        /// - Links to university student information system
        /// - Enables cross-system data synchronization
        /// - Supports academic reporting and compliance
        /// - Facilitates institutional data analytics
        /// 
        /// /// **Data Validation:**
        /// - Must be unique across all students
        /// - Validated against institutional directory
        /// - Requid for all student operations
        /// - Immutable once assigned to maintain data integrity
        /// </remarks>
        /// <example>2024001</example>
        [Required(ErrorMessage = "Student UMID is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Student UMID must be between 4 and 20 characters")]
        public string StudentUMID { get; set; } = string.Empty;

        /// <summary>
        /// Full legal name of the student as registered with the institution
        /// </summary>
        /// <remarks>
        /// The student's official name used for:
        /// - Academic record identification and verification
        /// - Consultation request display and faculty communication
        /// /// - Official transcripts and certification documents
        /// - System notifications and personalized communication
        /// 
        /// **Name Standards:**
        /// - Must match official institutional records
        /// - Used for legal and academic documenta
       /// - Displayed in faculty-facing consultation interfaces
        /// - Linked to graduation and certification processes
        /// 
        /// **Privacy and Security:**
        /// - Displayed only to authorized system users
        /// - Protected under educational privacy regulations
        /// - Used for official communication and verification
        /// - Maintained with institutional data governance standards
        /// </remarks>
        /// <example>John Doe</example>
        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Student name must be between 2 and 100 characters")]
        public string StudentName { get; set; } = string.Empty;

        /// <summary>
        /// Primary email address for student communication and system access
        /// </summary>
        /// <remarks>
        /// The student's institutional or personal email address serving as:
        /// - Primary communication channel for consultation updates
        /// - System notification delivery endpoint
        /// - Account recovery and verification contact
        /// - Integration with university email systems
        /// 
        /// **Communication Functions:**
        /// - Consultation status updates and notifications
        /// - Academic calendar and deadline reminders
        /// - System announcements and important updates
        /// - Faculty communication and consultation coordination
        /// 
        /// **Email Management:**
        /// - Validated for proper format and deliverability
        /// - Synchronized with institutional email systems
        /// - Used for automated system communications
        /// - Supports email preference and notification settings
        /// 
        /// **Privacy Considerations:**
        /// - Shared only with authorized faculty and staff
        /// - Protected under educational privacy regulations
        /// - Used exclusively for academic and administrative purposes
        /// - Maintained with institutional data security standards
        /// </remarks>
        /// <example>john.doe@university.edu</example>
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(100, ErrorMessage = "Email address cannot exceed 100 characters")]
        public string Email { get; set; } = string.Empty;
    }
}