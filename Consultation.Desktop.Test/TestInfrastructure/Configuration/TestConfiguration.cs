using Microsoft.EntityFrameworkCore;
using Consultation.Infrastructure.Data;
using System;

namespace Consultation.Desktop.Test.TestInfrastructure.Configuration
{
    public static class TestConfiguration
    {
        // Default test connection string
        private const string DefaultTestConnectionString = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConsultationTestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static string GetTestConnectionString()
        {
            return DefaultTestConnectionString;
        }

        public static bool UseInMemoryDatabase()
        {
            // Default to using in-memory database for faster tests
            return true;
        }

        public static DbContextOptions<AppDbContext> GetInMemoryOptions(string? databaseName = null)
        {
            var dbName = databaseName ?? $"TestDb_{Guid.NewGuid()}";
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;
        }

        public static DbContextOptions<AppDbContext> GetTestDbOptions()
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(GetTestConnectionString())
                .Options;
        }

        public static bool ResetDatabasePerTest()
        {
            return true;
        }

        public static bool SeedTestData()
        {
            return false;
        }
    }
}
