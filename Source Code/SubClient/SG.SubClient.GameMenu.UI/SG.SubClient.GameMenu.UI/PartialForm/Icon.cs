using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing.Drawing2D;

namespace SG.SubClient.GameMenu.UI.PartialForm
{
    public partial class Icon : BunifuImageButton
    {
        public Icon()
        {
            InitializeComponent();
            this.Image = null;
        }

        public Icon(Point location, Image BackgroundImage, Size size)
        {
            InitializeComponent();
            this.Image = null;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(BackgroundImage));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageActive = null;
            this.Location = location;//new System.Drawing.Point(18, 9);new System.Drawing.Point(129, 9);..3..;new System.Drawing.Point(576, 9);
                                     //new System.Drawing.Point(18, 115);..4..;new System.Drawing.Point(576, 115);
            this.Name = "icon1";
            this.Size = size;//new System.Drawing.Size(85, 85);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TabIndex = 0;
            this.TabStop = false;
            this.Zoom = 10;
            //Label label = new Label();
            //label.Location = new Point(0, 0);
            //label.Text = "GAME";
            //label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 50);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                pe.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
