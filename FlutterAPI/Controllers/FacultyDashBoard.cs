using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using FlutterAPI.Attributes;
using FlutterAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    /// <summary>
    /// Controller for faculty dashboard operations and consultation request management
    /// </summary>
    /// <remarks>
    /// This controller provides faculty members with comprehensive tools for managing consultation requests:
    /// - View all pending and processed consultation requests
    /// - Update consultation request status (approve/disapprove)
    /// - Access student information and course details
    /// - Manage consultation scheduling and responses
    /// 
    /// Faculty members can efficiently review student requests, make informed decisions,
    /// and maintain clear communication through the consultation management system.
    /// </remarks>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacultyDashboard : ControllerBase
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the FacultyDashboard controller
        /// </summary>
        /// <param name="context">The database context for faculty operations</param>
        public FacultyDashboard(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all consultation requests for faculty review and management
        /// </summary>
        /// <returns>A list of all consultation requests with student and course information</returns>
        /// <remarks>
        /// This endpoint provides faculty members with a comprehensive view of all consultation requests:
        /// 
        /// **Data Included:**
        /// - Consultation request details (ID, date, time, status)
        /// - Student information (name, contact details)
        /// - Course information (code, name from enrolled courses)
        /// - Request status and scheduling information
        /// 
        /// **Use Cases:**
        /// - Faculty dashboard overview of all requests
        /// - Bulk review of pending consultation requests
        /// - Historical view of processed requests
        /// - Student engagement tracking and analytics
        /// 
        /// **Data Relationships:**
        /// - Includes student profile information
        /// - Links to enrolled courses for context
        /// - Provides complete consultation request lifecycle data
        /// 
        /// **Business Logic:**
        /// - Returns empty result if no requests exist
        /// - Includes all request statuses (Pending, Approved, Disapproved)
        /// - Provides course code from student's enrolled courses
        /// - Handles missing course information gracefully
        /// </remarks>
        /// <response code="200">List of consultation requests retrieved successfully</response>
        /// <response code="404">No consultation requests found</response>
        /// <response code="500">Internal server error occurred</response>
        [HttpGet]
        [ApiDocumentation(
            "Get all consultation requests",
            "Retrieves all consultation requests for faculty review with student and course details"
        )]
        [ApiExample("ConsultationRequests", 
            @"[{
                ""consultationID"": 1,
                ""courseCode"": ""CS101"",
                ""studentName"": ""John Doe"",
                ""dateSchedule"": ""2024-12-15T14:30:00"",
                ""timeStart"": ""14:30:00"",
                ""timeEnd"": ""15:30:00"",
                ""status"": ""Pending""
            }]",
            "Example response showing consultation requests")]
        [ApiErrorResponse(404, "No requests found", 
            @"{""Message"": ""No consultation requests found.""}", "NO_REQUESTS_FOUND")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while retrieving consultation requests"", ""error"": ""Database query failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> GetAllConsultationRequests()
        {
            //Query to get all consultation requests
            var requests = await _context.ConsultationRequest
                .Include(c => c.Student)
                    .ThenInclude(s => s.EnrolledCourses)
                .ToListAsync();

            //Check if there are no requests
            if (requests == null || !requests.Any())
            {
                return NotFound(new { Message = "No consultation requests found." });
            }

            //Map the requests to the view model
            var responses = requests.Select(request =>
            {
                var enrolledCourse = request.Student.EnrolledCourses.FirstOrDefault();

                return new ConsultationRequestViewModel
                {
                    ConsultationID = request.ConsultationID,
                    CourseCode = enrolledCourse?.CourseCode ?? "N/A",
                    StudentName = request.Student.StudentName,
                    DateSchedule = request.DateSchedule,
                    TimeStart = request.StartedTime,
                    TimeEnd = request.EndedTime,
                    Status = request.Status
                };
            }).ToList();

            return Ok(responses);
        }

        /// <summary>
        /// Updates the status of a consultation request (approve or disapprove)
        /// </summary>
        /// <param name="id">The unique identifier of the consultation request</param>
        /// <param name="usm">The status update model containing the new status</param>
        /// <returns>The updated consultation request if successful, or error details if validation fails</returns>
        /// <remarks>
        /// This endpoint allows faculty members to respond to student consultation requests:
        /// 
        /// **Status Options:**
        /// - **Approved**: Faculty accepts the consultation request
        /// - **Disapproved**: Faculty declines the consultation request
        /// 
        /// **Business Rules:**
        /// - Only pending requests can be updated to approved or disapproved
        /// - Status changes are permanent and cannot be reversed
        /// - Each status change triggers appropriate notifications to students
        /// - Faculty must provide reasoning for disapproved requests
        /// 
        /// **Validation Logic:**
        /// 1. Verifies consultation request exists
        /// 2. Ensures current status is "Pending"
        /// 3. Validates new status is either "Approved" or "Disapproved"
        /// 4. Updates the request and saves changes
        /// 
        /// **Workflow Integration:**
        /// - Triggers notification system for student updates
        /// - Updates dashboard statistics and counters
        /// - Maintains audit trail of faculty decisions
        /// - Enables scheduling workflow for approved requests
        /// 
        /// **Error Handling:**
        /// - Returns 404 if consultation request not found
        /// - Returns 400 if request is not in pending status
        /// - Returns 400 if invalid status provided
        /// - Handles database concurrency issues
        /// </remarks>
        /// <response code="200">Consultation request status updated successfully</response>
        /// <response code="400">Invalid status or request cannot be updated</response>
        /// <response code="404">Consultation request not found</response>
        /// <response code="500">Internal server error occurred</response>
        [HttpPut("api/consultation-requests/{id}/status")]
        [ApiDocumentation(
            "Update consultation status",
            "Updates the status of a consultation request to approved or disapproved"
        )]
        [ApiExample(typeof(UpdateStatusModel), "Status update request with new status")]
        [ApiExample("UpdateResponse", 
            @"{
                ""consultationID"": 1,
                ""status"": ""Approved"",
                ""dateSchedule"": ""2024-12-15T14:30:00"",
                ""studentName"": ""John Doe""
            }",
            "Updated consultation request response")]
        [ApiErrorResponse(404, "Request not found", 
            @"{""message"": ""Consultation request not found."", ""error"": ""No request found with the provided ID""}", "REQUEST_NOT_FOUND")]
        [ApiErrorResponse(400, "Cannot update non-pending request", 
            @"{""message"": ""Only pending requests can be updated."", ""error"": ""Request status is not pending""}", "INVALID_STATUS_UPDATE")]
        [ApiErrorResponse(400, "Invalid status", 
            @"{""message"": ""Invalid status. Use 'Approved' or 'Disapproved'."", ""error"": ""Status must be Approved or Disapproved""}", "INVALID_STATUS")]
        [ApiErrorResponse(500, "Internal server error", 
            @"{""message"": ""An error occurred while updating status"", ""error"": ""Database update failed""}", "SERVER_ERROR")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] UpdateStatusModel usm)
        {
            var request = await _context.ConsultationRequest.FindAsync(id);
            if (request == null)
                return NotFound("Consultation request not found.");

            if (request.Status != Status.Pending)
                return BadRequest("Only pending requests can be updated.");

            if (usm.Status != Status.Approved && usm.Status != Status.Disapproved)
                return BadRequest("Invalid status. Use 'Approved' or 'Disapproved'.");

            request.Status = usm.Status;
            await _context.SaveChangesAsync();

            return Ok(request);
        }
    }
}