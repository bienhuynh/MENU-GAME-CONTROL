using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class Setting : FormMaster
    {
        public Setting(ICallAPIService callAPIService):base(callAPIService)
        {
            InitializeComponent();
        }
    }
}
