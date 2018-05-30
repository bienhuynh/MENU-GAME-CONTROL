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
    [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
    public class LicenceManageController : Controller
    {
        private ILicenceService licenceService;
        private IUserService userService;
        public LicenceManageController()
        {
            licenceService = new LicenceService();
            userService = new UserService();
        }


        /// <summary>
        /// Danh sach key ban quyen da mua
        /// </summary>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult MyLicence()
        {
            LicenceManageViewModel result = new LicenceManageViewModel();
            string userid = userService.GetUserId(User.Identity.Name);
            result.licences = licenceService.GetAllLicence().Where(m => m.Userid == userid).ToList();
            return View(result);
        }

        /// <summary>
        /// admin, nhan vien: Hien tat ca danh sach licence ke ca dang hoat dong lan khong hoat dong
        /// Client: Chi hien danh sach key thuoc ve Client do
        /// </summary>
        /// <returns></returns>
        // GET: LienceManage
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult Index()
        {
            LicenceManageViewModel result = new LicenceManageViewModel();
            result.licences = licenceService.GetAllLicence();
            if (userService.CheckAdminSysRole(User.Identity.Name, RolesSys.Admin) || userService.CheckAdminSysRole(User.Identity.Name, RolesSys.Staff))
            {
                return View(result);
            }
            string userid = userService.GetUserId(User.Identity.Name);
            result.licences = result.licences.Where(m => m.Userid == userid).ToList();
            return View(result);
        }

        // GET: LienceManage
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff })]
        public ActionResult Detail(string id)
        {
            return View();
        }

        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Client })]
        public ActionResult ChangeLicence(string clientId)
        {
            string namecomputer = "N/A";
            return View(new ChangeLicenceKeyForClient { ClientId = clientId, NameComputer = namecomputer});
        }

        // GET: 
        /// <summary>
        /// Thay doi licence key cho may client nay
        /// </summary>
        /// <param name="clientId">id may client muon doi key</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Client })]
        public ActionResult ChangeLicence(ChangeLicenceKeyForClient changeLicenceKeyForClient)
        {
            return View();
        }

        // GET: LienceManage
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin})]
        public ActionResult Edit(string id)
        {
            return View();
        }

        /// <summary>
        /// danh sach cac Licence bi vo hieu hoa
        /// </summary>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin })]
        public ActionResult LicenceNotActive()
        {
            return View(licenceService.GetAllLicence().Where(m => m.IsActive == false));
        }


        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin })]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin })]
        public ActionResult Create(LicenceDetailModel licenceDetailModel)
        {
            licenceService.AddLicence(licenceDetailModel);
            return View();
        }
    }
}