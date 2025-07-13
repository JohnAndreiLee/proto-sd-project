using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.Views.Controls.ConsultationManagement;
using Syncfusion.Windows.Forms.Tools;


namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationCard : UserControl
    {
        public event EventHandler ArchiveRequested;

        private ConsultationData data;
        public DateTime ScheduleDate { get; private set; }

        
        public string NameText => lblStudentName.Text;
        public string DateText => ScheduleDate.ToShortDateString(); 
        public string TimeText => txtboxTimeStart.Text;
        public string CourseCode => lblCourseCode.Text;
        public string Faculty => txtboxFaculty.Text;
        public string LocationText => Location.Text;
        public string IDNumber => txtboxIdNumber.Text;
        public string Notes => lblConcern.Text;

        public ConsultationCard(ConsultationData _data)
        {
            InitializeComponent();
            Data = _data;
        }

        public ConsultationData Data
        {
            get
            {

                return data;
            }
            set
            {

                data = value;
                lblStudentName.Text = data.Name;
                lblCourseCode.Text = data.CourseCode;
                lblConcern.Text = data.Concern;

                txtboxDateSchedule.Text = data.Date;
                txtboxTimeStart.Text = data.Time;
                txtboxFaculty.Text = data.Faculty;
                txtboxIdNumber.Text = data.IDNumber;
                Location.Text = data.Location;
                guna2txtboxStatus.Text = data.status;
                //courseCodeLabel.Location = new Point(StudentName.Right + 10, courseCodeLabel.Location.Y);

                //DateTime parsedDate;
                //if (DateTime.TryParse(data.Date, out parsedDate))
                //{
                //    ScheduleDate = parsedDate;
                //}
                //else
                //{
                //    ScheduleDate = DateTime.MinValue;
                //}
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuContext.Show(guna2Button1, guna2Button1.Width / 2, guna2Button1.Height);
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSchedule editForm = new EditSchedule(this);
            editForm.ShowDialog();
        }

        private void rescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reschedule rescheduleForm = new Reschedule(this);
            rescheduleForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewConsultation viewForm = new ViewConsultation(this); 
            viewForm.ShowDialog();
        }


    }
}
