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
            lblFacM = new Label();
            lblIDFM = new Label();
            lblEmailFM = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblFacM
            // 
            lblFacM.AutoSize = true;
            lblFacM.Location = new Point(166, 23);
            lblFacM.Name = "lblFacM";
            lblFacM.Size = new Size(98, 20);
            lblFacM.TabIndex = 3;
            lblFacM.Text = "Faculty Name";
            // 
            // lblIDFM
            // 
            lblIDFM.AutoSize = true;
            lblIDFM.Location = new Point(515, 23);
            lblIDFM.Name = "lblIDFM";
            lblIDFM.Size = new Size(27, 20);
            lblIDFM.TabIndex = 4;
            lblIDFM.Text = "I.D";
            // 
            // lblEmailFM
            // 
            lblEmailFM.AutoSize = true;
            lblEmailFM.Location = new Point(753, 23);
            lblEmailFM.Name = "lblEmailFM";
            lblEmailFM.Size = new Size(107, 20);
            lblEmailFM.TabIndex = 5;
            lblEmailFM.Text = " Email Address";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Icons.person_b;
            pictureBox3.Location = new Point(24, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1087, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // FacultyCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(lblEmailFM);
            Controls.Add(lblIDFM);
            Controls.Add(lblFacM);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FacultyCard";
            Size = new Size(1267, 70);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFacM;
        private Label lblIDFM;
        private Label lblEmailFM;
        private PictureBox pictureBox3;
        private Button button1;
    }
}
