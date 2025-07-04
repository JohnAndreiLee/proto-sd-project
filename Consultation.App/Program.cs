using Consultation.App.Views;
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

            LogIn loginForm = new LogIn();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainView());
            }
        }
    }
}