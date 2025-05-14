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
            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Bulletin());
        }

        private void ConsultationButton_Click(object sender, EventArgs e)
        {
            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Consultation2());
        }

        private void MainDashboardUserControl_Load(object sender, EventArgs e)
        {
            ActivityFeedPanel.Controls.Add(new Bulletin());
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
        }

        private void ThisWeekButton_Click(object sender, EventArgs e)
        {
        }
    }
}
