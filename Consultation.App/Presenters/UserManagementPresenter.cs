using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultation.App.Views;
using Consultation.App.Views.IViews;

namespace Consultation.App.Presenters
{
    public class UserManagementPresenter
    {
        private readonly IUserManagementView _userManagementView;

        public UserManagementPresenter(IUserManagementView userManagementView)
        {
            _userManagementView = userManagementView;
            _userManagementView.StudentManagementEvent += StudentManagementEvent;
            _userManagementView.FacultyManagementEvent += FacultyManagementEvent;
            _userManagementView.AdminManagementEvent += AdminManagementEvent;

            
        }

        private void StudentManagementEvent(object? sender, EventArgs e)
        {
            // Logic for handling student management event
            LoadTestCards("Joan de Arc", 10);
            _userManagementView.Message("runnin");


        }
        private void FacultyManagementEvent(object? sender, EventArgs e)
        {
            // Logic for handling faculty management event
            LoadTestCards("Stephen", 10);

        }
        private void AdminManagementEvent(object? sender, EventArgs e)
        {
            // Logic for handling admin management event
            LoadTestCards("Hesus", 10);
        }
        public void LoadTestCards(string name, int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                _userManagementView.AddUserCard(String.Concat(name, i));
            }
            _userManagementView.Message("runnin");
        }
    }
}
