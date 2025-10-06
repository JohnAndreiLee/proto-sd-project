using System;

namespace Consultation.BackEndCRUD.Service.IService
{
    public interface ILoggingService
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception? exception = null);
        void LogError(Exception exception, string message);
    }
}