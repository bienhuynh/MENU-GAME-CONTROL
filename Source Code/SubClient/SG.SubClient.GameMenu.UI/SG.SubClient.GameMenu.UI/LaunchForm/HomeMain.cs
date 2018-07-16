using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LaunchForm
{
    public partial class HomeMain : Form
    {
        private IList<PartialForm.IconGameDisplaySpace> iconGameDisplays;
        private IGameMenuService gameMenuService;
        private Point pointGameItem;
        private SoundPlayer audio;
        private string urlAds;
        private int SumGame;
        private ITcpClientConnection _tcpClientConnection;
        
        public HomeMain(ITcpClientConnection tcpClientConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //this.panel_Body.BackgroundImage = null;
            gameMenuService = new GameMenuService(tcpClientConnection);
            iconGameDisplays = new List<PartialForm.IconGameDisplaySpace>();
            pointGameItem = new Point(14, 22);
            audio = new SoundPlayer(SG.SubClient.GameMenu.UI.Properties.Resources.ding);
            urlAds = "https://garena.live/category/262161?region=vn";
            this._tcpClientConnection = tcpClientConnection;
            //LoadIconGame();
            locationTitleForm();
            //System.Diagnostics.Process.Start("http://124.158.13.36:81");
        }

        public void locationTitleForm()
        {
            //lblTitle.BringToFront();
            //lblTitle.Location = new Point((this.Width - this.lblTitle.Width) / 2, (this.border_top.Height - this.lblTitle.Height) / 2);
            btn_exit.Left = this.Width - 40;
            btn_maxisize.Left = this.Width - 90;
        }
        

        public void LoadIconGame()
        {
            var gameitems = gameMenuService.GetListAllGame();
            
            SetDataForControlGameItem(gameitems);
            DisplayGame(iconGameDisplays);
        }

        private void SetDataForControlGameItem(IList<GameItem> gameList)
        {
            if (gameList != null)
            {
                SumGame = gameList.Count();
                iconGameDisplays = new List<PartialForm.IconGameDisplaySpace>();
                foreach (var item in gameList)
                {   
                    var iconGame = new PartialForm.IconGameDisplaySpace(gameMenuService) { gameItem = item };
                    iconGame.SetData();
                    iconGameDisplays.Add(iconGame);
                }
            }
        }

        private void DisplayGame(IList<PartialForm.IconGameDisplaySpace> iconGameList)
        {
            int i = 0
                , widthGameItem = 165
                , heightGameItem = 61
                , locX = 0 // vị trí game hiện tại
                , locY = 0 //
                , line = 1 //số dòng game trên giao diện
                , gameperline = 10 // số game trên một dòng
                , openness = 24;//độ hở
            foreach (var iconGame in iconGameList.ToList())
            {
                locX = pointGameItem.X + (widthGameItem + openness) * i;
                locY = pointGameItem.Y * line;
                iconGame.BackColor = System.Drawing.Color.Transparent;
                iconGame.Location = new System.Drawing.Point(locX, locY);
                iconGame.Name = "iconGameDisplay1";
                iconGame.Size = new System.Drawing.Size(widthGameItem, heightGameItem);
                iconGame.TabIndex = 0;
                pnl_containGame.Controls.Add(iconGame);
                i++;
                line = i / gameperline + 1;
            }
            pnl_containGame.Show();
        }


        private void btn_closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            Point[] pontos =
            {
                new Point((int)(this.Width*0.1),0),
                new Point((int)(this.Width*0.9),0),
                new Point((int)(this.Width*0.86),40),
                new Point((int)(this.Width*0.14),40)
            };
            GraphicsPath poly = new GraphicsPath();
            poly.AddPolygon(pontos);
            border_top.Region = new Region(poly);

            Pen borda = new Pen(Color.Blue, 4);
            e.Graphics.DrawPolygon(borda, pontos);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_Resize(object sender, EventArgs e)
        {
            
        }

        private void border_top_Resize(object sender, EventArgs e)
        {
            locationTitleForm();
        }

        private void pnl_Logolink1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Logolink1_MouseHover(object sender, EventArgs e)
        {
            pnl_Logolink1.BorderStyle = BorderStyle.Fixed3D;
            audio.PlaySync();
        }

        private void pnl_Logolink1_MouseLeave(object sender, EventArgs e)
        {
            pnl_Logolink1.BorderStyle = BorderStyle.None;
            //audio.Stop();
        }

        private void pnl_Logolink2_MouseHover(object sender, EventArgs e)
        {
            pnl_Logolink2.BorderStyle = BorderStyle.Fixed3D;
            audio.PlaySync();
        }

        private void pnl_Logolink2_MouseLeave(object sender, EventArgs e)
        {
            pnl_Logolink2.BorderStyle = BorderStyle.None;
            //audio.Stop();
        }

        private void pnl_Logolink3_MouseHover(object sender, EventArgs e)
        {
            pnl_Logolink3.BorderStyle = BorderStyle.Fixed3D;
            audio.PlaySync();
        }

        private void pnl_Logolink3_MouseLeave(object sender, EventArgs e)
        {
            pnl_Logolink3.BorderStyle = BorderStyle.None;
            //audio.Stop();
        }
        private void hcbbookButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_Ads_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnl_Logolink1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlAds);
        }

        private void pnl_Logolink2_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlAds);
        }

        private void pnl_Logolink3_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlAds);
        }

        private void pnl_Ads_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlAds);
        }

        private void btn_TimGame_Click(object sender, EventArgs e)
        {
            //btn_TimGame.Text = "";
        }

        private void btn_TimGame_Enter(object sender, EventArgs e)
        {
            txt_TimGame.Text = "";
        }

        private void btn_TimGame_Click_1(object sender, EventArgs e)
        {
            SearchGameInList(txt_TimGame.Text);
        }
        private void RemoveControlGameitem()
        {
            pnl_containGame.Hide();
            pnl_containGame.Controls.Clear();
        }
        private void SearchGameInList(string namegame)
        {
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            //xoa game tren giao dien
            RemoveControlGameitem();
            SetDataForControlGameItem(gameMenuService.GetListAllGame());
            var dataSearch = iconGameDisplays.Where(m => m.gameItem.NameGame.Contains(namegame)).ToList();
            DisplayGame(dataSearch);
        }

        private void btn_MenuGameHot_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameHot.BackColor = System.Drawing.Color.Lime;
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            RemoveControlGameitem();
            SetDataForControlGameItem(gameMenuService.GetListAllGame());
            var dataSearch = iconGameDisplays.Where(m => m.gameItem.IsGameHot == true).ToList();
            DisplayGame(dataSearch);
        }

        private void btn_Allgame_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_Allgame.BackColor = System.Drawing.Color.Lime;
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            RemoveControlGameitem();
            //SetDataForControlGameItem(gameMenuService.GetListAllGame());
            LoadIconGame();
        }

        private void btn_MenuGameOnLine_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameOnLine.BackColor = System.Drawing.Color.Lime;
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            RemoveControlGameitem();
            SetDataForControlGameItem(gameMenuService.GetListAllGame());
            var dataSearch = iconGameDisplays.Where(m => m.gameItem.IsGameOnline == true).ToList();
            DisplayGame(dataSearch);
        }

        private void btn_MenuGameOffLine_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameOffLine.BackColor = System.Drawing.Color.Lime;
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            RemoveControlGameitem();
            SetDataForControlGameItem(gameMenuService.GetListAllGame());
            var dataSearch = iconGameDisplays.Where(m => m.gameItem.IsGameOnline == false).ToList();
            DisplayGame(dataSearch);
        }

        private void btn_MenuGameChienThuat_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameChienThuat.BackColor = System.Drawing.Color.Lime;
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            RemoveControlGameitem();
            SetDataForControlGameItem(gameMenuService.GetListAllGame());
            var dataSearch = iconGameDisplays.Where(m => m.gameItem.IsGameChienThuat == true).ToList();
            DisplayGame(dataSearch);
        }

        private void btn_Allgame_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_Allgame.BackColor = System.Drawing.Color.Lime;
        }

        private void btn_MenuGameHot_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameHot.BackColor = System.Drawing.Color.Lime;
        }

        private void btn_MenuGameHot_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
            this.btn_MenuGameHot.BackColor = System.Drawing.Color.Black;
        }

        private void btn_Allgame_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
            this.btn_Allgame.BackColor = System.Drawing.Color.Black;
        }

        private void btn_MenuGameOnLine_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameOnLine.BackColor = System.Drawing.Color.Lime;
        }

        private void btn_MenuGameOnLine_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
            this.btn_MenuGameOnLine.BackColor = System.Drawing.Color.Black;
        }

        private void btn_MenuGameOffLine_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameOffLine.BackColor = System.Drawing.Color.Lime;
        }

        private void btn_MenuGameOffLine_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
            this.btn_MenuGameOffLine.BackColor = System.Drawing.Color.Black;
        }

        private void btn_MenuGameChienThuat_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
            this.btn_MenuGameChienThuat.BackColor = System.Drawing.Color.Black;
        }

        private void btn_MenuGameChienThuat_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
            this.btn_MenuGameChienThuat.BackColor = System.Drawing.Color.Lime;
        }

        private void btn_MenuExit_MouseLeave(object sender, EventArgs e)
        {
            //audio.Stop();
        }

        private void btn_MenuExit_MouseHover(object sender, EventArgs e)
        {
            audio.PlaySync();
        }

        private void btn_maxisize_Click(object sender, EventArgs e)
        {

        }
    }
}
