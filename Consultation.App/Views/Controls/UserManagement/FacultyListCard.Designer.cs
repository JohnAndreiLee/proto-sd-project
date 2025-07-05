namespace Student_Faculty
{
    partial class FacultyListCard
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
            panel2 = new Panel();
            label8 = new Label();
            label5 = new Label();
            lblIDFM = new Label();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblIDFM);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 70);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1087, 23);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 6;
            label8.Text = "Actions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(753, 23);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 2;
            label5.Text = " Email Address\r\n";
            // 
            // lblIDFM
            // 
            lblIDFM.AutoSize = true;
            lblIDFM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDFM.Location = new Point(515, 23);
            lblIDFM.Name = "lblIDFM";
            lblIDFM.Size = new Size(25, 20);
            lblIDFM.TabIndex = 1;
            lblIDFM.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 23);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Faculty Name\r\n";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(3, 81);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1264, 442);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // FacultyListCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FacultyListCard";
            Size = new Size(1270, 526);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblIDFM;
        private Label label3;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label8;
    }
}
