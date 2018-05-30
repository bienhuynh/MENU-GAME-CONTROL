using SGP.HCBBOOK.CloudServer.UI.Models;
using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ILicenceService licenceService;
        private IUserService userService;
        public HomeController()
        {
            licenceService = new LicenceService();
            userService = new UserService();
        }
        public ActionResult Index()
        {
            var result = new DashboardViewModel();
            result.licences = licenceService.GetAllLicence();
            if (userService.CheckAdminSysRole(User.Identity.Name, RolesSys.Admin) || userService.CheckAdminSysRole(User.Identity.Name, RolesSys.Staff))
            {
                return View(result);
            }
            result.licences = result.licences.Where(m => m.Userid == User.Identity.Name).ToList();
            return View(result);
        }
    }
}