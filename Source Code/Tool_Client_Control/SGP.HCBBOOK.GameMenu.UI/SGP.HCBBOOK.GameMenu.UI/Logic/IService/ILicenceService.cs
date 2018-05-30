using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface ILicenceService
    {
        /// <summary>
        /// kiểm tra lience trong file json
        /// còn hạn sử dụng
        /// lience đủ số máy hay chua
        /// có đúng ip su dung hay không
        /// </summary>
        /// <param name="lienceKey"></param>
        /// <returns></returns>
        bool CheckLience(string lienceKey);
        /// <summary>
        /// Kiem tra key dang dang nhap tren he thong SGP webservice dong thoi vua dang nhap,
        /// neu dang nhap thanh cong thi ghi vao file json thong tin user neu khong thi return false bo qua
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        ResultBasic CheckLience(LoginModel loginModel);
    }
}
