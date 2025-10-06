using Consultation.BackEndCRUD.Service.IService;
using System;
using System.Diagnostics;

namespace Consultation.BackEndCRUD.Service
{
    public class LoggingService : ILoggingService
    {
        public void LogInformation(string message)
        {
            Debug.WriteLine($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            Console.WriteLine($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }

        public void LogWarning(string message)
        {
            Debug.WriteLine($"[WARN] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            Console.WriteLine($"[WARN] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }

        public void LogError(string message, Exception? exception = null)
        {
            var errorMessage = $"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            if (exception != null)
            {
                errorMessage += $" | Exception: {exception.Message} | StackTrace: {exception.StackTrace}";
            }
            
            Debug.WriteLine(errorMessage);
            Console.WriteLine(errorMessage);
        }

        public void LogError(Exception exception, string message)
        {
            LogError(message, exception);
        }
    }
}