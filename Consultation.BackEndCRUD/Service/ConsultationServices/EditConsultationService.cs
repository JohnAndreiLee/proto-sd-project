using Consultation.BackEndCRUD.Repository.IRepository;
using Consultation.BackEndCRUD.Repository;
using Consultation.BackEndCRUD.Service.IService;
using Consultation.BackEndCRUD.ViewModel.ConsultationViewModel;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.BackEndCRUD.Service.ConsultationServices
{
    public class EditConsultationService : IEditConsultationService
    {
       
        private readonly IEditConsultationrequestRepository _editRepo;

        public EditConsultationService(AppDbContext appDbContext)
        {
           _editRepo = new EditConsultationrequestRepository(appDbContext);

        }

        // Getting all of the Consultion Request
        public async Task<IEnumerable<EditConsultationViewModel>> getAllConsultations()
        {
            try
            {
                var results = await _editRepo.GetConsultationRequestsAsync();

                if (results == null)
                    return new List<EditConsultationViewModel>();

                return results.Select(c => new EditConsultationViewModel
                {
                    studentName = c.Student?.StudentName ?? "Unknown Student",
                    courseCode = c.SubjectCode ?? "N/A",
                    studentUMID = c.Student?.StudentUMID ?? "N/A",
                    concernDescription = c.Concern ?? "No concern provided",
                    dateSchedule = c.DateSchedule,
                    startedTime = c.StartedTime,
                    Status = c.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (in a real app, use proper logging)
                System.Diagnostics.Debug.WriteLine($"Error getting all consultations: {ex.Message}");
                return new List<EditConsultationViewModel>();
            }
        }

        // Getting only One specific Consultation Request
        public async Task<EditConsultationViewModel?> getEditConsultation(int studentID)
        {
            try
            {
                if (studentID <= 0)
                    return null;

                var editConsultation = await _editRepo.GetConsultationRequests(studentID);

                if (editConsultation == null)
                    return null;

                return new EditConsultationViewModel
                {
                    studentName = editConsultation.Student?.StudentName ?? "Unknown Student",
                    courseCode = editConsultation.SubjectCode ?? "N/A",
                    studentUMID = editConsultation.Student?.StudentUMID ?? "N/A",
                    concernDescription = editConsultation.Concern ?? "No concern provided",
                    dateSchedule = editConsultation.DateSchedule,
                    startedTime = editConsultation.StartedTime,
                    Status = editConsultation.Status
                };
            }
            catch (Exception ex)
            {
                // Log the exception (in a real app, use proper logging)
                System.Diagnostics.Debug.WriteLine($"Error getting consultation for student {studentID}: {ex.Message}");
                return null;
            }
        }
    }
}
