using Consultation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Consultation.Desktop.Test.TestInfrastructure.Fixtures
{
    public class InMemoryDatabaseFixture : IDisposable
    {
        private readonly string _databaseName;

        public InMemoryDatabaseFixture()
        {
            _databaseName = $"TestDb_{Guid.NewGuid()}";
        }

        public AppDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: _databaseName)
                .Options;

            return new AppDbContext(options);
        }

        public void ResetDatabase()
        {
            using var context = CreateContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            using var context = CreateContext();
            context.Database.EnsureDeleted();
        }
    }
}
