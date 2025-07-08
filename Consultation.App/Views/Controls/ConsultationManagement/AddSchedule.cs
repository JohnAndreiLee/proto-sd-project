
using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class AddSchedule : Form
    {

        public AddSchedule()
        {
            InitializeComponent();
            this.Click += ForwardClick;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += ForwardClick;
            }
        }

        private void ForwardClick(object sender, EventArgs e)
        {
            this.OnClick(e); // raises the UserControl's Click event
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

           // csWindow.AddConsultationCard(date, time, studentName);
            this.Close();
        }
    }
}