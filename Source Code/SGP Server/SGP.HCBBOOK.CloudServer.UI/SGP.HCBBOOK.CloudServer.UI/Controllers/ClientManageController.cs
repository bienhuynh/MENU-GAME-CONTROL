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
    public class ClientManageController : Controller
    {
        private IComputerMACClientService computerMACClientService;
        private IUserService userService;
        public ClientManageController()
        {
            computerMACClientService = new ComputerMACClientService();
            userService = new UserService();
        }
        // GET: ClientManage
        /// <summary>
        /// Admin, Nha vien: Show danh sach tat ca may client, tro link lien ket xem chi tiet may client
        /// Client: Show danh sach may Client cua nguoi do, dc xem chi tiet may Client, dc chinh sua thong tin neu co
        /// </summary>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Xem chi tiet thong tin may Client: danh sach may SubClient cua no,
        /// dang dung Lincence key nao, 
        /// go bo liecence key nay, 
        /// thay doi lincence key khac
        /// Cho phep Chinh sua
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult DetailClient(string clientId)
        {
            return View();
        }

        /// <summary>
        /// Admin, Staff: Xem danh sach tat ca may Sub Client
        /// </summary>
        /// <returns></returns>
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult Subclient()
        {
            return View();
        }
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Client })]
        public ActionResult ControlMenu()
        {
            return View();
        }

        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult GetAllListClient()
        {
            var list = computerMACClientService.GetAllListClient();
            return View(new GetAllListClientViewModel { computerMACClientModels = list});
        }

        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult GetAllListSubClient()
        {
            var list = computerMACClientService.GetAllListSubClient();
            return View(new GetAllListSubClientViewModel { computerSubClientModels = list });
        }

        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult GetListClientNotActiveLicence()
        {
            IList<ComputerMACClientModel> computerMACClients = new List<ComputerMACClientModel>();
            var listClient = computerMACClientService.GetAllListClient();

            if (listClient != null)
            {
                foreach (var item in listClient)
                {
                    if (item.licenceLives.Where(m => m.IsLive == false).Count() > 0)
                        computerMACClients.Add(item);
                }
            }
            string userid = userService.GetUserId(User.Identity.Name);
            if (userService.CheckAdminSysRole(User.Identity.Name,RolesSys.Client))
            {

                computerMACClients = computerMACClients.Where(m => m.UserId == userid).ToList();
            }
            return View(new GetListClientNotActiveLicenceViewModel { computerMACClients = computerMACClients });
        }

        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff, RolesSys.Client })]
        public ActionResult GetListClientActiveLicence()
        {
            IList<ComputerMACClientModel> computerMACClients = new List<ComputerMACClientModel>();
            var listClient = computerMACClientService.GetAllListClient();

            if (listClient != null)
            {
                foreach (var item in listClient)
                {
                    if (item.licenceLives.Where(m => m.IsLive == true && m.IsActive == true).Count() > 0)
                        computerMACClients.Add(item);
                }
            }
            string userid = userService.GetUserId(User.Identity.Name);
            if (userService.CheckAdminSysRole(User.Identity.Name, RolesSys.Client))
            {

                computerMACClients = computerMACClients.Where(m => m.UserId == userid).ToList();
            }
            return View(new GetListClientActiveLicenceViewModel { computerMACClients = computerMACClients });
        }
        
    }
}