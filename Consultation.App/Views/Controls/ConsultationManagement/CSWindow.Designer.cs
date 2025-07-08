namespace Consultation.App.ConsultationManagement
{
    partial class CSWindow
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
            WindowPanelDesign = new MaterialSkin.Controls.MaterialCard();
            WindowPanelConsultation = new FlowLayoutPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelWindow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
            WindowPanelDesign.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // WindowPanelDesign
            // 
            WindowPanelDesign.BackColor = Color.FromArgb(255, 255, 255);
            WindowPanelDesign.Controls.Add(WindowPanelConsultation);
            WindowPanelDesign.Depth = 0;
            WindowPanelDesign.ForeColor = Color.FromArgb(222, 0, 0, 0);
            WindowPanelDesign.Location = new Point(14, 15);
            WindowPanelDesign.Margin = new Padding(14);
            WindowPanelDesign.MouseState = MaterialSkin.MouseState.HOVER;
            WindowPanelDesign.Name = "WindowPanelDesign";
            WindowPanelDesign.Padding = new Padding(14);
            WindowPanelDesign.Size = new Size(1434, 754);
            WindowPanelDesign.TabIndex = 0;
            // 
            // WindowPanelConsultation
            // 
            WindowPanelConsultation.AutoScroll = true;
            WindowPanelConsultation.Location = new Point(0, 71);
            WindowPanelConsultation.Name = "WindowPanelConsultation";
            WindowPanelConsultation.Size = new Size(1434, 683);
            WindowPanelConsultation.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Archivo SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(25, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(192, 34);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Active Consultation";
            // 
            // LabelWindow
            // 
            LabelWindow.BackColor = Color.Transparent;
            LabelWindow.Font = new Font("Archivo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWindow.Location = new Point(17, 18);
            LabelWindow.Name = "LabelWindow";
            LabelWindow.Size = new Size(179, 31);
            LabelWindow.TabIndex = 0;
            LabelWindow.Text = "Active Consultation";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LabelWindow);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 15);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1434, 70);
            materialCard1.TabIndex = 2;
            // 
            // CSWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Controls.Add(WindowPanelDesign);
            Name = "CSWindow";
            Size = new Size(1462, 797);
            ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
            WindowPanelDesign.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private MaterialSkin.Controls.MaterialCard WindowPanelDesign;
        private FlowLayoutPanel WindowPanelConsultation;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelWindow;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
