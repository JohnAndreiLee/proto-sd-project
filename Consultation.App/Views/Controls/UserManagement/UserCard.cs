using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Consultation.App.Views.Controls.UserManagement
{
    public partial class UserCard : UserControl
    {
        private string userName;
        private string userID;
        private string userEmail;

        public UserCard(string name, string id, string email)
        {
            InitializeComponent();
            userName = name;
            userID = id;
            userEmail = email;

            labelName.Text = name;
            labelUserID.Text = id;
            labelUserEmail.Text = email;
        }



    }
}
