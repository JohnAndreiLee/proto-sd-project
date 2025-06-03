using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class AddSchedule : Form
    {
        private CSWindow csWindow;

        public AddSchedule(CSWindow csWindow)
        {
            InitializeComponent();
            this.csWindow = csWindow;
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

            csWindow.AddConsultationCard(date, time, studentName);
            this.Close();
        }
    }
}