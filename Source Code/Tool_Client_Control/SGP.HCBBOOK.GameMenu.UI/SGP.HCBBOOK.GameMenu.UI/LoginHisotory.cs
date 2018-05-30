using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
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
    public partial class LoginHisotory : FormHcbbook
    {
        public LoginHisotory()
        {
            InitializeComponent();
            RenameTitleForm("Lịch sử đăng nhập");
        }
        private IUserService userService;
        public LoginHisotory(IUserService _userService)
        {
            InitializeComponent();
            this.userService = _userService;
            RenameTitleForm("Lịch sử đăng nhập");
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoginHisotory_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            ListtoDataTable converttable = new ListtoDataTable();
            table = converttable.ToDataTable<HistoryLoginSessionModel>(userService.GetLoginHistory());
            dataHistory.DataSource = table;
        }
    }
}
