using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Models
{
    public class SettingGlobal
    {
        //lưu hình ảnh game
        public string DiskSaveData { get; set; }
        /// <summary>
        /// lưu địa chi cloud SGP
        /// </summary>
        public string IpAddressCloud { get; set; }
        /// <summary>
        /// Lưu port Cloud SGP
        /// </summary>
        public int? portCloud { get; set; }
    }
}
