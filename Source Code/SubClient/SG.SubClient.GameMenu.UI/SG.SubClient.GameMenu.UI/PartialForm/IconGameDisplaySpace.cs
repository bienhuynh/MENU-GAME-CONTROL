using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SG.SubClient.GameMenu.UI.Models;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;

namespace SG.SubClient.GameMenu.UI.PartialForm
{
    public partial class IconGameDisplaySpace : UserControl
    {
        public GameItem gameItem;
        private IGameMenuService gameMenuService;
        public IconGameDisplaySpace(IGameMenuService gameMenuService)
        {
            this.gameMenuService = gameMenuService;
            InitializeComponent();
        }

        public void SetData()
        {
            lbl_namegame.Text = gameItem.NameGame;
            pic_IconGame.Image = Image.FromFile(gameItem.IconUrL);
        }

        private void pnl_itemgame_DoubleClick(object sender, EventArgs e)
        {
            var res = gameMenuService.RunGame(gameItem);
        }

        private void pic_IconGame_DoubleClick(object sender, EventArgs e)
        {
            var res = gameMenuService.RunGame(gameItem);
        }

        private void lbl_namegame_DoubleClick(object sender, EventArgs e)
        {
            var res = gameMenuService.RunGame(gameItem);
        }
    }
}
