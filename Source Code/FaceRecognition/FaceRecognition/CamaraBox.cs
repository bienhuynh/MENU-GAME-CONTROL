using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.UI;
using Emgu.CV;

namespace FaceRecognition
{
    public partial class CamaraBox : UserControl
    {
        public VCapture _Vcapture;
        public CamaraBox()
        {
            InitializeComponent();
            try
            {
                _Vcapture.capture = new VideoCapture();
                _Vcapture.capture.Start();
                _Vcapture.capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            _Vcapture.frame = new Mat();
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_Vcapture.capture != null && _Vcapture.capture.Ptr != IntPtr.Zero)
            {
                _Vcapture.capture.Retrieve(_Vcapture.frame, 0);
            }
            imgbxcamara.Image = _Vcapture.frame;
        }
        private void CamaraBox_Load(object sender, EventArgs e)
        {

        }
    }
}
