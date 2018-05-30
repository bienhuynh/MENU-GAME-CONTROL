using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.SubClient.GameMenu.UI.Models
{
    public class GameItem
    {
        public string Id { get; set; }
        public string NameGame { get; set; }
        public string URLExecute { get; set; }
        public string IconUrL { get; set; }
        public string IcoUrL { get; set; }
        public byte[] IconImage { get; set; }
        public Nullable<System.DateTime> DateScan { get; set; }
        public Nullable<double> Size { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public bool IsGameOnline { get; set; }
        public bool IsGameHot { get; set; }
        public bool IsGameChienThuat { get; set; }
    }
}
