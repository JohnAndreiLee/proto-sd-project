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
        public CSWindow()
        {
            InitializeComponent();
        }

        public void AddConsultationCard(string date, string time, string name)
        {
            ConsultationCard card = new ConsultationCard();
            card.SetData(date, time, name);
            flowLayoutPanel1.Controls.Add(card); // Make sure this matches your FlowLayoutPanel name
        }
    }
}
