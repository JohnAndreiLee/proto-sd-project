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
using Consultation.App.Views.Controls.ConsultationManagement.IView;

namespace Consultation.App.ConsultationManagement
{

    public partial class CSWindow : UserControl, ICSWindowView
    {
       
        public event EventHandler<ConsultationCard> CardArchived;
        public event EventHandler LoadConsultationRequest;
        //public event EventHandler RemoveConsulationRequest;

        public CSWindow()
        {
            InitializeComponent();

            LoadConsultationRequest?.Invoke(this, EventArgs.Empty);

            // what does this do??
            for (int i = 0; i < 4; i++)
            {
                //ConsultationCard card = new ConsultationCard();

              
               // card.ArchiveRequested += (s, e) => CardArchived?.Invoke(s, card);

                //WindowPanelConsultation.Controls.Add(card);
            }
        }

        private void OnArchiveRequested(ConsultationCard card)
        {
          
            CardArchived?.Invoke(this, card);
        }

        public void RemoveCard(ConsultationCard card)
        {
            if (WindowPanelConsultation.Controls.Contains(card))
                WindowPanelConsultation.Controls.Remove(card);
        }
    }
}
