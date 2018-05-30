using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class MenuMain : UserControl
    {
        private IUserService userService;
        public MenuMain(IUserService _userService)
        {
            InitializeComponent();
            this.userService = _userService;
        }

        private void btn_settingPathSaveData_Click(object sender, EventArgs e)
        {
            SettingPath settingPath = new SettingPath();
            settingPath.Show();

        }

        private void btn_exitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_loginHistory_Click(object sender, EventArgs e)
        {
            LoginHisotory loginHisotory = new LoginHisotory(userService);
            loginHisotory.Show();
        }
    }
}
