using Consultation.App.ViewModels.DashboardModels;
using Consultation.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters
{
    public class DashboardPresenter
    {

        
          private readonly IDashboardView _view;
          //private readonly AppDbContext _dbContext;
        
          public DashboardPresenter(IDashboardView view)
          {
              _view = view;
             // _dbContext = new AppDbContext(); // Or inject it via DI
          }
        /*
          public void LoadDashboardData()
          {
              var user = _dbContext.Users.FirstOrDefault(u => u.Username == _view.LoggedInUsername);
      _view.DisplayUserName(user?.FirstName ?? "User");

      var bulletins = _dbContext.Bulletins
          .OrderByDescending(b => b.DatePosted)
          .Take(10)
          .Select(b => new BulletinModel
          {
              Title = b.Title,
              Status = b.Status,
              Body = b.Body,
              DatePosted = b.DatePosted
          })
          .ToList();

      _view.LoadRecentBulletins(bulletins);

      var consultations = _dbContext.Consultations
          .OrderByDescending(c => c.DateScheduled)
          .Take(10)
          .Select(c => new ConsultationModel
          {
              Title = c.Title,
              Status = c.Status,
              Body = c.Body,
              DateScheduled = c.DateScheduled,
              Course = c.Course
          })
          .ToList();

      _view.LoadRecentConsultations(consultations);

      // Count statistics

      int publishedCount = _dbContext.Bulletins.Count(b => b.Status == "Approved");
      int pendingCount = _dbContext.Bulletins.Count(b => b.Status == "Pending");
      int completedConsultations = _dbContext.Consultations.Count(c => c.Status == "Completed");
      int upcomingSessions = _dbContext.Consultations.Count(c => c.DateScheduled > DateTime.Now);

      _view.UpdateDashboardStats(publishedCount, pendingCount, completedConsultations, upcomingSessions);


      // ConsultationByDepartmentStats

      // Count consultations per department
      int countCPE = _dbContext.Consultations.Count(c => c.Course == "CPE");
      int countEE = _dbContext.Consultations.Count(c => c.Course == "EE");
      int countECE = _dbContext.Consultations.Count(c => c.Course == "ECE");
      int countCE = _dbContext.Consultations.Count(c => c.Course == "CE");
      int countME = _dbContext.Consultations.Count(c => c.Course == "ME");
      int countCHE = _dbContext.Consultations.Count(c => c.Course == "CHE");

      _view.UpdateConsultationStats(countCPE, countEE, countECE, countCE, countME, countCHE);
    }
    */
   }
}
