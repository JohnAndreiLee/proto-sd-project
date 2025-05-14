using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Dashboard.Upcoming_Schedule
{
    public partial class Today : UserControl
    {
        public Today()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                flowLayoutPanel1.Controls.Add(new TodayCard());
            }
        }
    }
}
