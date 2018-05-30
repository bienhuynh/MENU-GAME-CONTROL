using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface IHostService
    {
        /// <summary>
        /// Kiểm tra Port có sẵn để mở hay không
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        bool CheckAvailableServerPort(int port);
        /// <summary>
        /// Kiểm tra kết nối đến port 
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="portno"></param>
        /// <returns></returns>
        bool Test_connection(string hostname, int portno);
        /// <summary>
        /// Mở một port
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        bool OpenPort(int port);
        /// <summary>
        /// Lấy một port chưa sử dụng
        /// </summary>
        /// <returns></returns>
        int GetOpenPortUnUsed();
        /// <summary>
        /// Lấy danh sách Port đã sử dụng
        /// </summary>
        /// <returns></returns>
        List<int> GetListOpenPortUsed();
    }
}
