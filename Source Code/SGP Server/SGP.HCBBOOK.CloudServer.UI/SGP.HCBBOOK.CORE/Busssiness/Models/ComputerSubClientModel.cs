using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Models
{
    public class ComputerSubClientModel
    {
        public string MAC { get; set; }
        public string MacIdMaster { get; set; }
        public string NameComputer { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> DateJoin { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsDisable { get; set; }
    }
}
