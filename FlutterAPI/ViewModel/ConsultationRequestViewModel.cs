using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for displaying consultation request information in faculty interfaces
    /// </summary>
    /// <remarks>
    /// This view model represents consultation requests as displayed to faculty members:
    /// - Complete consultation request details for review
    /// - Student information for context and communication
    /// - Scheduling information for consultation planning
    /// - Status tracking for workflow management
    /// 
    /// **Faculty Interface Usage:**
    /// - Faculty dashboard consultation request listings
    /// - Individual consultation request detail views
    /// - Status update and management interfaces
    /// - Consultation scheduling and coordination tools
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "consultationID": 1,
    ///   "courseCode": "CS101",
    ///   "studentName": "John Doe",
    ///   "dateSchedule": "2024-12-15T14:30:00",
    ///   "timeStart": "14:30:00",
    ///   "timeEnd": "15:30:00",
    ///   "status": 0
    /// }
    /// </code>
    /// </example>
    public class ConsultationRequestViewModel
    {
        /// <summary>
        /// Unique identifier for the consultation request
        /// </summary>
        /// <example>1</example>
        [Range(1, int.MaxValue, ErrorMessage = "Consultation ID must be a positive number")]
        public int ConsultationID { get; set; }

        /// <summary>
        /// Course code for which the consultation is requested
        /// </summary>
        /// <example>CS101</example>
        [Required(ErrorMessage = "Course code is required")]
        [StringLength(20, ErrorMessage = "Course code cannot exceed 20 characters")]
        public string CourseCode { get; set; } = string.Empty;

        /// <summary>
        /// Name of the student requesting the consultation
        /// </summary>
        /// <example>John Doe</example>
        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, ErrorMessage = "Student name cannot exceed 100 characters")]
        public string StudentName { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled date and time for the consultation
        /// </summary>
        /// <example>2024-12-15T14:30:00</example>
        public DateTime DateSchedule { get; set; }

        /// <summary>
        /// Start time for the consultation session
        /// </summary>
        /// <example>14:30:00</example>
        public TimeOnly TimeStart { get; set; }

        /// <summary>
        /// End time for the consultation session
        /// </summary>
        /// <example>15:30:00</example>
        public TimeOnly TimeEnd { get; set; }

        /// <summary>
        /// Current status of the consultation request
        /// </summary>
        /// <remarks>
        ///    /// Status va
    /// - 0 (Pending): Awaiting faculty review
        /// - 1 (Approved): Faculty has approved the request
        /// - 2 (Disapproved): Faculty has declined the request
        /// </remarks>
        /// <example>0</example>
        public Status Status { get; set; }
    }
}




