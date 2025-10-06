using Consultation.BackEndCRUD.Service.ConsultationServices;
using Consultation.Desktop.Test.TestInfrastructure.Fixtures;
using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace Consultation.Desktop.Test.UnitTests.Services
{
    [TestFixture]
    public class EditConsultationServiceTests
    {
        private InMemoryDatabaseFixture _fixture;
        private AppDbContext _context;
        private EditConsultationService _service;

        [SetUp]
        public void Setup()
        {
            _fixture = new InMemoryDatabaseFixture();
            _context = _fixture.CreateContext();
            _service = new EditConsultationService(_context);
        }

        [Test]
        public async Task GetAllConsultations_WithNoData_ReturnsEmptyList()
        {
            // Act
            var result = await _service.getAllConsultations();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetAllConsultations_WithValidData_ReturnsConsultations()
        {
            // Arrange
            await SeedTestData();

            // Act
            var result = await _service.getAllConsultations();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.GreaterThan(0));
            
            var firstConsultation = result.First();
            Assert.That(firstConsultation.studentName, Is.EqualTo("Test Student"));
            Assert.That(firstConsultation.courseCode, Is.EqualTo("TEST101"));
        }

        [Test]
        public async Task GetEditConsultation_WithValidId_ReturnsConsultation()
        {
            // Arrange
            await SeedTestData();

            // Act
            var result = await _service.getEditConsultation(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.studentName, Is.EqualTo("Test Student"));
            Assert.That(result.courseCode, Is.EqualTo("TEST101"));
        }

        [Test]
        public async Task GetEditConsultation_WithInvalidId_ReturnsNull()
        {
            // Act
            var result = await _service.getEditConsultation(999);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task GetEditConsultation_WithZeroId_ReturnsNull()
        {
            // Act
            var result = await _service.getEditConsultation(0);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task GetEditConsultation_WithNegativeId_ReturnsNull()
        {
            // Act
            var result = await _service.getEditConsultation(-1);

            // Assert
            Assert.IsNull(result);
        }

        private async Task SeedTestData()
        {
            // Create test entities with proper relationships
            var user = new Users
            {
                Id = Guid.NewGuid().ToString(),
                Email = "test@example.com",
                UserName = "test@example.com",
                UMID = "TEST001",
                UserType = UserType.Student
            };

            var schoolYear = new SchoolYear
            {
                SchoolYearID = 1,
                Year1 = "2024",
                Year2 = "2025",
                Semester = Semester.Semester1,
                SchoolYearStatus = SchoolYearStatus.Current
            };

            var department = new Department
            {
                DepartmentID = 1,
                DepartmentName = "Test Department",
                Description = "Test Description"
            };

            var program = new Program
            {
                ProgramID = 1,
                ProgramName = "Test Program",
                Description = "Test Program Description",
                DepartmentID = 1,
                Department = department
            };

            var student = new Student
            {
                StudentID = 1,
                StudentUMID = "TEST001",
                StudentName = "Test Student",
                Email = "test@example.com",
                ProgramID = 1,
                Program = program,
                SchoolYearID = 1,
                SchoolYear = schoolYear,
                UsersID = user.Id,
                Users = user
            };

            var faculty = new Faculty
            {
                FacultyID = 1,
                FacultyUMID = "FAC001",
                FacultyName = "Test Faculty",
                SchoolYearID = 1,
                SchoolYear = schoolYear,
                UsersID = user.Id,
                Users = user
            };

            var consultationRequest = new ConsultationRequest
            {
                ConsultationID = 1,
                DateRequested = DateTime.Now,
                DateSchedule = DateTime.Now.AddDays(1),
                StartedTime = new TimeOnly(10, 0),
                EndedTime = new TimeOnly(11, 0),
                Concern = "Test concern",
                SubjectCode = "TEST101",
                Status = Status.Pending,
                StudentID = 1,
                Student = student,
                FacultyID = 1,
                Faculty = faculty
            };

            // Add to context
            _context.Users.Add(user);
            _context.SchoolYear.Add(schoolYear);
            _context.Department.Add(department);
            _context.Program.Add(program);
            _context.Students.Add(student);
            _context.Faculty.Add(faculty);
            _context.ConsultationRequest.Add(consultationRequest);

            await _context.SaveChangesAsync();
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
            _fixture.Dispose();
        }
    }
}