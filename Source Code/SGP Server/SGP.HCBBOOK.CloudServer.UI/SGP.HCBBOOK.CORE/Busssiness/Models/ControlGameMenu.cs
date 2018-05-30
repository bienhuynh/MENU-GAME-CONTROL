using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Models
{
    public class ControlGameMenu
    {
        public string GameId { get; set; }
        public string Userid { get; set; }
        public string IconUrL { get; set; }
        public string IcoUrL { get; set; }
        public bool IsGameOnline { get; set; }
        public bool IsGameHot { get; set; }
        public bool IsGameChienThuat { get; set; }
    }
}
