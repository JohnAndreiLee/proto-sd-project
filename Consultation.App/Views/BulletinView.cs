using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.Presenters;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.App.Views.Controls.BulletinManagement;
using Consultation.App.Views.IViews;
using Consultation.Domain;

namespace Consultation.App.Views
{
    public partial class BulletinView : Form, IBulletinView
    {
        public event EventHandler CreateEvent;
        public event EventHandler RefreshEvent;
        public event EventHandler<BulletinEventArgs> EditEvent;
        public event EventHandler<BulletinEventArgs> ArchiveEvent;
        public event EventHandler<BulletinEventArgs> RestoreEvent;
        public event EventHandler<BulletinEventArgs> DeleteEvent;
        public event EventHandler<BulletinEventArgs> PublishEvent;

        private ViewMode currentMode = ViewMode.Active;
        public ViewMode CurrentMode => currentMode;

        public BulletinView()
        {
            InitializeComponent();
        }

        public void DisplayBulletins(List<Consultation.Domain.Bulletin> bulletins)
        {
            flpBulletinList.Controls.Clear();

            foreach (var bulletin in bulletins.OrderByDescending(b => b.DatePublished))
            {
                var card = new BulletinCard(bulletin);

                card.EditClicked += (s, e) => { EditEvent?.Invoke(s, e); };
                card.ArchiveClicked += (s, e) => { ArchiveEvent?.Invoke(s, e); };
                card.DeleteClicked += (s, e) => { DeleteEvent?.Invoke(s, e); };
                card.PublishClicked += (s, e) => { PublishEvent?.Invoke(s, e); };

                flpBulletinList.Controls.Add(card);
            }
        }

        public void DisplayArchivedBulletins(List<Consultation.Domain.Bulletin> bulletins)
        {
            flpBulletinList.Controls.Clear();

            foreach (var bulletin in bulletins.OrderByDescending(b => b.DatePublished))
            {
                var card = new ArchiveCard(bulletin);

                card.EditClicked += (s, e) => { EditEvent?.Invoke(s, e); };
                card.RestoreClicked += (s, e) => { RestoreEvent?.Invoke(s, e); };
                card.DeleteClicked += (s, e) => { DeleteEvent?.Invoke(s, e); };
                card.PublishClicked += (s, e) => { PublishEvent?.Invoke(s, e); };

                flpBulletinList.Controls.Add(card);
            }
        }

        public void LoadBulletins()
        {
            if (CurrentMode == ViewMode.Active)
                btnBulletinView_Click(btnBulletinView, EventArgs.Empty);
            else
                btnArchive_Click(btnArchive, EventArgs.Empty);
        }

        private void btnCreateBulletin_Click(object sender, EventArgs e)
        {
            CreateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnBulletinView_Click(object sender, EventArgs e)
        {
            currentMode = ViewMode.Active;
            btnBulletinView.ForeColor = Color.FromArgb(190, 0, 2);
            btnBulletinView.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnArchive.ForeColor = Color.FromArgb(86, 93, 109);
            btnArchive.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnBulletinView);

            lblBulletinHeader.Text = "Active Bulletins";

            RefreshEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            currentMode = ViewMode.Archived;
            btnArchive.ForeColor = Color.FromArgb(190, 0, 2);
            btnArchive.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnBulletinView.ForeColor = Color.FromArgb(86, 93, 109);
            btnBulletinView.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnArchive);

            lblBulletinHeader.Text = "Archived Bulletins";

            RefreshEvent?.Invoke(this, EventArgs.Empty);
        }

        private void MoveUnderline(Guna.UI2.WinForms.Guna2Button targetButton)
        {
            panelUnderline.Width = targetButton.Width;
            panelUnderline.Left = targetButton.Left;
            panelUnderline.Top = targetButton.Bottom - 4;
            panelUnderline.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBulletins();
        }
    }
}