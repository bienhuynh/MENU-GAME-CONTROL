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
    public partial class ChangePaswword : FormHcbbook
    {
        private IUserService userService;
        public ChangePaswword(IUserService _userService)
        {
            InitializeComponent();
            this.userService = _userService;
            RenameTitleForm("Đổi mật khẩu");
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(userService.Login(txtPasswordold.Text).IsSuccess)
            {
                if(txtPasswordold.Text!=null)
                {
                    if(txtPasswordold.Text.Count()>6)
                    {
                        userService.ChangePassword(txtpasswwordnew.Text);
                        MessageBox.Show("Đổi mật khẩu thành công.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ.");
            }
        }
    }
}
