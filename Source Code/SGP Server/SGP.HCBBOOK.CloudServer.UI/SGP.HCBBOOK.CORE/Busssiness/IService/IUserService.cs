using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.IService
{
    public interface IUserService
    {
        /// <summary>
        /// Them user vao bang userprofile
        /// </summary>
        /// <param name="userProfileModel"></param>
        /// <returns></returns>
        bool AddUserProfile(UserProfileModel userProfileModel);
        Task<bool> AddUserProfileaAync(UserProfileModel userProfileModel);
        /// <summary>
        /// Lay thong tintai khoan
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        UserProfileModel GetProfile(string email);
        Task<UserProfileModel> GetProfileAync(string email);
        UserProfileModel GetProfileByUserId(string userid);
        Task<UserProfileModel> GetProfileByUserIdAync(string userid);
        /// <summary>
        /// Laay Userid 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        string GetUserId(string email);
        Task<string> GetUserIdAync(string email);
        /// <summary>
        /// Kiem tra user hien tai co phai la admin khong
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool CheckAdminSysRole(string email);
        Task<bool> CheckAdminSysRoleAync(string email);
        bool CheckAdminSysRole(string email, string role);
        Task<bool> CheckAdminSysRoleAync(string email, string role);

        void UpdateLogo(string userid, string Url);
        Task UpdateLogoAync(string userid, string Url);
        void UpdateProfile(UserProfileModel userProfileModel);
        Task UpdateProfileAync(UserProfileModel userProfileModel);
        string GetNameByUserId(string userId);
        Task<string> GetNameByUserIdAync(string userId);
        string GetNameByEmailId(string email);
        Task<string> GetNameByEmailIdAync(string email);
        string GetNameCompanyByUserId(string userid);
        string GetNameCompanyByEmail(string Email);
        Task<string> GetNameCompanyByUserIdAync(string userid);
        Task<string> GetNameCompanyByEmailAync(string Email);

        IList<UserProfileModel> GetAllUser();
        Task<IList<UserProfileModel>> GetAllUserAync();
        /// <summary>
        /// Kiem tra dang nhap phien
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        bool WriteLoginSession(LoginModel loginModel);
        Task<bool> WriteLoginSessionAync(LoginModel loginModel);

        bool CheckRole(string userid, string roleName);

    }
}
