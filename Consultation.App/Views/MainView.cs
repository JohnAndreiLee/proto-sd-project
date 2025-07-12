using Consultation.App.Views.IViews;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class MainView : Form, IMainView
    {
        private readonly Button[] _navButtons;

        public MainView()
        {
            InitializeComponent();

            profilePanel.BackColor = Color.FromArgb(50, 0, 0, 0);

            // Attach click handlers
            buttonDashboard.Click += (s, e) => DashboardEvent?.Invoke(s, e);
            buttonConsultation.Click += (s, e) => ConsultationEvent?.Invoke(s, e);
            buttonBulletin.Click += (s, e) => BulletinEvent?.Invoke(s, e);
            buttonSFManagement.Click += (s, e) => SFManagementEvent?.Invoke(s, e);
            buttonPreference.Click += (s, e) => PreferenceEvent?.Invoke(s, e);
<<<<<<< HEAD
            this.FormClosed += MainView_FormClosed;
=======

            // List of nav buttons to apply hover effect
            _navButtons = new[]
            {
                buttonDashboard,
                buttonConsultation,
                buttonBulletin,
                buttonSFManagement,
                buttonPreference
            };
>>>>>>> d0989aca09de3c61da6bc790767f04f19866b4ab

            // Attach hover handlers to all
            foreach (var btn in _navButtons)
            {
                btn.MouseEnter += NavButton_MouseEnter;
                btn.MouseLeave += NavButton_MouseLeave;
            }
        }

        public Panel MainPanel => panelContainer;

        public event EventHandler DashboardEvent;
        public event EventHandler ConsultationEvent;
        public event EventHandler BulletinEvent;
        public event EventHandler SFManagementEvent;
        public event EventHandler ReportsEvent;
        public event EventHandler PreferenceEvent;

        public void Header(string header)
        {
            labelForm.Text = header;
        }

        public void SetMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn) ButtonHighlight(btn);
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn) ButtonUnhighlight(btn);
        }

        public void ButtonHighlight(Button btn)
        {
            btn.ImageIndex = 1;
            btn.ForeColor = Color.Black;
        }

        public void ButtonUnhighlight(Button btn)
        {
            btn.ImageIndex = 0;
            btn.ForeColor = Color.White;
        }
        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ShowForm()
        {
            Show();
        }
    }
}
