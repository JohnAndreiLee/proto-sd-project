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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationCard : UserControl
    {
        public event EventHandler ArchiveRequested;

        public DateTime ScheduleDate { get; private set; }

        
        public string NameText => LabelName.Text;
        public string DateText => ScheduleDate.ToShortDateString(); 
        public string TimeText => textTime.Text;
        public string CourseCode => LabelCourse.Text;
        public string Faculty => textFaculty.Text;
        public string LocationText => textLocation.Text;
        public string IDNumber => textIDnumber.Text;
        public string Notes => LabelNotes.Text;

        public ConsultationCard()
        {
            InitializeComponent();
        }

        public void SetData(string date, string time, string name, string coursecode, string faculty, string location, string idnumber, string notes)
        {
            LabelName.Text = name;
            LabelCourse.Text = coursecode;
            LabelCourse.Location = new Point(LabelName.Right + 10, LabelCourse.Location.Y);
            LabelNotes.Text = notes;
            textDate.Text = date;
            textTime.Text = time;
            textFaculty.Text = faculty;
            textIDnumber.Text = idnumber;
            textLocation.Text = location;

            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                ScheduleDate = parsedDate;
            }
            else
            {
                ScheduleDate = DateTime.MinValue;
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
