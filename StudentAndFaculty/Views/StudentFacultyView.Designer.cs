namespace Consultation.App.Views
{
    partial class StudentFacultyView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanelstudafac = new FlowLayoutPanel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            BtnFaculty = new Button();
            BtnStudents = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(flowLayoutPanelstudafac);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BtnFaculty);
            panel1.Controls.Add(BtnStudents);
            panel1.Location = new Point(352, 260);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1396, 720);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanelstudafac
            // 
            flowLayoutPanelstudafac.BackColor = SystemColors.Control;
            flowLayoutPanelstudafac.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelstudafac.Location = new Point(45, 145);
            flowLayoutPanelstudafac.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelstudafac.Name = "flowLayoutPanelstudafac";
            flowLayoutPanelstudafac.Size = new Size(1295, 775);
            flowLayoutPanelstudafac.TabIndex = 6;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(632, 68);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 28);
            comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(451, 68);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(277, 68);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 68);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 2;
            // 
            // BtnFaculty
            // 
            BtnFaculty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFaculty.Location = new Point(143, 17);
            BtnFaculty.Margin = new Padding(3, 4, 3, 4);
            BtnFaculty.Name = "BtnFaculty";
            BtnFaculty.Size = new Size(86, 31);
            BtnFaculty.TabIndex = 1;
            BtnFaculty.Text = "Faculty";
            BtnFaculty.UseVisualStyleBackColor = true;
            BtnFaculty.Click += BtnFaculty_Click;
            // 
            // BtnStudents
            // 
            BtnStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStudents.Location = new Point(39, 17);
            BtnStudents.Margin = new Padding(3, 4, 3, 4);
            BtnStudents.Name = "BtnStudents";
            BtnStudents.Size = new Size(86, 31);
            BtnStudents.TabIndex = 0;
            BtnStudents.Text = "Students";
            BtnStudents.UseVisualStyleBackColor = true;
            BtnStudents.Click += BtnStudents_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(352, 143);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 98);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 52);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Students";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(733, 143);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 98);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 52);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 1;
            label5.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 20);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 0;
            label4.Text = "Faculty Members";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkRed;
            panel4.Location = new Point(1, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 1440);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label7);
            panel5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(333, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1895, 133);
            panel5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 9);
            label7.Name = "label7";
            label7.Size = new Size(825, 106);
            label7.TabIndex = 0;
            label7.Text = "Students and Faculty";
            // 
            // StudentFacultyView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentFacultyView";
            Text = "Form1";
            Load += StudentFacultyView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button BtnFaculty;
        private Button BtnStudents;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanelstudafac;
    }
}
