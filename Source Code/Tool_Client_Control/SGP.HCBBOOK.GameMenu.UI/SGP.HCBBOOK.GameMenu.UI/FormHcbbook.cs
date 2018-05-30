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

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class FormHcbbook : Form
    {
        bool canMove = false;
        Point formLocation;
        bool IsHidePnlmenu = true;
        public bool maximum = false;

        public FormHcbbook()
        {
            InitializeComponent();
            lblTitle.BringToFront();
            RenameTitleForm("Title");
        }
        public void RenameTitleForm(string text)
        {
            lblTitle.Text = text;
            locationTitleForm();
        }
        public void locationTitleForm()
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            btn_exit.Left = this.Width - 20;
            btn_maxisize.Left = this.Width - 40;
            btn_minisize.Left = this.Width - 60;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point[] pontos =
            {
                new Point((int)(this.Width*0.1),0),
                new Point((int)(this.Width*0.9),0),
                new Point((int)(this.Width*0.86),20),
                new Point((int)(this.Width*0.14),20)
            };
            GraphicsPath poly = new GraphicsPath();
            poly.AddPolygon(pontos);
            border_top.Region = new Region(poly);

            Pen borda = new Pen(Color.White, 4);
            e.Graphics.DrawPolygon(borda, pontos);
        }

        private void border_top_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            formLocation = e.Location;
        }

        private void border_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                int x = formLocation.X - e.Location.X;
                int y = formLocation.Y - e.Location.Y;
                Location = new Point(Location.X - x, Location.Y - y);
            }
        }

        private void border_top_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
        }

        private void FormMaster_Click(object sender, EventArgs e)
        {
            if (!IsHidePnlmenu)
            {
                IsHidePnlmenu = !IsHidePnlmenu;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormMaster_ResizeBegin(object sender, EventArgs e)
        {
            locationTitleForm();
        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maxisize_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/huynhcaobien96");
        }

        private void FormHcbbook_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelSGP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://124.158.13.36:81");
        }
    }
}
