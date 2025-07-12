using Consultation.App.Presenters;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.BackEndCRUD.Service;
using Consultation.Infrastructure.Data;
namespace Consultation.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXpecXRcQ2BcV0BwVktWYUA=");

            ApplicationConfiguration.Initialize();

            IMainView mainView = new MainView();
            new MainPresenter(mainView);
            AppDbContext appDbContext = new AppDbContext();

            var authservice = new AuthService(appDbContext);

            ILoginView loginView = new LogInView();
            new LogInPresenter(loginView, authservice);

            Application.Run((Form)loginView);

            ////Application.Run(new BulletinView());
            //ILoginView loginView = new LogInView();
            //using (new LogInPresenter(loginView, authservice))
            //{
            //    if (loginView.ShowDialog() == DialogResult.OK)
            //    {
            //        //LoadProgramList();
            //        Application.Run((Form)mainView);

            //    }
            //}
        }
    }
           
}