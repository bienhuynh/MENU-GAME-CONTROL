using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.SubClient.GameMenu.UI.Models
{
    public static class ClauseTCP
    {
        /// <summary>
        /// lấy danh sách game tra về string json
        /// </summary>
        public const string GetGame = "GetGame";
        /// <summary>
        /// Cap nhật dữ liệu
        /// </summary>
        public const string UpdateData = "UpdateData";
        /// <summary>
        /// xac nhan may tram va ket noi voi voi may chu
        /// </summary>
        public const string Authenticate = "Authenticate";
    }
}
