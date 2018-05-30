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

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class MenuManageListGame : UserControl
    {
        private IGameMenuService gameMenuService;
        private ContainListMenuGame containListMenuGame;
        private ContainScanDiskGame containScanDiskGame;
        private FormMaster FormMaster;
        public MenuManageListGame(
            IGameMenuService _gameMenuService,
            ContainListMenuGame _containListMenuGame, 
            ContainScanDiskGame _containScanDiskGame,
            FormMaster _formMaster)
        {
            this.containListMenuGame = _containListMenuGame;
            this.containScanDiskGame = _containScanDiskGame;
            this.FormMaster = _formMaster;
            this.gameMenuService = _gameMenuService;
            InitializeComponent();
        }

        private void btn_listGame_Click(object sender, EventArgs e)
        {
            this.FormMaster.SetHeaderName("Quản lý Game>Danh sách Game");
            this.FormMaster.panel_Body.Controls.Clear();

            this.FormMaster.panel_Body.Controls.Add(containListMenuGame);
            this.containListMenuGame.Dock = System.Windows.Forms.DockStyle.Fill;
            containListMenuGame.LoadIconGame();
            containListMenuGame.Show();
        }

        private void btn_scanDiskgame_Click(object sender, EventArgs e)
        {
            this.FormMaster.SetHeaderName("Quản lý Game>Quét đĩa Game");
            this.FormMaster.panel_Body.Controls.Clear();
            this.FormMaster.panel_Body.Controls.Add(containScanDiskGame);
            this.containScanDiskGame.Dock = System.Windows.Forms.DockStyle.Fill;
            containScanDiskGame.Show();
        }

        private void btn_addnewgame_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(this.gameMenuService);
            addGame.Show();
        }
    }
}
