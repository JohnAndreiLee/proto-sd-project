using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Repository.Irepository
{
    public interface IUserRepository
    {
        Task<Users?> GetUser(string email);
    }
}
