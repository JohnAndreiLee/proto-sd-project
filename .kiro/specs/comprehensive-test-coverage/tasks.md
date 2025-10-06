# Implementation Plan

- [ ] 1. Set up test infrastructure foundation
  - Create test configuration management system with appsettings.test.json
  - Implement TestConfiguration class to load and provide test settings
  - Set up folder structure for test infrastructure components
  - _Requirements: 7.1, 7.2, 7.3, 7.4_

- [ ] 2. Implement test data builders
  - [ ] 2.1 Create base TestDataBuilder class with common functionality
    - Implement fluent builder pattern base class
    - Add methods for generating realistic test data (emails, names, IDs)
    - _Requirements: 4.1, 4.4_

  - [ ] 2.2 Implement UserBuilder for creating test Users entities
    - Create UserBuilder with fluent API for email, UMID, UserType
    - Add BuildWithHashedPassword method that properly hashes passwords
    - Include default values for quick test user creation
    - _Requirements: 4.1, 4.4, 4.5_

  - [ ] 2.3 Implement FacultyBuilder for creating test Faculty entities
    - Create FacultyBuilder with fluent API for faculty-specific properties
    - Link to Users entity through builder
    - Add methods for setting schedules and courses
    - _Requirements: 4.1, 4.2_

  - [ ] 2.4 Implement StudentBuilder for creating test Student entities
    - Create StudentBuilder with fluent API for student-specific properties
    - Link to Users entity and Program through builder
    - Add methods for setting enrolled courses
    - _Requirements: 4.1, 4.2_

  - [ ] 2.5 Implement ConsultationRequestBuilder for test consultation requests
    - Create ConsultationRequestBuilder with fluent API
    - Add methods for different request states (Pending, Approved, Rejected)
    - Link to Student and Faculty entities
    - _Requirements: 4.1, 4.2_

- [ ] 3. Create database fixtures for test isolation
  - [ ] 3.1 Implement InMemoryDatabaseFixture for fast unit tests
    - Create fixture that provides in-memory DbContext instances
    - Implement CreateContext method that returns fresh context
    - Add ResetDatabase method for test isolation
    - Implement IDisposable for proper cleanup
    - _Requirements: 2.4, 3.4, 4.3_

  - [ ] 3.2 Implement DatabaseFixture for integration tests
    - Create fixture that manages test database lifecycle
    - Implement CreateContext method with test connection string
    - Add SeedTestData method for common test data
    - Add CleanDatabase method to remove test data after tests
    - Implement IDisposable for proper cleanup
    - _Requirements: 3.1, 3.4, 7.5_

- [ ] 4. Create mock factory helpers
  - [ ] 4.1 Implement MockRepositoryFactory for consistent mock creation
    - Create static factory methods for IUserRepository mocks
    - Create static factory methods for IEditConsultationrequestRepository mocks
    - Add common mock setups (return null, return specific entity, throw exception)
    - _Requirements: 1.4, 10.1, 10.2_

  - [ ] 4.2 Create TestPasswordHasher helper for password testing
    - Implement helper that uses same PasswordHasher as production
    - Add methods to hash passwords for test data
    - Add methods to verify password hashing in tests
    - _Requirements: 4.5_

- [ ] 5. Expand AuthService unit tests
  - [ ] 5.1 Refactor existing AuthServiceTests to use new test infrastructure
    - Update Setup to use InMemoryDatabaseFixture or mocks
    - Replace hardcoded connection string with TestConfiguration
    - Update existing tests to use UserBuilder for test data
    - _Requirements: 1.1, 1.4, 5.1, 5.2, 9.3_

  - [ ] 5.2 Add comprehensive null and edge case tests for AuthService
    - Test Login with null email parameter
    - Test Login with null password parameter
    - Test Login with empty string email
    - Test Login with empty string password
    - Test Login with whitespace-only inputs
    - _Requirements: 1.3, 8.1_

  - [ ] 5.3 Add mock verification tests for AuthService
    - Verify GetUserByEmail is called with correct email parameter
    - Verify GetUserByEmail is called exactly once per login attempt
    - Verify PasswordHasher.VerifyHashedPassword is called with correct parameters
    - _Requirements: 1.4, 10.3_

  - [ ] 5.4 Add password verification tests for AuthService
    - Test Login with correct password returns user
    - Test Login with incorrect password returns null
    - Test Login with password that differs only in case returns null
    - Test Login with password containing special characters
    - _Requirements: 1.1, 1.3, 4.5_

- [ ] 6. Implement EditConsultationService unit tests
  - [ ] 6.1 Create EditConsultationServiceTests class with test setup
    - Set up test class with InMemoryDatabaseFixture
    - Create helper method to instantiate service with mocked repository
    - Add Setup and TearDown methods
    - _Requirements: 1.2, 1.4_

  - [ ] 6.2 Test getAllConsultations method
    - Test getAllConsultations returns empty list when no consultations exist
    - Test getAllConsultations returns all consultations with correct mapping
    - Test getAllConsultations maps Student and Faculty data correctly
    - Test getAllConsultations handles null navigation properties gracefully
    - _Requirements: 1.2, 1.5, 8.1_

  - [ ] 6.3 Test getEditConsultation method
    - Test getEditConsultation with valid ID returns correct consultation
    - Test getEditConsultation with non-existent ID handles error appropriately
    - Test getEditConsultation maps all properties correctly to ViewModel
    - Test getEditConsultation with null Student or Faculty reference
    - _Requirements: 1.2, 1.3, 1.5_

  - [ ] 6.4 Add mock verification for EditConsultationService
    - Verify GetConsultationRequestsAsync is called when getting all consultations
    - Verify GetConsultationRequests is called with correct ID parameter
    - Verify repository methods are called exactly once per service call
    - _Requirements: 1.4, 10.3_

- [ ] 7. Implement UserRepository unit tests
  - [ ] 7.1 Create UserRepositoryTests class with in-memory database
    - Set up test class with InMemoryDatabaseFixture
    - Create helper method to seed test users in database
    - Add Setup and TearDown methods for database cleanup
    - _Requirements: 2.1, 2.4, 4.3_

  - [ ] 7.2 Test GetUserByEmail method with various scenarios
    - Test GetUserByEmail with existing user returns correct user
    - Test GetUserByEmail with non-existent email returns null
    - Test GetUserByEmail with null email handles gracefully
    - Test GetUserByEmail with empty string returns null
    - Test GetUserByEmail is case-insensitive (if applicable)
    - _Requirements: 2.1, 2.2, 2.3, 8.1_

  - [ ] 7.3 Test UserRepository with multiple users
    - Seed multiple users with different emails
    - Verify GetUserByEmail returns correct user among many
    - Test that query doesn't return wrong user
    - _Requirements: 2.2, 2.5_

- [ ] 8. Implement ConsultationRequestRepository unit tests
  - [ ] 8.1 Create ConsultationRequestRepositoryTests class
    - Set up test class with InMemoryDatabaseFixture
    - Create helper methods to seed consultation requests with related entities
    - Add Setup and TearDown methods
    - _Requirements: 2.1, 2.4_

  - [ ] 8.2 Test GetConsultationRequestsAsync method
    - Test returns empty list when no requests exist
    - Test returns all consultation requests with navigation properties loaded
    - Test includes Student and Faculty data correctly
    - Test ordering of results if applicable
    - _Requirements: 2.1, 2.2, 2.5_

  - [ ] 8.3 Test GetConsultationRequests method (single request)
    - Test with valid ID returns correct consultation request
    - Test with non-existent ID returns null or throws appropriate exception
    - Test navigation properties are loaded correctly
    - _Requirements: 2.1, 2.2, 2.3_

  - [ ] 8.4 Test repository with complex filtering scenarios
    - Test filtering by student ID if method exists
    - Test filtering by faculty ID if method exists
    - Test filtering by status if method exists
    - Test filtering by date range if method exists
    - _Requirements: 2.2, 2.5_

- [ ] 9. Implement domain model validation tests
  - [ ] 9.1 Create UserValidationTests for Users entity
    - Test Users entity can be created with valid data
    - Test UMID is required (if validation exists)
    - Test Email format validation (if validation exists)
    - Test UserType is set correctly
    - _Requirements: 6.1, 6.2, 6.3_

  - [ ] 9.2 Create ConsultationRequestValidationTests
    - Test ConsultationRequest can be created with valid data
    - Test required fields validation (Concern, SubjectCode, etc.)
    - Test DateSchedule cannot be in the past (if validation exists)
    - Test StartedTime must be before EndedTime (if validation exists)
    - Test Status enum values are valid
    - _Requirements: 6.1, 6.2, 6.3, 6.5_

  - [ ] 9.3 Test entity relationships and foreign keys
    - Test Student to ConsultationRequest relationship
    - Test Faculty to ConsultationRequest relationship
    - Test Users to Faculty relationship
    - Test Users to Student relationship
    - Test navigation properties are set correctly
    - _Requirements: 6.4_

- [ ] 10. Create integration tests for authentication flow
  - [ ] 10.1 Create AuthenticationFlowTests class with DatabaseFixture
    - Set up integration test class with real database fixture
    - Create helper method to seed complete user with hashed password
    - Add Setup and TearDown for database cleanup
    - _Requirements: 3.1, 3.2, 3.4_

  - [ ] 10.2 Test complete login flow end-to-end
    - Seed user with hashed password in database
    - Create AuthService with real repository and context
    - Call Login with correct credentials
    - Verify user is returned with all properties
    - _Requirements: 3.2, 3.3_

  - [ ] 10.3 Test failed login scenarios end-to-end
    - Test login with non-existent user returns null
    - Test login with wrong password returns null
    - Verify database state is unchanged after failed login
    - _Requirements: 3.2, 3.3, 3.5_

- [ ] 11. Create integration tests for consultation workflow
  - [ ] 11.1 Create ConsultationWorkflowTests class
    - Set up integration test class with DatabaseFixture
    - Create helper methods to seed Student, Faculty, and related entities
    - Add Setup and TearDown for database cleanup
    - _Requirements: 3.1, 3.3, 3.4_

  - [ ] 11.2 Test consultation request creation workflow
    - Seed Student and Faculty in database
    - Create consultation request through service
    - Verify request is saved with Pending status
    - Verify all relationships are correctly established
    - _Requirements: 3.3, 3.5_

  - [ ] 11.3 Test consultation request retrieval workflow
    - Seed multiple consultation requests
    - Retrieve all consultations through service
    - Verify correct data mapping to ViewModels
    - Verify navigation properties are loaded
    - _Requirements: 3.3, 3.5_

  - [ ] 11.4 Test consultation request filtering and querying
    - Seed consultations with different statuses
    - Test retrieving consultations by status
    - Test retrieving consultations by student
    - Test retrieving consultations by faculty
    - _Requirements: 3.3, 3.5_

- [ ] 12. Implement error handling and exception tests
  - [ ] 12.1 Add exception tests for AuthService
    - Test Login throws appropriate exception when repository throws
    - Test Login handles DbUpdateException gracefully
    - Test Login handles null reference exceptions
    - Verify error messages are meaningful
    - _Requirements: 8.1, 8.2, 8.3, 8.4_

  - [ ] 12.2 Add exception tests for EditConsultationService
    - Test getAllConsultations handles repository exceptions
    - Test getEditConsultation handles non-existent ID appropriately
    - Test service methods handle null navigation properties
    - Verify error propagation to caller
    - _Requirements: 8.1, 8.2, 8.3, 8.4_

  - [ ] 12.3 Add exception tests for repositories
    - Test repository methods handle database connection failures
    - Test repository methods handle constraint violations
    - Test repository methods handle concurrent access scenarios
    - _Requirements: 2.3, 8.2_

- [ ] 13. Add async testing patterns and verification
  - [ ] 13.1 Audit all async tests for proper async/await usage
    - Verify all async service methods are tested with async tests
    - Verify all tests properly await async operations
    - Ensure no .Result or .Wait() calls in tests
    - _Requirements: 5.1, 5.2_

  - [ ] 13.2 Add tests for async error handling
    - Test async methods that throw exceptions use Assert.ThrowsAsync
    - Test async methods handle cancellation tokens (if applicable)
    - Test async methods complete successfully
    - _Requirements: 5.2, 5.4_

  - [ ] 13.3 Add async mock verification tests
    - Verify async repository methods are called correctly
    - Test async method call ordering when multiple async calls exist
    - Verify async methods complete before assertions
    - _Requirements: 5.1, 5.3_

- [ ] 14. Improve test code quality and maintainability
  - [ ] 14.1 Refactor tests to follow Arrange-Act-Assert pattern
    - Review all existing tests for AAA pattern compliance
    - Add comments to clearly separate Arrange, Act, Assert sections
    - Extract complex setup into helper methods
    - _Requirements: 9.2, 9.3_

  - [ ] 14.2 Improve test naming and documentation
    - Ensure all tests follow MethodName_Scenario_ExpectedBehavior convention
    - Add XML documentation to complex test helper methods
    - Add comments explaining non-obvious test scenarios
    - _Requirements: 9.1, 9.4_

  - [ ] 14.3 Eliminate test code duplication
    - Extract common test setup into shared helper methods
    - Create reusable assertion helpers for common verifications
    - Consolidate similar tests using TestCase attributes where appropriate
    - _Requirements: 9.3_

  - [ ] 14.4 Add meaningful assertion messages
    - Update assertions to include descriptive failure messages
    - Ensure failure messages clearly indicate what went wrong
    - Add context to assertion messages for easier debugging
    - _Requirements: 9.4_

- [ ] 15. Set up code coverage measurement and reporting
  - [ ] 15.1 Configure code coverage collection
    - Add coverlet.collector package to test project
    - Configure coverage settings in test project file
    - Set up coverage output format (opencover or cobertura)
    - _Requirements: 7.1, 7.2_

  - [ ] 15.2 Create coverage report generation script
    - Write script to run tests with coverage collection
    - Generate HTML coverage report using ReportGenerator
    - Set up coverage thresholds for build failure
    - _Requirements: 7.3_

  - [ ] 15.3 Document coverage goals and review process
    - Document target coverage percentages for each layer
    - Create process for reviewing coverage reports
    - Add coverage badge or report to project documentation
    - _Requirements: 9.1_
