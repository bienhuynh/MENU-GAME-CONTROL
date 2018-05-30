using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LogicFeature.IService
{
    public interface ITcpClientConnection
    {
        void Connect();
        /// <summary>
        /// gửi thông điệp lên server 
        /// </summary>
        /// <param name="message"></param>
        void SendData(string message);
        /// <summary>
        /// Nhận phản hồi từ server 
        /// </summary>
        /// <returns></returns>
        void ReceiveResponseFromServerAsync();
        /// <summary>
        /// tra ve ket qua
        /// </summary>
        /// <returns></returns>
        string Result();
        void ResetResult();
        void FormWork(FormCustom form);
        FormCustom FormIsAction();
    }
}
