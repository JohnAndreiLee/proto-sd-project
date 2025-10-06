using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for system action logs and audit trail information
    /// </summary>
    /// <remarks>
    /// This view model represents system activity logs used for:
    /// - Security monitoring and audit trail maintenance
    /// - User activity tracking and system analytics
    /// - Compliance reporting and regulatory requirements
    /// - System troubleshooting and performance analysis
    /// 
    /// **Audit Functions:**
    /// - Tracks all significant user actions and system events
    /// - Maintains chronological record of system activities
    /// - Supports security incident investigation and analysis
    /// - Enables compliance with educational data regulations
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "actionLogID": 12345,
    ///   "description": "User successfully logged into the system",
    ///   "date": "2024-12-15T00:00:00",
    ///   "time": "14:30:00",
    ///   "userType": 0,
    ///   "accountName": "john.doe@university.edu"
    /// }
    /// </code>
    /// </example>
    public class ActionLogViewModel
    {
        /// <summary>
        /// Unique identifier for the action log entry
        /// </summary>
        /// <remarks>
        /// System-generated unique identifier for audit log entries:
        /// - Primary key for log record identification
        /// - Enables efficient log querying and retrieval
        /// - Supports log entry correlation and analysis
        /// - Used for log management and archival processes
        /// 
        /// **Log Management:**
        /// - Facilitates log entry sorting and filtering
        /// - Enables log retention policy implementation
        /// - Supports log backup and archival procedures
        /// - Maintains log integrity and chronological order
        /// </remarks>
        /// <example>12345</example>
        [Range(1, int.MaxValue, ErrorMessage = "Action Log ID must be a positive number")]
        public int ActionLogID { get; set; }

        /// <summary>
        /// Detailed description of the action or event that occurred
        /// </summary>
        /// <remarks>
        /// Human-readable description of system activities and user actions:
        /// - Provides context for security and compliance audits
        /// - Enables system administrators to understand user behavior
        /// - Supports troubleshooting and system analysis
        /// - Maintains detailed record of system events
        /// 
        /// **Description Categories:**
        /// - **Authentication Events**: Login, logout, password changes
        /// - **Consultation Activities**: Request creation, status updates, scheduling
        /// - **System Access**: Dashboard views, data retrieval, navigation
        /// - **Administrative Actions**: User management, system configuration
        /// 
        /// **Audit Value:**
        /// - Provides actionable information for security analysis
        /// - Enables pattern recognition for system optimization
        /// - Supports incident investigation and root cause analysis
        /// - Maintains comprehensive activity documentation
        /// </remarks>
        /// <example>User successfully logged into the system</example>
        [Required(ErrorMessage = "Action description is required")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Date when the action occurred
        /// </summary>
        /// <remarks>
        /// Calendar date of the logged action for chronological tracking:
        /// - Enables date-based log filtering and analysis
        /// - Supports compliance reporting with time-based requirements
        /// - Facilitates log retention and archival policies
        /// - Provides temporal context for security investigations
        /// 
        /// **Temporal Analysis:**
        /// - Enables trend analysis and pattern recognition
        /// - Supports workload and usage analytics
        /// - Facilitates compliance with data retention policies
        /// - Provides chronological context for system events
        /// </remarks>
        /// <example>2024-12-15</example>
        [Required(ErrorMessage = "Action date is required")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Precise time when the action occurred
        /// </summary>
        /// <remarks>
        /// Exact time of the logged action for detailed audit trails:
        /// - Provides precise timing for security analysis
        /// - Enables correlation of related system events
        /// - Supports detailed forensic investigation capabilities
        /// - Maintains high-resolution activity tracking
        /// 
        /// **Precision Benefits:**
        /// - Enables sequence analysis of related actions
        /// - Supports performance monitoring and optimization
        /// - Facilitates security incident timeline reconstruction
        /// - Provides detailed system usage patterns
        /// </remarks>
        /// <example>14:30:00</example>
        [Required(ErrorMessage = "Action time is required")]
        public TimeOnly Time { get; set; }

        /// <summary>
        /// Type of user account that performed the action
        /// </summary>
        /// <remarks>
        /// Classification of the user role for access control and audit analysis:
        /// 
        /// **User Type Categories:**
        /// - **0 (Student)**: Student-initiated actions and activities
        /// - **1 (Faculty)**: Faculty consultation management and course activities
        /// - **2 (Admin)**: Administrative actions and system management
        /// 
        /// **Audit Applications:**
        /// - Enables role-based activity analysis and reporting
        /// - Supports access control verification and compliance
        /// - Facilitates user behavior pattern recognition
        /// - Maintains separation of duties documentation
        /// 
        /// **Security Analysis:**
        /// - Identifies unusual activity patterns by user type
        /// - Supports privilege escalation detection
        /// - Enables role-based security monitoring
        /// - Facilitates compliance with access control policies
        /// </remarks>
        /// <example>0</example>
        public UserType UserType { get; set; }

        /// <summary>
        /// Account name or identifier of the user who performed the action
        /// </summary>
        /// <remarks>
        /// User identification for accountability and audit trail purposes:
        /// - Links actions to specific user accounts for accountability
        /// - Enables user-specific activity tracking and analysis
        /// - Supports security incident investigation and response
        /// - Maintains detailed user activity documentation
        /// 
        /// **Accountability Features:**
        /// - Provides clear attribution for all system actions
        /// - Enables user behavior analysis and monitoring
        /// - Supports disciplinary and compliance procedures
        /// - Maintains audit trail for regulatory requirements
        /// 
        /// **Privacy Considerations:**
        /// - Balances accountability with user privacy rights
        /// - Complies with educational data protection regulations
        /// - Maintains appropriate data retention and access controls
        /// - Supports legitimate audit and security requirements
        /// 
        /// **Investigation Support:**
        /// - Enables rapid identification of user activities
        /// - Supports forensic analysis and incident response
        /// - Facilitates pattern recognition and anomaly detection
        /// - Provides comprehensive user activity history
        /// </remarks>
        /// <example>john.doe@university.edu</example>
        [Required(ErrorMessage = "Account name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Account name must be between 2 and 100 characters")]
        public string AccountName { get; set; } = string.Empty;
    }
}
