using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class Itemgme : UserControl
    {
        public GameItem gameItem;
        private IGameMenuService gameMenuService;
        public Itemgme() { InitializeComponent(); }
        public Itemgme(IGameMenuService gameMenuService)
        {
            this.gameMenuService = gameMenuService;
            InitializeComponent();
        }

        private void Itemgme_Load(object sender, EventArgs e)
        {
            SetData();
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
        public void SetData()
        {
            lbl_NameGame.Text = gameItem.NameGame;
            lbl_Description.Text = gameItem.Description;
            try
            {
                picb_icongGame.Image = Image.FromFile(gameItem.IconUrL != null ? gameItem.IconUrL : String.Format("{0}SGP\\IMG\\Notfound.jpg", ReadPath.ReadDiskSaveData));
            }
            catch
            {
                picb_icongGame.Image = Image.FromFile(String.Format("{0}SGP\\IMG\\Notfound.jpg", ReadPath.ReadDiskSaveData));
            }
        }
    }
}
