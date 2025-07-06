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
        public ConsultationCard()
        {
            InitializeComponent();
        }

        public void SetData(string date, string time, string name)
        {

            LabelName.Text = name;
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
    }
}
