using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Views.IViews
{
    public interface ILogin
    {
        string email { get; }
        string password { get; }

        event EventHandler LogInEvent;

        void AuthenticationMessage(string message);
        

    }
}
