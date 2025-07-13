using Consultation.App.Views.IViews;
using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class LogInView : Form, ILoginView
    {
        public LogInView()
        {
            InitializeComponent();

            EmailTextBox.TextChanged += SignInTextBox_TextChanged;
            PasswordTextBox.TextChanged += PasswordTextBoxV2_TextChanged;
            buttonLogIn.Click += (s, e) => LogInEvent?.Invoke(s, e);
        }


        private void ShowPassButton_Click(object sender, EventArgs e)
        {
            PasswordVisible = !PasswordVisible;
            PasswordTextBox.UseSystemPasswordChar = !PasswordVisible;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void HideForm()
        {
            this.Hide();
        }
        //public string useremail => EmailTextBox.Text;

        //public string password => PasswordTextBox.Text;

        public string useremail => EmailTextBox.Text;

        public string password => PasswordTextBox.Text;

        public event EventHandler LogInEvent;


        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void SignInTextBox_TextChanged(object sender, EventArgs e)
        {
            resultlabel1.Text = "";
        }

        private void PasswordTextBoxV2_TextChanged(object sender, EventArgs e)
        {
            ErrorPassLabel.Text = "";
        }

        private bool PasswordVisible = false;
        private const string LePassword = "admin";

        private bool EmailIsValid(string email)

        {
            return Regex.IsMatch(email,
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.IgnoreCase);
        }

        //private void SignInButton_Click(object sender, EventArgs e)
        //{
        //    LogInEvent?.Invoke(this, EventArgs.Empty);

        //}

    }
}
