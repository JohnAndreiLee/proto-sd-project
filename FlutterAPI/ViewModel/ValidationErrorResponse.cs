using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// Specialized error response model for model validation failures
    /// </summary>
    /// <remarks>
    /// This model extends the standard error response to provide detailed information
    /// about model validation failures with field-specific error messages.
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "message": "Validation failed",
    ///   "error": "One or more validation errors occurred",
    ///   "timestamp": "2024-12-15T14:30:00Z",
    ///   "trackingId": "VAL-2024-12-15-001",
    ///   "validationErrors": {
    ///     "Email": ["Email address is required", "Email format is invalid"],
    ///     "StudentName": ["Student name cannot exceed 100 characters"]
    ///   }
    /// }
    /// </code>
    /// </example>
    public class ValidationErrorResponse : ApiErrorResponse
    {
        /// <summary>
        /// Dictionary of field-specific validation errors
        /// </summary>
        /// <example>
        /// {
        ///   "Email": ["Email address is required", "Email format is invalid"],
        ///   "StudentName": ["Student name cannot exceed 100 characters"]
        /// }
        /// </example>
        [Required(ErrorMessage = "Validation errors dictionary is required")]
        public Dictionary<string, List<string>> ValidationErrors { get; set; } = new Dictionary<string, List<string>>();
    }
}