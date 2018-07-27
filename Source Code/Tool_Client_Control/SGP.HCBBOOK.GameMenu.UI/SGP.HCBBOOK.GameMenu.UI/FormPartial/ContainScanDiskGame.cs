using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using TsudaKageyu;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using System.Media;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using SGP.HCBBOOK.GameMenu.UI.Models;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class ContainScanDiskGame : UserControl
    {
        private IGameMenuService gameMenuService;
        private IJsonService jsonService;

        private IList<IconGameDisplaySpace> iconGameDisplays;
        private Point pointGameItem;
        private SoundPlayer audio;
        private string urlAds;

        public ContainScanDiskGame(ICallAPIService _callAPIService)
        {
            InitializeComponent();
            gameMenuService = new GameMenuService(_callAPIService);
            jsonService = new JsonService();
            iconGameDisplays = new List<IconGameDisplaySpace>();
            pointGameItem = new Point(10, 10);
            audio = new SoundPlayer(SGP.HCBBOOK.GameMenu.UI.ResourceCustom.ding);
            urlAds = "https://garena.live/category/262161?region=vn";

        }

        private Task<bool> SetIcon()
        {
            pictureBox1.Image = global::SGP.HCBBOOK.GameMenu.UI.Properties.Resources.iconGame;
            
            return Task.FromResult(true);
        }

        public void LoadIconGame()
        {
            var gameitems = gameMenuService.JLoadGameItemFromDataJson();

            SetDataForControlGameItem(gameitems);
            DisplayGame(iconGameDisplays);
        }

        private void SetDataForControlGameItem(IList<Logic.Models.GameItem> gameList)
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
            pnl_Containresult.Controls.Clear();
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
                pnl_Containresult.Controls.Add(iconGame);
                i++;
                line = i / gameperline + 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private byte[] GetBytes(Icon icon)
        {
            MemoryStream ms = new MemoryStream();
            icon.Save(ms);
            return ms.ToArray();
        }

        
        private int viruses;
        private async void btn_Scan_Click(object sender, EventArgs e)
        {
            string pathico = ReadPath.ReadDiskSaveData;
            if(pathico == null)
            {
                MessageBox.Show("Vui lòng vào cài đặt chỉ định địa chỉ lưu hình ảnh Game trước khi scan.");
            }
            else
            {
                try
                {
                    btn_Scan.Enabled = false;
                    List<string> search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*_sgp.exe", SearchOption.AllDirectories).ToList();
                    progressBar1.Maximum = search.Count;
                    IList<Logic.Models.GameItem> gameItems = new List<Logic.Models.GameItem>();

                    foreach (string item in search)
                    {
                        try
                        {
                            viruses += 1;
                            lbl_Count.Text += listBox1.Items.Count;
                            listBox1.Items.Add(item);
                            IconExtractor m_iconExtractor;

                            Icon icon = null;
                            Icon[] splitIcons = null;
                            try
                            {
                                if (Path.GetExtension(item).ToLower() == ".ico")
                                {
                                    m_iconExtractor = null;
                                    icon = new Icon(item);
                                }
                                else
                                {
                                    m_iconExtractor = new IconExtractor(item);
                                    icon = m_iconExtractor.GetIcon(0);
                                }

                                splitIcons = IconUtil.Split(icon);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string[] spliturl = item.Split(@"\".ToCharArray());
                            string namegame = spliturl[spliturl.Length - 1].Substring(0, spliturl[spliturl.Length - 1].Length - "_sgp.exe".Length).ToUpper();
                            long size = DirectorySize.GetDirectorySize(folderBrowserDialog1.SelectedPath);
                            ///luu file icon
                            string urlIcon = String.Format("{0}SGP\\IMG\\ico", pathico);
                            if (!Directory.Exists(urlIcon))
                            {
                                Directory.CreateDirectory(urlIcon);
                            }
                            urlIcon = String.Format("{0}\\{1}.ico", urlIcon, namegame);
                            using (var fs = File.OpenWrite(urlIcon))
                            {
                                m_iconExtractor.Save(0, fs);
                            }
                            string idGame = await gameMenuService.JRandomIdGameAync();
                            gameItems.Add(new Logic.Models.GameItem
                            {
                                DateScan = DateTime.Now,
                                Description = "",
                                IconImage = m_iconExtractor.GetIconToByte(DirectorySize.GetIndexIconMaxSize(splitIcons)),
                                IconUrL = urlIcon,
                                Id = idGame,
                                NameGame = namegame,
                                Size = size,
                                URLExecute = item,
                                Version = "1.0",
                                IcoUrL = urlIcon
                            });

                            progressBar1.Increment(1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    await gameMenuService.JSaveGameonDiskAync(gameItems);
                    SetDataForControlGameItem(gameItems);
                    DisplayGame(iconGameDisplays);
                }
                catch(Exception ex)
                {
                    //"Vui lòng chọn đĩa game cần Scan trước."
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btn_selectPath_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            lbl_SelectPath.Text = folderBrowserDialog1.SelectedPath;
            viruses = 0;
            progressBar1.Value = 0;
            lbl_Count.Text += viruses.ToString();
            listBox1.Items.Clear();
            btn_Scan.Enabled = true;
        }

        private void btn_UploadToServer_Click(object sender, EventArgs e)
        {
            foreach(var item in iconGameDisplays)
            {
                gameMenuService.JUpdateGameToServer(item.gameItem);
                pnl_Containresult.Controls.Remove(item);
                item.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Count_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Addgame_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(gameMenuService);
            addGame.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
