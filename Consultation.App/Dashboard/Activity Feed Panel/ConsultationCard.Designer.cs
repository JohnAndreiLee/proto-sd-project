namespace Consultation.App.Dashboard.Activity_Feed_Panel
{
    partial class ConsultationCard
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
            BulletinTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            SuspendLayout();
            // 
            // BulletinTitle
            // 
            BulletinTitle.Location = new Point(36, 25);
            BulletinTitle.Name = "BulletinTitle";
            BulletinTitle.Size = new Size(65, 15);
            BulletinTitle.TabIndex = 0;
            BulletinTitle.Text = "autoLabel1";
            // 
            // autoLabel1
            // 
            autoLabel1.Location = new Point(36, 58);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(65, 15);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "autoLabel1";
            // 
            // ConsultationCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(autoLabel1);
            Controls.Add(BulletinTitle);
            Name = "ConsultationCard";
            Size = new Size(840, 170);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel BulletinTitle;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
