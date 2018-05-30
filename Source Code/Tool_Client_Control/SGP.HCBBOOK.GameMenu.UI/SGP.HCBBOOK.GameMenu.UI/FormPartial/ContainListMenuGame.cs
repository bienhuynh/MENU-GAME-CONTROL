using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGP.HCBBOOK.GameMenu.UI.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class ContainListMenuGame : UserControl
    {
        private IGameMenuService gameMenuService;
        private IList<GameItem> gameItems;
        private IList<Itemgme> itemgmes;
        private IList<IconGameDisplaySpace> iconGameDisplays;
        public Point pointGameItem;

        public IList<GameItem> GameItems { get => gameItems; set => gameItems = value; }
        public IList<Itemgme> Itemgmes { get => itemgmes; set => itemgmes = value; }

        public ContainListMenuGame(ICallAPIService _callAPIService)
        {
            InitializeComponent();
            gameMenuService = new GameMenuService(_callAPIService);
            iconGameDisplays = new List<IconGameDisplaySpace>();
            pointGameItem = new Point(10, 10);
            LoadIconGame();
            this.Width = 713;
            this.Height = 708;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ContainListMenuGame_Load(object sender, EventArgs e)
        {
                 
        }
        
        public async void UpdateGame()
        {
            try
            {
                await gameMenuService.GetListGameOnServer();
            }
            catch
            {
                MessageBox.Show("Mất kết nối đến server.");
            }
        }

        public void LoadIconGame()
        {
            var gameitems = gameMenuService.JLoadGameItemFromDataJson();

            SetDataForControlGameItem(gameitems);
            DisplayGame(iconGameDisplays);
        }

        private void SetDataForControlGameItem(IList<GameItem> gameList)
        {
            if (gameList != null)
            {
                iconGameDisplays.Clear();
                iconGameDisplays = new List<IconGameDisplaySpace>();
                foreach (var item in gameList)
                {
                    var iconGame = new IconGameDisplaySpace(gameMenuService) { gameItem = item };
                    iconGame.SetData();
                    iconGameDisplays.Add(iconGame);
                }
            }
        }

        private void DisplayGame(IList<IconGameDisplaySpace> iconGameList)
        {
            pnl_Content.Controls.Clear();
            int i = 0
                , widthGameItem = SettingIconSize.Width
                , heightGameItem = SettingIconSize.Height
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
                pnl_Content.Controls.Add(iconGame);
                i++;
                line = i / gameperline + 1;
            }
        }

        public void SetDesignItemGame()
        {
            GameItems = gameMenuService.JLoadGameItemFromDataJson();
            itemgmes = new List<Itemgme>();
            int i = 0
                , widthGameItem = 247
                , heightGameItem = 424/2
                , locX = 0 // vị trí game hiện tại
                , locY = 0 //
                , line = 1 //số dòng game trên giao diện
                , gameperline = 3 // số game trên một dòng
                , openness = 24;//độ hở
            if (GameItems != null)
            {
                if (GameItems.Count() > 0)
                {
                    foreach (var item in GameItems)
                    {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainListMenuGame));
                        locX += pointGameItem.X + widthGameItem * i + openness * i;
                        locY += pointGameItem.Y * line;
                        Itemgme itemgmeInlist = new Itemgme(gameMenuService) { gameItem = item };
                        itemgmeInlist.SetData();
                        itemgmeInlist.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                        itemgmeInlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemgme.BackgroundImage")));
                        itemgmeInlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        itemgmeInlist.Location = new System.Drawing.Point(locX, locY);
                        itemgmeInlist.Name = "itemgme" + i;
                        itemgmeInlist.Size = new System.Drawing.Size(widthGameItem, heightGameItem);
                        itemgmeInlist.TabIndex = 4;
                        pnl_Content.Controls.Add(itemgmeInlist);
                        Itemgmes.Add(itemgmeInlist);
                        i++;
                        line = i / gameperline;
                    }
                }
            }
        }

        private void pnl_Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
