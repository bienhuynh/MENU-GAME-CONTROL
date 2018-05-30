using SGP.HCBBOOK.CloudServer.UI.Models;
using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff})]
    public class AccounttingController : Controller
    {
        private IUserService userService;
        public AccounttingController()
        {
            userService = new UserService();
        }
        // GET: Accountting
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff})]
        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.userProfileModels = userService.GetAllUser();
            return View(homeViewModel);
        }

        // GET: Accountting
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff })]
        public ActionResult Detail(string userid)
        {
            return View(userService.GetProfileByUserId(userid));
        }

        // GET: Accountting
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff })]
        public ActionResult Edit(string userid)
        {
            var user = userService.GetProfileByUserId(userid);
            return View(user);
            //return View(new RegisterUserViewModel
            //{
            //    Address = user.Address,
            //    DateCreate = user.DateCreate,
            //    Email = user.Email,
            //    FirstName = user.FirstName,
            //    IsDelete = user.IsDelete,
            //    IsDisable = user.IsDisable,
            //    LastName = user.LastName,
            //    LogoUrl = user.LogoUrl,
            //    NumberPhone = user.NumberPhone,
            //    Password = "",
            //    UserId = user.UserId
            //});
        }

        // GET: Accountting
        [HttpPost, ValidateAntiForgeryToken]
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff })]
        public ActionResult Edit(UserProfileModel userProfileModel)
        {
            userService.UpdateProfile(userProfileModel);
            return View(userProfileModel);
        }

        [HttpPost]
        public async Task<JsonResult> UploadAync(string userid)
        {
            try
            {
                foreach (string file in Request.Files)
                {
                    var fileContent = Request.Files[file];
                    if (fileContent != null && fileContent.ContentLength > 0 /*&& fileContent.ContentType == "application/octet-stream"*/)
                    {
                        // get a stream
                        var stream = fileContent.InputStream;
                        // and optionally write the file to disk
                        string fileName = Path.GetFileName(Request.Files[file].FileName);
                        //string typefile = (fileName.Trim().ToLower()).Substring(fileName.Length - 4, 4);
                        string typefile = Path.GetExtension(Request.Files[file].FileName);
                        //if (typefile != ".rom")
                        //{
                        //    return Json("Không phải file Rom.", JsonRequestBehavior.AllowGet);
                        //}
                        string directory = String.Format(@"{0}\{1}", PathUpload.PathUploadLogo, userid.Trim());
                        //string pathDiretory = Server.MapPath(directory);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        fileName = String.Format("{0}", fileName);
                        var path = Path.Combine(directory, fileName);
                        if (System.IO.File.Exists(path))
                            System.IO.File.Delete(path);

                        Request.Files[file].SaveAs(path);

                        ///Luw truy vet vao csdl
                        userService.UpdateLogo(userid, String.Format(@"{0}\{1}", userid, fileName));
                        return Json("Lưu thành công!");
                    }
                }
            }
            catch (Exception e)
            {

            }
            return Json("Lưu không thành công!");
        }

        public FileResult Download(string filename)
        {
            var FileVirtualPath = String.Format(@"{0}\{1}", PathUpload.PathUploadLogoVirtual, filename);
            return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
        }
    }
}