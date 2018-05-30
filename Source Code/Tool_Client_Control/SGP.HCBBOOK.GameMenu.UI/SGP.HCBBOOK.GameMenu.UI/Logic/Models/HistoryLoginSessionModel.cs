using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Models
{
    public class HistoryLoginSessionModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool Remember { get; set; }
        public bool IsLoginFirst { get; set; }
        public string KeyLience { get; set; }
        public DateTime LoginTime { get; set; }
        public string IPAddress { get; set; }
        public string MACAddress { get; set; }
        public string NameMachine { get; set; }
        [DefaultValue(true)]
        public bool IsLogin { get; set; }
    }
}
