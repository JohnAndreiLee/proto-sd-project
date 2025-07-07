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
    public partial class ArchiveWindow : UserControl
    {

       
        public ArchiveWindow()
        {
            InitializeComponent();

        }

        public void AddToArchive(ConsultationCard card)
        {
            WindowPanelArchive.Controls.Add(card);
        }

        public void AddToArchive(ConsultationCard card, Panel originalPanel = null)
        {
            if (originalPanel != null)
                card.OriginalPanel = originalPanel;

            card.SetAsArchived();
            WindowPanelArchive.Controls.Add(card);
        }
    }
}
