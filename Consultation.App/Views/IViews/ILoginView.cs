using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Views.IViews
{
    public interface ILoginView
    {
        string useremail { get; set; }
        string password { get; set; }

        event EventHandler LogInEvent;
    }
}
