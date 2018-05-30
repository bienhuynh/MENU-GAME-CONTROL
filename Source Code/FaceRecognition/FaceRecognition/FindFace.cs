using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.CodeDom.Compiler;
using System.IO;

namespace FaceRecognition
{
    public partial class FrmFindFace : FormMaster
    {
        public Image picture = global::FaceRecognition.Properties.Resources.contacts_256;
        public FrmFindFace()
        {
            InitializeComponent();
            imgboxNeedfind.BackgroundImage = picture;
            //this.frmthis.Opacity = this.Opacity;
            this.OpacityConverter();
            this.RenameTitleForm("F i n d  F a c e");
            this.btn_maxisize.Hide();
            this.btn_minisize.Hide();
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageBox1_ParentChanged(object sender, EventArgs e)
        {
            //byte[] bytes = File.ReadAllBytes(Application.ExecutablePath);
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    string value = Convert.ToString(bytes[i], 2);
            //    value = value.PadLeft(8, '0');
            //    sb.Append(value + ' ');
            //}
            //richTextBox1.Text = sb.ToString();
        }
        
    }
}
