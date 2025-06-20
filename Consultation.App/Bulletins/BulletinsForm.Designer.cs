namespace Consultation.App.Bulletins
{
    partial class BulletinsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnCreateBulletin = new Guna.UI2.WinForms.Guna2Button();
            panelBulletinCard = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
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
            // btnCreateBulletin
            // 
            btnCreateBulletin.BorderRadius = 7;
            btnCreateBulletin.CustomizableEdges = customizableEdges3;
            btnCreateBulletin.DisabledState.BorderColor = Color.DarkGray;
            btnCreateBulletin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateBulletin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateBulletin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateBulletin.FillColor = Color.FromArgb(190, 0, 2);
            btnCreateBulletin.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBulletin.ForeColor = Color.White;
            btnCreateBulletin.Location = new Point(1427, 22);
            btnCreateBulletin.Name = "btnCreateBulletin";
            btnCreateBulletin.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            panelBulletinCard.Location = new Point(72, 123);
            panelBulletinCard.Margin = new Padding(14);
            panelBulletinCard.MouseState = MaterialSkin.MouseState.HOVER;
            panelBulletinCard.Name = "panelBulletinCard";
            panelBulletinCard.Padding = new Padding(14);
            panelBulletinCard.Size = new Size(1500, 790);
            panelBulletinCard.TabIndex = 1;
            // 
            // BulletinsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1642, 941);
            Controls.Add(panelBulletinCard);
            Controls.Add(materialCard1);
            Name = "BulletinsForm";
            Text = "BulletinsForm";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2Button btnCreateBulletin;
        private MaterialSkin.Controls.MaterialCard panelBulletinCard;
    }
}