using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Dashboard.Activity_Feed_Panel
{
    public partial class ConsultationCards : UserControl
    {
        public ConsultationCards(string consultationtitle, string consultationstatus, string consultationbody, string consultationdepartment, DateTime consultationdateScheduled)
        {
            InitializeComponent();

            this.MouseEnter += OnHoverEnter;
            this.MouseLeave += OnHoverLeave;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += OnHoverEnter;
                ctrl.MouseLeave += OnHoverLeave;
            }

            ApplyRoundedCorners(15);

             ConsultationTitle.Text = consultationtitle;
             ConsultationStatusLabel.Text = consultationstatus;
             ConsultationBody.Text = consultationbody;
             ConsultationDepartment.Text = consultationdepartment;
             ConsultationDate.Text = consultationdateScheduled.ToString("MMM dd, yyyy");

             UpdateStatusAppearance();
        }

        private void OnHoverEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            this.Cursor = Cursors.Hand;
        }

        private void OnHoverLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.Cursor = Cursors.Default;
        }

        private void ApplyRoundedCorners(int radius)
        {
            Rectangle bounds = this.ClientRectangle;
            int diameter = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private void UpdateStatusAppearance()
        {
            string status = ConsultationStatusLabel.Text.Trim();

            if (string.Equals(status, "Pending", StringComparison.OrdinalIgnoreCase))
            {
                ConsultationStatusPanel.FillColor = Color.Firebrick;
                ConsultationStatusLabel.ForeColor = Color.White;
                ConsultationStatusLabel.BackColor = Color.Firebrick;
                ConsultationStatusLabel.Font = new Font(
                    ConsultationStatusLabel.Font.FontFamily,
                    ConsultationStatusLabel.Font.Size,
                    FontStyle.Bold | FontStyle.Italic
                );
            }
            else if (string.Equals(status, "Approved", StringComparison.OrdinalIgnoreCase))
            {
                ConsultationStatusPanel.FillColor = Color.LightGreen;
                ConsultationStatusLabel.ForeColor = Color.Black;
                ConsultationStatusLabel.BackColor = Color.LightGreen;
                ConsultationStatusLabel.Font = new Font(
                    ConsultationStatusLabel.Font.FontFamily,
                    ConsultationStatusLabel.Font.Size,
                    FontStyle.Bold | FontStyle.Italic
                );
            }
        }
    }
}
