using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Models
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
        public Nullable<float> Size { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public bool IsGameOnline { get; set; }
        public bool IsGameHot { get; set; }
        public bool IsGameChienThuat { get; set; }
        public bool IsApplication { get; set; }
        public IEnumerable<CategoryGame> CategoryGames { get; internal set; }
    }
}
