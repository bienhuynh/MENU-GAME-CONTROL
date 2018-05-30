using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition
{
    public interface IExecCMD
    {
        /// <summary>
        /// khởi động phát hiện khuôn mặt
        /// </summary>
        void StartFaceDetect();
        /// <summary>
        /// Ngừng phát hiện khuôn mặt
        /// </summary>
        void StopFaceDetect();
        /// <summary>
        /// tạm dừng phát hiện khuôn mặt
        /// </summary>
        void PauseFaceDetect();
        /// <summary>
        /// khởi động lại phát hiện khuôn mặt
        /// </summary>
        void RestartFaceDetect();
        /// <summary>
        /// khởi động nhận diện khuôn mặt
        /// </summary>
        void StartFaceRecogtion();
        /// <summary>
        /// ngừng nhận diện khuôn mặt
        /// </summary>
        void StopFaceRecogtion();
        /// <summary>
        /// tạm dừng nhận diện khuôn mặt
        /// </summary>
        void PauseFaceRecogtion();
        /// <summary>
        /// khởi động lại nhận diện khuôn mặt
        /// </summary>
        void RestartFaceRecogtion();
        /// <summary>
        /// Khởi động lại phần mềm
        /// </summary>
        void Restart();
        /// <summary>
        /// Khởi động lại camara 
        /// </summary>
        void RestartCamara();
        /// <summary>
        /// Đóng chương trình mở nó lên
        /// </summary>
        void Close();
        /// <summary>
        /// Đóng trình CMD
        /// </summary>
        void CloseCMD();
        /// <summary>
        /// Đóng chương trình hiện tại
        /// </summary>
        void CloseThis();
        /// <summary>
        /// tạm dừng camara
        /// </summary>
        void PauseCamara();
        /// <summary>
        /// Dừng Camara
        /// </summary>
        void StopCamara();
        /// <summary>
        /// Bắt đầu Camara
        /// </summary>
        void StartCamara();
        /// <summary>
        /// Đóng toàn bộ chương trình
        /// </summary>
        void Exit();
        /// <summary>
        /// Close all form FindFace
        /// </summary>
        void CloseAllFormFindFaceAction();
        /// <summary>
        /// close form Find Face actied
        /// </summary>
        void CloseFormFindFaceAction(int frmClose);
        /// <summary>
        /// Find face in database
        /// </summary>
        void FindFace();
        /// <summary>
        /// open form find face
        /// </summary>
        void OpenFindFaceBox();
    }
}
