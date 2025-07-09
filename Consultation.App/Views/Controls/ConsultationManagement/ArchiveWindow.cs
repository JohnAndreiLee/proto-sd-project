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

            archiveCard.Data = new ConsultationData
            {
                Date = card.DateText,
                Time = card.TimeText,
                Name = card.NameText,
                CourseCode = card.CourseCode,
                Faculty = card.Faculty,
                Location = card.LocationText,
                IDNumber = card.IDNumber,
                Notes = card.Notes
            };

            WindowPanelArchive.Controls.Add(archiveCard);
        }
    }
}