using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Remember { get; set; }
        public bool IsLoginFirst { get; set; }
        public string KeyLience { get; set; }
        public DateTime LoginTime { get; set; }
        public string IPAddress { get; set; }
        public string MACAddress { get; set; }
        public string NameMachine { get; set; }
    }
}
