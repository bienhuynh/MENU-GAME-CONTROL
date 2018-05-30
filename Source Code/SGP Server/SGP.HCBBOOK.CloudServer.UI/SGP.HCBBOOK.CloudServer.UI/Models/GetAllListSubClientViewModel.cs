using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGP.HCBBOOK.CloudServer.UI.Models
{
    public class GetAllListSubClientViewModel
    {
        public IList<ComputerSubClientModel> computerSubClientModels { get; set; }
    }
}