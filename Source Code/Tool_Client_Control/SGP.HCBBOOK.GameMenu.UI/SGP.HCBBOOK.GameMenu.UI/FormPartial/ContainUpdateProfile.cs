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
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class ContainUpdateProfile : UserControl
    {
        private IUserService userService;
        public ContainUpdateProfile(IUserService _userService)
        {
            InitializeComponent();
            this.userService = _userService;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddressHome_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ContainUpdateProfile_Load(object sender, EventArgs e)
        {
            Enabled();
            SetData(userService.GetProfile());
        }

        private void Enabled()
        {
            txtAddressHome.Enabled = false;
            txtDateCreate.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtnumberphone.Enabled = false;
            txtNetname.Enabled = false;
        }

        public void SetData(UserProfileModel userProfileModel)
        {
            lblEmail.Text = userProfileModel.Email;
            lblNameTiemNet.Text = userProfileModel.NetName;
            txtAddressHome.Text = userProfileModel.Address;
            txtDateCreate.Text = userProfileModel.DateCreate.ToString();
            txtEmail.Text = userProfileModel.Email;
            txtFirstname.Text = userProfileModel.FirstName;
            txtLastname.Text = userProfileModel.LastName;
            txtnumberphone.Text = userProfileModel.NumberPhone;
            txtNetname.Text = userProfileModel.NetName;
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            ChangePaswword changePaswword = new ChangePaswword(userService);
            changePaswword.Show();
        }

        private void btn_sync_Click(object sender, EventArgs e)
        {

        }
    }
}
