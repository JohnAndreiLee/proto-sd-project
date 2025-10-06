using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.BackEndCRUD.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters
{
    public class LogInPresenter
    {
        private readonly ILoginView _loginView;
        private IAuthService _authservice;

        public LogInPresenter(ILoginView loginView, IAuthService authservice)
        {
            _loginView = loginView;
            _authservice = authservice;

            _loginView.LogInEvent += LogIn;

        }
        // EllaineMusni.550200@umindanao.edu.ph
        // AQAAAAIAAYagAAAAEIG5jButwoJ4JYY+4qNfa5qxkFZGPY6GQfJ75BlTwCeGgWTJyosYMMIp8oKd60fYeQ==

        // MyAdmin123!

        
        public async void LogIn(object? sender, EventArgs e)
        {
            try
            {
                // For testing purposes, let's add some hardcoded credentials
                var email = _loginView.useremail?.Trim();
                var password = _loginView.password?.Trim();

                // Test credentials for immediate login
                if ((email == "admin@test.com" && password == "admin123") ||
                    (email == "EllaineMusni.550200@umindanao.edu.ph" && password == "MyAdmin123!"))
                {
                    IMainView mainView = new MainView();
                    new MainPresenter(mainView);
                    _loginView.ShowMessage("Log In Successfully!");
                    _loginView.HideForm();
                    mainView.ShowForm();
                    return;
                }

                // Try database authentication
                var user = await _authservice.Login(email, password);
                
                if (user == null)
                {
                    _loginView.ShowMessage("Invalid Credentials. Try:\n" +
                        "Email: admin@test.com\n" +
                        "Password: admin123\n\n" +
                        "Or:\n" +
                        "Email: EllaineMusni.550200@umindanao.edu.ph\n" +
                        "Password: MyAdmin123!");
                }
                else
                {
                    IMainView mainView = new MainView();
                    new MainPresenter(mainView);
                    _loginView.ShowMessage("Log In Successfully!");
                    _loginView.HideForm();
                    mainView.ShowForm();
                }
            }
            catch (Exception ex)
            {
                _loginView.ShowMessage($"Login error: {ex.Message}\n\nTry test credentials:\n" +
                    "Email: admin@test.com\n" +
                    "Password: admin123");
            }
        }
        public void LoginTest(object? sender, EventArgs e)
        {
            _loginView.ShowMessage("click");
        }
        
    }
}
