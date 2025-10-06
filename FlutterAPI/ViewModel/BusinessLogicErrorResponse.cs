using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// Specialized error response model for domain-specific business logic errors
    /// </summary>
    /// <remarks>
    /// This model extends the standard error response to provide detailed information
    /// about business rule violations and domain-specific error conditions.
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "message": "Consultation request not allowed",
    ///   "error": "Student is not enrolled in the specified course",
    ///   "timestamp": "2024-12-15T14:30:00Z",
    ///   "trackingId": "BIZ-2024-12-15-001",
    ///   "businessRuleViolated": "COURSE_ENROLLMENT_REQUIRED",
    ///   "contextData": {
    ///     "courseCode": "CS101",
    ///     "studentId": "2024001"
    ///   },
    ///   "suggestedActions": [
    ///     "Enroll in the course before requesting consultation"
    ///   ]
    /// }
    /// </code>
    /// </example>
    public class BusinessLogicErrorResponse : ApiErrorResponse
    {
        /// <summary>
        /// Identifier for the specific business rule that was violated
        /// </summary>
        /// <example>COURSE_ENROLLMENT_REQUIRED</example>
        [Required(ErrorMessage = "Business rule identifier is required")]
        [StringLength(100, MinimumLength = 3)]
        public string BusinessRuleViolated { get; set; } = string.Empty;

        /// <summary>
        /// Additional context data relevant to the business logic error
        /// </summary>
        /// <example>
        /// {
        ///   "courseCode": "CS101",
        ///   "studentId": "2024001"
        /// }
        /// </example>
        public Dictionary<string, object> ContextData { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// List of suggested actions to resolve the business logic error
        /// </summary>
        /// <example>
        /// [
        ///   "Enroll in the course before requesting consultation"
        /// ]
        /// </example>
        public List<string> SuggestedActions { get; set; } = new List<string>();
    }
}