using Microsoft.AspNet.Identity.Owin;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class Login : FormHcbbook
    {
        private LoginModel loginModel;
        private IUserService userService;
        private HomeMain Form;
        public Login(HomeMain homeMain)
        {
            InitializeComponent();
            loginModel = new LoginModel();
            userService = homeMain.userService;
            txt_Password.isPassword = true;
            this.Form = homeMain;
            this.RenameTitleForm("SGP Login System");
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            txt_Email.Text = "";
        }

        private void btn_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(SwitchLoginFirst.Value)
            {
                pnl_LoginFirst.Show();
            }
            else
            {
                pnl_LoginFirst.Hide();
            }

            this.Form.Hide();
        }

        private void btn_Email_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Email.Text.Count() == 0)  txt_Email.Text = null;
        }

        private void btn_Email_MouseLeave(object sender, EventArgs e)
        {
            if(txt_Email.Text.Count() == 0)
                txt_Email.Text = "Email";
        }

        private void btn_Password_MouseEnter(object sender, EventArgs e)
        {
            if(txt_Password.Text.Count() == 0)
                txt_Password.Text = null;
        }

        private void btn_Password_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Password.Text.Count() == 0)
                txt_Password.Text = "Password";
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_Email.Text.Count()==0)
            {
                MessageBox.Show("Mời Nhập Email!");
            }
            else
            {
                if (txt_Password.Text.Count() == 0)
                {
                    MessageBox.Show("Mời Nhập Password!");
                }
                else
                {
                    loginModel.Email = txt_Email.Text;
                    loginModel.Password = txt_Password.Text;
                    loginModel.LoginTime = DateTime.Now;
                    loginModel.NameMachine= Environment.MachineName;
                    loginModel.IPAddress = Dns.GetHostAddresses(Environment.MachineName).FirstOrDefault(m=>m.AddressFamily== AddressFamily.InterNetwork).ToString();
                    loginModel.MACAddress = GetAddressPhysicallService.GetMacAddress();
                    if (SwitchLoginFirst.Value)
                    {
                        loginModel.KeyLience = String.Format("{0}-{1}-{2}-{3}-{4}", txtKey1.Text, txtKey2.Text, txtKey3.Text, txtKey4.Text, txtKey5.Text);
                    }

                    var res = await userService.LoginAync(loginModel);
                    if (res.IsSuccess)
                    {
                        this.Form.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.Message);
                    }
                }
            }
        }

        private void SwitchLoginFirst_Click(object sender, EventArgs e)
        {
            if (SwitchLoginFirst.Value)
            {
                pnl_LoginFirst.Show();
            }
            else
            {
                pnl_LoginFirst.Hide();
            }
            loginModel.IsLoginFirst = SwitchLoginFirst.Value;
        }

        private void SwitchRememberPass_Click(object sender, EventArgs e)
        {
            loginModel.Remember = SwitchRememberPass.Value;
        }

        private void txtKey1_OnValueChanged(object sender, EventArgs e)
        {
            if (txtKey1.Text.Count() >= 5) 
            {
                txtKey2.Text = "";
                txtKey2.Focus();
            }
        }

        private void txtKey2_OnValueChanged(object sender, EventArgs e)
        {
            if (txtKey2.Text.Count() >= 5)
            {
                txtKey3.Text = "";
                txtKey3.Focus();
            }
        }

        private void txtKey3_OnValueChanged(object sender, EventArgs e)
        {
            if (txtKey3.Text.Count() >= 5)
            {
                txtKey4.Text = "";
                txtKey4.Focus();
            }
        }

        private void txtKey4_OnValueChanged(object sender, EventArgs e)
        {
            if (txtKey4.Text.Count() >= 5)
            {
                txtKey5.Text = "";
                txtKey5.Focus();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Form.Close();
            //Application.Exit();
            Environment.Exit(0);
        }

        //static async Task<SignInStatus> LoginAsync(string email, string passwword)
        //{
        //    // Update port # in the following line.
        //    HttpClient client = new HttpClient();

        //    client.BaseAddress = new Uri("http://localhost:64195/Account/Login");

        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
        //    var data = new FormUrlEncodedContent(new LoginViewModel { Email = email, Password = passwword, RememberMe = false });
        //    HttpResponseMessage response = await client.PostAsync(client.BaseAddress, new LoginViewModel { Email = email, Password = passwword, RememberMe = false });
        //    if (response.IsSuccessStatusCode)
        //    {
        //        SignInStatus res = await response.Content.ReadAsAsync<SignInStatus>();
        //        return res;
        //    }
        //    return SignInStatus.Failure;
        //}
    }
}
