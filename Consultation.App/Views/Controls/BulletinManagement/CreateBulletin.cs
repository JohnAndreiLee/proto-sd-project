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

namespace Consultation.App.Views.Controls.BulletinManagement
{
    public partial class CreateBulletin : Form
    {
        private AppDbContext _dbContext;
        private Bulletin? _editBulletin;

        public CreateBulletin(Bulletin bulletin = null)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _editBulletin = bulletin;

            if (_editBulletin != null)
            {
                lblHeader.Text = "Edit Bulletin";
                txtTitle.Text = _editBulletin.Title;
                txtAuthor.Text = _editBulletin.Author;
                txtContent.Text = _editBulletin.Content;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isNew = _editBulletin == null;

            if (isNew)
            {
                _editBulletin = new Bulletin();
                _dbContext.Bulletins.Add(_editBulletin);
                _editBulletin.DatePublished = DateTime.Now;
                _editBulletin.Status = "Pending";
            }
            else
            {
                _dbContext.Bulletins.Update(_editBulletin);
            }

            _editBulletin.Title = txtTitle.Text;
            _editBulletin.Content = txtContent.Text;
            _editBulletin.Author = txtAuthor.Text;
            _editBulletin.FileCount = 0;

            await _dbContext.SaveChangesAsync();

            MessageBox.Show(isNew ? "Bulletin created successfully." : "Bulletin updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}