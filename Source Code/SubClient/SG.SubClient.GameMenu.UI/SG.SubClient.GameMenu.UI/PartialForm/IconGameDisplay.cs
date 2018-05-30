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
using System.Diagnostics;

namespace SG.SubClient.GameMenu.UI.PartialForm
{
    public partial class IconGameDisplay : UserControl
    {
        public GameItem gameItem;
        private IGameMenuService gameMenuService;
        public IconGameDisplay(IGameMenuService gameMenuService)
        {
            this.gameMenuService = gameMenuService;
            InitializeComponent();
        }
        public void SetData()
        {
            lbl_namegame.Text = gameItem.NameGame;
            pic_IconGame.Image = Image.FromFile(gameItem.IconUrL);
        }

        private void pic_IconGame_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_namegame_Click(object sender, EventArgs e)
        {

        }

        private void pic_IconGame_DoubleClick(object sender, EventArgs e)
        {
            var res = gameMenuService.RunGame(gameItem);
        }
    }
}
