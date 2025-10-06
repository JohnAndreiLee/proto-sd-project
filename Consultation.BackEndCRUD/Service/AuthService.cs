using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultation.BackEndCRUD.Repository;
using Consultation.BackEndCRUD.Repository.IRepository;
using Consultation.BackEndCRUD.Service.IService;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;


namespace Consultation.BackEndCRUD.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<Users> _passwordHasher;
        private readonly ILoggingService _logger;
       
        public AuthService(AppDbContext context)
        {
            _passwordHasher = new PasswordHasher<Users>();
            _userRepository = new UserRepository(context);
            _logger = new LoggingService();
        }

        public AuthService(AppDbContext context, ILoggingService logger)
        {
            _passwordHasher = new PasswordHasher<Users>();
            _userRepository = new UserRepository(context);
            _logger = logger;
        }

        public async Task<Users?> Login(string email, string password)
        {
            try
            {
                // Validate input parameters
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    return null;

                var user = await _userRepository.GetUserByEmail(email);
                if (user == null)
                    return null;

                // Check if password hash exists
                if (string.IsNullOrEmpty(user.PasswordHash))
                    return null;

                var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

                return result == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success ? user : null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Login failed for email: {email}");
                return null;
            }
        }
    }
}
