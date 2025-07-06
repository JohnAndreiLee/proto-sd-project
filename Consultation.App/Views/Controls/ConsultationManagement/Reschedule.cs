using System;
using System.Windows.Forms;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public partial class Reschedule : Form
    {


        public Reschedule()
        {
            InitializeComponent();

        }

        private void Reschedule_Load(object sender, EventArgs e)
        {
          
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
