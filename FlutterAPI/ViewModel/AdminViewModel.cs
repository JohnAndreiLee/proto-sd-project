using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for system administrator profile information and management data
    /// </summary>
    /// <remarks>
    /// This view model represents essential administrator information for system management:
    /// - Administrator identification and contact information
    /// - System access control and permission management
    /// - Audit trail and administrative activity tracking
    /// 
    /// **Administrative Functions:**
    /// - System configuration and maintenance
    /// - User account management and oversight
    /// - Security monitoring and compliance
    /// - System reporting and analytics
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "adminName": "System Administrator",
    ///   "adminID": "ADMIN001"
    /// }
    /// </code>
    /// </example>
    public class AdminViewModel
    {
        /// <summary>
        /// Full name or title of the system administrator
        /// </summary>
        /// <remarks>
        /// The administrator's name or professional title used for:
        /// - System audit logs and administrative tracking
        /// - User management and communication interfaces
        /// - Security incident reporting and documentation
        /// - Administrative dashboard and system displays
        /// 
        /// **Professional Context:**
        /// /// - May include job title or department affiliation
        /// - Used for administrative communication and documentation
        /// - Displayed in system logs for accountability
        /// - Supports administrative hierarcorting
        /// 
        /// **Security and Compliance:**
        /// - Links administrative actions to responsible individuals
        /// - Supports audit requirements and compliance reporting
        /// - Enables administrative accountability and oversight
        /// - Maintains professional standards for system management
        /// </remarks>
        /// <example>System Administrator</example>
        [Required(ErrorMessage = "Administrator name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Administrator name must be between 2 and 100 characters")]
        public string AdminName { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier for the administrator account
        /// </summary>
        /// <remarks>
        /// Administrative account identifier used for:
        /// - System access control and permission management
        /// - Audit trail tracking and security monitoring
        /// - Administrative activity logging and reporting
        /// - Cross-system integration and identification
        /// 
        /// **System Security:**
        /// - Links to elevated system permissions and access rights
        /// - Enables administrative function authorization
        /// - Supports role-based access control implementation
        /// - Maintains separation of administrative responsibilities
        /// 
        /// **Audit and Compliance:**
        /// - Tracks all administrative actions and system changes
        /// - Supports regulatory compliance and security audits
        /// - Enables administrative accountability and oversight
        /// - Maintains detailed logs for security analysis
        /// 
        /// **Administrative Hierarchy:**
        /// - Supports multiple administrator roles and levels
        /// - Enables delegation of administrative responsibilities
        /// - Maintains clear administrative chain of command
        /// - Supports administrative workflow and approval processes
        /// </remarks>
        /// <example>ADMIN001</example>
        [Required(ErrorMessage = "Administrator ID is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Administrator ID must be between 4 and 20 characters")]
        public string AdminID { get; set; } = string.Empty;
    }
}
