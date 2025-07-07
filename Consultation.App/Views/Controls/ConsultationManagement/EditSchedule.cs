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

            
            Student.Text = cardToEdit.NameText;
            guna2Date.Value = DateTime.Parse(cardToEdit.DateText);
            guna2Time.Text = cardToEdit.TimeText;
            

            btnChanges.Text = "Update"; 
            this.Text = "Edit Schedule";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            string studentName = Student.Text;
            string date = guna2Date.Value.ToShortDateString();
            string time = guna2Time.Text;
            string notes = Notes.Text;
            string location = Location.Text;
            string faculty = Faculty.Text;
            string coursecode = CourseCode.Text;
            string idnumber = Idnumber.Text;


            cardToEdit.SetData(date, time, studentName, coursecode, faculty, location, idnumber, notes);

            this.Close();
        }
    }
}
