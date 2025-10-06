using Consultation.BackEndCRUD.Repository.IRepository;
using Consultation.Domain;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consultation.Desktop.Test.TestInfrastructure.Helpers
{
    public static class MockRepositoryFactory
    {
        public static Mock<IUserRepository> CreateUserRepository(Users? userToReturn = null)
        {
            var mock = new Mock<IUserRepository>();
            
            mock.Setup(r => r.GetUserByEmail(It.IsAny<string>()))
                .ReturnsAsync(userToReturn);

            return mock;
        }

        public static Mock<IUserRepository> CreateUserRepositoryWithException()
        {
            var mock = new Mock<IUserRepository>();
            
            mock.Setup(r => r.GetUserByEmail(It.IsAny<string>()))
                .ThrowsAsync(new System.Exception("Database error"));

            return mock;
        }

        public static Mock<IEditConsultationrequestRepository> CreateConsultationRepository(
            IEnumerable<ConsultationRequest>? requests = null)
        {
            var mock = new Mock<IEditConsultationrequestRepository>();
            
            if (requests != null)
            {
                mock.Setup(r => r.GetConsultationRequestsAsync())
                    .ReturnsAsync(requests);
            }

            return mock;
        }
    }
}
