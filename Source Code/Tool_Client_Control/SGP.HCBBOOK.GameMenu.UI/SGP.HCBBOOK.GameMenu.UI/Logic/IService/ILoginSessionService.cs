using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    interface ILoginSessionService
    {
        /// <summary>
        /// Ghi phien dang nhap hien tai vao file json lich su dang nhap
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        bool WriteLoginSession(HistoryLoginSessionModel loginModel);
        /// <summary>
        /// Lay tat ca lich su dang nhap
        /// </summary>
        /// <returns></returns>
        IList<HistoryLoginSessionModel> GetHistoryLoginSession();
        /// <summary>
        /// laays tin dang nhap phien hien tai trong file json
        /// </summary>
        /// <returns></returns>
        LoginModel GetLoginSession();
        
        /// <summary>
        /// dang nhap local, username password truyen ben ngoai vao goi ham nay de so sach voi username password trong file json cua may
        /// </summary>
        /// <returns></returns>
        //bool Login();
        
        /// <summary>
        /// Co nho dang nhap, neu dang nhap thanh coong nguoi dung bat nho dang nhap thi se bo qua dang nhap,
        /// muon tat ngupi dung phai vao cau hinh tu tat nho
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsRememberLogin();
        void UpdateDataLogin(LoginModel loginModel);
        LoginModel GetDataLogin();
    }
}
