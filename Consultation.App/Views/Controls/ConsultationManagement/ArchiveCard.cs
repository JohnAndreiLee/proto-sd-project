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
        public ArchiveCard()
        {
            InitializeComponent();
        }

        public void SetData(string date, string time, string name, string coursecode, string faculty, string location, string idnumber, string notes)
        {
            Student.Text = name;
            Coursecode.Text = coursecode;
            Notes.Text = notes;
            Date.Text = date;
            Time.Text = time;
            Faculty.Text = faculty;
            IDnumber.Text = idnumber;
            Location.Text = location;
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
