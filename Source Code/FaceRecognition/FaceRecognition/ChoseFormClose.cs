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
    public partial class ChoseFormClose : FormMaster
    {
        public SetCommandLine _setcmd;
        public ChoseFormClose()
        {
            InitializeComponent();
            this.OpacityConverter();
            this.RenameTitleForm("C h o s e  F o r m  C l o s e");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text!=null)
            {
                if (txtNumber.Text.Trim().Length > 0)
                {
                    try
                    {
                        int formnumber = Int16.Parse(txtNumber.Text);
                        _setcmd._exec.CloseFormFindFaceAction(formnumber);
                    }
                    catch
                    {
                        MessageBox.Show("Enter a number!");
                    }
                }
            }   
            else
                MessageBox.Show("Enter position form need close!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
