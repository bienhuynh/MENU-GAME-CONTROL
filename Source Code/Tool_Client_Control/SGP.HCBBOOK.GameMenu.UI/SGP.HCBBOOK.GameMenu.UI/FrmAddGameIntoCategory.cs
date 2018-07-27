using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class FrmAddGameIntoCategory : Form
    {
        /// <summary>
        /// chua tat ca game
        /// </summary>
        IList<GameItem> gameItems;
        /// <summary>
        /// chua cac game trong category
        /// </summary>
        IList<GameItem> categotygames;
        IGameMenuService gameMenuService;
        /// <summary>
        /// chi dinh mot game hien tai
        /// </summary>
        GameItem GameItemClick;
        /// <summary>
        /// co kiem tra trang thai thay doi vung lam viec cua GameItemClick
        /// true da thay doi
        /// false chua thay doi
        /// </summary>
        bool isChange = false;

        /// <summary>
        /// Co kiem tra da luu hay chua
        /// false chua luu
        /// true da luu
        /// </summary>
        bool isSave = true;

        int idCategory;
        ICategoryService categoryService;
        public FrmAddGameIntoCategory(IGameMenuService _gameMenuService)
        {
            InitializeComponent();
            this.gameMenuService = _gameMenuService;
            gameItems = gameMenuService.JLoadGameItemFromDataJson();
            this.categoryService = new CategoryService();
        }
        
        private void FrmAddGameIntoCategory_Load(object sender, EventArgs e)
        {
            IList<Logic.Models.CategoryGame> categoryGames = categoryService.GetCategoryGamesOnLocal();

            if (categoryGames == null)
            {
                categoryGames = new List<Logic.Models.CategoryGame>();
            }            
            cbm_Category.DisplayMember = "Text";
            cbm_Category.ValueMember = "Value";
            foreach (var item in categoryGames)
            {
                cbm_Category.Items.Add(new { Text = item.CategoryName, Value = item.Id });
            }
            LoadAllGame();
            btn_remove.Enabled = false;
            btn_removeall.Enabled = false;
            btn_add.Enabled = false;
            btn_addall.Enabled = false;
            btn_save.Enabled = false;
        }

        private void cbm_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult dialogResult = MessageBox.Show("Vui lòng lưu các thay đổi", "Bấm OK để lưu lại, nếu NO sẽ không lưu lại!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveGame();
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }

            lbl_Category.Text = cbm_Category.Text;
            idCategory = categoryService.GetCategoryGamesOnLocal().FirstOrDefault(m=>m.CategoryName == lbl_Category.Text).Id;
            List<GameItem> games = new List<GameItem>();
            foreach (var item in gameItems)
            {
                if (item.CategoryGames != null)
                {
                    foreach (var cate in item.CategoryGames)
                    {
                        if (cate.CategoryName == cbm_Category.Text)
                        {
                            games.Add(item);
                            break;
                        }
                    }
                }
            }
            if (categotygames != null)
                categotygames.Clear();
            categotygames = games;
            LoadGameBycategory();
        }

        private void SaveGame()
        {
            gameMenuService.JSaveGameonDisk(gameItems);
            MessageBox.Show("Lưu thành công!");
            isSave = true;
        }

        private void LoadGameBycategory()
        {
            this.pnl_GameofCategory.Controls.Clear();
            SetDataForControlGameItem(categotygames, this.pnl_GameofCategory, false);
        }

        private void LoadAllGame()
        {
            this.pnl_allGAme.Controls.Clear();
            SetDataForControlGameItem(gameItems, this.pnl_allGAme, true);
        }

        private void SetDataForControlGameItem(IEnumerable<GameItem> games, Panel panel, bool isall)
        {
            if (games == null) return;
            
            int i = 0, j = 0;

            foreach (var item in games)
            {
                int x = 28 + 90 * i++;
                int y = 9 + 90 * j;
                Image image = byteArrayToImage(item.IconImage);
                if (x < panel.Width - 90)
                {
                    var gameitem = new HCBBOOK.DesignItem.Icon(new Point(x, y), image, new Size(70, 70));
                    if(isall)
                    {
                        gameitem.Click += new System.EventHandler(this.btn_gameicon_Click);
                    }
                    else
                    {
                        gameitem.Click += new System.EventHandler(this.btn_gameiconCategory_Click);
                    }
                    
                    gameitem.idGame = item.Id;
                    panel.Controls.Add(gameitem);
                }
                else
                {
                    j++;
                    i = 0;
                }
            }
        }

        private void btn_gameiconCategory_Click(object sender, EventArgs e)
        {
            btn_remove.Enabled = true;
            btn_removeall.Enabled = true;
            btn_add.Enabled = false;
            btn_addall.Enabled = false;
            string idgame = ((HCBBOOK.DesignItem.Icon)sender).idGame;
            GameItemClick = gameItems.FirstOrDefault(m => m.Id == idgame);
            isChange = false;
            ShowGameinfo(GameItemClick);
        }

        private void btn_gameicon_Click(object sender, EventArgs e)
        {
            btn_remove.Enabled = false;
            btn_removeall.Enabled = false;
            btn_add.Enabled = true;
            btn_addall.Enabled = true;
            string idgame = ((HCBBOOK.DesignItem.Icon)sender).idGame;
            GameItemClick = gameItems.FirstOrDefault(m => m.Id == idgame);
            isChange = false;
            ShowGameinfo(GameItemClick);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            try
            {
                MemoryStream memstr = new MemoryStream(bytesArr);
                Image img = Image.FromStream(memstr);
                return img;
            }
            catch (Exception ex)
            { }
            return null;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null) return null;
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (isChange) return;
            if (categotygames == null)
            {
                MessageBox.Show("Mời chọn danh mục game!");
            }
            else
            {
                categotygames.Add(GameItemClick);
                var game = gameItems.FirstOrDefault(m=>m.Id == GameItemClick.Id);
                if(game.CategoryGames == null)
                {
                    game.CategoryGames = new List<CategoryGame>();
                }                
                if(game.CategoryGames.FirstOrDefault(m => m.CategoryName == lbl_Category.Text) == null)
                {
                    game.CategoryGames.Add(new CategoryGame() { CategoryName = lbl_Category.Text, Id = idCategory });
                }
                LoadGameBycategory();
            }
            isChange = true;
            isSave = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
        }

        private void btn_addall_Click(object sender, EventArgs e)
        {
            if (categotygames == null)
            {
                MessageBox.Show("Mời chọn danh mục game!");
            }
            else
            {
                categotygames.Clear();
                foreach(var game in gameItems)
                {
                    if (game.CategoryGames == null)
                    {
                        game.CategoryGames = new List<CategoryGame>();
                    }
                    if (game.CategoryGames.FirstOrDefault(m => m.CategoryName == lbl_Category.Text) == null)
                    {
                        game.CategoryGames.Add(new CategoryGame() { CategoryName = lbl_Category.Text, Id = idCategory });
                    }
                    categotygames.Add(game);
                }               
                LoadGameBycategory();
            }
            isChange = true;
            isSave = false;
            btn_save.Enabled = true;
            btn_addall.Enabled = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (isChange) return;
            if (categotygames == null)
            {
                MessageBox.Show("Mời chọn danh mục game!");
            }
            else
            {
                categotygames.Remove(GameItemClick);
                var game = gameItems.FirstOrDefault(m => m.Id == GameItemClick.Id);
                if (game == null)
                {
                    game = GameItemClick;
                    gameItems.Add(game);
                }                    
                if (game.CategoryGames == null)
                {
                    game.CategoryGames = new List<CategoryGame>();
                }
                var cate = game.CategoryGames.FirstOrDefault(m => m.CategoryName == lbl_Category.Text);
                if (cate != null)
                {
                    game.CategoryGames.Remove(cate);
                }
                LoadGameBycategory();
            }
            isChange = true;
            isSave = false;
            btn_save.Enabled = true;
            btn_remove.Enabled = false;
        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {
            if (categotygames == null)
            {
                MessageBox.Show("Mời chọn danh mục game!");
            }
            else
            {
                categotygames.Clear();
                foreach (var game in gameItems)
                {
                    if (game.CategoryGames == null)
                    {
                        game.CategoryGames = new List<CategoryGame>();
                    }
                    var cate = game.CategoryGames.FirstOrDefault(m => m.CategoryName == lbl_Category.Text);
                    if (cate != null)
                    {
                        game.CategoryGames.Remove(cate);
                    }
                }
                LoadGameBycategory();
            }
            isChange = true;
            isSave = false;
            btn_save.Enabled = true;
            btn_removeall.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(!isSave)
            {
                SaveGame();
                isSave = true;
                btn_save.Enabled = false;
            }
            btn_save.Enabled = false;
        }

        private void btn_AddGame_Click(object sender, EventArgs e)
        {
            ShowGameinfo(new GameItem { Id = Guid.NewGuid().ToString(), DateScan = DateTime.Now });
            btn_addgameindatabase.Enabled = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            gameItems = gameMenuService.JLoadGameItemFromDataJson();
            LoadAllGame();
            LoadGameBycategory();            
        }

        private void ShowGameinfo(GameItem gameItemClick)
        {
            txt_id.Text = gameItemClick.Id;
            txt_namegame.Text = gameItemClick.NameGame;
            txt_size.Text = gameItemClick.Size.ToString();
            txt_datecreate.Text = gameItemClick.DateScan.ToString();
            txt_decription.Text = gameItemClick.Description;
            txt_iconUrl.Text = gameItemClick.IconUrL;
            txt_urlexec.Text = gameItemClick.URLExecute;
            txt_version.Text = gameItemClick.Version;
            pnl_category.Controls.Clear();
            if (gameItemClick.CategoryGames != null)
            {
                foreach (var item in gameItemClick.CategoryGames)
                {
                    pnl_category.Controls.Add(new CheckBox() { Text = item.CategoryName, Checked = true });
                }
            }
            else
            {
                IList<Logic.Models.CategoryGame> categoryGames = categoryService.GetCategoryGamesOnLocal();
                int i = 0;
                foreach (var item in categoryGames)
                {
                    pnl_category.Controls.Add(new CheckBox() { Text = item.CategoryName, Checked = false, Location =new Point(7, 10 + i * 23) });
                    i++;
                }
            }
            Image image = byteArrayToImage(gameItemClick.IconImage);
            pictureBox1.Image = image;
        }

        private void btn_addgameindatabase_Click(object sender, EventArgs e)
        {
            LoadNewInfoGameToRAM();
            SaveGame();
            btn_addgameindatabase.Enabled = false;
            MessageBox.Show("Thành công!");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            GameItemClick = LoadNewInfoGameToRAM();
            SaveGame();
            btn_addgameindatabase.Enabled = false;
            MessageBox.Show("Thành công!");
        }

        private GameItem LoadNewInfoGameToRAM()
        {
            IList<CategoryGame> categorys = new List<CategoryGame>();
            foreach (CheckBox item in pnl_category.Controls)
            {
                var cate = categoryService.GetCategoryGamesOnLocal().FirstOrDefault(m => m.CategoryName == item.Text);
                categorys.Add(cate);
            }
            
            GameItem gameItem = new GameItem()
            {
                Id = txt_id.Text,
                DateScan = DateTime.Parse(txt_datecreate.Text),
                Description = txt_decription.Text,
                IconUrL = txt_iconUrl.Text,
                IcoUrL = txt_iconUrl.Text,
                NameGame = txt_namegame.Text,
                Size = float.Parse(txt_size.Text),
                URLExecute = txt_urlexec.Text,
                Version = txt_version.Text,
                IconImage = imageToByteArray(pictureBox1.Image),
                CategoryGames = categorys
            };
            var game = gameItems.FirstOrDefault(m=>m.Id == gameItem.Id);
            if(game == null)
            {
                gameItems.Add(gameItem);
            }
            else
            {
                gameItems.Remove(game);
                gameItems.Add(gameItem);
            }
            return gameItem;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_iconUrl.Text = openFileDialog1.FileName;

                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_urlexec.Text = openFileDialog2.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
