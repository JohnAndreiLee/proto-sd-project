namespace Consultation.App.ConsultationManagement
{
    partial class ConsultationCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LabelCourse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            LabelDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LabelTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DateDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            materialCard1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LabelCourse);
            materialCard1.Controls.Add(LabelName);
            materialCard1.Controls.Add(guna2Panel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(30);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(0, 50, 0, 50);
            materialCard1.RightToLeft = RightToLeft.No;
            materialCard1.Size = new Size(1500, 200);
            materialCard1.TabIndex = 0;
            // 
            // LabelCourse
            // 
            LabelCourse.BackColor = Color.Transparent;
            LabelCourse.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCourse.ForeColor = Color.DimGray;
            LabelCourse.Location = new Point(207, 60);
            LabelCourse.Name = "LabelCourse";
            LabelCourse.Size = new Size(142, 24);
            LabelCourse.TabIndex = 2;
            LabelCourse.Text = "CPE 325 - L (7605)";
            // 
            // LabelName
            // 
            LabelName.BackColor = Color.Transparent;
            LabelName.Font = new Font("Archivo Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelName.Location = new Point(207, 25);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(188, 34);
            LabelName.TabIndex = 1;
            LabelName.Text = "Stephen Neil Garde";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(LabelDate);
            guna2Panel1.Controls.Add(LabelTime);
            guna2Panel1.Controls.Add(DateDay);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.FillColor = Color.LightGray;
            guna2Panel1.Location = new Point(24, 28);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Color = Color.Gray;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.ShadowDecoration.Depth = 0;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(170, 141);
            guna2Panel1.TabIndex = 0;
            // 
            // LabelDate
            // 
            LabelDate.BackColor = Color.Transparent;
            LabelDate.Font = new Font("Inter ExtraLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDate.Location = new Point(34, 107);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(99, 20);
            LabelDate.TabIndex = 2;
            LabelDate.Text = "May 05, 2025";
            LabelDate.TextAlignment = ContentAlignment.BottomCenter;
            // 
            // LabelTime
            // 
            LabelTime.BackColor = Color.Transparent;
            LabelTime.Font = new Font("Archivo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTime.Location = new Point(13, 45);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(147, 50);
            LabelTime.TabIndex = 1;
            LabelTime.Text = "10:30 AM";
            LabelTime.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // DateDay
            // 
            DateDay.BackColor = Color.Transparent;
            DateDay.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateDay.ForeColor = Color.DeepSkyBlue;
            DateDay.Location = new Point(61, 13);
            DateDay.Name = "DateDay";
            DateDay.Size = new Size(43, 20);
            DateDay.TabIndex = 0;
            DateDay.Text = "Today";
            DateDay.TextAlignment = ContentAlignment.TopCenter;
            // 
            // ConsultationCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "ConsultationCard";
            Size = new Size(1500, 200);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel DateDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelCourse;
    }
}
