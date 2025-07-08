namespace Consultation.App.Views
{
    partial class BulletinView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            panelUnderline = new Panel();
            btnBulletinView = new Guna.UI2.WinForms.Guna2Button();
            btnArchive = new Guna.UI2.WinForms.Guna2Button();
            btnCreateBulletin = new Guna.UI2.WinForms.Guna2Button();
            panelBulletinCard = new MaterialSkin.Controls.MaterialCard();
            panelHeader = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            materialCard1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panelUnderline);
            materialCard1.Controls.Add(btnBulletinView);
            materialCard1.Controls.Add(btnArchive);
            materialCard1.Controls.Add(btnCreateBulletin);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(21, 15);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1600, 80);
            materialCard1.TabIndex = 0;
            // 
            // panelUnderline
            // 
            panelUnderline.BackColor = Color.FromArgb(190, 0, 2);
            panelUnderline.Location = new Point(315, 47);
            panelUnderline.Name = "panelUnderline";
            panelUnderline.Size = new Size(190, 4);
            panelUnderline.TabIndex = 6;
            // 
            // btnBulletinView
            // 
            btnBulletinView.CustomizableEdges = customizableEdges1;
            btnBulletinView.DisabledState.BorderColor = Color.DarkGray;
            btnBulletinView.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBulletinView.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBulletinView.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBulletinView.FillColor = Color.White;
            btnBulletinView.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBulletinView.ForeColor = Color.FromArgb(190, 0, 2);
            btnBulletinView.Location = new Point(12, 12);
            btnBulletinView.Name = "btnBulletinView";
            btnBulletinView.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBulletinView.Size = new Size(136, 56);
            btnBulletinView.TabIndex = 5;
            btnBulletinView.Text = "Bulletin View";
            btnBulletinView.Click += btnBulletinView_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.White;
            btnArchive.CustomizableEdges = customizableEdges3;
            btnArchive.DisabledState.BorderColor = Color.DarkGray;
            btnArchive.DisabledState.CustomBorderColor = Color.DarkGray;
            btnArchive.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnArchive.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnArchive.FillColor = Color.White;
            btnArchive.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchive.ForeColor = Color.FromArgb(86, 93, 109);
            btnArchive.Location = new Point(154, 12);
            btnArchive.Name = "btnArchive";
            btnArchive.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnArchive.Size = new Size(136, 56);
            btnArchive.TabIndex = 4;
            btnArchive.Text = "Archive";
            btnArchive.Click += btnArchive_Click;
            // 
            // btnCreateBulletin
            // 
            btnCreateBulletin.BorderRadius = 7;
            btnCreateBulletin.CustomizableEdges = customizableEdges5;
            btnCreateBulletin.DisabledState.BorderColor = Color.DarkGray;
            btnCreateBulletin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateBulletin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateBulletin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateBulletin.FillColor = Color.FromArgb(190, 0, 2);
            btnCreateBulletin.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBulletin.ForeColor = Color.White;
            btnCreateBulletin.Location = new Point(1427, 22);
            btnCreateBulletin.Name = "btnCreateBulletin";
            btnCreateBulletin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCreateBulletin.Size = new Size(136, 36);
            btnCreateBulletin.TabIndex = 3;
            btnCreateBulletin.Text = "Create Bulletin";
            btnCreateBulletin.Click += btnCreateBulletin_Click;
            // 
            // panelBulletinCard
            // 
            panelBulletinCard.BackColor = Color.FromArgb(255, 255, 255);
            panelBulletinCard.Depth = 0;
            panelBulletinCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelBulletinCard.Location = new Point(88, 197);
            panelBulletinCard.Margin = new Padding(0);
            panelBulletinCard.MouseState = MaterialSkin.MouseState.HOVER;
            panelBulletinCard.Name = "panelBulletinCard";
            panelBulletinCard.Padding = new Padding(14);
            panelBulletinCard.Size = new Size(1460, 724);
            panelBulletinCard.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 255, 255);
            panelHeader.Controls.Add(label1);
            panelHeader.Depth = 0;
            panelHeader.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelHeader.Location = new Point(88, 123);
            panelHeader.Margin = new Padding(14);
            panelHeader.MouseState = MaterialSkin.MouseState.HOVER;
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(14);
            panelHeader.Size = new Size(1460, 70);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 26, 31);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Active Bulletins";
            // 
            // BulletinView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1642, 941);
            Controls.Add(panelHeader);
            Controls.Add(panelBulletinCard);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BulletinView";
            Text = "BulletinsForm";
            materialCard1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2Button btnCreateBulletin;
        private MaterialSkin.Controls.MaterialCard panelBulletinCard;
        private Guna.UI2.WinForms.Guna2Button btnBulletinView;
        private Guna.UI2.WinForms.Guna2Button btnArchive;
        private Panel panelUnderline;
        private MaterialSkin.Controls.MaterialCard panelHeader;
        private Label label1;
    }
}