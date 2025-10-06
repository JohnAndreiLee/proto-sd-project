using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    /// <summary>
    /// Standard error response model for consistent API error handling
    /// </summary>
    /// <remarks>
    /// This model provides a standardized format for all API error responses:
    /// - Consistent error message structure across all endpoints
    /// - Detailed error information for debugging and troubleshooting
    /// - Support for both user-friendly and technical error details
    /// - Integration with logging and monitoring systems
    /// </remarks>
    /// <example>
    /// Example JSON representation:
    /// <code>
    /// {
    ///   "message": "Student not found",
    ///   "error": "No student record found with the provided ID",
    ///   "timestamp": "2024-12-15T14:30:00Z",
    ///   "trackingId": "ERR-2024-12-15-001"
    /// }
    /// </code>
    /// </example>
    public class ApiErrorResponse
    {
        /// <summary>
        /// Human-readable error message describing what went wrong
        /// </summary>
        /// <example>Student not found</example>
        [Required(ErrorMessage = "Error message is required")]
        [StringLength(500, MinimumLength = 1)]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Detailed error information for debugging and technical analysis
        /// </summary>
        /// <example>No student record found with the provided ID</example>
        [StringLength(1000)]
        public string Error { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp when the error occurred
        /// </summary>
        /// <example>2024-12-15T14:30:00Z</example>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Unique error tracking identifier for correlation and support
        /// </summary>
        /// <example>ERR-2024-12-15-001</example>
        public string? TrackingId { get; set; }
    }
}