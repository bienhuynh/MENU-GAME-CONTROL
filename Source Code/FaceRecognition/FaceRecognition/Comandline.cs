using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class Comandline : FormMaster
    {
        private SetCommandLine _execCMD = new SetCommandLine();
        public MenuControlParameter _frmControl = new MenuControlParameter();
        private string NameCMD = "HCB>";
        private int lenghtCMD = 0;
        public Comandline()
        {
            InitializeComponent();
            _frmControl.frmThis = this;
            this.TopMost = true;
            lenghtCMD = NameCMD.Length;
        }
        public void Setup()
        {
            if (_frmControl != null)
            {
                _frmControl.frmThis = this;
                _execCMD._frmControl = _frmControl;
            }
        }
        public void DrawCursorsOnForm(Cursor cursor)
        {
            // If the form's cursor is not the Hand cursor and the 
            // Current cursor is the Default, Draw the specified 
            // cursor on the form in normal size and twice normal size.
            if (this.Cursor == Cursors.IBeam || this.Cursor == Cursors.Default)
            {
                // Draw the cursor stretched.
                Graphics graphics = this.CreateGraphics();
                Pen p = new Pen(Color.DarkOrange);
                Rectangle rectangle = new Rectangle(
                  new Point(10, 10), new Size(cursor.Size.Width * 4,
                  cursor.Size.Height * 2));
                cursor.DrawStretched(graphics, rectangle);
                
                // Draw the cursor in normal size.
                rectangle.Location = new Point(
                rectangle.Width + rectangle.Location.X,
                  rectangle.Height + rectangle.Location.Y);
                rectangle.Size = cursor.Size;

                graphics.DrawRectangle(p, rectangle);
                cursor.Draw(graphics, rectangle);
                // Dispose of the cursor.
                //cursor.Dispose();
            }
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCommandline_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back)
            {
                int currentLine = richtextCommandline.GetLineFromCharIndex(richtextCommandline.SelectionStart);
                if (richtextCommandline.Lines[currentLine] == NameCMD) e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.A && e.KeyCode == Keys.Back)
            {
                richtextCommandline.Text = NameCMD;
            }
            if(e.KeyCode == Keys.Left)
            {
                int currentLine = richtextCommandline.GetLineFromCharIndex(richtextCommandline.SelectionStart);
                int legnht = richtextCommandline.SelectionStart, count = 0;
                for (int i = 0; i < currentLine; i++)
                    count += richtextCommandline.Lines[i].Length;
                legnht = legnht - count - lenghtCMD - currentLine;
                if (legnht <= lenghtCMD)
                {
                    richtextCommandline.SelectionStart = count + lenghtCMD + currentLine;
                    e.Handled = true;
                }
                    
            }
            
            if (e.KeyData == Keys.Enter)
            {
                int currentLine = richtextCommandline.GetLineFromCharIndex(richtextCommandline.SelectionStart);
                string line = richtextCommandline.Lines[currentLine];
                e.Handled = true;
                line = line.Trim();
                if (line != null) line = line.Substring(lenghtCMD);
                _execCMD.SetKeyCMD(line);
                if (!_execCMD.EXEC()) richtextCommandline.Text = richtextCommandline.Text + "\nNot found Command!";
                if (_frmControl.frmCommandLine != null)
                    if (_frmControl.frmCommandLine.richtextCommandline != null) 
                        if (_frmControl.frmCommandLine.richtextCommandline.IsDisposed != true)
                        {
                            richtextCommandline.Text = richtextCommandline.Text + "\n" + NameCMD;
                            richtextCommandline.SelectionStart = richtextCommandline.Text.Length;
                            richtextCommandline.Focus();
                        }
            }
        }

        private void txtCommandline_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                richtextCommandline.SelectionStart = richtextCommandline.SelectionStart + lenghtCMD;
            }
        }

        private void richtextCommandline_Click(object sender, EventArgs e)
        {
            int currentLine = richtextCommandline.GetLineFromCharIndex(richtextCommandline.SelectionStart);
            if (richtextCommandline.Lines[currentLine].Length <= lenghtCMD) ;
        }

        private void btnFullSceen_Click(object sender, EventArgs e)
        {

        }
    }
}
