using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for updating consultation request status by faculty members
    /// </summary>
    /// <remarks>
    /// This focused view model handles consultation request status updates:
    /// - Faculty approval or disapproval of student consultation requests
    /// - Status transition management and validation
    /// - Workflow control for consultation request lifecycle
    /// 
    /// **Workflow Integration:**
    /// - Enables faculty to respond to pending consultation requests
    /// - Triggers notification systems for status changes
    /// - Maintains audit trail of faculty decisions
    /// - Supports consultation scheduling and management workflows
    /// </remarks>
    /// <example>
    /// Example JSON for approving a consultation request:
    /// <code>
    /// {
    ///   "status": 1
    /// }
    /// </code>
    /// 
    /// Example JSON for disapproving a consultation request:
    /// <code>
    /// {
    ///   "status": 2
    /// }
    /// </code>
    /// </example>
    public class UpdateStatusModel
    {
        /// <summary>
        /// New status to be applied to the consultation request
        /// </summary>
        /// <remarks>
        /// Defines the updated status for consultation request workflow management:
        /// 
        /// **Status Values:**
        /// - **0 (Pending)**: Initial status when request is submitted (not typically used in updates)
        /// - **1 (Approved)**: Faculty approves the consultation request
        /// - **2 (Disapproved)**: Faculty declines the consultation request
        /// 
        /// **Business Rules:**
        /// - Only pending requests can be updated to approved or disapproved
        /// - Status changes are permanent and cannot be reversed
        /// - Each status change triggers appropriate notifications to students
        /// - Faculty must provide reasoning for disapproved requests
        /// 
        /// **Workflow Impact:**
        /// - **Approved**: Enables consultation scheduling and coordination
        /// - **Disapproved**: Closes the request and notifies student with feedback
        /// - **Status History**: Maintains complete audit trail of status changes
        /// 
        /// **Notification Triggers:**
        /// - Approved requests trigger scheduling coordination workflows
        /// - Disapproved requests send feedback notifications to students
        /// - Status changes update student dashboard and notification feeds
        /// - Faculty actions are logged for audit and reporting purposes
        /// 
        /// **System Integration:**
        /// - Updates consultation request database records
        /// - Triggers automated notification and communication systems
        /// - Integrates with faculty dashboard and workload management
        /// - Supports reporting and analytics for consultation metrics
        /// </remarks>
        /// <example>1</example>
        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(Status), ErrorMessage = "Invalid status value")]
        public Status Status { get; set; }
    }
}
