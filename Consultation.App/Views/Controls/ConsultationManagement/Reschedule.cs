using System;
using System.Windows.Forms;
using Consultation.App.ConsultationManagement;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public partial class Reschedule : Form
    {
        private ConsultationCard card;

        public Reschedule(ConsultationCard cardToReschedule)
        {
            InitializeComponent();
            card = cardToReschedule;

            
            CurrentDate.Text = card.DateText;
            CurrentTime.Text = card.TimeText;
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
          
            string newDate = Datepicker.Value.ToString("MMMM dd, yyyy");
            string newTime = Timepicker.Text;
            string reason = TextBoxReason.Text;

            
            card.SetData(
                newDate,
                newTime,
                card.NameText,
                card.CourseCode,
                card.Faculty,
                card.LocationText,
                card.IDNumber,
                reason 
            );

            Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
