using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Consultation.App.ConsultationManagement
{
    public partial class ConsultationCard : UserControl
    {
        public ConsultationCard()
        {
            InitializeComponent();
        }

        public void SetData(string date, string time, string name)
        {
            LabelDate.Text = date;
            LabelTime.Text = time;
            LabelName.Text = name;
        }
    }
}
