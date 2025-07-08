using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.ConsultationManagement;
using Syncfusion.Windows.Tools.Controls;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public partial class ViewConsultation : Form
    {

        private ConsultationCard card;
        public ViewConsultation(ConsultationCard cardToView)
        {
            InitializeComponent();
            card = cardToView;
            LoadCardDetails();

        }

        private void LoadCardDetails()
        {
            ViewName.Text = card.NameText;
            ViewSched.Text = card.DateText;
            ViewTime.Text = card.TimeText;
            ViewCourse.Text = card.CourseCode;
            ViewFaculty.Text = card.Faculty;
            ViewLocation.Text = card.LocationText;
            ViewIDnumber.Text = card.IDNumber;
            ViewNotes.Text = card.Notes;
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            Reschedule rescheduleForm = new Reschedule(card);
            rescheduleForm.ShowDialog();

         
            LoadCardDetails();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSchedule editForm = new EditSchedule(card);
            editForm.ShowDialog();

     
            LoadCardDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
