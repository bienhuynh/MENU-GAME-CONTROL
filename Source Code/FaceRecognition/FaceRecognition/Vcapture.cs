using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition
{
    public class VCapture
    {
        public VideoCapture capture = null;
        public bool captureStatus = false;
        public Mat frame;

        /// <summary>
        /// true: Start, false:Pause
        /// </summary>
        public bool IsStart { get; set; }
        
        /// <summary>
        /// true: Stop, false: Not Stop
        /// </summary>
        public bool IsStop { get; set; }
    }
}
