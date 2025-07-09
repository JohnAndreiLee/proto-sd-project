using System;
using System.Windows.Forms;
using Consultation.App.Views.Controls.ConsultationManagement;
using Guna.UI2.WinForms;

namespace Consultation.App.ConsultationManagement
{
    public partial class EditSchedule : Form
    {
      

        public EditSchedule(ConsultationCard cardToEdit)
        {
            InitializeComponent(); 
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}