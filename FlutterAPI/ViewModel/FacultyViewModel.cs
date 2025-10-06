using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for faculty profile information and academic staff data
    /// </summary>
    /// <remarks>
    /// This view model represents essential faculty information used throughout the consultation system:
    /// - Faculty identification and institutional data
    /// - Course assignment and consultation management context
    /// - Integration with academic department and program structures
    /// 
    /// **System Functions:**
    /// - Faculty profile display in consultation interfaces
    ///  /// - Course uctor assignment and student communication
    /// - Consultation request routing and management
    /// - Academic department reporting and analytics
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "facultyID": 101,
    ///   "facultyUMID": "FAC2024001",
    ///   "facultyName": "Dr. Jane Smith",
    ///   "userID": 12345
    /// }
    /// </code>
    /// </example>
    public class FacultyViewModel
    {
        /// <summary>
        /// Unique system identifier for the faculty member's profile
        /// </summary>
        /// <remarks>
        /// Internal database identifier for faculty records:
        /// - Primary key for faculty data relationships
        /// - Links to course assignments and consultation history
        /// - Enables efficient database queries and joins
        /// - Used for system-internal operations and reporting
        /// 
        /// **Database Relationships:**
        /// - Links to consultation request assignments
        /// - Connects to course teaching assignments
        /// /// - References academic department associations
        /// - Supports faculty workload and analytics tracking
        /// </remarks>
        /// <exampiple>
        [Range(1, int.MaxValue, ErrorMessage = "Faculty ID must be a positive number")]
        public int FacultyID { get; set; }

        /// <summary>
        /// University Member ID specific to the faculty member's institutional record
        /// </summary>
        /// <remarks>
        /// The faculty's unique institutional identifier linking to:
        /// - Official employment and HR records
        /// /// - Academic department and program assignments
        /// /// - Payroll and benefits administration
        /// - Campus services and facility access
        /// 
        /// **Institutional Integration:**
        /// - Links to university faculty directory
        /// - Enables cross-system data synchron
        /// - Supports academic reporng and compliance
        /// - Facilitates institutional analytics and planning
        /// 
        /// **Professional Context:**
        /// - Used for official faculty communications
        /// - Links to research and publication records
        /// - Supports tenure and promotion processes
        /// - Enables academic collaboration tracking
        /// </remarks>
        /// <example>FAC2024001</example>
        [Required(ErrorMessage = "Faculty UMID is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Faculty UMID must be between 4 and 20 characters")]
        public string FacultyUMID { get; set; } = string.Empty;

        /// <summary>
        /// Full professional name of the faculty member including academic titles
        /// </summary>
        /// <remarks>
        /// The faculty member's professional name used for:
        /// - Student-facing course and consultation displays
        /// - Official academic communications and documentation
        /// - Consultation request routing and identification
        /// /// - Academic department and program representation
        /// 
        /// **Professional Standards:**
        /// - Includes appropriate academic titles (Dr., Prof., etc.)
        /// - Matchal institutional directory listings
        /// - Used for formal academic communications
        /// - Displayed in student consultation interfaces
        /// 
        /// **Usage Context:**
        /// - Course instructor listings and syllabi
        /// - Consultation request faculty selection
        /// - Academic department faculty directories
        /// - Student communication and correspondence
        /// 
        /// **Professional Recognition:**
        /// - Reflects earned degrees and academic achievements
        /// - Supports institutional branding and reputation
        /// - Enables proper academic protocol and etiquette
        /// - Maintains professional communication standards
        /// </remarks>
        /// <example>Dr. Jane Smith</example>
        [Required(ErrorMessage = "Faculty name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Faculty name must be between 2 and 100 characters")]
        public string FacultyName { get; set; } = string.Empty;

        /// <summary>
        /// Reference to the associated user account for authentication and system access
        /// </summary>
        /// <remarks>
        /// Links the faculty profile to the corresponding user authentication account:
        /// - Connects to login credentials and security settings
        /// - Enables role-based access control and permissions
        /// - Links to system audit logs and activity tracking
        /// - Supports single sign-on and authentication integration
        /// 
        /// /// **Security Integration:**
        /// - Links to ASP.NET Core Identity user account
        /// - Enables faculty-specific system permissions
        /// - Supports multi-factor authentication when configured
        /// - Maintains audit trail for security compliance/ 
        /// **System Access:**
        /// - Determines available system features and endpoints
        /// - Controls consultation management capabilities
        /// - Enables faculty dashboard and reporting access
        /// - Supports integration with other university systems
        /// 
        /// /// **Data Relationships:**
        /// /// - One-to-one relationship with Users table
        /// - Enables user profile and faculty data synchronization
        /// - Supports account lifecycle management// - Facilitatestem user identification
        /// </remarks>
        /// <example>12345</example>
        [Range(1, int.MaxValue, ErrorMessage = "User ID must be a positive number")]
        public int UserID { get; set; }
    }
}