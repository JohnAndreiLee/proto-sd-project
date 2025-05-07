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
            Color containerColor = Form1.DefaultForeColor;
            textBoxExt1.BackColor = containerColor;
            textBoxExt1.BorderColor = containerColor;
            textBoxExt1.BorderStyle = BorderStyle.None; // Optional
        }
    }
}
