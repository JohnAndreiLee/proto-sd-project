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
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            WindowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
            WindowPanelDesign.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // WindowPanelDesign
            // 
            WindowPanelDesign.BackColor = Color.FromArgb(255, 255, 255);
            WindowPanelDesign.Controls.Add(materialCard2);
            WindowPanelDesign.Controls.Add(WindowPanel);
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
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(guna2HtmlLabel1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 0);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1434, 70);
            materialCard2.TabIndex = 0;
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
            // WindowPanel
            // 
            WindowPanel.Location = new Point(0, 71);
            WindowPanel.Name = "WindowPanel";
            WindowPanel.Size = new Size(1434, 683);
            WindowPanel.TabIndex = 1;
            // 
            // CSWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WindowPanelDesign);
            Name = "CSWindow";
            Size = new Size(1462, 797);
            ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
            WindowPanelDesign.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private MaterialSkin.Controls.MaterialCard WindowPanelDesign;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FlowLayoutPanel WindowPanel;
    }
}
