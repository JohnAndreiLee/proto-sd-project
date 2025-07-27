using Consultation.App.Views.IViews;
using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{

    public partial class ConsultationView : UserControl, IConsultationView
    {
        private CSWindow csWindow;
        private ArchiveWindow archiveWindow;

        public ConsultationView()
        {
            InitializeComponent();
            MoveUnderline(btnConsultation);
            ShowConsultationView();
        }
        public UserControl AsUserControl => this;



        private void ShowConsultationView()
        {
           
           WindowPanelConsultation.Controls.Clear();

            if (csWindow == null)
            {
                csWindow = new CSWindow();
                csWindow.CardArchived += OnCardArchived; // Subscribe to event
            }

            WindowPanelConsultation.Controls.Add(csWindow);
        }

        // What does this method do, Only Displaying The Higlight line Under the button
        private void MoveUnderline(Control targetButton)
        {
            underlinePanel.Width = targetButton.Width;
            underlinePanel.Left = targetButton.Left;
            underlinePanel.Top = targetButton.Bottom - 4;
            underlinePanel.Visible = true;
        }

        //This is the Function For the Archived
        private void OnCardArchived(object? sender, ConsultationCard card)
        {
            csWindow.RemoveCard(card);

            if (archiveWindow == null)
                archiveWindow = new ArchiveWindow();

            archiveWindow.AddToArchive(card);
        }

       
        private void btnConsultation_Click_1(object? sender, EventArgs e)
        {
            MoveUnderline(btnConsultation);
            ShowConsultationView();
        }

        private void btnArchive_Click(object? sender, EventArgs e)
        {
            MoveUnderline(btnArchive);

            if (archiveWindow == null)
                archiveWindow = new ArchiveWindow();

            WindowPanelConsultation.Controls.Clear();
            WindowPanelConsultation.Controls.Add(archiveWindow);


        }

        // No I logic for this button in the original code, but keeping it for consistency
        private void btnRefresh_Click(object? sender, EventArgs e)
        {

        }

        private void materialCard2_Paint(object? sender, PaintEventArgs e)
        {

        }
    }
}