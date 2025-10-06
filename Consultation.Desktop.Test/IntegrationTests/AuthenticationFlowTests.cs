using Consultation.BackEndCRUD.Service;
using Consultation.Desktop.Test.TestInfrastructure.Builders;
using Consultation.Desktop.Test.TestInfrastructure.Fixtures;
using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Consultation.Desktop.Test.IntegrationTests
{
    [TestFixture]
    public class AuthenticationFlowTests
    {
        private InMemoryDatabaseFixture _fixture;
        private AppDbContext _context;
        private AuthService _authService;
        private PasswordHasher<Users> _passwordHasher;

        [SetUp]
        public void Setup()
        {
            _fixture = new InMemoryDatabaseFixture();
            _context = _fixture.CreateContext();
            _authService = new AuthService(_context);
            _passwordHasher = new PasswordHasher<Users>();
        }

        [Test]
        public async Task CompleteLoginFlow_WithValidCredentials_ReturnsUser()
        {
            // Arrange - Create and seed a test user with hashed password
            var testUser = new UserBuilder()
                .WithEmail("integration.test@example.com")
                .WithUMID("INT001")
                .WithUserType(UserType.Faculty)
                .WithPassword("TestPassword123!")
                .BuildWithHashedPassword(_passwordHasher);
            
            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act - Attempt login with correct credentials
            var result = await _authService.Login("integration.test@example.com", "TestPassword123!");

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Email, Is.EqualTo(testUser.Email));
            Assert.That(result.UMID, Is.EqualTo(testUser.UMID));
            Assert.That(result.UserType, Is.EqualTo(UserType.Faculty));
        }

        [Test]
        public async Task CompleteLoginFlow_WithWrongPassword_ReturnsNull()
        {
            // Arrange
            var testUser = new UserBuilder()
                .WithEmail("test.wrong@example.com")
                .WithUMID("INT002")
                .WithUserType(UserType.Student)
                .WithPassword("CorrectPassword123!")
                .BuildWithHashedPassword(_passwordHasher);
            
            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act
            var result = await _authService.Login("test.wrong@example.com", "WrongPassword123!");

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task CompleteLoginFlow_WithNonExistentUser_ReturnsNull()
        {
            // Arrange - No user seeded

            // Act
            var result = await _authService.Login("nonexistent@example.com", "AnyPassword123!");

            // Assert
            Assert.IsNull(result);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
            _fixture.Dispose();
        }
    }
}
