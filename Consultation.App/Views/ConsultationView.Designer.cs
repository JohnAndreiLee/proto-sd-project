namespace Consultation.App.ConsultationManagement
{
    partial class ConsultationView
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            underlinePanel = new Panel();
            btnArchive = new Guna.UI2.WinForms.Guna2Button();
            btnConsultation = new Guna.UI2.WinForms.Guna2Button();
            WindowPanelConsultation = new FlowLayoutPanel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnRefresh);
            materialCard2.Controls.Add(underlinePanel);
            materialCard2.Controls.Add(btnArchive);
            materialCard2.Controls.Add(btnConsultation);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(29, 23);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1600, 80);
            materialCard2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderColor = Color.Red;
            btnRefresh.BorderRadius = 8;
            btnRefresh.BorderThickness = 1;
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.DarkRed;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Icons.images_removebg_preview;
            btnRefresh.ImageAlign = HorizontalAlignment.Left;
            btnRefresh.ImageSize = new Size(15, 15);
            btnRefresh.Location = new Point(1460, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PressedColor = Color.FromArgb(255, 128, 128);
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(97, 36);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextOffset = new Point(10, 0);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // underlinePanel
            // 
            underlinePanel.BackColor = Color.Red;
            underlinePanel.Location = new Point(15, 68);
            underlinePanel.Name = "underlinePanel";
            underlinePanel.Size = new Size(235, 5);
            underlinePanel.TabIndex = 4;
            underlinePanel.Visible = false;
            // 
            // btnArchive
            // 
            btnArchive.BorderColor = Color.Transparent;
            btnArchive.CustomizableEdges = customizableEdges3;
            btnArchive.DisabledState.BorderColor = Color.DarkGray;
            btnArchive.DisabledState.CustomBorderColor = Color.DarkGray;
            btnArchive.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnArchive.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnArchive.FillColor = Color.Transparent;
            btnArchive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArchive.ForeColor = Color.DimGray;
            btnArchive.Location = new Point(158, 9);
            btnArchive.Name = "btnArchive";
            btnArchive.PressedColor = Color.Transparent;
            btnArchive.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnArchive.Size = new Size(92, 53);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive";
            btnArchive.Click += btnArchive_Click;
            // 
            // btnConsultation
            // 
            btnConsultation.BorderColor = Color.Transparent;
            btnConsultation.CustomizableEdges = customizableEdges5;
            btnConsultation.DisabledState.BorderColor = Color.DarkGray;
            btnConsultation.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConsultation.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConsultation.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConsultation.FillColor = Color.Transparent;
            btnConsultation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultation.ForeColor = Color.DimGray;
            btnConsultation.Location = new Point(15, 9);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.PressedColor = Color.Transparent;
            btnConsultation.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnConsultation.Size = new Size(142, 53);
            btnConsultation.TabIndex = 2;
            btnConsultation.Text = "Consultation";
            btnConsultation.Click += btnConsultation_Click_1;
            // 
            // WindowPanelConsultation
            // 
            WindowPanelConsultation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WindowPanelConsultation.Location = new Point(98, 136);
            WindowPanelConsultation.Name = "WindowPanelConsultation";
            WindowPanelConsultation.Size = new Size(1462, 797);
            WindowPanelConsultation.TabIndex = 3;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ConsultationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1658, 961);
            Controls.Add(WindowPanelConsultation);
            Controls.Add(materialCard2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultationView";
            Text = "ConsultationWindow";
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnConsultation;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel underlinePanel;
        private Guna.UI2.WinForms.Guna2Button btnArchive;
        private FlowLayoutPanel WindowPanelConsultation;
        private ConsultationCard consultationCard1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}