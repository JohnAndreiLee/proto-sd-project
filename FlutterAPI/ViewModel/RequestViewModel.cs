using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for student course and academic year information used in consultation requests
    /// </summary>
    /// <remarks>
    /// This view model provides essential academic context for consultation requests by combining:
    /// - Current school year and semester information
    /// - Complete list of enrolled courses with instructor details
    /// - Academic program context for consultation planning
    /// 
    /// This information helps students select appropriate courses and faculty for consultations,
    /// and provides faculty with necessary academic context when reviewing requests.
    /// 
    /// **Usage Context:**
    /// - Pre-populates consultation request forms with student's current courses
    /// - Displays academic timeline for scheduling considerations
    /// - Provides instructor information for direct consultation routing
    /// - Supports academic advising and course-specific consultations
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "schoolYear": "First Semester 2024-2025",
    ///   "courses": [
    ///     {
    ///       "code": "CS101",
    ///       "course": "Introduction to Programming",
    ///       "instructor": "Dr. Jane Smith"
    ///     },
    ///     {
    ///       "code": "MATH201",
    ///       "course": "Calculus II",
    ///       "instructor": "Prof. Robert Johnson"
    ///     }
    ///   ]
    /// }
    /// </code>
    /// </example>
    public class RequestViewModel
    {
        /// <summary>
        /// Formatted string representing the student's current academic school year and semester
        /// </summary>
        /// <remarks>
        /// Provides academic timeline context for consultation requests and course enrollment.
        /// Format: "{Semester} Semester {StartYear}-{EndYear}"
        /// 
        /// **Academic Context:**
        /// - Helps faculty understand the student's current academic standing
        /// - Provides timeline context for course-related consultations
        /// - Supports academic planning and progression tracking
        /// - Enables semester-specific consultation scheduling
        /// 
        /// /// **Format Examples:**
        /// - "First Semester 2024-2025" (Fall semester)
        /// - "Second Semester 2024-2025" (Spring semester)
        /// - "Summer 2024-2025" (Summer session)
        /// 
        /// This information is automatically from the student's enrollment data
        /// and reflects their current academic period registration.
        /// </remarks>
        /// <example>First Semester 2024-2025</example>
        [Required(ErrorMessage = "School year information is required")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "School year must be between 10 and 50 characters")]
        public string SchoolYear { get; set; } = string.Empty;

        /// <summary>
        /// List of courses in which the student is currently enrolled, including instructor information
        /// </summary>
        /// <remarks>
        /// Contains comprehensive course enrollment information for the current academic period:
        /// 
        /// **Course Information Includes:**
        /// - Course code (e.g., "CS101", "MATH201")
        /// - Full course name and description
        /// - Assigned instructor or faculty member
        /// - Academic department and program context
        /// 
        /// **Business Applications:**
        /// - **Consultation Request Context**: Students can select relevant courses for consultations
        /// - **Faculty Routing**: Automatically routes requests to appropriate course instructors
        /// - **Academic Planning**: Provides overview of current academic workload
        /// - **Course-Specific Support**: Enables targeted academic assistance
        /// 
        /// **Data Relationships:**
        /// - Links to student enrollment records
        /// - Connects to faculty assignment information
        /// - Reflects current semester course registrations
        /// - Supports course prerequisite and progression tracking
        /// 
        /// **Usage Scenarios:**
        /// - Pre-populate consultation request forms with relevant courses
        /// - Display student's academic context to faculty reviewers
        /// - Support course-specific consultation scheduling
        /// - Enable academic advising and progress monitoring
        /// 
        /// **Data Quality:**
        /// - Automatically synchronized with enrollment system
        /// - Includes only active course registrations
        /// - Handles instructor changes and updates
        /// - Provides fallback for missing instructor information ("TBA")
        /// </remarks>
        /// <example>
        /// [
        ///   {
        ///     "code": "CS101",
        ///     "course": "Introduction to Programming",
        ///     "instructor": "Dr. Jane Smith"
        ///   },
        ///   {
        ///     "code": "MATH201", 
        ///     "course": "Calculus II",
        ///     "instructor": "Prof. Robert Johnson"
        ///   }
        /// ]
        /// </example>
        /// [Required(ErrorMessage = "Course list is required")]
        public List<CourseInfoViewModel> Courses { get; set; } = new List<CourseInfoViewModel>();
    }
}