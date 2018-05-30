using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class Login : FormMaster
    {
        
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            //disappear when the user starts typing
            //txtPassword.MouseClick += (sender, args) => {
            //    txtPassword.Text = "";
            //};
            //txtUsername.MouseClick += (sender, args) => {
            //    txtUsername.Text = "";
            //};
        }

        public bool LoginSys(LoginViewModel login)
        {
            LoginViewModel logindata = new LoginViewModel { IDAdmin = "1", UserName = "admin", Password = "123", RememberMe = false, Error = "None" };
            if (login.UserName == logindata.UserName && login.Password == logindata.Password)
                return true;
            return false;
        }

        private void hcbbook_BtnLogin_Click(object sender, EventArgs e)
        {
            if (LoginSys(new LoginViewModel { UserName = txtUsername.Text, Password = txtPassword.Text }))
            {
                Camara startProgram = new Camara();
                startProgram.Show();
            }
        }
    }
}
