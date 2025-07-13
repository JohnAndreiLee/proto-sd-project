using Consultation.App.Views.Controls.UserManagement;
using Consultation.App.Views.IViews;
using Student_Faculty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class UserManagementView : UserControl, IUserManagementView
    {
        public UserManagementView()
        {
            InitializeComponent();

            buttonStudents.Click += (s, e) => StudentManagementEvent?.Invoke(s, e);
            buttonFaculty.Click += (s, e) => FacultyManagementEvent?.Invoke(s, e);
            buttonAdmin.Click += (s, e) => AdminManagementEvent?.Invoke(s, e);

            //AddUserCard("JLE");
            //Message("we weorks");

        }

        public event EventHandler StudentManagementEvent;
        public event EventHandler FacultyManagementEvent;
        public event EventHandler AdminManagementEvent;

        public UserControl AsUserControl => this;

        //for adding user cards; change if needed
        public void AddUserCard(string name)
        {
            flPanelUserCard.Controls.Add(new UserCard(name, "547546", "genericEmail@hotmail.net"));
        }
        public void Message(string message) { 
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
