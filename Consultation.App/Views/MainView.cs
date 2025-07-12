using Consultation.App.Views.IViews;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            profilePanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            buttonDashboard.Click += (s, e) => DashboardEvent?.Invoke(s, e);
            buttonConsultation.Click += (s, e) => ConsultationEvent?.Invoke(s, e);
            buttonBulletin.Click += (s, e) => BulletinEvent?.Invoke(s, e);
            buttonSFManagement.Click += (s, e) => SFManagementEvent?.Invoke(s, e);
            //buttonReports.Click += (s, e) => ReportsEvent?.Invoke(s, e);
            buttonPreference.Click += (s, e) => PreferenceEvent?.Invoke(s, e);
            this.FormClosed += MainView_FormClosed;

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
            //this.Text = header;
            labelForm.Text = header;
        }
        public void SetMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonDashboard_MouseLeave(object sender, EventArgs e)
        {
            buttonDashboard.ImageIndex = 0;
            buttonDashboard.ForeColor = Color.White;
        }

        private void buttonDashboard_MouseEnter(object sender, EventArgs e)
        {
            buttonDashboard.ImageIndex = 1;
            buttonDashboard.ForeColor = Color.Black;
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
