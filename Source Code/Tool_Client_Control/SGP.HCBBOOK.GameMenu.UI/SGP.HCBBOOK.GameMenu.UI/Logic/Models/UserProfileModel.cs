using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Models
{
    public class UserProfileModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string NetName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsDisable { get; set; }
        public string LogoUrl { get; set; }
    }
}
