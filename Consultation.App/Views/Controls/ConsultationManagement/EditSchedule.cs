using System;
using System.Windows.Forms;
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
            
            cardToEdit.SetData(

                guna2Date.Value.ToString("MMMM dd, yyyy"),
                guna2Time.Text,
                Student.Text,
                CourseCode.Text,
                Faculty.Text,
                Location.Text,
                Idnumber.Text,
                Notes.Text
            );

            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}