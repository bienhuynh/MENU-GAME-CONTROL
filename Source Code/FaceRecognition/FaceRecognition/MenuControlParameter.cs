using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public class MenuControlParameter
    {
        public Form frmThis { get; set; }
        public Camara frmCamara { get; set; }
        public Comandline frmCommandLine { get; set; }
        public RecognitionParameters frmRecognitionParameters { get; set; }
        public Image pictureFind { get; set; }
        public FindFaceAction listFindFaceAction { get; set; }
    }

    public class FindFaceAction
    {
        public List<FrmFindFace> findfaceAction { get; set; }
        public int Action = 0;
    }
}
