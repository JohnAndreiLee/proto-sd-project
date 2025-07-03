namespace Consultation.App.Views
{
    partial class FacultyCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyCard));
            lblFacM = new Label();
            lblIDFM = new Label();
            lblEmailFM = new Label();
            lblStatusFM = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFacM
            // 
            lblFacM.AutoSize = true;
            lblFacM.Location = new Point(79, 32);
            lblFacM.Name = "lblFacM";
            lblFacM.Size = new Size(98, 20);
            lblFacM.TabIndex = 3;
            lblFacM.Text = "Faculty Name";
            // 
            // lblIDFM
            // 
            lblIDFM.AutoSize = true;
            lblIDFM.Location = new Point(304, 32);
            lblIDFM.Name = "lblIDFM";
            lblIDFM.Size = new Size(27, 20);
            lblIDFM.TabIndex = 4;
            lblIDFM.Text = "I.D";
            // 
            // lblEmailFM
            // 
            lblEmailFM.AutoSize = true;
            lblEmailFM.Location = new Point(488, 32);
            lblEmailFM.Name = "lblEmailFM";
            lblEmailFM.Size = new Size(107, 20);
            lblEmailFM.TabIndex = 5;
            lblEmailFM.Text = " Email Address";
            // 
            // lblStatusFM
            // 
            lblStatusFM.AutoSize = true;
            lblStatusFM.Location = new Point(757, 32);
            lblStatusFM.Name = "lblStatusFM";
            lblStatusFM.Size = new Size(35, 20);
            lblStatusFM.TabIndex = 6;
            lblStatusFM.Text = "role";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1089, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1004, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(918, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FacultyCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblStatusFM);
            Controls.Add(lblEmailFM);
            Controls.Add(lblIDFM);
            Controls.Add(lblFacM);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FacultyCard";
            Size = new Size(1285, 82);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFacM;
        private Label lblIDFM;
        private Label lblEmailFM;
        private Label lblStatusFM;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
