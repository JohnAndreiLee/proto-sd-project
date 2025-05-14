namespace Consultation.App.Dashboard
{
    partial class MainDashboardUserControl
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
            ActivityFeedPanel = new MaterialSkin.Controls.MaterialCard();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            ConsultationButton = new Syncfusion.WinForms.Controls.SfButton();
            BulletinButton = new Syncfusion.WinForms.Controls.SfButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1 = new Panel();
            WelcomeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel3 = new Panel();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            ThisWeekButton = new Syncfusion.WinForms.Controls.SfButton();
            TodayButton = new Syncfusion.WinForms.Controls.SfButton();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel2 = new Panel();
            panel4 = new Panel();
            today1 = new Consultation.App.Dashboard.Upcoming_Schedule.Today();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            materialCard8.SuspendLayout();
            SuspendLayout();
            // 
            // ActivityFeedPanel
            // 
            ActivityFeedPanel.BackColor = Color.FromArgb(255, 255, 255);
            ActivityFeedPanel.Depth = 0;
            ActivityFeedPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ActivityFeedPanel.Location = new Point(53, 351);
            ActivityFeedPanel.Margin = new Padding(14);
            ActivityFeedPanel.MouseState = MaterialSkin.MouseState.HOVER;
            ActivityFeedPanel.Name = "ActivityFeedPanel";
            ActivityFeedPanel.Padding = new Padding(14);
            ActivityFeedPanel.Size = new Size(900, 600);
            ActivityFeedPanel.TabIndex = 0;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel1.Location = new Point(17, 20);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel1.Size = new Size(136, 25);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Activity Feed";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(ConsultationButton);
            materialCard2.Controls.Add(BulletinButton);
            materialCard2.Controls.Add(autoLabel1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(53, 280);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(900, 70);
            materialCard2.TabIndex = 2;
            // 
            // ConsultationButton
            // 
            ConsultationButton.BackColor = SystemColors.ButtonHighlight;
            ConsultationButton.FlatStyle = FlatStyle.Popup;
            ConsultationButton.FocusRectangleVisible = true;
            ConsultationButton.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsultationButton.ForeColor = Color.DimGray;
            ConsultationButton.Location = new Point(772, 20);
            ConsultationButton.Name = "ConsultationButton";
            ConsultationButton.Size = new Size(111, 28);
            ConsultationButton.Style.BackColor = SystemColors.ButtonHighlight;
            ConsultationButton.Style.ForeColor = Color.DimGray;
            ConsultationButton.TabIndex = 11;
            ConsultationButton.Text = "Consultations";
            ConsultationButton.UseVisualStyleBackColor = false;
            ConsultationButton.Click += ConsultationButton_Click;
            // 
            // BulletinButton
            // 
            BulletinButton.BackColor = SystemColors.ButtonHighlight;
            BulletinButton.FlatStyle = FlatStyle.Popup;
            BulletinButton.FocusRectangleVisible = true;
            BulletinButton.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BulletinButton.ForeColor = Color.FromArgb(192, 0, 0);
            BulletinButton.Location = new Point(685, 20);
            BulletinButton.Name = "BulletinButton";
            BulletinButton.Size = new Size(96, 28);
            BulletinButton.Style.BackColor = SystemColors.ButtonHighlight;
            BulletinButton.Style.ForeColor = Color.FromArgb(192, 0, 0);
            BulletinButton.TabIndex = 2;
            BulletinButton.Text = "Bulletins";
            BulletinButton.UseVisualStyleBackColor = false;
            BulletinButton.Click += BulletinButton_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(autoLabel5);
            materialCard3.Controls.Add(panel1);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(53, 102);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(325, 150);
            materialCard3.TabIndex = 3;
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.DimGray;
            autoLabel5.Location = new Point(29, 14);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel5.Size = new Size(158, 20);
            autoLabel5.TabIndex = 6;
            autoLabel5.Text = "New Consultations";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(16, 150);
            panel1.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.Black;
            WelcomeLabel.Location = new Point(45, 19);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            WelcomeLabel.Size = new Size(167, 37);
            WelcomeLabel.TabIndex = 4;
            WelcomeLabel.Text = "Welcome ";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.ForeColor = Color.Gray;
            autoLabel3.Location = new Point(51, 64);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel3.Size = new Size(313, 20);
            autoLabel3.TabIndex = 5;
            autoLabel3.Text = "Here's what's happening at UM  today";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(autoLabel6);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(448, 102);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(325, 150);
            materialCard4.TabIndex = 6;
            // 
            // autoLabel6
            // 
            autoLabel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.ForeColor = Color.DimGray;
            autoLabel6.Location = new Point(31, 14);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel6.Size = new Size(149, 20);
            autoLabel6.TabIndex = 7;
            autoLabel6.Text = "Upcoming Events";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(autoLabel7);
            materialCard5.Controls.Add(panel3);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(849, 102);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(325, 150);
            materialCard5.TabIndex = 7;
            // 
            // autoLabel7
            // 
            autoLabel7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.ForeColor = Color.DimGray;
            autoLabel7.Location = new Point(34, 14);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel7.Size = new Size(132, 20);
            autoLabel7.TabIndex = 13;
            autoLabel7.Text = "Active Bulletins";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 150);
            panel3.TabIndex = 1;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(autoLabel8);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(1243, 102);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(325, 150);
            materialCard6.TabIndex = 8;
            // 
            // autoLabel8
            // 
            autoLabel8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel8.ForeColor = Color.DimGray;
            autoLabel8.Location = new Point(34, 14);
            autoLabel8.Name = "autoLabel8";
            autoLabel8.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel8.Size = new Size(126, 20);
            autoLabel8.TabIndex = 14;
            autoLabel8.Text = "Pending Tasks";
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(today1);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(994, 351);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(574, 600);
            materialCard7.TabIndex = 9;
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(ThisWeekButton);
            materialCard8.Controls.Add(TodayButton);
            materialCard8.Controls.Add(sfButton2);
            materialCard8.Controls.Add(autoLabel4);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(994, 280);
            materialCard8.Margin = new Padding(14);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(14);
            materialCard8.Size = new Size(574, 70);
            materialCard8.TabIndex = 10;
            // 
            // ThisWeekButton
            // 
            ThisWeekButton.BackColor = SystemColors.ButtonHighlight;
            ThisWeekButton.FlatStyle = FlatStyle.Popup;
            ThisWeekButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThisWeekButton.ForeColor = Color.DimGray;
            ThisWeekButton.Location = new Point(461, 20);
            ThisWeekButton.Name = "ThisWeekButton";
            ThisWeekButton.Size = new Size(96, 28);
            ThisWeekButton.Style.BackColor = SystemColors.ButtonHighlight;
            ThisWeekButton.Style.ForeColor = Color.DimGray;
            ThisWeekButton.TabIndex = 13;
            ThisWeekButton.Text = "This Week";
            ThisWeekButton.UseVisualStyleBackColor = false;
            ThisWeekButton.Click += ThisWeekButton_Click;
            // 
            // TodayButton
            // 
            TodayButton.BackColor = SystemColors.ButtonHighlight;
            TodayButton.FlatStyle = FlatStyle.Popup;
            TodayButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TodayButton.ForeColor = Color.DimGray;
            TodayButton.Location = new Point(359, 20);
            TodayButton.Name = "TodayButton";
            TodayButton.Size = new Size(96, 28);
            TodayButton.Style.BackColor = SystemColors.ButtonHighlight;
            TodayButton.Style.ForeColor = Color.DimGray;
            TodayButton.TabIndex = 12;
            TodayButton.Text = "Today";
            TodayButton.UseVisualStyleBackColor = false;
            TodayButton.Click += TodayButton_Click;
            // 
            // sfButton2
            // 
            sfButton2.Font = new Font("Segoe UI Semibold", 9F);
            sfButton2.ForeColor = Color.Red;
            sfButton2.Location = new Point(671, 22);
            sfButton2.Name = "sfButton2";
            sfButton2.Size = new Size(96, 28);
            sfButton2.Style.ForeColor = Color.Red;
            sfButton2.TabIndex = 2;
            sfButton2.Text = "Bulletins";
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel4.Location = new Point(17, 20);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            autoLabel4.Size = new Size(204, 25);
            autoLabel4.TabIndex = 1;
            autoLabel4.Text = "Upcoming Schedule";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Location = new Point(448, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 150);
            panel2.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkTurquoise;
            panel4.Location = new Point(1243, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 150);
            panel4.TabIndex = 12;
            // 
            // today1
            // 
            today1.Location = new Point(0, 0);
            today1.Name = "today1";
            today1.Size = new Size(574, 600);
            today1.TabIndex = 0;
            // 
            // MainDashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(materialCard8);
            Controls.Add(materialCard7);
            Controls.Add(materialCard6);
            Controls.Add(materialCard5);
            Controls.Add(materialCard4);
            Controls.Add(autoLabel3);
            Controls.Add(WelcomeLabel);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(ActivityFeedPanel);
            ForeColor = Color.Red;
            Name = "MainDashboardUserControl";
            Size = new Size(1620, 980);
            Load += MainDashboardUserControl_Load;
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            materialCard7.ResumeLayout(false);
            materialCard8.ResumeLayout(false);
            materialCard8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Syncfusion.WinForms.Controls.SfButton BulletinButton;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel WelcomeLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.WinForms.Controls.SfButton ConsultationButton;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.WinForms.Controls.SfButton ThisWeekButton;
        private Syncfusion.WinForms.Controls.SfButton TodayButton;
        public MaterialSkin.Controls.MaterialCard ActivityFeedPanel;
        private Upcoming_Schedule.Today today1;
    }
}
