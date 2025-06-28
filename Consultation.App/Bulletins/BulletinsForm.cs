using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Bulletins
{
    public partial class BulletinsForm : Form
    {
        public BulletinsForm()
        {
            InitializeComponent();
            btnBulletinView_Click(btnBulletinView, EventArgs.Empty);
        }

        private void btnCreateBulletin_Click(object sender, EventArgs e)
        {
            CreateBulletinForm bulletinForm = new CreateBulletinForm();
            bulletinForm.ShowDialog();
        }

        private void btnBulletinView_Click(object sender, EventArgs e)
        {
            btnBulletinView.ForeColor = Color.FromArgb(190, 0, 2);
            btnBulletinView.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnArchive.ForeColor = Color.FromArgb(86, 93, 109);
            btnArchive.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnBulletinView);

            panelBulletinCard.Controls.Clear();
            panelBulletinCard.Controls.Add(new BulletinCardUserControl());
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnArchive.ForeColor = Color.FromArgb(190, 0, 2);
            btnArchive.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnBulletinView.ForeColor = Color.FromArgb(86, 93, 109);
            btnBulletinView.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnArchive);

            panelBulletinCard.Controls.Clear();
            panelBulletinCard.Controls.Add(new ArchiveCardUserControl());
        }

        private void MoveUnderline(Guna.UI2.WinForms.Guna2Button targetButton)
        {
            panelUnderline.Width = targetButton.Width;
            panelUnderline.Left = targetButton.Left;
            panelUnderline.Top = targetButton.Bottom - 4;
            panelUnderline.Visible = true;
        }
    }
}