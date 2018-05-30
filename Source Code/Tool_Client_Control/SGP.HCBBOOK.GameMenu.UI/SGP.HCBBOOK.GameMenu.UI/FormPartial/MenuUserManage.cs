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
    public partial class MenuUserManage : UserControl
    {
        private IUserService userService;
        private ContainUpdateProfile ContainUpdateProfile;
        private FormMaster FormMaster;
        public MenuUserManage(IUserService _userService, ContainUpdateProfile _containUpdateProfile, FormMaster _formMaster)
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxLogo.Width - 3, pictureBoxLogo.Height - 3);
            Region rg = new Region(gp);
            pictureBoxLogo.Region = rg;
            this.FormMaster = _formMaster;
            this.ContainUpdateProfile = _containUpdateProfile;
            this.userService = _userService;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            userService.Logout();
            Application.Restart();
        }

        private void btn_UpdateProfile_Click(object sender, EventArgs e)
        {
            this.FormMaster.SetHeaderName("Quản lý tài khoản>Thông tin tài khoản");
            this.FormMaster.panel_Body.Controls.Clear();
            this.FormMaster.panel_Body.Controls.Add(this.ContainUpdateProfile);
            this.ContainUpdateProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainUpdateProfile.Show();
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            ChangePaswword changePaswword = new ChangePaswword(userService);
            changePaswword.Show();
        }

        private void btn_loginhistory_Click(object sender, EventArgs e)
        {
            LoginHisotory loginHisotory = new LoginHisotory(userService);
            loginHisotory.Show();
        }
    }
}
