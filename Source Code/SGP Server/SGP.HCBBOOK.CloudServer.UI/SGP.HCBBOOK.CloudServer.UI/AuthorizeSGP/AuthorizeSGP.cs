using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SGP.HCBBOOK.CloudServer.UI.AuthorizeSGP
{
    public class AuthorizeSGPAttribute: System.Web.Mvc.AuthorizeAttribute
    {
        private IUserService userService;

        public string[] RolesList;
        public AuthorizeSGPAttribute()
        {
            userService = new UserService();
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectResult("~/Error/Denied");
            }
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            foreach (var role in this.RolesList)
            {
                authorize = userService.CheckAdminSysRole(httpContext.User.Identity.Name, role);
                if (authorize)
                    break;
            }
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }
    
}