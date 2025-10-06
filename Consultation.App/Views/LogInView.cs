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
            buttonLogIn.Click += ButtonLogIn_Click;
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // Clear previous error messages
            resultlabel1.Text = "";
            ErrorPassLabel.Text = "";

            // Basic validation
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                resultlabel1.Text = "Please enter your email";
                resultlabel1.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                ErrorPassLabel.Text = "Please enter your password";
                ErrorPassLabel.ForeColor = Color.Red;
                return;
            }

            if (!EmailIsValid(EmailTextBox.Text))
            {
                resultlabel1.Text = "Please enter a valid email address";
                resultlabel1.ForeColor = Color.Red;
                return;
            }

            // Trigger the login event
            LogInEvent?.Invoke(this, EventArgs.Empty);
        }


        private void ShowPassButton_Click(object sender, EventArgs e)
        {
            PasswordVisible = !PasswordVisible;
            if (PasswordVisible)
            {
                PasswordTextBox.PasswordChar = '\0'; // Show password
            }
            else
            {
                PasswordTextBox.PasswordChar = '●'; // Hide password
            }
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
