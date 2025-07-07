using Student_Faculty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class UserManagementView : Form
    {
        public UserManagementView()
        {
            InitializeComponent();
            Load += StudentFacultyView_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayPanSFA.Controls.Add(new StudentListCard());
        }
        private void BtnStudents_Click(object sender, EventArgs e)
        {
            flowLayPanSFA.Controls.Clear();
            flowLayPanSFA.Controls.Add(new StudentListCard());
        }

        private void BtnFaculty_Click(object sender, EventArgs e)
        {
            flowLayPanSFA.Controls.Clear();
            flowLayPanSFA.Controls.Add(new FacultyListCard());
        }

        private void StudentFacultyView_Load(object sender, EventArgs e)
        {
            flowLayPanSFA.Controls.Add(new StudentListCard());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelstudafac_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
