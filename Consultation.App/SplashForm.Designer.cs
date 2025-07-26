namespace Consultation.App
{
    partial class SplashForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Red, Color.Orange);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Location = new Point(-2, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(999, 543);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Icons.SampleSplash2_removebg_preview;
            pictureBox1.Location = new Point(332, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 381);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 542);
            Controls.Add(gradientPanel1);
            Name = "SplashForm";
            Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
    }
}