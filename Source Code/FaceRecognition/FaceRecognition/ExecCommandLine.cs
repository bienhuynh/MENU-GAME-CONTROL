using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    /// <summary>
    /// Chứa bộ commandline, mỗi tập lệnh đều có thể được thực thi
    /// </summary>
    public class ExecCommandLine : IExecCMD
    {
        public MenuControlParameter _frmControl = new MenuControlParameter();

        public void Close()
        {
            this._frmControl.frmThis.Close();
        }
        public void CloseCMD()
        {
            this._frmControl.frmThis.Close();
        }

        public void CloseThis()
        {
            this._frmControl.frmThis.Close();
        }

        public void Exit()
        {
            this._frmControl.frmCamara._Vcapture.capture.Stop();
            this._frmControl.frmCamara._Vcapture.capture.Dispose();
            Application.Exit();
        }

        public void PauseCamara()
        {
            this._frmControl.frmCamara._Vcapture.capture.Pause();
        }

        public void Restart()
        {
            Application.Restart();
        }

        public void RestartCamara()
        {
            this._frmControl.frmCamara._Vcapture.capture.Dispose();
            this._frmControl.frmCamara._Vcapture.capture = new Emgu.CV.VideoCapture();
            this._frmControl.frmCamara._Vcapture.capture.Start();
            this._frmControl.frmCamara.RunCamara();
        }

        public void StartCamara()
        {
            this._frmControl.frmCamara._Vcapture.capture.Start();
        }

        public void StopCamara()
        {
            this._frmControl.frmCamara._Vcapture.capture.Stop();
        }

        public void PauseFaceDetect()
        {
            this._frmControl.frmCamara._Vcapture.IsStart = false;
        }

        public void RestartFaceDetect()
        {
            this._frmControl.frmCamara._Vcapture.IsStart = true;
            this._frmControl.frmCamara._Vcapture.IsStop = true;
        }

        public void StartFaceDetect()
        {
            this._frmControl.frmCamara._Vcapture.IsStart = true;
        }

        public void StopFaceDetect()
        {
            this._frmControl.frmCamara._Vcapture.IsStop = true;
        }

        public void StopFaceRecogtion()
        {
            //chua cai dat
        }

        public void StartFaceRecogtion()
        {
            //chua cai dat
        }
        public void RestartFaceRecogtion()
        {
            //chua cai dat
        }
        public void PauseFaceRecogtion()
        {
            //chua cai dat
        }

        public void FindFace()
        {
            FrmFindFace _findface = new FrmFindFace();
            _findface.picture = _frmControl.pictureFind;
            _findface.RenameTitleForm("F i n d  F a c e I n  D a t a b a s e");
            _findface.Show();
            if (this._frmControl.listFindFaceAction == null) 
            {
                this._frmControl.listFindFaceAction = new FindFaceAction();
            }
            if (this._frmControl.listFindFaceAction.findfaceAction == null)
            {
                this._frmControl.listFindFaceAction.findfaceAction = new List<FrmFindFace>();
            }
            this._frmControl.listFindFaceAction.findfaceAction.Add(_findface);
            this._frmControl.listFindFaceAction.Action = this._frmControl.listFindFaceAction.findfaceAction.Count - 1;
        }

        public void CloseFormFindFaceAction(int frmClose)
        {
            this._frmControl.listFindFaceAction.findfaceAction[frmClose].Close();
        }
        public void CloseAllFormFindFaceAction()
        {
            foreach(FrmFindFace item in this._frmControl.listFindFaceAction.findfaceAction)
                item.Close();
        }
        public void OpenFindFaceBox()
        {
            FrmFindFace _findface = new FrmFindFace();
            _findface.RenameTitleForm("F i n d  F a c e I n  D a t a b a s e");
            _findface.Show();
            if (this._frmControl.listFindFaceAction == null)
            {
                this._frmControl.listFindFaceAction = new FindFaceAction();
            }
            if (this._frmControl.listFindFaceAction.findfaceAction == null)
            {
                this._frmControl.listFindFaceAction.findfaceAction = new List<FrmFindFace>();
            }
            this._frmControl.listFindFaceAction.findfaceAction.Add(_findface);
            this._frmControl.listFindFaceAction.Action = this._frmControl.listFindFaceAction.findfaceAction.Count - 1;
        }
    }
}
