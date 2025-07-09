using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Consultation.App.ConsultationManagement;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public partial class ArchiveCard : UserControl
    {

        private ConsultationData data = new ConsultationData();
        public ArchiveCard()
        {
            InitializeComponent();
        }

        public ConsultationData Data
        {
            get => data;
            set
            {
                data = value;

                StudentName.Text = data.Name;
                CourseCode.Text = data.CourseCode;
                Notes.Text = data.Notes;
                Date.Text = data.Date;
                Time.Text = data.Time;
                Faculty.Text = data.Faculty;
                idnumber.Text = data.IDNumber;
                Location.Text = data.Location;
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuContextArchive.Show(guna2Button1, guna2Button1.Width / 2, guna2Button1.Height);
        }

    }
}
