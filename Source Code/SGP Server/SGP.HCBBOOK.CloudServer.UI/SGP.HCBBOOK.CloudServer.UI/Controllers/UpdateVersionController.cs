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
    [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.DEV })]
    public class UpdateVersionController : Controller
    {
        private ICheckVersion checkVersion;
        public UpdateVersionController()
        {
            checkVersion = new CheckVersion();
        }
        // GET: UpdateVersion
        //Danh sach ChangeVersion
        public ActionResult Index()
        {
            return View(checkVersion.GetAllList());
        }

        public ActionResult Detail(int id)
        {
            return View(checkVersion.GetDetail(id));
        }

        public ActionResult Edit(int id)
        {
            return View(checkVersion.GetDetail(id));
        }

        [HttpPost, ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult Edit(CheckVersionInfoModel checkVersionInfoModel)
        {
            checkVersionInfoModel.DateChange = DateTime.Now;
            if (checkVersion.ModifiedInfoVersion(checkVersionInfoModel))
            {
                return RedirectToAction("Index");
            }
            return View(checkVersionInfoModel);
        }

        public ActionResult AddNewVersion()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult AddNewVersion(CheckVersionInfoModel checkVersionInfoModel)
        {
            checkVersionInfoModel.DateChange = DateTime.Now;
            checkVersionInfoModel.IsUpdateAvailable = true;
            if (checkVersion.AddNewVersion(checkVersionInfoModel))
            {
                return RedirectToAction("Index");
            }
            return View(checkVersionInfoModel);
        }
    }
}