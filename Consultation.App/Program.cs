using Consultation.App.Presenter;
using Consultation.App.Services;
using Consultation.App.Services.IServices;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.Infrastructure.Data;
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
            AppDbContext context = new AppDbContext();

            ILogin login = new LogIn();
            IAuthenticationServices authenticationServices = new AuthenticationServices(context);

            new LoginViewPresenter(authenticationServices, login);

            SplashForm splash = new SplashForm();
            splash.Show();
            splash.Refresh();

            Thread.Sleep(3000);

            splash.Close();

            LogIn loginForm = new LogIn();

            Application.Run((Form)login);
        }
    }
}