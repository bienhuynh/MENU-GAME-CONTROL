using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Models
{
    public class ComputerMACClientModel
    {
        public string MAC { get; set; }
        public string UserId { get; set; }
        public string NameComputer { get; set; }
        public string SystemOperator { get; set; }
        public string IP { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsDisable { get; set; }
        public Nullable<System.DateTime> DateJoin { get; set; }
        public IList<LicenceLive> licenceLives { get; set; }
    }
    public class LicenceLive
    {
        public Nullable<bool> IsLive { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string LicenceId { get; set; }
        public string LicenceKey { get; set; }
    }
}
