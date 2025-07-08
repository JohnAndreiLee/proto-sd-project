using Consultation.App.BulletinManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views.Controls.Dashboard.Quick_Actions_Panel
{
    public partial class CreateNewBulletin : UserControl
    {
        public CreateNewBulletin()
        {
            InitializeComponent();
        }

        private void materialCard1_Click(object sender, EventArgs e)
        {
            CreateBulletin bulletinForm = new CreateBulletin();
            bulletinForm.ShowDialog();
        }
    }
}
