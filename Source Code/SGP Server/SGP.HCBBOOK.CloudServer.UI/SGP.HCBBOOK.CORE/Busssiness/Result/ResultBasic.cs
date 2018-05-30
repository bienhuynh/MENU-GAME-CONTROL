using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Result
{
    public class ResultBasic
    {
        public bool IsSuccess { get; set; }
        public int CodeError { get; set; }
        public string Message { get; set; }
    }
}
