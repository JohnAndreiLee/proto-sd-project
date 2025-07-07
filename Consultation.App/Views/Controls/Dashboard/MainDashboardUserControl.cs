using Consultation.App.Dashboard.Activity_Feed_Panel;
using Consultation.App.Presenters;
using Consultation.App.Views.Controls.Dashboard.Quick_Actions_Panel;
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

        public event EventHandler ButtonClick;

        private Color bulletinDefaultColor;
        private Color consultationDefaultColor;
        private Color hoverColor = Color.LightBlue;

        public MainDashboardUserControl()
        {
            InitializeComponent();
            createNewBulletin1.Cursor = Cursors.Hand;
            scheduleConsultation1.Cursor = Cursors.Hand;

            bulletinDefaultColor = createNewBulletin1.BackColor;
            consultationDefaultColor = scheduleConsultation1.BackColor;

            //hover events for buttons
            AttachHoverEvents(createNewBulletin1, createNewBulletin1_MouseEnter, createNewBulletin1_MouseLeave);
            AttachHoverEvents(scheduleConsultation1, scheduleConsultation1_MouseEnter, scheduleConsultation1_MouseLeave);
            AttachHoverEvents(addUser1, addUser1_MouseEnter, addUser1_MouseLeave);
            AttachHoverEvents(systemSettings1, systemSettings1_MouseEnter, systemSettings1_MouseLeave);
        }
        private void BulletinButton_Click_1(object sender, EventArgs e)
        {
            ResetButtonBorders();
            BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
            BulletinButton.CustomBorderColor = Color.Red;
            BulletinButton.ForeColor = Color.Red;

            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Bulletin());
        }

        private void ConsultationButton_Click_1(object sender, EventArgs e)
        {
            ResetButtonBorders();
            ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
            ConsultationButton.CustomBorderColor = Color.Red;
            ConsultationButton.ForeColor = Color.Red;

            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Consultation2());
        }

        private void MainDashboardUserControl_Load(object sender, EventArgs e)
        {
            ActivityFeedPanel.Controls.Add(new Bulletin());
        }

        private void AttachHoverEvents(Control parent, EventHandler onEnter, EventHandler onLeave)
        {
            parent.MouseEnter += onEnter;
            parent.MouseLeave += onLeave;

            foreach (Control child in parent.Controls)
            {
                AttachHoverEvents(child, onEnter, onLeave);
            }
        }

        private void createNewBulletin1_Load(object sender, EventArgs e)
        {
        }

        private void createNewBulletin1_MouseEnter(object sender, EventArgs e)
        {
            createNewBulletin1.BackColor = hoverColor;
        }

        private void createNewBulletin1_MouseLeave(object sender, EventArgs e)
        {
            createNewBulletin1.BackColor = bulletinDefaultColor;
        }

        private void scheduleConsultation1_MouseEnter(object sender, EventArgs e)
        {
            scheduleConsultation1.BackColor = hoverColor;
        }

        private void scheduleConsultation1_MouseLeave(object sender, EventArgs e)
        {
            scheduleConsultation1.BackColor = consultationDefaultColor;
        }

        private void addUser1_MouseEnter(object sender, EventArgs e)
        {
            addUser1.BackColor = hoverColor;
        }

        private void addUser1_MouseLeave(object sender, EventArgs e)
        {
            addUser1.BackColor = consultationDefaultColor;
        }

        private void systemSettings1_MouseEnter(object sender, EventArgs e)
        {
            systemSettings1.BackColor = hoverColor;
        }

        private void systemSettings1_MouseLeave(object sender, EventArgs e)
        {
            systemSettings1.BackColor = consultationDefaultColor;
        }

        private void ResetButtonBorders()
        {
            BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 0);
            ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 0);

            BulletinButton.ForeColor = Color.Black;
            ConsultationButton.ForeColor = Color.Black;
        }
    }
}
