﻿using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGP.HCBBOOK.CloudServer.UI.Models
{
    public class GetAllListClientViewModel
    {
        public IList<ComputerMACClientModel> computerMACClientModels { get; set; }
    }
}