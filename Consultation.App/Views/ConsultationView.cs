using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationView : Form
    {
        private CSWindow csWindow;

        public ConsultationView()
        {
            InitializeComponent();


            ShowConsultationView();
        }

        private void ShowConsultationView()
        {
            MoveUnderline(btnConsultation);
            if (csWindow == null)
            {
                csWindow = new CSWindow();
            }

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(csWindow);
        }

        private void btnConsultation_Click_1(object sender, EventArgs e)
        {
          ShowConsultationView();
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
            if (csWindow == null)
            {
                MessageBox.Show("Please open the Consultation view first.");
                return;
            }

            AddSchedule addSchedule = new AddSchedule(csWindow);
            addSchedule.ShowDialog();
        }

       
    }
}
