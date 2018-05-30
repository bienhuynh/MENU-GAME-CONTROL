using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface ITcpServerConnection
    {
        /// <summary>
        /// Tạo kết nối lắng nghe socket bên server 
        /// </summary>
        void Start();
        /// <summary>
        /// Client đang trao đổi thông tin với server 
        /// </summary>
        /// <returns></returns>
        TcpClient LastCommunicatedClient();
        /// <summary>
        /// Danh sach Client Dang ket noi
        /// </summary>
        /// <returns></returns>
        IList<TcpClient> ConnectedClients();
        /// <summary>
        /// Gui noi dung den Client
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="message"></param>
        void SendDataToClient(TcpClient tcpClient, string message);
    }
}
