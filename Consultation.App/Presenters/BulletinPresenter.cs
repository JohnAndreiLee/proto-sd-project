using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultation.App.Views.Controls.BulletinManagement;
using Consultation.App.Views.IViews;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.DotNet.DesignTools.ViewModels;

namespace Consultation.App.Presenters
{
    public class BulletinPresenter
    {
        private IBulletinView _bulletinView;
        private AppDbContext _dbContext;
        private IEnumerable<Bulletin> _bulletinList;

        public BulletinPresenter(IBulletinView bulletinView)
        {
            _bulletinView = bulletinView;
            _dbContext = new AppDbContext();

            _bulletinView.CreateEvent += CreateEvent;
            _bulletinView.RefreshEvent += RefreshEvent;
            _bulletinView.EditEvent += EditEvent;
            _bulletinView.ArchiveEvent += ArchiveEvent;
            _bulletinView.RestoreEvent += RestoreEvent;
            _bulletinView.DeleteEvent += DeleteEvent;
            _bulletinView.PublishEvent += PublishEvent;

            _bulletinView.LoadBulletins();
        }

        private void CreateEvent(object sender, EventArgs e)
        {
            using (var createForm = new CreateBulletin())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    _bulletinView.LoadBulletins();
                }
            }
        }

        private void RefreshEvent(object sender, EventArgs e)
        {
            if (_bulletinView.CurrentMode == ViewMode.Active)
            {
                _bulletinList = _dbContext.Bulletins
                    .Where(b => !b.IsArchived)
                    .ToList();

                _bulletinView.DisplayBulletins(_bulletinList.ToList());
            }
            else if (_bulletinView.CurrentMode == ViewMode.Archived)
            {
                _bulletinList = _dbContext.Bulletins
                    .Where(b => b.IsArchived)
                    .ToList();

                _bulletinView.DisplayArchivedBulletins(_bulletinList.ToList());
            }
        }

        private void EditEvent(object sender, BulletinEventArgs e)
        {
            var bulletinToEdit = _dbContext.Bulletins.FirstOrDefault(b => b.BulletinID == e.BulletinID);
            if (bulletinToEdit == null) return;

            using (var editForm = new CreateBulletin(bulletinToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _bulletinView.LoadBulletins();
                }
            }
        }

        private void ArchiveEvent(object sender, BulletinEventArgs e)
        {
            var bulletin = _dbContext.Bulletins.FirstOrDefault(b => b.BulletinID == e.BulletinID);
            if (bulletin == null) return;

            bulletin.IsArchived = true;
            _dbContext.SaveChanges();

            _bulletinView.LoadBulletins();
        }

        private void RestoreEvent(object sender, BulletinEventArgs e)
        {
            var bulletin = _dbContext.Bulletins.FirstOrDefault(b => b.BulletinID == e.BulletinID);
            if (bulletin == null) return;

            bulletin.IsArchived = false;
            _dbContext.SaveChanges();

            _bulletinView.LoadBulletins();
        }

        private void DeleteEvent(object sender, BulletinEventArgs e)
        {
            var bulletin = _dbContext.Bulletins.FirstOrDefault(b => b.BulletinID == e.BulletinID);
            if (bulletin == null) return;

            _dbContext.Bulletins.Remove(bulletin);
            _dbContext.SaveChanges();

            _bulletinView.LoadBulletins();
        }

        private void PublishEvent(object? sender, BulletinEventArgs e)
        {
            var bulletin = _dbContext.Bulletins.FirstOrDefault(b => b.BulletinID == e.BulletinID);
            if (bulletin == null) return;

            bulletin.Status = "Published";
            bulletin.DatePublished = DateTime.Now;
            _dbContext.SaveChanges();

            _bulletinView.LoadBulletins();
        }
    }
}