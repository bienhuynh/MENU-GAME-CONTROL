using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGP.HCBBOOK.CloudServer.UI.Models
{
    public class DetailClientViewModel
    {
        public IList<LicenceDetailModel> licenceDetailModels { get; set; }
        public ComputerMACClientModel computerMACClientModel { get; set; }
    }
}