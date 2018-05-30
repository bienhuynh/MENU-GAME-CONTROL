using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class Camara : FormMaster
    {
        public VCapture _Vcapture = new VCapture();
        private Mat _frame = new Mat();
        public ParameterSetting _parameterCustomize = new ParameterSetting();
        
        private Label btnRestartCamara;
        private Label btnPauseCamara;
        private Label btnStopCamara;
        private TranspControl.TranspControl comandline;
        private TranspControl.TranspControl FindedBox;
        private int sizebtn = 50;
        private bool pause = true;
        //Thread thead;
        public Camara()
        {
            InitializeComponent();
            //thead = new Thread(new ThreadStart(RunCamara));
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            //thead.Start();
            //Thread.Sleep(3000);
            ReleaseData();
            
            this.RenameTitleForm("Camara");
            this.IsMdiContainer = false;
            RunCamara();
            _Vcapture.frame = new Mat();
            _parameterCustomize.ScaleFactor = 1.1;
            _parameterCustomize.MinNeighbors = 10;
            menuForm1._controlParameter.frmThis = this;
            menuForm1._controlParameter.frmCamara = this;
            _Vcapture.IsStart = true;
            _Vcapture.IsStop = false;
            this.btn_minisize.Enabled = false;
            //panelcamara
            btnRestartCamara = new Label();
            btnPauseCamara = new Label();
            btnStopCamara = new Label();
            comandline = new TranspControl.TranspControl();
            FindedBox = new TranspControl.TranspControl();

            //FindBox();
            //FindFace();

            this.btnRestartCamara.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartCamara.BackgroundImage = global::FaceRecognition.Properties.Resources.Quick_restart;
            this.btnRestartCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestartCamara.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestartCamara.Name = "btnRestartCamara";
            this.btnRestartCamara.Size = new System.Drawing.Size(sizebtn, sizebtn);
            this.btnRestartCamara.TabIndex = 0;
            this.btnRestartCamara.Click += new System.EventHandler(this.btnRestartCamara_Click);


            this.btnPauseCamara.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseCamara.BackgroundImage = global::FaceRecognition.Properties.Resources.player_pause_256;
            this.btnPauseCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPauseCamara.ForeColor = System.Drawing.Color.Transparent;
            this.btnPauseCamara.Name = "btnPauseCamara";
            this.btnPauseCamara.Size = new System.Drawing.Size(sizebtn, sizebtn);
            this.btnPauseCamara.TabIndex = 0;
            this.btnPauseCamara.Click += new System.EventHandler(this.btnPauseCamara_Click);


            this.btnStopCamara.BackColor = System.Drawing.Color.Transparent;
            this.btnStopCamara.BackgroundImage = global::FaceRecognition.Properties.Resources.player_stop;
            this.btnStopCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopCamara.ForeColor = System.Drawing.Color.Transparent;
            this.btnStopCamara.Name = "btnStopCamara";
            this.btnStopCamara.Size = new System.Drawing.Size(sizebtn, sizebtn);
            this.btnStopCamara.TabIndex = 0;
            this.btnStopCamara.Click += new System.EventHandler(this.btnStopCamara_Click);


            this.imgbxcamara.Controls.Add(btnRestartCamara);
            this.imgbxcamara.Controls.Add(btnStopCamara);
            this.imgbxcamara.Controls.Add(btnPauseCamara);

            
            t.Abort();
            DockButtonCamara();
            //this.Refresh();
        }

        private void btn_maxisize_Click(object sender, EventArgs e)
        {
            DockButtonCamara();
        }
        public void DockButtonCamara()
        {
            btnRestartCamara.Left = (this.Width - btnPauseCamara.Width) / 2 - (sizebtn + 50);
            btnRestartCamara.Top = (this.Height - (50 + sizebtn));

            btnPauseCamara.Left = (this.Width - btnPauseCamara.Width) / 2;
            btnPauseCamara.Top = (this.Height - (50 + sizebtn));

            btnStopCamara.Left = (this.Width - btnPauseCamara.Width) / 2 + (sizebtn + 50);
            btnStopCamara.Top = (this.Height - (50 + sizebtn));
            this.imgbxcamara.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        public void SplashStart()
        {
            Application.Run(new StartProgram());
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_Vcapture.capture != null && _Vcapture.capture.Ptr != IntPtr.Zero)
            {
                _Vcapture.capture.Retrieve(_Vcapture.frame, 0);
                if (_Vcapture.IsStart && !_Vcapture.IsStop)
                    SwitchFind(2);
                
                CvInvoke.Resize(_Vcapture.frame, _frame, new Size(imgbxcamara.Width, imgbxcamara.Height), 0, 0, Inter.Linear);
            }
            imgbxcamara.Image = _frame;
        }
        private void SwitchFind(object chose)
        {
            int number = 0;
            int.TryParse(chose.ToString(), out number);
            switch (number)
            {
                case 1:
                    FindPeople(_Vcapture.frame);
                    break;
                case 2:
                    Findface(_Vcapture.frame, _parameterCustomize);
                    break;
                default:
                    Findface(_Vcapture.frame, _parameterCustomize);
                    break;
            }
        }
        private void FindPeople(Mat image)
        {
            using (image)
            {

                long processingTime;
                Rectangle[] results;

                if (CudaInvoke.HasCuda)
                {
                    using (GpuMat gpuMat = new GpuMat(image))
                        results = FindPedestrian.Find(gpuMat, out processingTime);
                }
                else
                {
                    using (UMat uImage = image.GetUMat(AccessType.ReadWrite))
                        results = FindPedestrian.Find(uImage, out processingTime);
                }

                foreach (Rectangle rect in results)
                {
                    CvInvoke.Rectangle(image, rect, new Bgr(Color.Red).MCvScalar);
                }
            }
        }
    
        static void Findface(Mat image, ParameterSetting _parameterCustomize)
        {
            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            //List<Rectangle> eyes = new List<Rectangle>();
            DetectFace.Detectface(
              image, "haarcascade_frontalface_default.xml",
              faces, _parameterCustomize,
              out detectionTime);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            //foreach (Rectangle eye in eyes)
            //    CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
        }

        private void ReleaseData()
        {
            if (_Vcapture.capture != null)
                _Vcapture.capture.Dispose();
        }
        
        public void RunCamara()
        {
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
        }
        private void btnRestartCamara_Click(object sender,EventArgs e)
        {
            SetCommandLine exec = new SetCommandLine();
            exec._frmControl = menuForm1._controlParameter;
            exec.SetKeyCMD(KeyCMD.RestartCamara);
            exec.EXEC();
        }
        private void btnPauseCamara_Click(object sender, EventArgs e)
        {
            if(pause)
            {
                SetCommandLine exec = new SetCommandLine();
                exec._frmControl = menuForm1._controlParameter;
                exec.SetKeyCMD(KeyCMD.PauseCamara);
                this.btnPauseCamara.BackgroundImage = global::FaceRecognition.Properties.Resources.play3;
                exec.EXEC();
                
            }
            else
            {
                SetCommandLine exec = new SetCommandLine();
                exec._frmControl = menuForm1._controlParameter;
                exec.SetKeyCMD(KeyCMD.RestartCamara);
                this.btnPauseCamara.BackgroundImage = global::FaceRecognition.Properties.Resources.player_pause_256;
                exec.EXEC();
            }
            pause = !pause;
        }
        private void btnStopCamara_Click(object sender, EventArgs e)
        {
            SetCommandLine exec = new SetCommandLine();
            exec._frmControl = menuForm1._controlParameter;
            exec.SetKeyCMD(KeyCMD.StopCamara);
            exec.EXEC();
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _maximum = false;
        private void btnFullSceen_Click(object sender, EventArgs e)
        {
            if (!_maximum)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            _maximum = !_maximum;
            DockButtonCamara();
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}
