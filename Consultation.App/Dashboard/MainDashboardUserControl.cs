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
            //BulletinButton.ForeColor = Color.FromArgb(192, 0, 0);
            //ConsultationButton.ForeColor = Color.DimGray;
        }

        private void ConsultationButton_Click(object sender, EventArgs e)
        {
            //ConsultationButton.ForeColor = Color.FromArgb(192, 0, 0);
            //BulletinButton.ForeColor = Color.DimGray;
        }
    }
}
