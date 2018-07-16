using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LaunchForm
{
    public partial class Laucher : Form
    {
        private IList<PartialForm.IconGameDisplaySpace> iconGameDisplays;
        private IGameMenuService gameMenuService;
        private Point pointGameItem;
        private SoundPlayer audio;
        private string urlAds;
        private int SumGame;
        private ITcpClientConnection _tcpClientConnection;
        private GameItem GameItemClick;
        public Laucher(ITcpClientConnection tcpClientConnection)
        {
            InitializeComponent();
            this.bunifuImageButton1.Image = null;
            this.bunifuImageButton2.Image = null;
            this.bunifuImageButton3.Image = null;
            this.bunifuImageButton4.Image = null;
            this.bunifuImageButton5.Image = null;
            this.bunifuImageButton6.Image = null;
            this.btn_allgame.Image = null;
            this.btn_onlinegame.Image = null;
            this.btn_offlinegame.Image = null;
            this.btn_gamehot.Image = null;
            this.btn_application.Image = null;
            this.btn_play.Image = null;
            audio = new SoundPlayer(SG.SubClient.GameMenu.UI.Properties.Resources.ding);
            this._tcpClientConnection = tcpClientConnection;
            gameMenuService = new GameMenuService(tcpClientConnection);
            btn_play.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }

        private void btn_maxisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Laucher_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void icongoogle_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", @"http://www.google.com/");
        }

        private void iconfacebook_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", @"http://www.fb.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome", @"http://www.sieugiaiphap.com/");
        }

        private void btn_allgame_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            IList<GameItem> games;
            do
            {
                games = gameMenuService.GetListAllGame();
            } while (games == null);

            SetDataForControlGameItem(games);
        }

        private void SetDataForControlGameItem(IEnumerable<GameItem> games)
        {
            if (games == null) return;
            this.pnl_gamebox.Controls.Clear();
            int i = 0, j = 0;

            foreach (var item in games)
            {
                int x = 18 + 110 * i++;
                int y = 9 + 105 * j;
                Image image = byteArrayToImage(item.IconImage);
                if (x < pnl_gamebox.Width)
                {
                    var gameitem = new PartialForm.Icon(new Point(x, y), image, new Size(85, 85));
                    gameitem.Click += new System.EventHandler(this.btn_gameicon_Click);
                    this.pnl_gamebox.Controls.Add(gameitem);
                }
                else
                {
                    j++;
                    i = 0;
                }                
            }
        }

        private void btn_gameicon_Click(object sender, EventArgs e)
        {
            GameItemClick = (GameItem)sender;
            btn_play.Enabled = true;
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            try
            {
                MemoryStream memstr = new MemoryStream(bytesArr);
                Image img = Image.FromStream(memstr);
                return img;
            }
            catch(Exception ex)
            {  }
            return null;
        }

        private void btn_onlinegame_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            IList<GameItem> games;
            do
            {
                games = gameMenuService.GetListAllGame();
            } while (games == null);
            
            var ol = games.Where(m => m.IsGameOnline == true);

            SetDataForControlGameItem(ol);
        }

        private void btn_offlinegame_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            IList<GameItem> games;
            do
            {
                games = gameMenuService.GetListAllGame();
            } while (games == null);
            var ol = games.Where(m => m.IsGameOnline == false);
            SetDataForControlGameItem(ol);
        }

        private void btn_gamehot_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            IList<GameItem> games;
            do
            {
                games = gameMenuService.GetListAllGame();
            } while (games == null);
            var ol = games.Where(m => m.IsGameHot == true);
            SetDataForControlGameItem(ol);
        }

        private void btn_application_Click(object sender, EventArgs e)
        {
            audio.PlaySync();
            _tcpClientConnection.SendData(ClauseTCP.GetGame);
            IList<GameItem> games;
            do
            {
                games = gameMenuService.GetListAllGame();
            } while (games == null);
            var ol = games.Where(m => m.IsApplication == true);

            SetDataForControlGameItem(ol);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if(GameItemClick == null)
            {
                MessageBox.Show("Mời chọn một game!");
            }
            else
                gameMenuService.RunGameAync(GameItemClick);
        }
    }
}
