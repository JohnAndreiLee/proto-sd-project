using Consultation.App.Views;
using System.Threading; // Add this for Thread.Sleep (optional)

namespace Consultation.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/...");

            ApplicationConfiguration.Initialize();

            SplashForm splash = new SplashForm();
            splash.Show();
            splash.Refresh();

            Thread.Sleep(3000);

            splash.Close();

            LogIn loginForm = new LogIn();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainView());
            }
        }
    }
}