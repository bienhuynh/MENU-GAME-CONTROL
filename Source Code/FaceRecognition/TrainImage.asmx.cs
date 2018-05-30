using Emgu.CV;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace FaceRecognizeService
{
    /// <summary>
    /// Summary description for TrainImage1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TrainImage1 : System.Web.Services.WebService
    {

        HaarCascade faceDetect;
        /// <summary>
        /// Hàm train image
        /// </summary>
        /// <param name="name">tên nhân viên</param>
        /// <param name="fileData">Dữ liệu ảnh train</param>
        /// <returns></returns>
        [WebMethod]
        public string Train(string name, string fileData)
        {

            //Chuyển dữ liệu dạng string sang bitmap và phát hiện khuôn mặt trên ảnh
            byte[] data = Convert.FromBase64String(fileData);
            string parentDir = Server.MapPath("~");

            
            faceDetect = new HaarCascade(parentDir + "libs/haarcascade_frontalface_default.xml");
            Bitmap bmp;
            using (var ms = new MemoryStream(data))
            {
                bmp = new Bitmap(ms);
            }
            try
            {
                Image<Bgr, byte> currentImage = new Image<Bgr, byte>(bmp);
                //Get a gray frame from capture device
                Image<Gray, byte> gray = currentImage.Convert<Gray, byte>().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                faceDetect,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Cắt khuôn mặt phát hiện được trong ảnh
                Image<Gray, byte> TrainedFace = null;
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = gray.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    break;
                }
                //Lưu nếu có khuôn mặt 
                if (TrainedFace != null)
                {
                    //Lưu ảnh và thêm dữ liệu vào database
                    string imagePath = parentDir + "Images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
                    TrainedFace.Save(imagePath);
                    BAL.InsertTrain(name, imagePath);
                    return "Saved";

                }
                else
                {
                    return "No face detected!";
                }

            }
            catch (Exception e)
            {
                return e.Message;
                //MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return name;
        }

        /// <summary>
        /// Nhận diện
        /// </summary>
        /// <param name="fileData">Dữ liệu ảnh</param>
        /// <returns></returns>
        [WebMethod]
        public string Recognize(string fileData)
        {
            //Giống hàm train
            var data = Convert.FromBase64String(fileData);
            string parentDir = Server.MapPath("~");
            faceDetect = new HaarCascade(parentDir + "libs/haarcascade_frontalface_default.xml");
            Bitmap bmp;
            using (var ms = new MemoryStream(data))
            {
                bmp = new Bitmap(ms);
            }
            try
            {
                Image<Bgr, byte> currentImage = new Image<Bgr, byte>(bmp);
                //Get a gray frame from capture device
                Image<Gray, byte> gray = currentImage.Convert<Gray, byte>().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                faceDetect,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                Image<Gray, byte> TrainedFace = null;
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = gray.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    break;
                }
                if (TrainedFace != null)
                {
                    //Lấy danh sách ảnh đã train và tên nhân viên
                    List<TrainImage> lstTrain = BAL.GetAllTrain();
                    List<string> names = new List<string>();
                    List<Image<Gray, byte>> trains = new List<Image<Gray, byte>>();
                    foreach (TrainImage train in lstTrain)
                    {
                        names.Add(train.Employee.EmployeeName);
                        trains.Add(new Image<Gray, byte>(train.TrainImagePath));
                    }
                    if (trains.Count != 0)
                    {
                        //TermCriteria for face recognition with numbers of trained images like maxIteration
                        MCvTermCriteria termCrit = new MCvTermCriteria(trains.Count, 0.001);

                        //Eigen face recognizer
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                           trains.ToArray(),
                           names.ToArray(),
                           3000,
                           ref termCrit);

                        string name = recognizer.Recognize(TrainedFace);
                        foreach (TrainImage train in lstTrain)
                        {
                            if (train.Employee.EmployeeName == name)
                            {
                                BAL.InsertHistory(train.Employee);
                                break;
                            }
                        }
                        return "Name: " + name;
                        //Draw the label for each face detected and recognized
                    }
                    return "Not recognize.";

                }
                else
                {
                    return "No face detected!";
                }

            }
            catch (Exception e)
            {
                return e.Message;
                //MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Lấy danh sách lịch sử của nhân viên
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetHistories()
        {
            List<History> lst = BAL.GetAllHistory();
            var serializer = new JsonSerializer();
            List<HistoryJson> listJ = new List<HistoryJson>();
            foreach (var item in lst)
            {
                HistoryJson newHis = new HistoryJson();
                newHis.EmployeeName = item.Employee.EmployeeName;
                newHis.AtTime = item.AtTime;
                listJ.Add(newHis);
            }
            return new JavaScriptSerializer().Serialize(listJ);
        }
    }
}
