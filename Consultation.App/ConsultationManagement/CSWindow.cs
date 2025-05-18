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

            for (int i = 0; i < 10; i++)
            {

               flowLayoutPanel1.Controls.Add(new ConsultationCard());

            }
        }
    }
}
