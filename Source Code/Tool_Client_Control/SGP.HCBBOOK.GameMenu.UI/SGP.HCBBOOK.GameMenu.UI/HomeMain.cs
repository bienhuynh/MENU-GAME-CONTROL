using SGP.HCBBOOK.GameMenu.UI.FormPartial;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class HomeMain : FormMaster
    {
        private IList<GameItem> gameItems;
        private ICallAPIService CallAPIService;
        private Login Login;

        public HomeMain(ICallAPIService _callAPIService) : base(_callAPIService)
        {
            InitializeComponent();
            this.CallAPIService = _callAPIService;
            
        }

        private async Task<bool> GetListGame()
        {
            IList<Logic.Models.GameItem> listGame = await gameMenuService.GetListGameOnServer();
            gameItems = listGame; 
            return true;
        }
        
        private void btn_closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {

        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Menu_MouseHover(object sender, EventArgs e)
        {
            //PanelSilderMenu.Width = 235;
        }

        private void btn_Menu_MouseLeave(object sender, EventArgs e)
        {
            //PanelSilderMenu.Width = 0;
        }

        private void containUpdateProfile2_Load(object sender, EventArgs e)
        {
            
        }

        private void HomeMain_Load(object sender, EventArgs e)
        {
            //neu co nho mk thi bo qua dang nhap
            if(!userService.IsRememberLogin())
            {
                Login = new Login(this);
                this.Hide();
                Login.ShowDialog();
            }
        }

        private void btn_closeapp_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
