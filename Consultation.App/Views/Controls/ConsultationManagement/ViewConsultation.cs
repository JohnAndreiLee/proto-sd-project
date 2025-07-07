using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public partial class ViewConsultation : Form
    {
        public ViewConsultation()
        {
            InitializeComponent();
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            Reschedule reschedule = new Reschedule();
            reschedule.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textIDnumber.ReadOnly = false;
            textCode.ReadOnly = false;
            textLocation.ReadOnly = false;
            textNotes.ReadOnly = false;
            textPersonel.ReadOnly = false;
            textRequestDate.ReadOnly = false;
            textSchedTime.ReadOnly = false;
            textStudent.ReadOnly = false;
            textScheduleDate.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
