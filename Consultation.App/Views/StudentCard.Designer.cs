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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 29);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "I.D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 29);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Course ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(690, 29);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Umindanao Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(918, 29);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // button1
            // 
            button1.Location = new Point(1087, 25);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1121, 25);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1153, 25);
            button3.Name = "button3";
            button3.Size = new Size(27, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // StudentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentCard";
            Size = new Size(1295, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
