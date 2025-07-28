using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Services.IServices
{
    public interface IAuthenticationServices
    {
        Task<Users?> LoginAsync(string email, string password);
    }
}
