namespace Consultation.App.Views
{
    partial class LogIn
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
            dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ErrorPassLabel = new Label();
            resultlabel1 = new Label();
            ShowPassButton = new Button();
            label3 = new Label();
            GoogleSignInButton = new Button();
            SignInButton = new Button();
            label2 = new Label();
            PasswordTextBoxV2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            SignInTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            dockingClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBoxV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SignInTextBox).BeginInit();
            SuspendLayout();
            // 
            // dockingClientPanel1
            // 
            dockingClientPanel1.BackgroundImage = Properties.Icons.NewBGV2;
            dockingClientPanel1.Controls.Add(pictureBox3);
            dockingClientPanel1.Controls.Add(pictureBox2);
            dockingClientPanel1.Location = new Point(0, 1);
            dockingClientPanel1.Name = "dockingClientPanel1";
            dockingClientPanel1.Size = new Size(515, 548);
            dockingClientPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Icons.Namelogo_removebg_preview1;
            pictureBox3.Location = new Point(68, 369);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(406, 117);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Icons.Newlogo_againV2_removebg_preview;
            pictureBox2.Location = new Point(128, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 248);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ErrorPassLabel);
            panel1.Controls.Add(resultlabel1);
            panel1.Controls.Add(ShowPassButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GoogleSignInButton);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTextBoxV2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SignInTextBox);
            panel1.Location = new Point(511, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 548);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = Properties.Icons.Gmail_Image_removebg_preview;
            pictureBox1.Location = new Point(140, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // ErrorPassLabel
            // 
            ErrorPassLabel.AutoSize = true;
            ErrorPassLabel.Location = new Point(39, 211);
            ErrorPassLabel.Name = "ErrorPassLabel";
            ErrorPassLabel.Size = new Size(0, 15);
            ErrorPassLabel.TabIndex = 17;
            // 
            // resultlabel1
            // 
            resultlabel1.AutoSize = true;
            resultlabel1.BackColor = Color.Transparent;
            resultlabel1.Location = new Point(39, 79);
            resultlabel1.Name = "resultlabel1";
            resultlabel1.Size = new Size(0, 15);
            resultlabel1.TabIndex = 16;
            // 
            // ShowPassButton
            // 
            ShowPassButton.Image = Properties.Icons.Untitled_design;
            ShowPassButton.Location = new Point(403, 203);
            ShowPassButton.Name = "ShowPassButton";
            ShowPassButton.Size = new Size(32, 23);
            ShowPassButton.TabIndex = 15;
            ShowPassButton.UseVisualStyleBackColor = true;
            ShowPassButton.Click += ShowPassButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(94, 353);
            label3.Name = "label3";
            label3.Size = new Size(316, 21);
            label3.TabIndex = 7;
            label3.Text = "------------------------Or------------------------";
            // 
            // GoogleSignInButton
            // 
            GoogleSignInButton.BackColor = Color.LimeGreen;
            GoogleSignInButton.FlatStyle = FlatStyle.Popup;
            GoogleSignInButton.Font = new Font("Microsoft Sans Serif", 12F);
            GoogleSignInButton.ForeColor = Color.White;
            GoogleSignInButton.ImageAlign = ContentAlignment.TopRight;
            GoogleSignInButton.Location = new Point(140, 391);
            GoogleSignInButton.Name = "GoogleSignInButton";
            GoogleSignInButton.Size = new Size(218, 53);
            GoogleSignInButton.TabIndex = 6;
            GoogleSignInButton.Text = "              Log In with Google";
            GoogleSignInButton.UseVisualStyleBackColor = false;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Brown;
            SignInButton.FlatStyle = FlatStyle.Popup;
            SignInButton.Font = new Font("Microsoft Sans Serif", 12F);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(156, 287);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(183, 40);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Log In";
            SignInButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(28, 154);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // PasswordTextBoxV2
            // 
            PasswordTextBoxV2.BackColor = Color.Transparent;
            PasswordTextBoxV2.BeforeTouchSize = new Size(418, 43);
            PasswordTextBoxV2.Font = new Font("Segoe UI", 12F);
            PasswordTextBoxV2.Location = new Point(28, 194);
            PasswordTextBoxV2.Multiline = true;
            PasswordTextBoxV2.Name = "PasswordTextBoxV2";
            PasswordTextBoxV2.PasswordChar = '●';
            PasswordTextBoxV2.Size = new Size(418, 43);
            PasswordTextBoxV2.TabIndex = 2;
            PasswordTextBoxV2.TextChanged += PasswordTextBoxV2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(232, 22);
            label1.TabIndex = 1;
            label1.Text = "Umindanao E-mail Address:";
            // 
            // SignInTextBox
            // 
            SignInTextBox.BackColor = Color.Transparent;
            SignInTextBox.BeforeTouchSize = new Size(418, 43);
            SignInTextBox.Font = new Font("Segoe UI", 12F);
            SignInTextBox.Location = new Point(28, 90);
            SignInTextBox.Multiline = true;
            SignInTextBox.Name = "SignInTextBox";
            SignInTextBox.Size = new Size(418, 43);
            SignInTextBox.TabIndex = 0;
            SignInTextBox.TextChanged += SignInTextBox_TextChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(995, 542);
            Controls.Add(panel1);
            Controls.Add(dockingClientPanel1);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            dockingClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBoxV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SignInTextBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTextBoxV2;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SignInTextBox;
        private Label label2;
        private Button SignInButton;
        private Button GoogleSignInButton;
        private Label label3;
        private Button ShowPassButton;
        private Label ErrorPassLabel;
        private Label resultlabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}