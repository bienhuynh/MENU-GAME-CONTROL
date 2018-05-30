using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class StartProgram : Form
    {
        public StartProgram()
        {
            InitializeComponent();
        }
        
        private void timerBar_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 100) timerBar.Stop();
        }
    }
}
