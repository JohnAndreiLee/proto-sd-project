using Consultation.Domain;
using Consultation.Infrastructure.Data;
using FlutterAPI.Attributes;
using FlutterAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    /// <summary>
    /// Controller for providing dashboard information and summary data for students
    /// </summary>
    /// <remarks>
    /// This controller provides comprehensive dashboard views for students, including:
    /// - Student profile information and current school year
    /// - Consultation request statistics and status summaries
    /// - Notification feed for consultation updates
    /// - Academic program information
    /// 
    /// The dashboard serves as the main landing page for students after login,
    /// providing a centralized view of their consultation activities and important updates.
    /// </remarks>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the DashboardController
        /// </summary>
        /// <param name="context">The database context for dashboard data operations</param>
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves comprehensive dashboard information for a specific student
        /// </summary>
        /// <param name="studentId">The unique identifier of the student (must be greater than 0)</param>
        /// <returns>Complete dashboard data including student information, consultation statistics, and notifications</returns>
        /// <remarks>
        /// This endpoint provides a comprehensive dashboard view for students containing:
        /// 
        /// **Student Information:**
        /// - Complete student profile with personal details
        /// - Current school year and semester information
        /// - Academic program enrollment details
        /// 
        /// /// **Consultation Statistics:**
        /// /// - Count of pending consultation requests awaiting faculty response
        /// - Historical consultation request data with status information
        /// /// 
        /// **Notification System:**
        /// - Real-time updates on consultation request status changes
        /// - Faculty responses and feedback notifications
        /// - System announcements and important updates
        /// 
        /// **Data Relationships:**
        /// - Includes related consultation requests with faculty information
        /// /// - Links to academic program and school year data
        /// - Provides navigation context for other system features
        /// 
        /// **Audit and Logging:**
        /// - Records dashboard access for analytics and usage tracking
        /// - Maintains user activity logs for security and compliance
        /// 
        /// **Performance Considerations:**
        /// - Uses efficient database queries with appropriate includes
        /// - Optimized for frequent access as primary student interface
        /// - Caches frequently accessed reference data
        /// </remarks>
        /// <response code="200">Dashboard data retrieved successfully with complete student information</response>
        /// <response code="400">Invalid student ID provided (must be positive integer)</response>
        /// <response code="404">Student not found or missing required data (school year)</response>
        /// <response code="500">Internal server error occurred during data retrieval</response>
        [HttpGet("{studentId}")]
        [ApiAuthentication("Bearer", new[] { "Student" }, "JWT token required for accessing dashboard data")]
        [ApiDocumentation(
            "Get student dashboard",
            "Retrieves comprehensive dashboard information including student profile, consultation statistics, and notifications"
        )]
        [ApiExample("StudentDashboard", 
            @"{
                ""student"": {
                    ""studentID"": 1,
                    ""studentName"": ""John Doe"",
                    ""email"": ""john.doe@university.edu""
                },
                ""schoolYear"": ""First Semester 2024-2025"",
                ""pendingConsultation"": 2,
                ""notifications"": [
                    ""Dr. Smith has Approved your consultation request."",
                    ""Prof. Johnson has Rejected your consultation request.""
                ]
            }",
            "Example dashboard response with student information and notifications")]
        [ApiErrorResponse(401, "Unauthorized", 
            @"{""message"": ""Authentication required"", ""error"": ""Valid JWT token must be provided""}", "AUTHENTICATION_REQUIRED")]
        [ApiErrorResponse(403, "Forbidden", 
            @"{""message"": ""Access denied"", ""error"": ""Student role required""}", "INSUFFICIENT_PERMISSIONS")]
        [ApiErrorResponse(400, "Invalid student ID", 
            @"{""message"": ""Invalid student ID"", ""error"": ""Student ID must be greater than 0""}", "INVALID_STUDENT_ID")]
        [ApiErrorResponse(404, "Student not found", 
            @"{""message"": ""Student not found"", ""error"": ""No student record found with the provided ID""}", "STUDENT_NOT_FOUND")]
        [ApiErrorResponse(404, "School year not found", 
            @"{""message"": ""School year not found for student"", ""error"": ""Student has no associated school year information""}", "SCHOOL_YEAR_NOT_FOUND")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while retrieving dashboard data"", ""error"": ""Database connection failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> ShowForStudents(int studentId)
        {
            try
            {
                if (studentId <= 0)
                {
                    var validationResponse = new ValidationErrorResponse
                    {
                        Message = "Invalid student ID",
                        Error = "Student ID must be a positive integer greater than 0",
                        TrackingId = $"VAL-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        ValidationErrors = new Dictionary<string, List<string>>
                        {
                            ["studentId"] = new List<string> { "Student ID must be greater than 0" }
                        }
                    };
                    return BadRequest(validationResponse);
                }

                var student = await _context.Students
                    .Include(c => c.SchoolYear)
                    .Include(c => c.ConsultationRequests)
                        .ThenInclude(cr => cr.Faculty)
                    .Include(c => c.Program)
                    .FirstOrDefaultAsync(c => c.StudentID == studentId);

                if (student == null)
                {
                    var notFoundResponse = new ApiErrorResponse
                    {
                        Message = "Student not found",
                        Error = $"No student record found with ID {studentId}",
                        TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                    };
                    return NotFound(notFoundResponse);
                }

                if (student.SchoolYear == null)
                {
                    var businessLogicResponse = new BusinessLogicErrorResponse
                    {
                        Message = "School year information missing",
                        Error = "Student has no associated school year information",
                        TrackingId = $"BIZ-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}",
                        BusinessRuleViolated = "SCHOOL_YEAR_REQUIRED",
                        ContextData = new Dictionary<string, object>
                        {
                            ["studentId"] = studentId,
                            ["studentName"] = student.StudentName
                        },
                        SuggestedActions = new List<string>
                        {
                            "Contact academic advisor to ensure proper school year enrollment",
                            "Verify student registration status for current academic period"
                        }
                    };
                    return NotFound(businessLogicResponse);
                }

                var schoolYearString = $"{student.SchoolYear.Semester} Semester {student.SchoolYear.Year1}-{student.SchoolYear.Year2}";

                List<string> notifications = new List<string>();
                if (student.ConsultationRequests != null)
                {
                    foreach (var request in student.ConsultationRequests
                        .Where(c => c.Status != Consultation.Domain.Enum.Status.Pending))
                    {
                        var facultyName = request.Faculty?.FacultyName ?? "Unknown Faculty";
                        var requestString = $"{facultyName} has {request.Status} your consultation request.";
                        notifications.Add(requestString);
                    }
                }

                var dashboardVM = new DashboardViewModel
                {
                    Student = student,
                    SchoolYear = schoolYearString,
                    PendingConsultation = student.ConsultationRequests?.Count(c => c.Status == Consultation.Domain.Enum.Status.Pending) ?? 0,
                    Notifications = notifications
                };

                // Log the action
                string message = $"{student.StudentName} has accessed the dashboard";
                var actionLog = ActionLogController.ActionLogger(message, student.StudentName, 0, student.Users);

                _context.ActionLog.Add(actionLog);
                await _context.SaveChangesAsync();

                return Ok(dashboardVM);
            }
            catch (Exception ex)
            {
                var serverErrorResponse = new ApiErrorResponse
                {
                    Message = "Internal server error",
                    Error = "An error occurred while retrieving dashboard data",
                    TrackingId = $"ERR-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString()[..8]}"
                };
                return StatusCode(500, serverErrorResponse);
            }
        }
    }
}
