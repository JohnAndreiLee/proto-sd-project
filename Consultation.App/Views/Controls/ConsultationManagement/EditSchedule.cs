using System;
using System.Windows.Forms;
using Consultation.App.Views.Controls.ConsultationManagement;
using Guna.UI2.WinForms;

namespace Consultation.App.ConsultationManagement
{
    public partial class EditSchedule : Form
    {
        private ConsultationCard cardToEdit;

        public EditSchedule(ConsultationCard cardToEdit)
        {
            InitializeComponent();
            this.cardToEdit = cardToEdit;

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

            cardToEdit.Data = new ConsultationData
            {
                Date = Date.Value.ToString("MMMM dd, yyyy"),
                Time = Time.Text,
                Name = StudentName.Text,
                CourseCode = CourseCode.Text,
                Faculty = Faculty.Text,
                Location = Location.Text,
                IDNumber = Idnumber.Text,
                Notes = Notes.Text
            };

            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}