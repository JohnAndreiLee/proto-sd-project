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
            var user = await _authservice.Login(_loginView.useremail, _loginView.password);
            _loginView.ShowMessage("click");
            if (user == null)
            {
                _loginView.ShowMessage("Invalid Credentials");
            }
            else if (user != null)
            {
                IMainView mainView = new MainView();
                new MainPresenter(mainView);
                _loginView.ShowMessage("Log In Successfully!");
                _loginView.HideForm();
                  mainView.ShowForm();

            }
        }
        public void LoginTest(object? sender, EventArgs e)
        {
            _loginView.ShowMessage("click");
        }
        
    }
}
