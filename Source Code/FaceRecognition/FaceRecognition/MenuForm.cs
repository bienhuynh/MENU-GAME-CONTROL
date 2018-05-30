using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class MenuForm : UserControl
    {
        public MenuControlParameter _controlParameter = new MenuControlParameter();
        
        private bool drag;
        private Point p0;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void commandLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._controlParameter.frmCommandLine = new Comandline();
            this._controlParameter.frmCommandLine._frmControl = this._controlParameter;
            this._controlParameter.frmCommandLine.Setup();
            
            this._controlParameter.frmCommandLine.Show();
        }
        
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            p0 = e.Location;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag && e.Button == MouseButtons.Left)
                this._controlParameter.frmThis.Location = new Point(this._controlParameter.frmThis.Location.X + (e.X - p0.X), this._controlParameter.frmThis.Location.Y + (e.Y - p0.Y));
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._controlParameter.frmThis.Close();
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._controlParameter.frmCamara._Vcapture.capture != null) this._controlParameter.frmCamara._Vcapture.capture.FlipHorizontal = !this._controlParameter.frmCamara._Vcapture.capture.FlipHorizontal;
        }

        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._controlParameter.frmCamara._Vcapture.capture != null) this._controlParameter.frmCamara._Vcapture.capture.FlipVertical = !this._controlParameter.frmCamara._Vcapture.capture.FlipVertical;
        }

        private void recognitionParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._controlParameter.frmRecognitionParameters = new RecognitionParameters(this._controlParameter.frmCamara);
            this._controlParameter.frmRecognitionParameters.Show();
        }

        private void restartCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCommandLine exec = new SetCommandLine();
            exec._frmControl = _controlParameter;
            exec.SetKeyCMD(KeyCMD.RestartCamara);
            exec.EXEC();
        }

        private void pauseCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCommandLine exec = new SetCommandLine();
            exec._frmControl = _controlParameter;
            exec.SetKeyCMD(KeyCMD.PauseCamara);
            exec.EXEC();
        }

        private void stopCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCommandLine exec = new SetCommandLine();
            exec._frmControl = _controlParameter;
            exec.SetKeyCMD(KeyCMD.StopCamara);
            exec.EXEC();
        }
    }
}
