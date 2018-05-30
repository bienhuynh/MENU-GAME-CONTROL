using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using SGP.HCBBOOK.GameMenu.UI.Models;
namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    interface ILoginService
    {
        /// <summary>
        /// Đăng nhặp server sgp
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        SignInStatus Login(LoginViewModel model);

        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <returns></returns>
        bool LogOut();
        Task<bool> LogOutAync();
    }
}
