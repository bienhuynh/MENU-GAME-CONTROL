using Newtonsoft.Json;
using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    
    public class ApiGameServiceController : Controller
    {
        private IGameService gameService;
        private IUserService userService;
        public ApiGameServiceController()
        {
            gameService = new GameService();
            userService = new UserService();
        }
        // GET: lay toan bo danh sach
        public Task<JsonResult> GetAllListGame()
        {
            var data = gameService.GetAllGameList();
            return Task.FromResult(Json(data,JsonRequestBehavior.AllowGet));
        }

        // GET: ApiGameService
        public Task<JsonResult> GetListGameByUser()
        {
            var data = gameService.GetGameListbyEmail(User.Identity.Name);
            return Task.FromResult(Json(data, JsonRequestBehavior.AllowGet));
        }

        // GET: ApiGameService
        public Task<JsonResult> DeleteGame(string gameId)
        {
            var data = gameService.DeleteGameAync(User.Identity.Name, gameId);
            return Task.FromResult(Json(data, JsonRequestBehavior.AllowGet));
        }

        // GET: ApiGameService
        public Task<JsonResult> UpdateCustomGame(ControlGameMenu controlGameMenu)
        {
            var data = gameService.UpdateGame(controlGameMenu);
            return Task.FromResult(Json(data, JsonRequestBehavior.AllowGet));
        }
    }
}