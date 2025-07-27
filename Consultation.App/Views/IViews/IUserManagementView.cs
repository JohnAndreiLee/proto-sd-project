using Consultation.App.Views.Controls.UserManagement;

namespace Consultation.App.Views.IViews
{
    public interface IUserManagementView : IChildView
    {
        event EventHandler StudentManagementEvent;
        event EventHandler FacultyManagementEvent;
        event EventHandler AdminManagementEvent;

        void AddUserCard(string name);
        void Message(string message);
    }
}
