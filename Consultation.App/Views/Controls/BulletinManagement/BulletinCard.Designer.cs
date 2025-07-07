namespace Consultation.App.Views.Controls.BulletinManagement
{
    partial class BulletinCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletinCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            txtContent = new RichTextBox();
            btnMore = new Guna.UI2.WinForms.Guna2Button();
            tagStatus = new Guna.UI2.WinForms.Guna2Button();
            tagId = new Guna.UI2.WinForms.Guna2Button();
            tagDate = new Guna.UI2.WinForms.Guna2Button();
            tagAuthor = new Guna.UI2.WinForms.Guna2Button();
            tagAttachments = new Guna.UI2.WinForms.Guna2Button();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Archivo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(23, 26, 31);
            lblTitle.Location = new Point(28, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "School Closure - Faculty Meeting";
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.White;
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.ForeColor = Color.FromArgb(23, 26, 31);
            txtContent.Location = new Point(33, 75);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.ScrollBars = RichTextBoxScrollBars.None;
            txtContent.Size = new Size(1270, 42);
            txtContent.TabIndex = 1;
            txtContent.Text = resources.GetString("txtContent.Text");
            // 
            // btnMore
            // 
            btnMore.Cursor = Cursors.Hand;
            btnMore.CustomizableEdges = customizableEdges13;
            btnMore.DisabledState.BorderColor = Color.DarkGray;
            btnMore.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMore.FillColor = Color.Transparent;
            btnMore.Font = new Font("Segoe UI", 9F);
            btnMore.ForeColor = Color.White;
            btnMore.Image = Properties.Icons.more;
            btnMore.ImageSize = new Size(24, 6);
            btnMore.Location = new Point(1338, 26);
            btnMore.Name = "btnMore";
            btnMore.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMore.Size = new Size(32, 32);
            btnMore.TabIndex = 2;
            btnMore.Click += btnMore_Click;
            // 
            // tagStatus
            // 
            tagStatus.BackColor = Color.White;
            tagStatus.BorderColor = Color.Transparent;
            tagStatus.BorderRadius = 12;
            tagStatus.CustomizableEdges = customizableEdges15;
            tagStatus.DisabledState.BorderColor = Color.DarkGray;
            tagStatus.DisabledState.CustomBorderColor = Color.DarkGray;
            tagStatus.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tagStatus.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tagStatus.FillColor = Color.FromArgb(255, 240, 240);
            tagStatus.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagStatus.ForeColor = Color.FromArgb(190, 0, 2);
            tagStatus.ImageSize = new Size(16, 16);
            tagStatus.Location = new Point(1232, 26);
            tagStatus.Name = "tagStatus";
            tagStatus.ShadowDecoration.CustomizableEdges = customizableEdges16;
            tagStatus.Size = new Size(100, 32);
            tagStatus.TabIndex = 29;
            tagStatus.Text = "Pending";
            // 
            // tagId
            // 
            tagId.BackColor = Color.White;
            tagId.BorderRadius = 12;
            tagId.CustomizableEdges = customizableEdges17;
            tagId.DisabledState.BorderColor = Color.DarkGray;
            tagId.DisabledState.CustomBorderColor = Color.DarkGray;
            tagId.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tagId.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tagId.FillColor = Color.FromArgb(243, 244, 246);
            tagId.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagId.ForeColor = Color.FromArgb(50, 55, 67);
            tagId.Location = new Point(33, 134);
            tagId.Name = "tagId";
            tagId.ShadowDecoration.CustomizableEdges = customizableEdges18;
            tagId.Size = new Size(131, 28);
            tagId.TabIndex = 30;
            tagId.Text = "ID: BUL-2025-001";
            // 
            // tagDate
            // 
            tagDate.BackColor = Color.White;
            tagDate.BorderRadius = 12;
            tagDate.CustomizableEdges = customizableEdges19;
            tagDate.DisabledState.BorderColor = Color.DarkGray;
            tagDate.DisabledState.CustomBorderColor = Color.DarkGray;
            tagDate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tagDate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tagDate.FillColor = Color.FromArgb(243, 244, 246);
            tagDate.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagDate.ForeColor = Color.FromArgb(50, 55, 67);
            tagDate.Image = Properties.Icons.tag_date2;
            tagDate.ImageOffset = new Point(-1, 0);
            tagDate.ImageSize = new Size(16, 15);
            tagDate.Location = new Point(179, 134);
            tagDate.Name = "tagDate";
            tagDate.ShadowDecoration.CustomizableEdges = customizableEdges20;
            tagDate.Size = new Size(118, 28);
            tagDate.TabIndex = 31;
            tagDate.Text = "2024-05-05";
            // 
            // tagAuthor
            // 
            tagAuthor.BackColor = Color.White;
            tagAuthor.BorderRadius = 12;
            tagAuthor.CustomizableEdges = customizableEdges21;
            tagAuthor.DisabledState.BorderColor = Color.DarkGray;
            tagAuthor.DisabledState.CustomBorderColor = Color.DarkGray;
            tagAuthor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tagAuthor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tagAuthor.FillColor = Color.FromArgb(243, 244, 246);
            tagAuthor.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagAuthor.ForeColor = Color.FromArgb(50, 55, 67);
            tagAuthor.Image = Properties.Icons.tag_person2;
            tagAuthor.ImageSize = new Size(16, 16);
            tagAuthor.Location = new Point(312, 134);
            tagAuthor.Name = "tagAuthor";
            tagAuthor.ShadowDecoration.CustomizableEdges = customizableEdges22;
            tagAuthor.Size = new Size(122, 28);
            tagAuthor.TabIndex = 32;
            tagAuthor.Text = "Admin Office";
            // 
            // tagAttachments
            // 
            tagAttachments.BackColor = Color.White;
            tagAttachments.BorderRadius = 12;
            tagAttachments.CustomizableEdges = customizableEdges23;
            tagAttachments.DisabledState.BorderColor = Color.DarkGray;
            tagAttachments.DisabledState.CustomBorderColor = Color.DarkGray;
            tagAttachments.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tagAttachments.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tagAttachments.FillColor = Color.FromArgb(243, 244, 246);
            tagAttachments.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagAttachments.ForeColor = Color.FromArgb(50, 55, 67);
            tagAttachments.Image = Properties.Icons.tag_attachment;
            tagAttachments.ImageOffset = new Point(-1, 0);
            tagAttachments.ImageSize = new Size(16, 16);
            tagAttachments.Location = new Point(449, 134);
            tagAttachments.Name = "tagAttachments";
            tagAttachments.ShadowDecoration.CustomizableEdges = customizableEdges24;
            tagAttachments.Size = new Size(90, 28);
            tagAttachments.TabIndex = 33;
            tagAttachments.Text = "1 file (s)";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(10, 7);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1380, 180);
            materialCard1.TabIndex = 34;
            // 
            // BulletinCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tagAttachments);
            Controls.Add(tagAuthor);
            Controls.Add(tagDate);
            Controls.Add(tagId);
            Controls.Add(tagStatus);
            Controls.Add(btnMore);
            Controls.Add(txtContent);
            Controls.Add(lblTitle);
            Controls.Add(materialCard1);
            Margin = new Padding(20, 0, 0, 0);
            Name = "BulletinCard";
            Size = new Size(1400, 194);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox txtContent;
        private Guna.UI2.WinForms.Guna2Button btnMore;
        private Guna.UI2.WinForms.Guna2Button tagStatus;
        private Guna.UI2.WinForms.Guna2Button tagId;
        private Guna.UI2.WinForms.Guna2Button tagDate;
        private Guna.UI2.WinForms.Guna2Button tagAuthor;
        private Guna.UI2.WinForms.Guna2Button tagAttachments;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
