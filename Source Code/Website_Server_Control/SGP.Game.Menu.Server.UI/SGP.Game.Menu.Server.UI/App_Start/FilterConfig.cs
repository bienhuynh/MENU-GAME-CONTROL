﻿using System.Web;
using System.Web.Mvc;

namespace SGP.Game.Menu.Server.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
