using Consultation.App.Repository;
using Consultation.App.Repository.Irepository;
using Consultation.App.Services.IServices;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Services
{
    public class AuthenticationServices : IAuthenticationServices
    {

        private readonly IUserRepository _userrepository;
        private readonly PasswordHasher<Users> _passwordHasher;
        private Users? _users;

        public AuthenticationServices(AppDbContext context) 
        {
            _userrepository = new UserRepository(context);
            _passwordHasher = new PasswordHasher<Users>();
        }

        public async Task<Users?> LoginAsync(string email, string password)
        {
           _users = await _userrepository.GetUser(email);

            if (_users == null) 
            {
                return null;
            }

            var result = _passwordHasher.VerifyHashedPassword(_users, _users.PasswordHash, password);
            return result == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success ? _users : null;
        }
    }
}
