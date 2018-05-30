using RedCell.Diagnostics.Update;
using SGP.HCBBOOK.GameMenu.UI.FormPartial;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using Newtonsoft.Json;
using SGP.HCBBOOK.GameMenu.UI.Models;

namespace SGP.HCBBOOK.GameMenu.UI
{
    public partial class FormMaster : Form
    {
        public IUserService userService;
        public IGameMenuService gameMenuService;
        private bool[] onClick;
        /// <summary>
        /// Menu
        /// </summary>
        public MenuMain menuMain;
        public MenuManageLicence menuManageLicence;
        public MenuManageListGame menuManageListGame;
        public MenuUserManage menuUserManage;

        /// <summary>
        /// Noi dung
        /// </summary>
        public ContainScanDiskGame containScanDiskGame;
        public ContainUpdateProfile containUpdateProfile;
        public ContainListMenuGame containListMenuGame;
        public ContainGameList containGameList;
        public CantainControlMenu cantainControlMenu;
        public FormMaster(ICallAPIService _callAPIService)
        {
            InitializeComponent();
            userService = new UserService(_callAPIService);
            this.gameMenuService = new GameMenuService(_callAPIService);
            containGameList = new ContainGameList();
            containListMenuGame = new ContainListMenuGame(_callAPIService);
            containScanDiskGame = new ContainScanDiskGame(_callAPIService);
            containUpdateProfile = new ContainUpdateProfile(this.userService);
            cantainControlMenu = new CantainControlMenu();

            menuMain = new MenuMain(this.userService);
            menuUserManage = new MenuUserManage(userService, containUpdateProfile, this);
            menuManageLicence = new MenuManageLicence();
            menuManageListGame = new MenuManageListGame(this.gameMenuService,this.containListMenuGame,this.containScanDiskGame, this);
            

            this.PanelSilderMenu.Controls.Add(this.menuMain);
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain1";
            this.menuMain.Size = new System.Drawing.Size(250, 708);
            this.menuMain.TabIndex = 0;

            this.PanelSilderMenu.Controls.Add(this.menuUserManage);
            this.menuUserManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUserManage.Location = new System.Drawing.Point(0, 0);
            this.menuUserManage.Name = "menuUserManage";
            this.menuUserManage.Size = new System.Drawing.Size(250, 708);
            this.menuUserManage.TabIndex = 1;

            this.PanelSilderMenu.Controls.Add(this.menuManageListGame);
            this.menuManageListGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuManageListGame.Location = new System.Drawing.Point(0, 0);
            this.menuManageListGame.Name = "menuManageListGame";
            this.menuManageListGame.Size = new System.Drawing.Size(250, 708);
            this.menuManageListGame.TabIndex = 3;

            this.PanelSilderMenu.Controls.Add(this.menuManageListGame);
            this.menuManageListGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuManageListGame.Location = new System.Drawing.Point(0, 0);
            this.menuManageListGame.Name = "menuManageListGame";
            this.menuManageListGame.Size = new System.Drawing.Size(250, 708);
            this.menuManageListGame.TabIndex = 4;

            this.PanelSilderMenu.Controls.Add(this.menuManageLicence);
            this.menuManageLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuManageLicence.Location = new System.Drawing.Point(0, 0);
            this.menuManageLicence.Name = "menuManageListGame";
            this.menuManageLicence.Size = new System.Drawing.Size(250, 708);
            this.menuManageLicence.TabIndex = 5;

            //LeaveMenu();
            onClick = new bool[8] { false, false, false, false, false, false, false, false };
        }

        public void SetHeaderName(string nameMenu)
        {
            lbl_nammenu.Text = nameMenu;
        }

        private void btn_closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoverMenu(int index)
        {
            PanelSilderMenu.Show();
            switch(index)
            {
                case 0://main menu
                    menuMain.Show();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 1://User manage
                    menuMain.Hide();
                    menuUserManage.Show();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[0] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 2://control menu
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[0] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 3://List game
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Show();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[0] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 4://menu manage Licence
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Show();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[0] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 5://
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[0] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;
                case 6:
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[0] = false;
                    onClick[7] = false;
                    break;
                case 7:
                    menuMain.Hide();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[0] = false;
                    break;
                default:
                    menuMain.Show();
                    menuUserManage.Hide();
                    menuManageLicence.Hide();
                    menuManageListGame.Hide();
                    containListMenuGame.Hide();
                    containGameList.Hide();
                    containScanDiskGame.Hide();
                    containUpdateProfile.Hide();
                    onClick[1] = false;
                    onClick[2] = false;
                    onClick[3] = false;
                    onClick[4] = false;
                    onClick[5] = false;
                    onClick[6] = false;
                    onClick[7] = false;
                    break;

            }
        }

        private void LeaveMenu(int index)
        {
            PanelSilderMenu.Hide();
            menuUserManage.Hide();
            menuMain.Hide();
        }

        private void btn_minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void btn_ManageUser_Click(object sender, EventArgs e)
        {
            if (!onClick[1])
            {
                HoverMenu(1);
            }
            else
            {
                PanelSilderMenu.Hide();
            }
            onClick[1] = !onClick[1];
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btn_menuControlMenu_Click(object sender, EventArgs e)
        {
            if (!onClick[2])
            {
                HoverMenu(2);
            }
            else
            {
                PanelSilderMenu.Hide();
                //menuMain.Hide();
            }
            onClick[2] = !onClick[2];
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (!onClick[0])
            {
                HoverMenu(0);
            }
            else
            {
                PanelSilderMenu.Hide();
                menuMain.Hide();
            }
            onClick[0] = !onClick[0];
        }

        private void btn_menuListGame_Click(object sender, EventArgs e)
        {
            if (!onClick[3])
            {
                HoverMenu(3);
            }
            else
            {
                PanelSilderMenu.Hide();
            }
            onClick[3] = !onClick[3];
        }

        private void btn_menumanageLicence_Click(object sender, EventArgs e)
        {
            if (!onClick[4])
            {
                HoverMenu(4);
            }
            else
            {
                PanelSilderMenu.Hide();
            }
            onClick[4] = !onClick[4];
        }


        private void btn_Menu_MouseHover(object sender, EventArgs e)
        {
            btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
        }

        private void btn_menumanageLicence_MouseHover(object sender, EventArgs e)
        {
            btn_menumanageLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
        }


        private void btn_menuControlMenu_MouseHover(object sender, EventArgs e)
        {
            btn_menuControlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
        }

        private void btn_menuListGame_MouseHover(object sender, EventArgs e)
        {
            btn_menuListGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
        }

        private void btn_ManageUser_MouseHover(object sender, EventArgs e)
        {
            btn_ManageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
        }

        private void btn_menumanageLicence_MouseLeave(object sender, EventArgs e)
        {
            btn_Menu.BackColor = Color.Black;
        }

        private void btn_menuListGame_MouseLeave(object sender, EventArgs e)
        {
            btn_Menu.BackColor = Color.Black;
        }

        private void btn_menuControlMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_Menu.BackColor = Color.Black;
        }

        private void btn_Menu_MouseLeave(object sender, EventArgs e)
        {
            btn_Menu.BackColor = Color.Black;
        }

        private void btn_ManageUser_MouseLeave(object sender, EventArgs e)
        {
            btn_Menu.BackColor = Color.Black;
        }

        private void btn_infoSoftWare_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            userService.Logout();
            Environment.Exit(0);
        }

        private void btn_checkupdate_Click(object sender, EventArgs e)
        {
            string hostname = ReadPath.IpAddressCloud;
            int? port = ReadPath.PortCloud;
            if(hostname.Length == 0 && port == null)
            {
                MessageBox.Show("Vui lòng vào cài đặt chỉ định địa chỉ lưu hình ảnh Game trước khi scan.");
            }
            else
            {
                AutoUpdater.DownloadPath = Environment.CurrentDirectory;
                AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;
                AutoUpdater.Start(String.Format("http://{0}:{1}/download/checkversionSGPMGC", hostname, port));
            }
        }

        private void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            string hostname = ReadPath.IpAddressCloud;
            int? port = ReadPath.PortCloud;
            if (hostname.Length == 0 && port == null)
            {
                MessageBox.Show("Vui lòng vào cài đặt chỉ định địa chỉ lưu hình ảnh Game trước khi scan.");
            }
            else
            {
                string downloadurl = "checkversionSGPMGC32";
                if (Environment.Is64BitOperatingSystem)
                {
                    downloadurl = "checkversionSGPMGC64";
                }

                CheckVersionInfoModel json = JsonConvert.DeserializeObject<CheckVersionInfoModel>(args.RemoteData);
                args.UpdateInfo = new UpdateInfoEventArgs
                {
                    CurrentVersion = json.CurrentVersion,
                    ChangelogURL = String.Format("http://{0}:{1}/download/releasedocs", hostname, port),
                    Mandatory = json.Mandatory,
                    DownloadURL = String.Format("http://{0}:{1}/download/{2}", hostname, port, downloadurl)
                    //Checksum = "",
                    //HashingAlgorithm = "MD5"
                };
            }
        }
    }
}
