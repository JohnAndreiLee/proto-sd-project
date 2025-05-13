using Consultation.App.Dashboard.Activity_Feed_Panel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Dashboard
{
    public partial class MainDashboardUserControl : UserControl
    {
        public MainDashboardUserControl()
        {
            InitializeComponent();

        }

        private void BulletinButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new Bulletin());
        }

        private void ConsultationButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void MainDashboardUserControl_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Bulletin());
        }
    }
}
