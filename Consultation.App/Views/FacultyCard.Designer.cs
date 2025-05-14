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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1073, 25);
            button1.Name = "button1";
            button1.Size = new Size(29, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1108, 25);
            button2.Name = "button2";
            button2.Size = new Size(32, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1146, 25);
            button3.Name = "button3";
            button3.Size = new Size(36, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Faculty Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 29);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 4;
            label2.Text = "I.D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 29);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Umindanao Email";
            // 
            // FacultyCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FacultyCard";
            Size = new Size(1295, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
