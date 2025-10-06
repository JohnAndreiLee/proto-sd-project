using Consultation.BackEndCRUD.Service;
using Consultation.Desktop.Test.TestInfrastructure.Builders;
using Consultation.Desktop.Test.TestInfrastructure.Fixtures;
using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Consultation.Desktop.Test
{
    [TestFixture]
    public class AuthServiceTests
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
        public async Task Login_WithExistingUser_ReturnsUser()
        {
            // Arrange - Create a test user with hashed password
            var testUser = new UserBuilder()
                .WithEmail("test.user@example.com")
                .WithUMID("TEST001")
                .WithUserType(UserType.Faculty)
                .WithPassword("MyPassword123!")
                .BuildWithHashedPassword(_passwordHasher);

            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act
            var user = await _authService.Login("test.user@example.com", "MyPassword123!");

            // Assert
            Assert.IsNotNull(user);
            Assert.That(user.Email, Is.EqualTo("test.user@example.com"));
        }

        [Test]
        public async Task Login_WithNonExistentUser_ReturnsNull()
        {
            // Act
            var user = await _authService.Login("nonexistent@example.com", "password123");

            // Assert
            Assert.IsNull(user);
        }

        [Test]
        public async Task Login_WithInvalidPassword_ReturnsNull()
        {
            // Arrange
            var testUser = new UserBuilder()
                .WithEmail("test.user@example.com")
                .WithPassword("CorrectPassword123!")
                .BuildWithHashedPassword(_passwordHasher);

            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act
            var user = await _authService.Login("test.user@example.com", "WrongPassword!");

            // Assert
            Assert.IsNull(user);
        }

        [Test]
        public async Task Login_WithEmptyEmail_ReturnsNull()
        {
            // Act
            var user = await _authService.Login("", "MyPassword123!");

            // Assert
            Assert.IsNull(user);
        }

        [Test]
        public async Task Login_WithEmptyPassword_ReturnsNull()
        {
            // Arrange
            var testUser = new UserBuilder()
                .WithEmail("test.user@example.com")
                .WithPassword("MyPassword123!")
                .BuildWithHashedPassword(_passwordHasher);

            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act
            var user = await _authService.Login("test.user@example.com", "");

            // Assert
            Assert.IsNull(user);
        }

        [Test]
        public async Task Login_WithNullEmail_ReturnsNull()
        {
            // Act
            var user = await _authService.Login(null!, "MyPassword123!");

            // Assert
            Assert.IsNull(user);
        }

        [Test]
        public async Task Login_WithNullPassword_ReturnsNull()
        {
            // Arrange
            var testUser = new UserBuilder()
                .WithEmail("test.user@example.com")
                .WithPassword("MyPassword123!")
                .BuildWithHashedPassword(_passwordHasher);

            _context.Users.Add(testUser);
            await _context.SaveChangesAsync();

            // Act
            var user = await _authService.Login("test.user@example.com", null!);

            // Assert
            Assert.IsNull(user);
        }


        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
            _fixture.Dispose();
        }


    }


}
