using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// View model for creating and managing consultation requests between students and faculty
    /// </summary>
    /// <remarks>
    /// This view model represents the data structure for consultation requests submitted by students.
    /// It contains all necessary information for faculty members to understand the student's needs
    /// and make informed decisions about consultation scheduling and approval.
    /// 
    /// The model supports the complete consultation request workflow from initial submission
    /// through faculty review and final scheduling or rejection.
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "studentName": "John Doe",
    ///   "facultyName": "Dr. Smith",
    ///   "courseCode": "CS101",
    ///   "concern": "Need help understanding recursion concepts",
    ///   "dateOfConsultation": "2024-12-15T14:30:00",
    ///   "usertype": 0
    /// }
    /// </code>
    /// </example>
    public class ConsultationViewModel
    {
        /// <summary>
        /// The full name of the student requesting the consultation
        /// </summary>
        /// <remarks>
        /// This should match the student's registered name in the system.
        /// Used for identification and linking to the student's academic record.
        /// </remarks>
        /// <example>John Doe</example>
        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Student name must be between 2 and 100 characters")]
        public string StudentName { get; set; } = string.Empty;

        /// <summary>
        /// The full name of the faculty member being requested for consultation
        /// </summary>
        /// <remarks>
        /// This should match the faculty member's registered name in the system.
        /// Used for identification and routing the consultation request to the appropriate faculty.
        /// </remarks>
        /// <example>Dr. Jane Smith</example>
        [Required(ErrorMessage = "Faculty name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Faculty name must be between 2 and 100 characters")]
        public string FacultyName { get; set; } = string.Empty;

        /// <summary>
        /// The course code for which the consultation is being requested
        /// </summary>
        /// <remarks>
        /// This should correspond to a course in which the student is enrolled.
        /// Helps faculty understand the academic context of the consultation request.
        /// /// </remarks>
        /// <example>CS101</example>
        /// [Required(ErrorMessage = "Course code is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Coursode must be between 2 and 20 characters")]
        public string CourseCode { get; set; } = string.Empty;

        /// <summary>
        /// Detailed description of the stud's concern or topic for consultation
        /// </summary>
        /// <remarks>
        /// This field allows students to explain their specific questions, problems, or topics
        /// they want to discuss during the consultation. Faculty use this information to
        /// prepare for the consultation and determine if they can provide appropriate assistance.
        /// </remarks>
        /// <example>I'm having difficulty understanding the concept of recursion in programming. Specifically, I'm confused about how the call stack works and when to use recursive solutions versus iterative ones.</example>
        [Required(ErrorMessage = "Concern description is required")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Concern must be between 10 and 1000 characters")]
        public string Concern { get; set; } = string.Empty;

        /// <summary>
        /// Reason provided by faculty if the consultation request is disapproved
        /// </summary>
        /// <remarks>
        /// /// This field is populated by faculty members when they decline a consultation request.
        /// It provides feedback to students about why their request was not approved and
        /// may include suggestions for alternative resources or approaches.
        /// 
        /// This field is optional during request submission and is only filled when
        /// faculty members review and disapprove requests.
        /// </remarks>
        /// <example>This topic is covered in the upcoming lecture. Please attend the class firshen request consultation if you still have questions.</example>
        [StringLength(500, ErrorMessage = "Disapproved reason cannot exceed 500 characters")]
        public string DisapprovedReason { get; set; } = string.Empty;

        /// <summary>
        /// The preferred date and time for the consultation
        /// </summary>
        /// <remarks>
        /// Students specify their preferred consultation date and time. This must be a future date.
        /// Faculty members can use this as a starting point for scheduling, though the final
        /// consultation time may be adjusted based on faculty availability.
        /// 
        /// /// The system validates that this date is in the future to prevent scheduling
        /// consultations for past dates.
        /// </remarks>
        /// <example>2024-12-15T14:30:00</example>
        /// [Required(ErrorMessage"Consultation date is required")]
        public DateTime DateOfConsultation { get; set; }

        /// <summary>
        /// The type of user making the consultation request
        /// </y>
        /// <remarks>
        /// Indicates the role of the user in the system. For consultation requests,
        /// this is typically set to Student (0), but the field supports other user types
        /// for system flexibility and audit purposes.
        /// 
        /// /// **User Type Values:**
        /// - 0: Student
        /// /// - 1: Faculty
        /// - 2: Admin
        /// </remarks>
        /// <example>0</example>
        public UserType Usertype { get; set; } = UserType.Student;
    }
}
