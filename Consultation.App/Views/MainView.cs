using Consultation.App.ConsultationManagement;
using System;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class MainView : Form
    {
      
        private ConsultationWindow consultationWindow;

        public MainView()
        {
            InitializeComponent();
        }

        private void buttonConsulation_Click(object sender, EventArgs e)
        {
            if (consultationWindow == null || consultationWindow.IsDisposed)
            {
                consultationWindow = new ConsultationWindow();

                
                consultationWindow.StartPosition = FormStartPosition.Manual;

            
                consultationWindow.Location = new Point(262, 16);

                consultationWindow.Show();
            }
            else if (!consultationWindow.Visible)
            {
                consultationWindow.Show();
            }
            else
            {
                consultationWindow.BringToFront();
            }
        }

       
        private void CloseAllChildWindows()
        {
            if (consultationWindow != null && !consultationWindow.IsDisposed)
            {
                consultationWindow.Close();
                consultationWindow = null;
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
