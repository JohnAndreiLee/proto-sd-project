using Consultation.Domain;
using Consultation.Domain.Enum;
using Microsoft.AspNetCore.Identity;
using System;

namespace Consultation.Desktop.Test.TestInfrastructure.Builders
{
    public class UserBuilder
    {
        private string _id = Guid.NewGuid().ToString();
        private string _email = "test@example.com";
        private string _userName = "test@example.com";
        private string _umid = "TEST123";
        private UserType _userType = UserType.Faculty;
        private string _password = "TestPassword123!";

        public UserBuilder WithId(string id)
        {
            _id = id;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            _email = email;
            _userName = email; // Keep username in sync with email
            return this;
        }

        public UserBuilder WithUMID(string umid)
        {
            _umid = umid;
            return this;
        }

        public UserBuilder WithUserType(UserType userType)
        {
            _userType = userType;
            return this;
        }

        public UserBuilder WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public UserBuilder AsFaculty()
        {
            _userType = UserType.Faculty;
            return this;
        }

        public UserBuilder AsStudent()
        {
            _userType = UserType.Student;
            return this;
        }

        public Users Build()
        {
            return new Users
            {
                Id = _id,
                Email = _email,
                UserName = _userName,
                UMID = _umid,
                UserType = _userType
            };
        }

        public Users BuildWithHashedPassword()
        {
            var user = Build();
            var passwordHasher = new PasswordHasher<Users>();
            user.PasswordHash = passwordHasher.HashPassword(user, _password);
            return user;
        }

        public Users BuildWithHashedPassword(PasswordHasher<Users> passwordHasher)
        {
            var user = Build();
            user.PasswordHash = passwordHasher.HashPassword(user, _password);
            return user;
        }
    }
}
