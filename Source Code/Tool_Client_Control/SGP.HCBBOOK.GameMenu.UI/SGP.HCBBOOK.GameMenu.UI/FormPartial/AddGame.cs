using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
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
using TsudaKageyu;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class AddGame : FormHcbbook
    {
        private Itemgme itemgme;
        private IGameMenuService gameMenuService;
        public AddGame(IGameMenuService _gameMenuService)
        {
            InitializeComponent();
            this.gameMenuService = _gameMenuService;
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            btn_saveGame.Enabled = false;
            btn_choosePicture.Enabled = false;
            RenameTitleForm("Thêm game mới.");
        }
        private int viruses;
        private async void btn_ChooseGame_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Logic.Models.GameItem gameItem = null;
                progressBar1.Value = 20;
                try
                {
                    viruses += 1;
                    IconExtractor m_iconExtractor;

                    Icon icon = null;
                    Icon[] splitIcons = null;
                    progressBar1.Value = 30;
                    try
                    {
                        if (Path.GetExtension(openFileDialog1.FileName).ToLower() == ".ico")
                        {
                            m_iconExtractor = null;
                            icon = new Icon(openFileDialog1.FileName);
                        }
                        else
                        {
                            m_iconExtractor = new IconExtractor(openFileDialog1.FileName);
                            icon = m_iconExtractor.GetIcon(0);
                        }

                        splitIcons = IconUtil.Split(icon);
                        progressBar1.Value = 50;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    progressBar1.Value = 60;
                    string[] spliturl = openFileDialog1.FileName.Split(@"\".ToCharArray());
                    string namegame = spliturl[spliturl.Length - 1].Substring(0, spliturl[spliturl.Length - 1].Length - ".exe".Length).ToUpper();
                    long size = new System.IO.FileInfo(openFileDialog1.FileName).Length;
                    ///luu file icon
                    string urlIcon = String.Format("{0}SGP\\IMG\\ico\\{1}.ico", ReadPath.ReadDiskSaveData, namegame);
                    using (var fs = File.OpenWrite(urlIcon))
                    {
                        m_iconExtractor.Save(0, fs);
                    }
                    string idGame = "";
                    if (gameMenuService!=null)
                    {
                         idGame = await gameMenuService.JRandomIdGameAync();
                    }
                    progressBar1.Value = 70;
                    gameItem = new Logic.Models.GameItem
                    {
                        DateScan = DateTime.Now,
                        Description = "",
                        IconImage = m_iconExtractor.GetIconToByte(DirectorySize.GetIndexIconMaxSize(splitIcons)),
                        IconUrL = urlIcon,
                        Id = idGame,
                        NameGame = namegame,
                        Size = size,
                        URLExecute = openFileDialog1.FileName,
                        Version = "1.0",
                        IcoUrL = urlIcon
                    };

                    progressBar1.Value = 90;
                    ///Display game
                    txtNamegame.Text = gameItem.NameGame;
                    txtDescriptionGame.Text = gameItem.Description;
                    itemgme = new Itemgme(gameMenuService) { gameItem = gameItem };
                    pnlGamedisplay.Controls.Add(itemgme);
                    this.itemgme.Dock = DockStyle.Fill;
                    itemgme.SetData();
                    itemgme.Show();
                    progressBar1.Value = 100;
                    btn_saveGame.Enabled = true;
                    btn_choosePicture.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn game cần thêm trước.");
                }
            }
            
        }

        private void btn_saveGame_Click(object sender, EventArgs e)
        {
            if(itemgme!=null)
            {
                if(itemgme.gameItem!=null)
                {
                    itemgme.gameItem.NameGame = txtNamegame.Text;
                    itemgme.gameItem.Description = txtDescriptionGame.Text;
                    if(gameMenuService.JAddGameInLocal(itemgme.gameItem))
                    {
                        MessageBox.Show("Thêm thành công.");
                    }
                }
            }
        }

        private void txtNamegame_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
