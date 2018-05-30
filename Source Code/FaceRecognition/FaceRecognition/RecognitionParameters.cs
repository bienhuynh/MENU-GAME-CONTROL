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
    public partial class RecognitionParameters : FormMaster
    {
        public ParameterSetting _parameterDefault = new ParameterSetting();
        bool close = false;
        Camara frm;
        public RecognitionParameters(Camara frmCam)
        {
            frm = frmCam;
            InitializeComponent();
            _parameterDefault.ScaleFactor = 1.1;
            _parameterDefault.MinNeighbors = 10;
            txtScaleFactor.Text = frm._parameterCustomize.ScaleFactor.ToString();
            txtMinNeighbors.Text = frm._parameterCustomize.MinNeighbors.ToString();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frm._parameterCustomize.ScaleFactor = Double.Parse(txtScaleFactor.Text);
                frm._parameterCustomize.MinNeighbors = Int32.Parse(txtMinNeighbors.Text);
                close = !close;
            }
            catch
            {
                MessageBox.Show("Emter number double,please!");
                close = false;
            }
            if(close)
                this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtScaleFactor.Text = _parameterDefault.ScaleFactor.ToString();
            txtMinNeighbors.Text = _parameterDefault.MinNeighbors.ToString();
        }
    }
}
