using Consultation.App.ConsultationManagement;
using Consultation.App.Views.Controls.ConsultationManagement;
using Consultation.App.Views.Controls.ConsultationManagement.IView;
using Consultation.BackEndCRUD.Service.IService;
using Consultation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters.Consultation
{
    public class CSWindowPresenter
    {
        private ICSWindowView _cSWindow;
        private IEditConsultationService _editConsultationService;

        public CSWindowPresenter(ICSWindowView cSWindow, IEditConsultationService editConsultationService)
        {
            _cSWindow = cSWindow;
            _editConsultationService = editConsultationService;
            _cSWindow.LoadConsultationRequest += LoadConsultationRequest;
        }

        public async void LoadConsultationRequest(object? obj, EventArgs e)
        {
            ICollection<ConsultationCard> consultationCards = new List<ConsultationCard>();

            var consultations = await _editConsultationService.getAllConsultations();

            //comment sa nako
            /*foreach (var consultation in consultations)
            {
                consultationCards.Add(new ConsultationCard(new ConsultationData())
                {
                    Data = new ConsultationData
                    {
                        Name = consultation.studentName,
                        CourseCode = consultation.courseCode,
                        Concern = consultation.concernDescription,
                        Date = consultation.dateSchedule.ToString(),
                        Time = consultation.startedTime.ToString(),
                        Faculty = consultation.facultyName,
                        IDNumber = consultation.studentUMID,
                        Location = "BE214"

                        switch(consultation.Status)
                        {
                            case ConsultationStatus.Pending:
                                status = "Pending";
                                break;
                            case ConsultationStatus.Approved:
                                status = "Approved";
                                break;
                            case ConsultationStatus.Rejected:
                                status = "Rejected";
                                break;
                            case ConsultationStatus.Completed:
                                status = "Completed";
                                break;
                            default:
                                status = "Unknown";
                                break;
                        }

                    }
            
                });
            }*/
           // WindowPanelConsultation.Controls.Add(card);
        }
    }
}
