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
    public class GameManageController : Controller
    {
        private IGameService gameService;
        private IUserService userService;
        public GameManageController()
        {
            gameService = new GameService();
            userService = new UserService();
        }
        // GET: GameManage
        [AuthorizeSGP.AuthorizeSGP(RolesList = new string[] { RolesSys.Admin, RolesSys.Staff })]
        public ActionResult Index()
        {
            return View(new GameManageViewModel { games= gameService.GetAllGameList() });
        }

        // GET: GameManage
        public ActionResult Detail(string id)
        {
            return View();
        }

        // GET: GameManage
        public ActionResult Edit(string id)
        {
            return View();
        }
    }
}