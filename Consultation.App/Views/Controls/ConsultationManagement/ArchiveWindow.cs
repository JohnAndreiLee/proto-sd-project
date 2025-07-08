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


namespace Consultation.App.ConsultationManagement
{
    public partial class ArchiveWindow : UserControl
    {
        public ArchiveWindow()
        {
            InitializeComponent();
        }

        public void AddToArchive(ConsultationCard card)
        {
            ArchiveCard archiveCard = new ArchiveCard();
            archiveCard.SetData(
                card.DateText,         
                card.TimeText,
                card.NameText,
                card.CourseCode,
                card.Faculty,
                card.LocationText,
                card.IDNumber,
                card.Notes
            );

            WindowPanelArchive.Controls.Add(archiveCard);
        }
    }
}