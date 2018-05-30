using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition
{
    public static class KeyCMD
    {
        public static string NameSYS = "hcb";
        /// <summary>
        /// Khởi động phần mềm
        /// </summary>
        public static string Start { get { return NameSYS + " start"; } }
        /// <summary>
        /// khởi động phát hiện khuôn mặt
        /// </summary>
        public static string StartFaceDetect { get { return NameSYS + " start face detect"; } }
        /// <summary>
        /// Ngừng phát hiện khuôn mặt
        /// </summary>
        public static string StopFaceDetect { get { return NameSYS + " start face detect"; } }
        /// <summary>
        /// tạm dừng phát hiện khuôn mặt
        /// </summary>
        public static string PauseFaceDetect { get { return NameSYS + " pause face detect"; } }
        /// <summary>
        /// khởi động lại phát hiện khuôn mặt
        /// </summary>
        public static string RestartFaceDetect { get { return NameSYS + " restart face detect"; } }
        /// <summary>
        /// khởi động nhận diện khuôn mặt
        /// </summary>
        public static string StartFaceRecogtion { get { return NameSYS + " start face recogtion"; } }
        /// <summary>
        /// ngừng nhận diện khuôn mặt
        /// </summary>
        public static string StopFaceRecogtion { get { return NameSYS + " stop face recogtion"; } }
        /// <summary>
        /// tạm dừng nhận diện khuôn mặt
        /// </summary>
        public static string PauseFaceRecogtion { get { return NameSYS + " pause face recogtion"; } }
        /// <summary>
        /// khởi động lại nhận diện khuôn mặt
        /// </summary>
        public static string RestartFaceRecogtion { get { return NameSYS + " Restart face recogtion"; } }
        
        /// <summary>
        /// Khởi động lại phần mềm
        /// </summary>
        public static string Restart { get { return NameSYS + " restart"; } }
        
        /// <summary>
        /// Đóng trình CMD
        /// </summary>
        public static string Close { get { return NameSYS + " close"; } }
        /// <summary>
        /// Đóng trình CMD
        /// </summary>
        public static string CloseCMD { get { return NameSYS + " close cmd"; } }
        /// <summary>
        /// Đóng chương trình mở nó lên
        /// </summary>
        public static string CloseThis { get { return NameSYS + " close this"; } }
        /// <summary>
        /// Đóng From mong muốn
        /// </summary>
        public static string CloseApp { get { return NameSYS + " close app"; } }
        /// <summary>
        /// Đóng camara
        /// </summary>
        public static string PauseCamara { get { return NameSYS + " pause camara"; } }
        /// <summary>
        /// Dừng Camara
        /// </summary>
        public static string StopCamara { get { return NameSYS + " stop camara"; } }
        /// <summary>
        /// Bắt đầu Camara
        /// </summary>
        public static string StartCamara { get { return NameSYS + " start camara"; } }
        /// <summary>
        /// Khởi động lại camara 
        /// </summary>
        public static string RestartCamara { get { return NameSYS + " restart camara"; } }
        /// <summary>
        /// Đóng toàn bộ chương trình
        /// </summary>
        public static string Exit { get { return NameSYS + " exit"; } }
        /// <summary>
        /// Find face in database
        /// </summary>
        public static string FindFace { get { return NameSYS + " find face"; } }
        /// <summary>
        /// close form Find face
        /// </summary>
        public static string ClosefrmFindFace { get { return NameSYS + " close find face"; } }
        /// <summary>
        /// close all form Find face
        /// </summary>
        public static string CloseAllfrmFindFace { get { return NameSYS + " close all find face"; } }
        /// <summary>
        /// Ope form find face
        /// </summary>
        public static string OpenFindFaceBox { get { return NameSYS + " open find face box"; } }
    }
}
