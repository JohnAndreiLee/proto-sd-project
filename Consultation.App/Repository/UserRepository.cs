using Consultation.App.Repository.Irepository;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Consultation.App.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbcontext;

        public UserRepository(AppDbContext context) => _dbcontext = context;

        public async Task<Users?> GetUser(string email)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(a => a.Email == email);
        }
    }
}
