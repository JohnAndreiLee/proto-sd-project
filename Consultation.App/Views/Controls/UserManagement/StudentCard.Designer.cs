namespace Consultation.App.Views
{
    partial class StudentCard
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
            lblName = new Label();
            lblID = new Label();
            lblEmail = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(166, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Student Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(515, 23);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 1;
            lblID.Text = "I.D";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(753, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(127, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Umindanao Email";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Icons.person_b;
            pictureBox3.Location = new Point(24, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1087, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // StudentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(lblEmail);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentCard";
            Size = new Size(1267, 70);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblID;
        private Label lblEmail;
        private PictureBox pictureBox3;
        private Button button1;
    }
}
