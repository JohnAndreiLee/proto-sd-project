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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ErrorPassLabel = new Label();
            resultlabel1 = new Label();
            ShowPassButton = new Button();
            ForgotPasswordButton = new Button();
            SystemBtn = new Button();
            ReqBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            GoogleSignInButton = new Button();
            SignInButton = new Button();
            RememberMeCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            label2 = new Label();
            PasswordTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            EmailTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            dockingClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RememberMeCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox).BeginInit();
            SuspendLayout();
            // 
            // dockingClientPanel1
            // 
            dockingClientPanel1.BackgroundImage = Properties.Icons.RedBg_1_;
            dockingClientPanel1.Controls.Add(pictureBox1);
            dockingClientPanel1.Controls.Add(panel1);
            dockingClientPanel1.Location = new Point(-23, 0);
            dockingClientPanel1.Name = "dockingClientPanel1";
            dockingClientPanel1.Size = new Size(1940, 1080);
            dockingClientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Icons.Untitled__Logo_;
            pictureBox1.Location = new Point(23, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(872, 987);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(ErrorPassLabel);
            panel1.Controls.Add(resultlabel1);
            panel1.Controls.Add(ShowPassButton);
            panel1.Controls.Add(ForgotPasswordButton);
            panel1.Controls.Add(SystemBtn);
            panel1.Controls.Add(ReqBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GoogleSignInButton);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(RememberMeCheckBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EmailTextBox);
            panel1.Location = new Point(1180, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 849);
            panel1.TabIndex = 0;
            // 
            // ErrorPassLabel
            // 
            ErrorPassLabel.AutoSize = true;
            ErrorPassLabel.Location = new Point(69, 283);
            ErrorPassLabel.Name = "ErrorPassLabel";
            ErrorPassLabel.Size = new Size(0, 15);
            ErrorPassLabel.TabIndex = 17;
            // 
            // resultlabel1
            // 
            resultlabel1.AutoSize = true;
            resultlabel1.BackColor = Color.Transparent;
            resultlabel1.Location = new Point(69, 151);
            resultlabel1.Name = "resultlabel1";
            resultlabel1.Size = new Size(0, 15);
            resultlabel1.TabIndex = 16;
            // 
            // ShowPassButton
            // 
            ShowPassButton.Image = Properties.Icons.Untitled_design;
            ShowPassButton.Location = new Point(485, 275);
            ShowPassButton.Name = "ShowPassButton";
            ShowPassButton.Size = new Size(32, 23);
            ShowPassButton.TabIndex = 15;
            ShowPassButton.UseVisualStyleBackColor = true;
            ShowPassButton.Click += ShowPassButton_Click;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.BackColor = Color.Transparent;
            ForgotPasswordButton.FlatAppearance.BorderSize = 0;
            ForgotPasswordButton.FlatStyle = FlatStyle.Flat;
            ForgotPasswordButton.ForeColor = Color.Red;
            ForgotPasswordButton.Location = new Point(411, 331);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(117, 23);
            ForgotPasswordButton.TabIndex = 14;
            ForgotPasswordButton.Text = "Forgot Password?";
            ForgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // SystemBtn
            // 
            SystemBtn.BackColor = Color.Brown;
            SystemBtn.FlatStyle = FlatStyle.Flat;
            SystemBtn.Font = new Font("Microsoft Sans Serif", 12F);
            SystemBtn.ForeColor = Color.White;
            SystemBtn.Location = new Point(311, 647);
            SystemBtn.Name = "SystemBtn";
            SystemBtn.Size = new Size(197, 40);
            SystemBtn.TabIndex = 13;
            SystemBtn.Text = "System Status";
            SystemBtn.UseVisualStyleBackColor = false;
            // 
            // ReqBtn
            // 
            ReqBtn.BackColor = Color.Brown;
            ReqBtn.FlatStyle = FlatStyle.Flat;
            ReqBtn.Font = new Font("Microsoft Sans Serif", 12F);
            ReqBtn.ForeColor = Color.White;
            ReqBtn.Location = new Point(97, 647);
            ReqBtn.Name = "ReqBtn";
            ReqBtn.Size = new Size(197, 40);
            ReqBtn.TabIndex = 12;
            ReqBtn.Text = "Request Access";
            ReqBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(114, 583);
            label4.Name = "label4";
            label4.Size = new Size(378, 21);
            label4.TabIndex = 9;
            label4.Text = "------------------------Need Help?------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(143, 468);
            label3.Name = "label3";
            label3.Size = new Size(316, 21);
            label3.TabIndex = 7;
            label3.Text = "------------------------Or------------------------";
            // 
            // GoogleSignInButton
            // 
            GoogleSignInButton.BackColor = Color.Brown;
            GoogleSignInButton.FlatStyle = FlatStyle.Flat;
            GoogleSignInButton.Font = new Font("Microsoft Sans Serif", 12F);
            GoogleSignInButton.ForeColor = Color.White;
            GoogleSignInButton.Location = new Point(97, 509);
            GoogleSignInButton.Name = "GoogleSignInButton";
            GoogleSignInButton.Size = new Size(411, 40);
            GoogleSignInButton.TabIndex = 6;
            GoogleSignInButton.Text = "Log In with Google";
            GoogleSignInButton.UseVisualStyleBackColor = false;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Brown;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Microsoft Sans Serif", 12F);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(201, 396);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(197, 40);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Log In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // RememberMeCheckBox
            // 
            RememberMeCheckBox.AccessibilityEnabled = true;
            RememberMeCheckBox.Location = new Point(58, 331);
            RememberMeCheckBox.Name = "RememberMeCheckBox";
            RememberMeCheckBox.Size = new Size(150, 21);
            RememberMeCheckBox.TabIndex = 4;
            RememberMeCheckBox.Text = "Remember Me?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(58, 226);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BeforeTouchSize = new Size(470, 43);
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.Location = new Point(58, 266);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '●';
            PasswordTextBox.Size = new Size(470, 43);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextChanged += PasswordTextBoxV2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(58, 103);
            label1.Name = "label1";
            label1.Size = new Size(285, 26);
            label1.TabIndex = 1;
            label1.Text = "Umindanao E-mail Address:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.Transparent;
            EmailTextBox.BeforeTouchSize = new Size(470, 43);
            EmailTextBox.Font = new Font("Segoe UI", 12F);
            EmailTextBox.Location = new Point(58, 136);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(470, 43);
            EmailTextBox.TabIndex = 0;
            EmailTextBox.TextChanged += SignInTextBox_TextChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1924, 1041);
            Controls.Add(dockingClientPanel1);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            dockingClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RememberMeCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTextBox;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt EmailTextBox;
        private Label label2;
        private Button SignInButton;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv RememberMeCheckBox;
        private Button GoogleSignInButton;
        private Label label3;
        private Button SystemBtn;
        private Button ReqBtn;
        private Label label4;
        private Button ForgotPasswordButton;
        private Button ShowPassButton;
        private Label ErrorPassLabel;
        private Label resultlabel1;
    }
}