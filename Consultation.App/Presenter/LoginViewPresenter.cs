using Consultation.App.Services.IServices;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.Domain;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenter
{
    public class LoginViewPresenter
    {
        private readonly IAuthenticationServices _authentication;
        private readonly ILogin _login;

        public LoginViewPresenter(IAuthenticationServices authentication, ILogin login)
        {
            _authentication = authentication;
            _login = login;

            _login.LogInEvent += LogIn;
        }

        public async void LogIn(object? sender, EventArgs e)
        {
            var user = await _authentication.LoginAsync(_login.email.ToLower(), _login.password);

            if (user == null)
            {
                _login.AuthenticationMessage("Invalid password or email!");

                return;
            }

            if (user.UserType.ToString() != "Admin")
            {
                _login.AuthenticationMessage("Account is not authorized as an Admin");

                return;
            }

            MainView mainView = new MainView();
            ((Form)_login).Hide();
            mainView.Show();
        }
    }
}
