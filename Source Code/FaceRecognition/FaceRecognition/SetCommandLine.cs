using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    /// <summary>
    /// thực hiện validate commandline và phân luồng thực hiện
    /// </summary>
    
    public class SetCommandLine
    {
        private string keycmd { get; set; }
        public MenuControlParameter _frmControl = new MenuControlParameter();
        public ExecCommandLine _exec = new ExecCommandLine();
        //public int formnumber = 0;
        public void SetKeyCMD(string _keycmd)
        {
            keycmd = _keycmd.ToLower();
        }
        public bool EXEC()
        {
            _exec._frmControl = _frmControl; 
            if(keycmd == KeyCMD.CloseThis)
            {
                _exec.CloseThis();
                return true;
            }
            else if (keycmd == NameAppProgram.Camara)
            {
                Application.Exit();
            }
            else if (keycmd == NameAppProgram.Comandline)
            {
                this._frmControl.frmCamara.Close();
            }
            else if (keycmd == NameAppProgram.RecognitionParameters)
            {
                this._frmControl.frmRecognitionParameters.Close();
            }
            else if (keycmd == KeyCMD.PauseCamara)
            {
                _exec.PauseCamara();
                return true;
            }
            else if (keycmd == KeyCMD.Exit)
            {
                _exec.Exit();
                return true;
            }
            else if (keycmd == KeyCMD.Restart)
            {
                _exec.Restart();
                return true;
            }
            else if (keycmd == KeyCMD.RestartCamara)
            {
                _exec.RestartCamara();
                return true;
            }
            else if (keycmd == KeyCMD.StartCamara)
            {
                _exec.StartCamara();
                return true;
            }
            else if (keycmd == KeyCMD.StartFaceDetect)
            {
                _exec.StartFaceDetect();
            }
            else if (keycmd == KeyCMD.StopFaceDetect)
            {
                _exec.StopFaceDetect();
                return true;
            }
            else if (keycmd == KeyCMD.PauseFaceDetect)
            {
                _exec.PauseFaceDetect();
                return true;
            }
            else if (keycmd == KeyCMD.RestartFaceDetect)
            {
                _exec.RestartFaceDetect();
                return true;
            }
            else if (keycmd == KeyCMD.StartFaceRecogtion)
            {
                _exec.StartFaceRecogtion();
                return true;
            }
            else if (keycmd == KeyCMD.StopFaceRecogtion)
            {
                _exec.StopFaceRecogtion();
                return true;
            }
            else if (keycmd == KeyCMD.RestartFaceRecogtion)
            {
                _exec.RestartFaceRecogtion();
                return true;
            }
            else if (keycmd == KeyCMD.PauseFaceRecogtion)
            {
                _exec.PauseFaceRecogtion();
                return true;
            }
            else if (keycmd == KeyCMD.StopCamara)
            {
                _exec.StopCamara();
                return true;
            }
            else if (keycmd == KeyCMD.Close || keycmd == KeyCMD.CloseCMD)
            {
                _exec.CloseCMD();
                return true;
            }
            else if (keycmd == KeyCMD.FindFace)
            {
                _exec.FindFace();
                return true;
            }
            else if (keycmd == KeyCMD.ClosefrmFindFace)
            {
                ChoseFormClose _chosefrm = new ChoseFormClose();
                _chosefrm._setcmd = this;
                int count = 0;
                foreach (FrmFindFace item in this._frmControl.listFindFaceAction.findfaceAction)
                {
                    _chosefrm.cmbListFrm.Items.Add(count.ToString() + item.Name);
                    count++;
                }
                _chosefrm.lbltotal.Text = "Total: " +this._frmControl.listFindFaceAction.findfaceAction.Count.ToString();
                _chosefrm.txtNumber.Text = this._frmControl.listFindFaceAction.Action.ToString();
                _chosefrm.Show();
                return true;
            }
            else if (keycmd == KeyCMD.CloseAllfrmFindFace)
            {
                _exec.CloseAllFormFindFaceAction();
                return true;
            }
            else if (keycmd == KeyCMD.OpenFindFaceBox)
            {
                _exec.OpenFindFaceBox();
                return true;
            }

            return false;
        }
    }
}
