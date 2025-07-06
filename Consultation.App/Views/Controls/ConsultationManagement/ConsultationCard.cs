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

            LabelName.Text = name;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuContext.Show(guna2Button1, guna2Button1.Width / 2, guna2Button1.Height);
        }

   
    }
}
