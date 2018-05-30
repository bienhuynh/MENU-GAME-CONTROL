using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    [Authorize]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult _404()
        {
            return View();
        }

        // GET: Error
        public ActionResult Denied()
        {
            return View();
        }
    }
}