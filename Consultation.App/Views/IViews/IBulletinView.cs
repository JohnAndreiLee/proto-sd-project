using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.Domain;
using Microsoft.DotNet.DesignTools.ViewModels;
using Consultation.App.Views;
using Consultation.App.Views.Controls.BulletinManagement;

namespace Consultation.App.Views.IViews
{
    public interface IBulletinView
    {
        event EventHandler CreateEvent;
        event EventHandler RefreshEvent;
        event EventHandler<BulletinEventArgs> EditEvent;
        event EventHandler<BulletinEventArgs> ArchiveEvent;
        event EventHandler<BulletinEventArgs> RestoreEvent;
        event EventHandler<BulletinEventArgs> DeleteEvent;
        event EventHandler<BulletinEventArgs> PublishEvent;

        void DisplayBulletins(List<Bulletin> bulletins);
        void DisplayArchivedBulletins(List<Bulletin> bulletins);
        void LoadBulletins();
        ViewMode CurrentMode { get; }
    }
}