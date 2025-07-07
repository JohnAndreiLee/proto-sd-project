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

        public Panel OriginalPanel { get; set; }
        private CSWindow csWindow;

        public string NameText => LabelName.Text;
        public string DateText => textDate.Text;
        public string TimeText => textTime.Text;

        public ConsultationCard()
        {
            InitializeComponent();
        }
        public void SetData(string date, string time, string name, string coursecode, string faculty, string location, string idnumber, string notes)
        {
            LabelName.Text = name;
            LabelCourse.Text = coursecode;
            LabelNotes.Text = notes;
            textDate.Text = date;
            textDate.Width = TextRenderer.MeasureText(textDate.Text, textDate.Font).Width + 10;
            textTime.Text = time;
            textTime.Width = TextRenderer.MeasureText(textTime.Text, textTime.Font).Width + 10;
            textFaculty.Text = faculty;
            textFaculty.Width = TextRenderer.MeasureText(textFaculty.Text, textFaculty.Font).Width + 10;
            textIDnumber.Text = idnumber;
            textIDnumber.Width = TextRenderer.MeasureText(textIDnumber.Text, textIDnumber.Font).Width + 10;
            textLocation.Text = location;
            textLocation.Width = TextRenderer.MeasureText(textLocation.Text, textLocation.Font).Width + 10;
        }

        public void SetAsArchived()
        {
            MenuContext.Items.Clear(); 

            //Need restore button for the conetxtmenustrip.
            MenuContext.Items.Add("View", null, viewToolStripMenuItem_Click);
            MenuContext.Items.Add("Delete", null, deleteToolStripMenuItem_Click);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuContext.Show(guna2Button1, guna2Button1.Width / 2, guna2Button1.Height);
        }

        public event EventHandler ArchiveClicked;
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewConsultation viewForm = new ViewConsultation();
            viewForm.ShowDialog();
        }

        private void rescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reschedule rescheduleForm = new Reschedule();
            rescheduleForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditSchedule editSchedule = new EditSchedule(this);
            editSchedule.ShowDialog();
        }


    }
}
