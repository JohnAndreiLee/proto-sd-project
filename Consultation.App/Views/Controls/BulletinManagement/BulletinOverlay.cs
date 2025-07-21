using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.Views.IViews;
using Consultation.Domain;
using Consultation.Infrastructure.Data;

namespace Consultation.App.Views.Controls.BulletinManagement
{
    public partial class BulletinOverlay : Form
    {
        public event EventHandler<BulletinEventArgs> EditClicked;
        public event EventHandler<BulletinEventArgs> DeleteClicked;
        public event EventHandler<BulletinEventArgs> PublishClicked;

        public BulletinOverlay()
        {
            InitializeComponent();
        }

        public int BulletinID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public string Status { get; set; }
        public int FileCount { get; set; }
        public bool IsArchived { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Delete this bulletin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            DeleteClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Publish this bulletin?", "Confirm Publish", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            PublishClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
            this.Close();
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            // download attachment logic
        }
    }
}