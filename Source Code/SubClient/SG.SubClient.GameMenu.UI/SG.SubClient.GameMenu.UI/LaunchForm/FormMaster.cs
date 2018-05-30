using SG.SubClient.GameMenu.UI.LogicFeature;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LaunchForm
{
    public partial class FormMaster : FormCustom
    {
        private IList<PartialForm.IconGameDisplay> iconGameDisplays;        
        private IGameMenuService gameMenuService;
        private Point pointGameItem;
        
        
        public FormMaster(ITcpClientConnection tcpClientConnection)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            gameMenuService = new GameMenuService(tcpClientConnection);
            iconGameDisplays = new List<PartialForm.IconGameDisplay>();            
            pointGameItem = new Point(14, 22);
            //tcpClientConnection.SendData(ClauseTCP.GetGame);
            //timer_updateGame.Interval = (1 * 1 * 1000); // 45 mins
            //timer_updateGame.Tick += new EventHandler(timer_updateGame_Tick);
            //timer_updateGame.Start();            

            //string data = tcpClientConnection.Result();
            LoadIconGame();
        }
        
        public void LoadIconGame()
        {
            var gameitems = gameMenuService.GetListAllGame();
            if (gameitems != null)
            {
                int i = 0
                , widthGameItem = 247
                , heightGameItem = 424 / 2
                , locX = 0 // vị trí game hiện tại
                , locY = 0 //
                , line = 1 //số dòng game trên giao diện
                , gameperline = 10 // số game trên một dòng
                , openness = 24;//độ hở
                foreach (var item in gameitems)
                {
                    var iconGame = new PartialForm.IconGameDisplay(gameMenuService) { gameItem = item };
                    iconGame.SetData();
                    locX += pointGameItem.X + widthGameItem * i + openness * i;
                    locY += pointGameItem.Y * line;
                    iconGame.BackColor = System.Drawing.Color.Transparent;
                    iconGame.Location = new System.Drawing.Point(locX, locY);
                    iconGame.Name = "iconGameDisplay1";
                    iconGame.Size = new System.Drawing.Size(widthGameItem, heightGameItem);
                    iconGame.TabIndex = 0;
                    pnl_bodyContent.Controls.Add(iconGame);
                    iconGameDisplays.Add(iconGame);
                    i++;
                    line = i / gameperline;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_updateGame_Tick(object sender, EventArgs e)
        {
            LoadIconGame();
            timer_updateGame.Interval = (5 * 60 * 1000);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            timer_updateGame.Stop();
            this.Close();
        }

        public void OnLoad()
        {
            LoadIconGame();
        }
    }
}
