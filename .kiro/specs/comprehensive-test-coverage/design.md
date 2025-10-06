# Design Document: Comprehensive Test Coverage

## Overview

This design establishes a comprehensive testing strategy for the Consultation Management System. The solution implements a multi-layered testing approach with unit tests, integration tests, and proper test infrastructure. The design focuses on test isolation, maintainability, and coverage of critical business logic while following industry best practices for .NET testing.

The testing architecture will use NUnit as the test framework (already in use), Moq for mocking dependencies, and Entity Framework Core's in-memory database for integration testing. This approach ensures fast, reliable, and maintainable tests.

## Architecture

### Testing Layers

```
┌─────────────────────────────────────────────────────────┐
│                    Test Projects                         │
├─────────────────────────────────────────────────────────┤
│  Consultation.Desktop.Test (Unit & Integration Tests)   │
│  - Unit Tests (Service Layer)                           │
│  - Unit Tests (Repository Layer)                        │
│  - Integration Tests (End-to-End Scenarios)             │
│  - Test Fixtures & Helpers                              │
└─────────────────────────────────────────────────────────┘
                           │
                           ▼
┌─────────────────────────────────────────────────────────┐
│              Test Infrastructure Layer                   │
├─────────────────────────────────────────────────────────┤
│  - TestDataBuilder (Factory for test entities)          │
│  - DatabaseFixture (Test DB setup/teardown)             │
│  - MockRepositoryFactory (Consistent mock creation)     │
│  - TestConfiguration (Connection strings, settings)     │
└─────────────────────────────────────────────────────────┘
                           │
                           ▼
┌─────────────────────────────────────────────────────────┐
│              Application Under Test                      │
├─────────────────────────────────────────────────────────┤
│  Services → Repositories → DbContext → Database         │
└─────────────────────────────────────────────────────────┘
```

### Test Organization Structure

```
Consultation.Desktop.Test/
├── UnitTests/
│   ├── Services/
│   │   ├── AuthServiceTests.cs
│   │   ├── EditConsultationServiceTests.cs
│   │   └── [Other Service Tests]
│   ├── Repositories/
│   │   ├── UserRepositoryTests.cs
│   │   ├── ConsultationRequestRepositoryTests.cs
│   │   └── [Other Repository Tests]
│   └── Domain/
│       ├── UserValidationTests.cs
│       ├── ConsultationRequestValidationTests.cs
│       └── [Other Domain Tests]
├── IntegrationTests/
│   ├── AuthenticationFlowTests.cs
│   ├── ConsultationWorkflowTests.cs
│   └── [Other Integration Tests]
├── TestInfrastructure/
│   ├── Fixtures/
│   │   ├── DatabaseFixture.cs
│   │   └── InMemoryDatabaseFixture.cs
│   ├── Builders/
│   │   ├── TestDataBuilder.cs
│   │   ├── UserBuilder.cs
│   │   ├── FacultyBuilder.cs
│   │   ├── StudentBuilder.cs
│   │   └── ConsultationRequestBuilder.cs
│   ├── Helpers/
│   │   ├── MockRepositoryFactory.cs
│   │   └── TestPasswordHasher.cs
│   └── Configuration/
│       └── TestConfiguration.cs
└── appsettings.test.json
```

## Components and Interfaces

### 1. Test Data Builders

**Purpose**: Provide fluent API for creating test entities with sensible defaults

```csharp
public class UserBuilder
{
    private string _email = "test@example.com";
    private string _umid = "TEST123";
    private UserType _userType = UserType.Faculty;
    private string _password = "TestPassword123!";
    
    public UserBuilder WithEmail(string email);
    public UserBuilder WithUMID(string umid);
    public UserBuilder WithUserType(UserType userType);
    public UserBuilder WithPassword(string password);
    public Users Build();
    public Users BuildWithHashedPassword(PasswordHasher<Users> hasher);
}

public class ConsultationRequestBuilder
{
    // Similar fluent builder pattern for ConsultationRequest
}
```

**Design Rationale**: Builders provide flexibility in test data creation while maintaining consistency. They reduce test setup code and make tests more readable.

### 2. Database Fixtures

**Purpose**: Manage test database lifecycle and provide isolated database contexts

```csharp
public class InMemoryDatabaseFixture : IDisposable
{
    public AppDbContext CreateContext();
    public void ResetDatabase();
    public void Dispose();
}

public class DatabaseFixture : IDisposable
{
    private readonly string _connectionString;
    public AppDbContext CreateContext();
    public void SeedTestData();
    public void CleanDatabase();
    public void Dispose();
}
```

**Design Rationale**: 
- InMemoryDatabaseFixture: Fast, isolated tests for unit testing repositories
- DatabaseFixture: Real database for integration tests that need full EF Core features

### 3. Mock Repository Factory

**Purpose**: Centralize mock creation with common setups

```csharp
public class MockRepositoryFactory
{
    public static Mock<IUserRepository> CreateUserRepository(
        Users? userToReturn = null);
    
    public static Mock<IEditConsultationrequestRepository> 
        CreateConsultationRepository(
            IEnumerable<ConsultationRequest>? requests = null);
}
```

**Design Rationale**: Reduces duplication in mock setup across test classes and ensures consistent mocking patterns.

### 4. Test Configuration

**Purpose**: Manage test-specific configuration settings

```csharp
public class TestConfiguration
{
    public static string GetTestConnectionString();
    public static bool UseInMemoryDatabase();
    public static DbContextOptions<AppDbContext> GetInMemoryOptions();
    public static DbContextOptions<AppDbContext> GetTestDbOptions();
}
```

## Data Models

### Test Data Model Strategy

**Minimal Test Data**: Each test should create only the data it needs
**Isolated Data**: Tests should not share data to prevent interdependencies
**Realistic Data**: Test data should represent realistic scenarios

### Test User Profiles

```csharp
// Standard test users for consistent testing
public static class TestUsers
{
    public static Users FacultyUser => new UserBuilder()
        .WithEmail("faculty@test.com")
        .WithUserType(UserType.Faculty)
        .Build();
    
    public static Users StudentUser => new UserBuilder()
        .WithEmail("student@test.com")
        .WithUserType(UserType.Student)
        .Build();
}
```

### Test Consultation Scenarios

```csharp
public static class TestConsultationScenarios
{
    public static ConsultationRequest PendingRequest();
    public static ConsultationRequest ApprovedRequest();
    public static ConsultationRequest RejectedRequest();
}
```

## Error Handling

### Test Error Scenarios

1. **Null Reference Handling**
   - Test services with null parameters
   - Test repository methods with non-existent IDs
   - Verify appropriate null checks and returns

2. **Database Errors**
   - Mock repository to throw DbUpdateException
   - Verify service layer handles and propagates errors
   - Test transaction rollback scenarios

3. **Validation Errors**
   - Test invalid email formats
   - Test password validation failures
   - Test business rule violations

### Exception Testing Pattern

```csharp
[Test]
public void Method_WithInvalidInput_ThrowsException()
{
    // Arrange
    var service = CreateService();
    
    // Act & Assert
    Assert.ThrowsAsync<ArgumentNullException>(
        async () => await service.Method(null));
}
```

## Testing Strategy

### Unit Testing Approach

**Service Layer Tests**:
- Mock all repository dependencies
- Test business logic in isolation
- Verify correct repository method calls
- Test all conditional branches
- Test error handling

**Repository Layer Tests**:
- Use in-memory database for fast tests
- Test CRUD operations
- Test query filtering and sorting
- Test null handling

**Domain Model Tests**:
- Test validation logic
- Test property setters and getters
- Test relationship navigation

### Integration Testing Approach

**Authentication Flow**:
1. Create user in test database
2. Attempt login with correct credentials
3. Verify user returned
4. Attempt login with incorrect credentials
5. Verify null returned

**Consultation Workflow**:
1. Create student and faculty in test database
2. Student creates consultation request
3. Verify request saved with Pending status
4. Faculty approves request
5. Verify status updated to Approved
6. Test rejection flow similarly

### Test Isolation Strategy

**Per-Test Database Reset**:
- Each test gets fresh database context
- In-memory database recreated per test
- Integration tests clean up after execution

**No Shared State**:
- Tests don't depend on execution order
- Each test creates its own test data
- Mocks reset between tests

## Test Coverage Goals

### Coverage Targets

- **Service Layer**: 90%+ code coverage
- **Repository Layer**: 85%+ code coverage
- **Domain Models**: 80%+ coverage for validation logic
- **Critical Paths**: 100% coverage (authentication, consultation approval)

### Coverage Measurement

Use built-in Visual Studio code coverage or coverlet for .NET Core:

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Testing Best Practices

### Test Naming Convention

```
MethodName_Scenario_ExpectedBehavior
```

Examples:
- `Login_WithValidCredentials_ReturnsUser`
- `Login_WithInvalidPassword_ReturnsNull`
- `GetConsultationRequest_WithNonExistentId_ReturnsNull`

### Arrange-Act-Assert Pattern

```csharp
[Test]
public async Task Login_WithValidCredentials_ReturnsUser()
{
    // Arrange
    var expectedUser = new UserBuilder().Build();
    var mockRepo = MockRepositoryFactory.CreateUserRepository(expectedUser);
    var service = new AuthService(mockRepo.Object);
    
    // Act
    var result = await service.Login("test@example.com", "password");
    
    // Assert
    Assert.IsNotNull(result);
    Assert.AreEqual(expectedUser.Email, result.Email);
}
```

### Async Testing Pattern

```csharp
[Test]
public async Task AsyncMethod_Scenario_ExpectedBehavior()
{
    // Always use async/await
    var result = await service.AsyncMethod();
    Assert.IsNotNull(result);
}
```

### Mock Verification

```csharp
[Test]
public async Task Service_CallsRepository_WithCorrectParameters()
{
    // Arrange
    var mockRepo = new Mock<IUserRepository>();
    var service = new AuthService(mockRepo.Object);
    
    // Act
    await service.Login("test@example.com", "password");
    
    // Assert
    mockRepo.Verify(r => r.GetUserByEmail("test@example.com"), 
        Times.Once);
}
```

## Implementation Phases

### Phase 1: Test Infrastructure Setup
- Create test data builders
- Implement database fixtures
- Set up test configuration
- Create mock factory helpers

### Phase 2: Service Layer Unit Tests
- Complete AuthService tests
- Implement EditConsultationService tests
- Add tests for other service classes
- Achieve 90%+ service coverage

### Phase 3: Repository Layer Tests
- Implement UserRepository tests
- Implement ConsultationRequestRepository tests
- Test all repository methods
- Use in-memory database

### Phase 4: Integration Tests
- Authentication flow tests
- Consultation workflow tests
- End-to-end scenario tests
- Database integration verification

### Phase 5: Domain and Validation Tests
- User entity validation tests
- ConsultationRequest validation tests
- Business rule tests
- Relationship tests

## Technology Stack

- **Test Framework**: NUnit 3.x
- **Mocking Framework**: Moq 4.x
- **In-Memory Database**: Entity Framework Core InMemory Provider
- **Assertion Library**: NUnit Assert (built-in)
- **Code Coverage**: Coverlet or Visual Studio Code Coverage
- **Test Runner**: Visual Studio Test Explorer or dotnet test CLI

## Configuration Management

### appsettings.test.json

```json
{
  "ConnectionStrings": {
    "TestDatabase": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConsultationTestDatabase;Integrated Security=True",
    "UseInMemoryDatabase": true
  },
  "TestSettings": {
    "ResetDatabasePerTest": true,
    "SeedTestData": false
  }
}
```

### Test Configuration Loading

```csharp
public class TestConfiguration
{
    private static IConfiguration _configuration;
    
    static TestConfiguration()
    {
        _configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.test.json")
            .Build();
    }
    
    public static string GetTestConnectionString() =>
        _configuration.GetConnectionString("TestDatabase");
}
```

## Maintenance and Evolution

### Adding New Tests

1. Identify the component to test (service, repository, domain)
2. Create test class in appropriate folder
3. Use existing builders and fixtures
4. Follow naming conventions
5. Ensure test isolation

### Updating Existing Tests

1. When business logic changes, update corresponding tests
2. Maintain test coverage percentage
3. Refactor tests if they become complex
4. Keep test data builders up to date

### Continuous Improvement

- Review test failures and flaky tests regularly
- Refactor duplicate test code
- Update test infrastructure as needed
- Monitor code coverage trends
- Add tests for bug fixes
