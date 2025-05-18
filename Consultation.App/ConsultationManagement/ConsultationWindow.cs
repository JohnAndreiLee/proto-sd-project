using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationWindow : Form
    {
        public ConsultationWindow()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1636, 1080);


        }

        private void btnConsultation_Click_1(object sender, EventArgs e)
        {
            MoveUnderline(btnConsultation);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new CSWindow());

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            MoveUnderline(btnArchive);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ArchiveWindow());

        }

        private void MoveUnderline(Control targetButton)
        {

            underlinePanel.Visible = true;
            underlinePanel.Width = targetButton.Width;
            underlinePanel.Left = targetButton.Left;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.Show();
        }
    }
}
