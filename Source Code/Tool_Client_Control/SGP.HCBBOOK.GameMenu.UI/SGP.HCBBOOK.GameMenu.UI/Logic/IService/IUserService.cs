using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface IUserService
    {
        /// <summary>
        /// Cập nhật Thông tin
        /// </summary>
        /// <returns></returns>
        bool UpdateProfile(UserProfileModel userProfileModel);
        UserProfileModel GetProfile();
        bool ChangePassword(string newPassword);
        bool UpdateAvarta();
        string GetName();
        string GetUserId();
        string GetEmail();
        /// <summary>
        /// Co hieu dang nhap thanh cong
        /// </summary>
        /// <returns></returns>
        bool IsLoginSuccess();
        /// <summary>
        /// Co nho dang nhap, neu dang nhap thanh coong nguoi dung bat nho dang nhap thi se bo qua dang nhap,
        /// muon tat ngupi dung phai vao cau hinh tu tat nho
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsRememberLogin();
        /// <summary>
        /// Dang nhập vào hệ thống SGP Game nếu có mạng thì gửi username(mã hóa) password (mã hóa) lên webservice 
        /// nếu không có mạng: nếu có sẵn file json lưu username pasword mã hóa thì lấy đó kiểm tra
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns>true nếu login thành công, false nếu thất bại</returns>
        ResultBasic Login(string password);
        ResultBasic Login(LoginModel loginModel);
        Task<ResultBasic> LoginAync(LoginModel loginModel);
        IList<HistoryLoginSessionModel> GetLoginHistory();
        void Logout();
    }
}
