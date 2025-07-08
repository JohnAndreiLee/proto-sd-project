using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationView : Form
    {
        private CSWindow csWindow;
        private ArchiveWindow archiveWindow;

        public ConsultationView()
        {
            InitializeComponent();
            ShowConsultationView();
        }

        private void ShowConsultationView()
        {
            MoveUnderline(btnConsultation);
            WindowPanelConsultation.Controls.Clear();

            if (csWindow == null)
            {
                csWindow = new CSWindow();
                csWindow.CardArchived += OnCardArchived; // Subscribe to event
            }

            WindowPanelConsultation.Controls.Add(csWindow);
        }

        private void OnCardArchived(object sender, ConsultationCard card)
        {
            csWindow.RemoveCard(card);

            if (archiveWindow == null)
                archiveWindow = new ArchiveWindow();

            archiveWindow.AddToArchive(card);
        }

        private void btnConsultation_Click_1(object sender, EventArgs e)
        {
            ShowConsultationView();

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            MoveUnderline(btnArchive);

            if (archiveWindow == null)
                archiveWindow = new ArchiveWindow();

            WindowPanelConsultation.Controls.Clear();
            WindowPanelConsultation.Controls.Add(archiveWindow);


        }

        private void MoveUnderline(Control targetButton)
        {
            underlinePanel.Width = targetButton.Width;
            underlinePanel.Left = targetButton.Left;
            underlinePanel.Top = targetButton.Bottom - 4;
            underlinePanel.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}