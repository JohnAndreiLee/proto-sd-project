using Consultation.Domain;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for student dashboard displaying comprehensive overview information
    /// </summary>
    /// <remarks>
    /// This view model provides a centralized dashboard view for students, containing:
    /// - Complete student profile information
    /// - Current academic year and semester details
    /// - Consultation request statistics and status summaries
    /// - Real-time notification feed for important updates
    /// 
    /// The dashboard serves as the primary interface for students after login,
    /// offering quick access to consultation activities and system notifications.
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "student": {
    ///     "studentID": 1,
    ///     "studentName": "John Doe",
    ///     "email": "john.doe@university.edu",
    ///     "studentUMID": "2024001"
    ///   },
    ///   "schoolYear": "First Semester 2024-2025",
    ///   "pendingConsultation": 3,
    ///   "notifications": [
    ///     "Dr. Smith has approved your consultation request for CS101",
    ///     "Prof. Johnson has scheduled your consultation for tomorrow at 2:00 PM"
    ///   ]
    /// }
    /// </code>
    /// </example>
    public class DashboardViewModel
    {
        /// <summary>
        /// Complete student information including profile, academic details, and system relationships
        /// </summary>
        /// <remarks>
        /// Contains the full student entity with all related information:
        /// - Personal details (name, email, UMID)
        /// - Academic program enrollment
        /// - Course enrollments and faculty assignments
        /// - Consultation request history
        /// - User account linkage for authentication
        /// 
        /// This comprehensive student object enables the dashboard to display
        /// personalized information and maintain proper data relationships.
        /// </remarks>
        /// <example>
        /// /// Student object with ID 1, name "John Doe", email "john.doe@university.edu"
        /// </example>
        [Required(ErrorMessage = "Student information is required")]
        public Student Student { get; set; } = null!;

        /// <summary>
        /// Formatted string representingrrent academic school year and semester
        /// /// </summary>
        /// <remarks>
        /// Provides a human-readable repreation of the student's current academic period.
        /// Format: "{Semester} Semester {StartYear}-{EndYear}"
        /// /// 
        /// /// **Semester Values:**
        /// - "First Semester" - Fall semester
        /// - "Second Semester" - Spring semester  
        /// - "Summer" - Summer session
        /// 
        /// **Year Format:**
        /// - Academic year spans two calendar years (e.g., 024-2025
      /// - Represents the complete academic cycle
        /// 
        /// This information helps students understand their current academic context
        /// and is used for course enrollment and consultation scheduling.
        /// </remarks>
        /// <example>First Semester 2024-2025</example>
        [Required(ErrorMessage = "School year information is required")]
        [StringLength(50, ErrorMessage = "School year format is too long")]
        public string SchoolYear { get; set; } = string.Empty;

        /// <summary>
        /// /// Count of consultation requests currently in pending status awaiting faculty response
        /// </summary>
        /// <remarks>
        /// Displays the number of consultation requests that have been submitted by the student
        /// but have not yet been reviewed by faculty members. This provides students with
        /// immediate visibility into their outstang requests.
        /// 
        /// **Status Tracking:**
        /// /// - Only counts requests with "Pending" status
        /// - Excludes approved, disapproved, or completed consultations
        /// - Updates in real-time as faculty members review requests
        /// - Helps students track their consultation request activity
        /// 
        /// **Business Value:**
        /// - Enables students request progress
        /// - Prevents duplicate requests for the same topic
        /// - Provides insight into faculty response times
        /// - Supports workload management for students
        /// </remarks>
        /// <example>3</example>
        [Range(0, int.MaxValue, ErrorMessage = "Pending consultation count cannot be negative")]
        public int PendingConsultation { get; set; } = 0;

        /// <summary>
        /// List of notification messages for important updates and system communications
        /// </summary>
        /// <remarks>
        /// Contains real-time notifications about consultation activities and system updates:
        /// 
        /// **Notification Types:**
        /// - **Consultation Status Updates**: Faculty approval/disapproval notifications
        /// - **Scheduling Information**: Confirmed consultation times and locations
        /// - **System Announcements**: Important academic calendar updates
        /// - **Reminder Messages**: Upcoming consultation reminders
        /// 
        /// **Message Format:**
        /// - Human-readable messages with clear action context
        /// - Faculty names and course codes for specificity
        /// - Status changes with timestamps (when applicable)
        /// - Actionable information for student follow-up
        /// 
        /// **Notification Management:**
        /// - Most recent notifications appear first
        /// - Automatically generated based on system events
        /// - Filtered to show only relevant student notifications
        /// - Supports rich text formatting for important information
        /// 
        /// **Examples of Notifications:**
        /// - "Dr. Smith has approved your consultation request for CS101"
        /// - "Prof. Johnson has disapproved your request: Please review the course material first"
        /// - "Your consultation with Dr. Brown is scheduled for tomorrow at 2:00 PM"
        /// - "Reminder: You have a consultation with Prof. Davis in 1 hour"
        /// </remarks>
        /// <example>
        /// [
        ///   "Dr. Smith has approved your consultation request for CS101",
        ///   "Prof. Johnson has scheduled your consultation for December 15th at 2:00 PM",
        ///   "Reminder: Course registration deadline is approaching"
        ///   /// ]
        /// </example>
        [Required(ErrorMessage = "Notifications list is required")]
        public List<string> Notifications { get; set; } = new List<string>();
    }
}