using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Guna.UI2.WinForms.Suite;

namespace Consultation.App.Views.Controls.BulletinManagement
{
    public partial class ArchiveCard : UserControl
    {
        public event EventHandler<BulletinEventArgs> ViewClicked;
        public event EventHandler<BulletinEventArgs> EditClicked;
        public event EventHandler<BulletinEventArgs> RestoreClicked;
        public event EventHandler<BulletinEventArgs> DeleteClicked;
        public event EventHandler<BulletinEventArgs> PublishClicked;

        private ToolStripDropDown _activeDropDown;

        public ArchiveCard(Consultation.Domain.Bulletin bulletin)
        {
            InitializeComponent();

            lblTitle.Text = bulletin.Title;
            txtContent.Text = bulletin.Content;
            tagDate.Text = bulletin.DatePublished.ToString("yyyy-MM-dd");    // alternative format: ToString("MMMM dd, yyyy")
            tagId.Text = "ID: BUL-2025-00" + bulletin.BulletinID.ToString();
            tagAuthor.Text = bulletin.Author;
            tagAttachments.Text = bulletin.FileCount.ToString() + " file (s)";
            tagStatus.Text = bulletin.Status;

            BulletinID = bulletin.BulletinID;
            Title = bulletin.Title;
            Author = bulletin.Author;
            Content = bulletin.Content;
            DatePublished = bulletin.DatePublished;
            Status = bulletin.Status;
            FileCount = bulletin.FileCount;
            IsArchived = bulletin.IsArchived;

            if (this.Status == "Published")
            {
                tagStatus.FillColor = Color.FromArgb(238, 253, 243);
                tagStatus.ForeColor = Color.FromArgb(17, 123, 52);
            }
        }

        public int BulletinID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public string Status { get; set; }
        public int FileCount { get; set; }
        public bool IsArchived { get; set; }

        private void btnMore_Click(object sender, EventArgs e)
        {
            Initialize_btnMoreComponents();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            btn.FillColor = Color.FromArgb(255, 240, 240);
            btn.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.FromArgb(190, 0, 2);

            if (btn.Name == "btnView") btn.Image = Properties.Icons.more_view_hovered;
            else if (btn.Name == "btnEdit") btn.Image = Properties.Icons.more_edit_hovered;
            else if (btn.Name == "btnArchive") btn.Image = Properties.Icons.more_archive_hovered;
            else btn.Image = Properties.Icons.more_delete_hovered;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            btn.FillColor = Color.White;
            btn.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.FromArgb(86, 93, 109);

            if (btn.Name == "btnView") btn.Image = Properties.Icons.more_view;
            else if (btn.Name == "btnEdit") btn.Image = Properties.Icons.more_edit;
            else if (btn.Name == "btnArchive") btn.Image = Properties.Icons.more_archive;
            else btn.Image = Properties.Icons.more_delete;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BulletinOverlay bulletinOverlay = new BulletinOverlay
            {
                BulletinID = this.BulletinID,
                Title = this.Title,
                Author = this.Author,
                Content = this.Content,
                DatePublished = this.DatePublished,
                Status = this.Status,
                FileCount = this.FileCount,
                IsArchived = this.IsArchived
            };

            bulletinOverlay.tagId.Text = "ID: BUL-2025-00" + BulletinID;
            bulletinOverlay.tagDate.Text = DatePublished.ToString("yyyy-MM-dd");    // alternative format: ToString("MMMM dd, yyyy")
            bulletinOverlay.tagAuthor.Text = Author;
            bulletinOverlay.lblTitle.Text = Title;
            bulletinOverlay.txtContent.Text = Content;

            bulletinOverlay.EditClicked += (s2, e2) => { EditClicked?.Invoke(this, e2); };
            bulletinOverlay.DeleteClicked += (s2, e2) => { DeleteClicked?.Invoke(this, e2); };
            bulletinOverlay.PublishClicked += (s2, e2) => { PublishClicked?.Invoke(this, e2); };

            if (this.Status == "Published")
                bulletinOverlay.btnPublish.Enabled = false;

            bulletinOverlay.ShowDialog();

            CloseDropdown();
            ViewClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
            // retrieve attachment/s from db not implemented
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CloseDropdown();
            EditClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            CloseDropdown();
            var confirm = MessageBox.Show("Restore this bulletin?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            RestoreClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CloseDropdown();
            var confirm = MessageBox.Show("Delete this bulletin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            DeleteClicked?.Invoke(this, new BulletinEventArgs(this.BulletinID));
        }

        public void CloseDropdown()
        {
            _activeDropDown?.Close();
        }

        private void Initialize_btnMoreComponents()
        {
            FlowLayoutPanel dropPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(6),
                Margin = Padding.Empty
            };

            Guna.UI2.WinForms.Guna2Button btnView = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2Button btnEdit = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2Button btnRestore = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2Button btnDelete = new Guna.UI2.WinForms.Guna2Button();

            btnView.Cursor = Cursors.Hand;
            btnView.DisabledState.BorderColor = Color.DarkGray;
            btnView.DisabledState.CustomBorderColor = Color.DarkGray;
            btnView.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnView.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnView.FillColor = Color.White;
            btnView.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.FromArgb(86, 93, 109);
            btnView.Image = Properties.Icons.more_view;
            btnView.ImageAlign = HorizontalAlignment.Left;
            btnView.ImageOffset = new Point(6, 0);
            btnView.ImageSize = new Size(22, 15);
            btnView.Location = new Point(8, 10);
            btnView.Name = "btnView";
            btnView.Size = new Size(115, 40);
            btnView.TabIndex = 35;
            btnView.Text = "View";
            btnView.TextAlign = HorizontalAlignment.Left;
            btnView.TextOffset = new Point(6, 0);
            btnView.Margin = Padding.Empty;
            btnView.MouseEnter += button_MouseEnter;
            btnView.MouseLeave += button_MouseLeave;
            btnView.Click += btnView_Click;

            btnEdit.Cursor = Cursors.Hand;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(86, 93, 109);
            btnEdit.Image = Properties.Icons.more_edit;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageOffset = new Point(6, 0);
            btnEdit.ImageSize = new Size(22, 22);
            btnEdit.Location = new Point(8, 50);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 40);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = HorizontalAlignment.Left;
            btnEdit.TextOffset = new Point(6, 0);
            btnEdit.Margin = Padding.Empty;
            btnEdit.MouseEnter += button_MouseEnter;
            btnEdit.MouseLeave += button_MouseLeave;
            btnEdit.Click += btnEdit_Click;

            btnRestore.Cursor = Cursors.Hand;
            btnRestore.DisabledState.BorderColor = Color.DarkGray;
            btnRestore.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRestore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRestore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRestore.FillColor = Color.White;
            btnRestore.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.FromArgb(86, 93, 109);
            btnRestore.Image = Properties.Icons.more_archive;
            btnRestore.ImageAlign = HorizontalAlignment.Left;
            btnRestore.ImageOffset = new Point(6, 0);
            btnRestore.ImageSize = new Size(22, 20);
            btnRestore.Location = new Point(8, 90);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(115, 40);
            btnRestore.TabIndex = 37;
            btnRestore.Text = "Restore";
            btnRestore.TextAlign = HorizontalAlignment.Left;
            btnRestore.TextOffset = new Point(6, 0);
            btnRestore.Margin = Padding.Empty;
            btnRestore.MouseEnter += button_MouseEnter;
            btnRestore.MouseLeave += button_MouseLeave;
            btnRestore.Click += btnRestore_Click;

            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.White;
            btnDelete.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(86, 93, 109);
            btnDelete.Image = Properties.Icons.more_delete;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageOffset = new Point(6, 0);
            btnDelete.ImageSize = new Size(22, 22);
            btnDelete.Location = new Point(8, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 40);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = HorizontalAlignment.Left;
            btnDelete.TextOffset = new Point(6, 0);
            btnDelete.Margin = Padding.Empty;
            btnDelete.MouseEnter += button_MouseEnter;
            btnDelete.MouseLeave += button_MouseLeave;
            btnDelete.Click += btnDelete_Click;

            dropPanel.Controls.Add(btnView);
            dropPanel.Controls.Add(btnEdit);
            dropPanel.Controls.Add(btnRestore);
            dropPanel.Controls.Add(btnDelete);

            ToolStripControlHost host = new ToolStripControlHost(dropPanel)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = true
            };

            _activeDropDown = new ToolStripDropDown
            {
                AutoClose = true,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            _activeDropDown.Items.Add(host);
            _activeDropDown.Show(btnMore, new Point(0, btnMore.Height));
        }
    }
}