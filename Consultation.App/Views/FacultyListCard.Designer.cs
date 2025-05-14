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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1295, 70);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1315, 505);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(947, 34);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Total: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Faculty List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 77);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1139, 29);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 3;
            label6.Text = "Actions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 29);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 2;
            label5.Text = "Umindanao Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 29);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 1;
            label4.Text = "I.D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 29);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 0;
            label3.Text = "Faculty Member";
            // 
            // FacultyListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FacultyListCard";
            Size = new Size(1295, 581);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
    }
}
