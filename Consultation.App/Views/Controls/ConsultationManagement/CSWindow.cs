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

    public partial class CSWindow : UserControl
    {

        public event EventHandler<ConsultationCard> CardArchived;
        public CSWindow()
        {
            InitializeComponent();
        }

        public void AddConsultationCard(string date, string time, string name)
        {
            ConsultationCard card = new ConsultationCard();
            card.SetData(date, time, name);

            // Subscribe to archive event
            card.ArchiveClicked += (s, e) =>
            {
                // Let the main form handle it
                CardArchived?.Invoke(this, card);
            };

            WindowPanelConsultation.Controls.Add(card);
        }

        public void RemoveCard(ConsultationCard card)
        {
            WindowPanelConsultation.Controls.Remove(card);
        }

    }
}
