using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGP.HCBBOOK.CloudServer.UI.Models
{
    public class ChangeLicenceKeyForClient
    {
        public string LicenceKey { get; set; }
        public string NameComputer { get; set; }        
        public string ClientId { get; set; }
    }
}