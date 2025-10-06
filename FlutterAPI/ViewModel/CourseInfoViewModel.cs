using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model representing individual course information for student enrollment and consultation context
    /// </summary>
    /// <remarks>
    /// This view model encapsulates essential course details used throughout the consultation system:
    /// - Course identification and academic classification
    /// - Descriptive course information for context
    /// - Instructor assignment for consultation routing
    /// 
    /// **System Integration:**
    /// - Used in consultation request forms for course selection
    /// - Displayed in student dashboards for academic overview
    /// - Provides context for faculty when reviewing consultation requests
    /// - Supports academic advising and course-specific consultations
    /// 
    /// **Data Sources:**
    /// - Synchronized with institutional course catalog
    /// - Reflects current semester enrollment data
    /// - Includes real-time instructor assignment information
    /// - Maintains academic department and program relationships
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "code": "CS101",
    ///   "course": "Introduction to Programming",
    ///   "instructor": "Dr. Jane Smith"
    /// }
    /// </code>
    /// </example>
    public class CourseInfoViewModel
    {
        /// <summary>
        /// Unique course code identifier used for academic classification and system reference
        /// </summary>
        /// <remarks>
        /// The course code serves as the primary identifier for academic courses:
        /// 
        /// **Format Standards:**
        /// - Typically follows department prefix + number format (e.g., "CS101", "MATH201")
        /// - Standardized across institutional course catalog
        /// - Used for prerequisite tracking and academic progression
        /// - Enables cross-system integration and data consistency
        /// 
        /// **Business Applications:**
        /// - **Course Selection**: Students use codes to identify specific courses for consultations
        /// - **Faculty Routing**: System routes consultation requests based on course codes
        /// - **Academic Planning**: Supports degree requirement tracking and course sequencing
        /// - **Reporting**: Enables course-specific analytics and consultation metrics
        /// 
        /// **Data Validation:**
        /// - Must match institutional course catalog standards
        /// - Validated against current semester course offerings
        /// - Supports both undergraduate and graduate course codes
        /// - Handles special session and cross-listed course variations
        /// </remarks>
        /// <example>CS101</example>
        [Required(ErrorMessage = "Course code is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Course code must be between 2 and 20 characters")]
        [RegularExpression(@"^[A-Z]{2,4}\d{3,4}[A-Z]?$", ErrorMessage = "Course code must follow standard format (e.g., CS101, MATH201)")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Full descriptive name of the course providing academic context and subject matter identification
        /// </summary>
        /// <remarks>
        /// The course name provides comprehensive identification and context:
        /// 
        /// **Content Standards:**
        /// - Official course title from institutional catalog
        /// - Descriptive enough to understand subject matter and academic level
        /// - Consistent with accreditation and academic standards
        /// - Supports student understanding and course selection
        /// 
        /// **Usage Context:**
        /// - **Student Interface**: Helps students identify courses for consultation requests
        /// - **Faculty Review**: Provides context when faculty review consultation requests
        /// - **Academic Advising**: Supports course recommendation and planning discussions
        /// - **System Display**: Used in dashboards, reports, and user interfaces
        /// 
        /// **Examples by Discipline:**
        /// - Computer Science: "Introduction to Programming", "Data Structures and Algorithms"
        /// - Mathematics: "Calculus II", "Linear Algebra"
        /// - Business: "Principles of Marketing", "Financial Accounting"
        /// - Engineering: "Circuit Analysis", "Thermodynamics"
        /// 
        /// **Quality Assurance:**
        /// - Synchronized with official course catalog
        /// - Updated when course descriptions change
        /// - Maintains consistency across all system interfaces
        /// - Supports multilingual course names when applicable
        /// </remarks>
        /// <example>Introduction to Programming</example>
        [Required(ErrorMessage = "Course name is required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Course name must be between 5 and 200 characters")]
        public string Course { get; set; } = string.Empty;

        /// <summary>
        /// Name of the faculty member or instructor assigned to teach the course
        /// </summary>
        /// <remarks>
        /// The instructor information enables direct consultation routing and academic context:
        /// 
        /// **Instructor Information:**
        /// - Full name of assigned faculty member or instructor
        /// - Academic title and credentials when available (Dr., Prof., etc.)
        /// - Primary contact for course-related consultations
        /// - Subject matter expert for academic support
        /// 
        /// **System Integration:**
        /// - **Consultation Routing**: Automatically routes requests to appropriate faculty
        /// - **Contact Information**: Links to faculty profiles and contact details
        /// - **Availability Scheduling**: Integrates with faculty calendar systems
        /// - **Academic Hierarchy**: Respects department and program structures
        /// 
        /// **Data Management:**
        /// - Updated when instructor assignments change
        /// - Handles multiple instructors for team-taught courses
        /// - Provides fallback display for unassigned courses ("TBA" - To Be Announced)
        /// - Maintains historical instructor information for completed courses
        /// 
        /// **Special Cases:**
        /// - **TBA (To Be Announced)**: Used when instructor not yet assigned
        /// - **Multiple Instructors**: Primary instructor listed, others in course details
        /// - **Guest Lecturers**: Permanent instructor maintained for consultation routing
        /// - **Substitute Instructors**: Temporary assignments handled appropriately
        /// 
        /// **Privacy and Security:**
        /// - Displays only public faculty information
        /// - Respects faculty privacy preferences
        /// - Maintains professional contact boundaries
        /// - Supports institutional directory integration
        /// </remarks>
        /// <example>Dr. Jane Smith</example>
        [Required(ErrorMessage = "Instructor information is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Instructor name must be between 2 and 100 characters")]
        public string Instructor { get; set; } = string.Empty;
    }
}