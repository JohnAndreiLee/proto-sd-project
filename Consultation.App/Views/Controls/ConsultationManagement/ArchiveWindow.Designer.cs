namespace Consultation.App.ConsultationManagement
{
    partial class ArchiveWindow
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
            components = new System.ComponentModel.Container();
            flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flowLayout2 = new Syncfusion.Windows.Forms.Tools.FlowLayout(components);
            WindowPanelArchive = new FlowLayoutPanel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            LabelWindow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flowLayout2).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Archivo SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(20, 19);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(217, 34);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Archived Consultation";
            // 
            // WindowPanelArchive
            // 
            WindowPanelArchive.Location = new Point(0, 71);
            WindowPanelArchive.Name = "WindowPanelArchive";
            WindowPanelArchive.Size = new Size(1434, 682);
            WindowPanelArchive.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialCard2);
            materialCard1.Controls.Add(WindowPanelArchive);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1434, 753);
            materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(LabelWindow);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 0);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1434, 70);
            materialCard2.TabIndex = 2;
            // 
            // LabelWindow
            // 
            LabelWindow.BackColor = Color.Transparent;
            LabelWindow.Font = new Font("Archivo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWindow.Location = new Point(17, 18);
            LabelWindow.Name = "LabelWindow";
            LabelWindow.Size = new Size(203, 31);
            LabelWindow.TabIndex = 0;
            LabelWindow.Text = "Archived Consultation";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Archivo SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(17, 14);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(217, 34);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Archived Consultation";
            // 
            // ArchiveWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "ArchiveWindow";
            Size = new Size(1462, 797);
            ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flowLayout2).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout2;
        public FlowLayoutPanel WindowPanelArchive;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelWindow;
    }
}
