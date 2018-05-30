using SGP.HCBBOOK.CloudServer.UI.Models;
using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    [Authorize]
    public class DownloadController : Controller
    {
        private ICheckVersion checkVersion;
        public DownloadController()
        {
            checkVersion = new CheckVersion();
        }
        // GET: Download
        public ActionResult Index()
        {
            return View(checkVersion.GetAllList());
        }

        [AllowAnonymous]
        public ActionResult ReleaseDocs()
        {
            return View(checkVersion.GetAllList());
        }

        //--------------------Checkversion ------------------//

        [AllowAnonymous]
        public JsonResult checkversionSGPMGC()
        {
            //checkversion/UpdateVersionConfig.xml
            try
            {
                var checkversioninfo = checkVersion.CheckVersionSGPMGC();
                
                return Json(new
                {
                    CurrentVersion = checkversioninfo.CurrentVersion,
                    Mandatory = checkversioninfo.Mandatory
                    
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [AllowAnonymous]
        public JsonResult checkversionSGPMG()
        {
            //checkversion/UpdateVersionConfig.xml
            try
            {
                var checkversioninfo = checkVersion.CheckVersionSGPMG();
                return Json(checkversioninfo, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [AllowAnonymous]
        public FileResult checkversionSGPMG64()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Update_Current\64bit\update64bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [AllowAnonymous]
        public FileResult checkversionSGPMG32()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Update_Current\32bit\update32bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [AllowAnonymous]
        public FileResult checkversionSGPMGC64()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Update_Current\64bit\update64bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [AllowAnonymous]
        public FileResult checkversionSGPMGC32()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Update_Current\32bit\update32bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        //--------------------End checkversion--------------//
        //--------------------Download SGP MG --------------//
        public FileResult SGPMG32()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Version_Current\32bit\32bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }
            
            return null;
        }
        
        public FileResult SGPMG64()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MG\Version_Current\64bit\64bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        //--------------------End-----------------------//
        //--------------------Download SGP MGC -----------------//
        public FileResult SGPMGC32()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MGC\Version_Current\32bit\32bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public FileResult SGPMGC64()
        {
            try
            {
                var FileVirtualPath = String.Format(@"C:\MENU-GAME-CONTROL\Release Product\SGP MGC\Version_Current\64bit\64bit.rar");
                return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}