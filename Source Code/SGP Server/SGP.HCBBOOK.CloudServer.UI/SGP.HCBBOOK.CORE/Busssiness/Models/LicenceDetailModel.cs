using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Models
{
    public class LicenceDetailModel
    {
        public string LicenceId { get; set; }
        public string LicenceKey { get; set; }
        public bool IsActive { get; set; }
        public int NumberDevicesLiveActive { get; set; }
        public int MaxNumberDevices { get; set; }
        public decimal Price { get; set; }
        public string Userid { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string UserIdCreate { get; set; }
    }
}
