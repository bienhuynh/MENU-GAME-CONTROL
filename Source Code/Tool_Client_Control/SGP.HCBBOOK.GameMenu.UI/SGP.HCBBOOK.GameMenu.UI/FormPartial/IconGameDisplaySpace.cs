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
using SGP.HCBBOOK.GameMenu.UI.Models;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class IconGameDisplaySpace : UserControl
    {
        public GameItem gameItem;
        private IGameMenuService _gameMenuService;
        public IconGameDisplaySpace(IGameMenuService gameMenuService)
        {
            this._gameMenuService = gameMenuService;
            InitializeComponent();
        }

        public void SetData()
        {
            lbl_namegame.Text = gameItem.NameGame;
            pic_IconGame.Image = Image.FromFile(gameItem.IconUrL);
        }

        private void pnl_itemgame_DoubleClick(object sender, EventArgs e)
        {
            var res = _gameMenuService.RunGame(gameItem);
        }

        private void pic_IconGame_DoubleClick(object sender, EventArgs e)
        {
            var res = _gameMenuService.RunGame(gameItem);
        }

        private void lbl_namegame_DoubleClick(object sender, EventArgs e)
        {
            var res = _gameMenuService.RunGame(gameItem);
        }
    }
}
