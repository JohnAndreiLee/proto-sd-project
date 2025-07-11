namespace Consultation.App.Views
{
    partial class MainView
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
            sidePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            label3 = new Label();
            buttonPreference = new Button();
            buttonReports = new Button();
            label2 = new Label();
            buttonStudents = new Button();
            buttonConsulation = new Button();
            buttonBulletin = new Button();
            label1 = new Label();
            buttonDashboard = new Button();
            profilePanel = new Panel();
            labelProfileRole = new Label();
            labelProfileName = new Label();
            pictureBoxProfile = new PictureBox();
            pictureBoxLogo = new PictureBox();
            headerPanel = new Panel();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)sidePanel).BeginInit();
            sidePanel.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaption;
            sidePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.FromArgb(222, 59, 64), Color.FromArgb(222, 167, 59));
            sidePanel.Border3DStyle = Border3DStyle.Flat;
            sidePanel.BorderStyle = BorderStyle.None;
            sidePanel.Controls.Add(label3);
            sidePanel.Controls.Add(buttonPreference);
            sidePanel.Controls.Add(buttonReports);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(buttonStudents);
            sidePanel.Controls.Add(buttonConsulation);
            sidePanel.Controls.Add(buttonBulletin);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(buttonDashboard);
            sidePanel.Controls.Add(profilePanel);
            sidePanel.Controls.Add(pictureBoxLogo);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.ControlText;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(260, 1041);
            sidePanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter", 14.25F);
            label3.Location = new Point(24, 600);
            label3.Name = "label3";
            label3.Size = new Size(85, 27);
            label3.TabIndex = 11;
            label3.Text = "Settings";
            // 
            // buttonPreference
            // 
            buttonPreference.BackColor = Color.Transparent;
            buttonPreference.FlatAppearance.BorderSize = 0;
            buttonPreference.FlatStyle = FlatStyle.Flat;
            buttonPreference.Font = new Font("Inter", 11.25F);
            buttonPreference.ForeColor = SystemColors.ControlText;
            buttonPreference.Image = Properties.Icons.lsicon__setting_outline;
            buttonPreference.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPreference.Location = new Point(40, 640);
            buttonPreference.Name = "buttonPreference";
            buttonPreference.Size = new Size(208, 56);
            buttonPreference.TabIndex = 10;
            buttonPreference.Text = "Preference and Security";
            buttonPreference.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPreference.UseVisualStyleBackColor = false;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.Transparent;
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Inter", 11.25F);
            buttonReports.ForeColor = SystemColors.ControlText;
            buttonReports.Image = Properties.Icons.streamline__graph_bar_increase;
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(40, 512);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(208, 42);
            buttonReports.TabIndex = 9;
            buttonReports.Text = "Reports";
            buttonReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReports.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter", 14.25F);
            label2.Location = new Point(24, 424);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 7;
            label2.Text = "Management";
            // 
            // buttonStudents
            // 
            buttonStudents.BackColor = Color.Transparent;
            buttonStudents.FlatAppearance.BorderSize = 0;
            buttonStudents.FlatStyle = FlatStyle.Flat;
            buttonStudents.Font = new Font("Inter", 11.25F);
            buttonStudents.ForeColor = SystemColors.ControlText;
            buttonStudents.Image = Properties.Icons.material_symbols__groups_2;
            buttonStudents.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudents.Location = new Point(40, 464);
            buttonStudents.Name = "buttonStudents";
            buttonStudents.Size = new Size(208, 48);
            buttonStudents.TabIndex = 6;
            buttonStudents.Text = "Students and Faculty";
            buttonStudents.TextAlign = ContentAlignment.MiddleLeft;
            buttonStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonStudents.UseVisualStyleBackColor = false;
            // 
            // buttonConsulation
            // 
            buttonConsulation.BackColor = Color.Transparent;
            buttonConsulation.FlatAppearance.BorderSize = 0;
            buttonConsulation.FlatStyle = FlatStyle.Flat;
            buttonConsulation.Font = new Font("Inter", 11.25F);
            buttonConsulation.ForeColor = SystemColors.ControlText;
            buttonConsulation.Image = Properties.Icons.material_symbols__chat_bubble_outline;
            buttonConsulation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsulation.Location = new Point(40, 328);
            buttonConsulation.Name = "buttonConsulation";
            buttonConsulation.Size = new Size(208, 48);
            buttonConsulation.TabIndex = 5;
            buttonConsulation.Text = "Consulation";
            buttonConsulation.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsulation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsulation.UseVisualStyleBackColor = false;
            // 
            // buttonBulletin
            // 
            buttonBulletin.BackColor = Color.Transparent;
            buttonBulletin.FlatAppearance.BorderSize = 0;
            buttonBulletin.FlatStyle = FlatStyle.Flat;
            buttonBulletin.Font = new Font("Inter", 11.25F);
            buttonBulletin.ForeColor = SystemColors.ControlText;
            buttonBulletin.Image = Properties.Icons.material_symbols__format_list_bulleted;
            buttonBulletin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBulletin.Location = new Point(40, 280);
            buttonBulletin.Name = "buttonBulletin";
            buttonBulletin.Size = new Size(208, 42);
            buttonBulletin.TabIndex = 4;
            buttonBulletin.Text = "Bulletin";
            buttonBulletin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBulletin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 14.25F);
            label1.Location = new Point(24, 192);
            label1.Name = "label1";
            label1.Size = new Size(56, 27);
            label1.TabIndex = 3;
            label1.Text = "Main";
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Inter", 11.25F);
            buttonDashboard.ForeColor = SystemColors.ControlText;
            buttonDashboard.Image = Properties.Icons.material_symbols__dashboard_outline;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(40, 232);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(208, 42);
            buttonDashboard.TabIndex = 2;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(labelProfileRole);
            profilePanel.Controls.Add(labelProfileName);
            profilePanel.Controls.Add(pictureBoxProfile);
            profilePanel.Dock = DockStyle.Bottom;
            profilePanel.Location = new Point(0, 946);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(260, 95);
            profilePanel.TabIndex = 1;
            // 
            // labelProfileRole
            // 
            labelProfileRole.AutoSize = true;
            labelProfileRole.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProfileRole.Location = new Point(88, 48);
            labelProfileRole.Name = "labelProfileRole";
            labelProfileRole.Size = new Size(42, 22);
            labelProfileRole.TabIndex = 2;
            labelProfileRole.Text = "Role";
            // 
            // labelProfileName
            // 
            labelProfileName.AutoSize = true;
            labelProfileName.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProfileName.Location = new Point(88, 24);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(93, 22);
            labelProfileName.TabIndex = 1;
            labelProfileName.Text = "John Name";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.White;
            pictureBoxProfile.Location = new Point(16, 24);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(56, 56);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = Properties.Icons.LOGO_name__Custom___1_;
            pictureBoxLogo.Location = new Point(8, 40);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(248, 96);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.ForeColor = SystemColors.ControlText;
            headerPanel.Location = new Point(260, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1644, 100);
            headerPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(260, 100);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1644, 941);
            mainPanel.TabIndex = 2;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidePanel);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidePanel).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel sidePanel;
        private Panel headerPanel;
        private Panel profilePanel;
        private PictureBox pictureBoxLogo;
        private Button buttonDashboard;
        private Label label1;
        private Button buttonConsulation;
        private Button buttonBulletin;
        private Label label3;
        private Button buttonPreference;
        private Button buttonReports;
        private Label label2;
        private Button buttonStudents;
        private Label labelProfileRole;
        private Label labelProfileName;
        private PictureBox pictureBoxProfile;
        private Panel mainPanel;
    }
}