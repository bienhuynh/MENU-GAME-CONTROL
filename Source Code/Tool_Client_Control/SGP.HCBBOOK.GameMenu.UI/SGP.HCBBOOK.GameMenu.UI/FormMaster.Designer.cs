namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class FormMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.panel_header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_minimum = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_closeapp = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.PanelSilderMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_checkupdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_infoSoftWare = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_NumberPhone = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_menumanageLicence = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_menuListGame = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_menuControlMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ManageUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_Body = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl_Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_nammenu = new System.Windows.Forms.Label();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuImageButton();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeapp)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_infoSoftWare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NumberPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menumanageLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menuListGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menuControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ManageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = this.panel_header;
            bunifuDragControl1.Vertical = true;
            // 
            // panel_header
            // 
            this.panel_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_header.BackgroundImage")));
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header.Controls.Add(this.bunifuCustomLabel1);
            this.panel_header.Controls.Add(this.btn_minimum);
            this.panel_header.Controls.Add(this.btn_closeapp);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.GradientBottomLeft = System.Drawing.Color.Navy;
            this.panel_header.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel_header.GradientTopLeft = System.Drawing.Color.Maroon;
            this.panel_header.GradientTopRight = System.Drawing.Color.Red;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Quality = 10;
            this.panel_header.Size = new System.Drawing.Size(1024, 60);
            this.panel_header.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(215, 22);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "SGP CONTROL MENU";
            // 
            // btn_minimum
            // 
            this.btn_minimum.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimum.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimum.Image")));
            this.btn_minimum.ImageActive = null;
            this.btn_minimum.Location = new System.Drawing.Point(926, 12);
            this.btn_minimum.Name = "btn_minimum";
            this.btn_minimum.Size = new System.Drawing.Size(40, 34);
            this.btn_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimum.TabIndex = 1;
            this.btn_minimum.TabStop = false;
            this.btn_minimum.Zoom = 10;
            this.btn_minimum.Click += new System.EventHandler(this.btn_minimum_Click);
            // 
            // btn_closeapp
            // 
            this.btn_closeapp.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeapp.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeapp.Image")));
            this.btn_closeapp.ImageActive = null;
            this.btn_closeapp.Location = new System.Drawing.Point(972, 12);
            this.btn_closeapp.Name = "btn_closeapp";
            this.btn_closeapp.Size = new System.Drawing.Size(40, 34);
            this.btn_closeapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_closeapp.TabIndex = 1;
            this.btn_closeapp.TabStop = false;
            this.btn_closeapp.Zoom = 10;
            this.btn_closeapp.Click += new System.EventHandler(this.btn_closeapp_Click);
            // 
            // timer_menu
            // 
            this.timer_menu.Interval = 30;
            // 
            // PanelSilderMenu
            // 
            this.PanelSilderMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PanelSilderMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSilderMenu.BackgroundImage")));
            this.PanelSilderMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSilderMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSilderMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PanelSilderMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PanelSilderMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PanelSilderMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PanelSilderMenu.Location = new System.Drawing.Point(76, 60);
            this.PanelSilderMenu.Name = "PanelSilderMenu";
            this.PanelSilderMenu.Quality = 10;
            this.PanelSilderMenu.Size = new System.Drawing.Size(250, 708);
            this.PanelSilderMenu.TabIndex = 6;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btn_Logout);
            this.bunifuGradientPanel2.Controls.Add(this.btn_checkupdate);
            this.bunifuGradientPanel2.Controls.Add(this.btn_infoSoftWare);
            this.bunifuGradientPanel2.Controls.Add(this.btn_NumberPhone);
            this.bunifuGradientPanel2.Controls.Add(this.btn_menumanageLicence);
            this.bunifuGradientPanel2.Controls.Add(this.btn_menuListGame);
            this.bunifuGradientPanel2.Controls.Add(this.btn_menuControlMenu);
            this.bunifuGradientPanel2.Controls.Add(this.btn_ManageUser);
            this.bunifuGradientPanel2.Controls.Add(this.btn_Menu);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 60);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(76, 708);
            this.bunifuGradientPanel2.TabIndex = 5;
            // 
            // btn_checkupdate
            // 
            this.btn_checkupdate.BackColor = System.Drawing.Color.Black;
            this.btn_checkupdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_checkupdate.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkupdate.Image")));
            this.btn_checkupdate.ImageActive = null;
            this.btn_checkupdate.Location = new System.Drawing.Point(0, 488);
            this.btn_checkupdate.Name = "btn_checkupdate";
            this.btn_checkupdate.Size = new System.Drawing.Size(76, 70);
            this.btn_checkupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_checkupdate.TabIndex = 0;
            this.btn_checkupdate.TabStop = false;
            this.btn_checkupdate.Zoom = 10;
            this.btn_checkupdate.Click += new System.EventHandler(this.btn_checkupdate_Click);
            // 
            // btn_infoSoftWare
            // 
            this.btn_infoSoftWare.BackColor = System.Drawing.Color.Black;
            this.btn_infoSoftWare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_infoSoftWare.Image = ((System.Drawing.Image)(resources.GetObject("btn_infoSoftWare.Image")));
            this.btn_infoSoftWare.ImageActive = null;
            this.btn_infoSoftWare.Location = new System.Drawing.Point(0, 418);
            this.btn_infoSoftWare.Name = "btn_infoSoftWare";
            this.btn_infoSoftWare.Size = new System.Drawing.Size(76, 70);
            this.btn_infoSoftWare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_infoSoftWare.TabIndex = 0;
            this.btn_infoSoftWare.TabStop = false;
            this.btn_infoSoftWare.Zoom = 10;
            this.btn_infoSoftWare.Click += new System.EventHandler(this.btn_infoSoftWare_Click);
            // 
            // btn_NumberPhone
            // 
            this.btn_NumberPhone.BackColor = System.Drawing.Color.Black;
            this.btn_NumberPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NumberPhone.Image = ((System.Drawing.Image)(resources.GetObject("btn_NumberPhone.Image")));
            this.btn_NumberPhone.ImageActive = null;
            this.btn_NumberPhone.Location = new System.Drawing.Point(0, 348);
            this.btn_NumberPhone.Name = "btn_NumberPhone";
            this.btn_NumberPhone.Size = new System.Drawing.Size(76, 70);
            this.btn_NumberPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_NumberPhone.TabIndex = 0;
            this.btn_NumberPhone.TabStop = false;
            this.btn_NumberPhone.Zoom = 10;
            // 
            // btn_menumanageLicence
            // 
            this.btn_menumanageLicence.BackColor = System.Drawing.Color.Black;
            this.btn_menumanageLicence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menumanageLicence.Image = ((System.Drawing.Image)(resources.GetObject("btn_menumanageLicence.Image")));
            this.btn_menumanageLicence.ImageActive = null;
            this.btn_menumanageLicence.Location = new System.Drawing.Point(0, 278);
            this.btn_menumanageLicence.Name = "btn_menumanageLicence";
            this.btn_menumanageLicence.Size = new System.Drawing.Size(76, 70);
            this.btn_menumanageLicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menumanageLicence.TabIndex = 0;
            this.btn_menumanageLicence.TabStop = false;
            this.btn_menumanageLicence.Zoom = 10;
            this.btn_menumanageLicence.Click += new System.EventHandler(this.btn_menumanageLicence_Click);
            this.btn_menumanageLicence.MouseLeave += new System.EventHandler(this.btn_menumanageLicence_MouseLeave);
            this.btn_menumanageLicence.MouseHover += new System.EventHandler(this.btn_menumanageLicence_MouseHover);
            // 
            // btn_menuListGame
            // 
            this.btn_menuListGame.BackColor = System.Drawing.Color.Black;
            this.btn_menuListGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menuListGame.Image = ((System.Drawing.Image)(resources.GetObject("btn_menuListGame.Image")));
            this.btn_menuListGame.ImageActive = null;
            this.btn_menuListGame.Location = new System.Drawing.Point(0, 208);
            this.btn_menuListGame.Name = "btn_menuListGame";
            this.btn_menuListGame.Size = new System.Drawing.Size(76, 70);
            this.btn_menuListGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menuListGame.TabIndex = 0;
            this.btn_menuListGame.TabStop = false;
            this.btn_menuListGame.Zoom = 10;
            this.btn_menuListGame.Click += new System.EventHandler(this.btn_menuListGame_Click);
            this.btn_menuListGame.MouseLeave += new System.EventHandler(this.btn_menuListGame_MouseLeave);
            this.btn_menuListGame.MouseHover += new System.EventHandler(this.btn_menuListGame_MouseHover);
            // 
            // btn_menuControlMenu
            // 
            this.btn_menuControlMenu.BackColor = System.Drawing.Color.Black;
            this.btn_menuControlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menuControlMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menuControlMenu.Image")));
            this.btn_menuControlMenu.ImageActive = null;
            this.btn_menuControlMenu.Location = new System.Drawing.Point(0, 138);
            this.btn_menuControlMenu.Name = "btn_menuControlMenu";
            this.btn_menuControlMenu.Size = new System.Drawing.Size(76, 70);
            this.btn_menuControlMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menuControlMenu.TabIndex = 0;
            this.btn_menuControlMenu.TabStop = false;
            this.btn_menuControlMenu.Zoom = 10;
            this.btn_menuControlMenu.Click += new System.EventHandler(this.btn_menuControlMenu_Click);
            this.btn_menuControlMenu.MouseLeave += new System.EventHandler(this.btn_menuControlMenu_MouseLeave);
            this.btn_menuControlMenu.MouseHover += new System.EventHandler(this.btn_menuControlMenu_MouseHover);
            // 
            // btn_ManageUser
            // 
            this.btn_ManageUser.BackColor = System.Drawing.Color.Black;
            this.btn_ManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageUser.Image")));
            this.btn_ManageUser.ImageActive = null;
            this.btn_ManageUser.Location = new System.Drawing.Point(0, 68);
            this.btn_ManageUser.Name = "btn_ManageUser";
            this.btn_ManageUser.Size = new System.Drawing.Size(76, 70);
            this.btn_ManageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ManageUser.TabIndex = 0;
            this.btn_ManageUser.TabStop = false;
            this.btn_ManageUser.Zoom = 10;
            this.btn_ManageUser.Click += new System.EventHandler(this.btn_ManageUser_Click);
            this.btn_ManageUser.MouseLeave += new System.EventHandler(this.btn_ManageUser_MouseLeave);
            this.btn_ManageUser.MouseHover += new System.EventHandler(this.btn_ManageUser_MouseHover);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Black;
            this.btn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.ImageActive = null;
            this.btn_Menu.Location = new System.Drawing.Point(0, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(76, 68);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Zoom = 10;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            this.btn_Menu.MouseLeave += new System.EventHandler(this.btn_Menu_MouseLeave);
            this.btn_Menu.MouseHover += new System.EventHandler(this.btn_Menu_MouseHover);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Black;
            this.panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Body.BackgroundImage")));
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.panel_Body.GradientBottomRight = System.Drawing.Color.Transparent;
            this.panel_Body.GradientTopLeft = System.Drawing.Color.Transparent;
            this.panel_Body.GradientTopRight = System.Drawing.Color.Transparent;
            this.panel_Body.Location = new System.Drawing.Point(326, 94);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Quality = 10;
            this.panel_Body.Size = new System.Drawing.Size(698, 674);
            this.panel_Body.TabIndex = 7;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Header.BackgroundImage")));
            this.pnl_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Header.Controls.Add(this.lbl_nammenu);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.GradientBottomLeft = System.Drawing.Color.ForestGreen;
            this.pnl_Header.GradientBottomRight = System.Drawing.Color.MediumAquamarine;
            this.pnl_Header.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_Header.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.pnl_Header.Location = new System.Drawing.Point(326, 60);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Quality = 10;
            this.pnl_Header.Size = new System.Drawing.Size(698, 34);
            this.pnl_Header.TabIndex = 8;
            // 
            // lbl_nammenu
            // 
            this.lbl_nammenu.AutoSize = true;
            this.lbl_nammenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nammenu.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_nammenu.ForeColor = System.Drawing.Color.White;
            this.lbl_nammenu.Location = new System.Drawing.Point(7, 6);
            this.lbl_nammenu.Name = "lbl_nammenu";
            this.lbl_nammenu.Size = new System.Drawing.Size(97, 21);
            this.lbl_nammenu.TabIndex = 0;
            this.lbl_nammenu.Text = "nameMenu";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Black;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageActive = null;
            this.btn_Logout.Location = new System.Drawing.Point(0, 558);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(76, 70);
            this.btn_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Zoom = 10;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.PanelSilderMenu);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaster";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeapp)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_infoSoftWare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NumberPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menumanageLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menuListGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menuControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ManageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_minimum;
        private System.Windows.Forms.Timer timer_menu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_ManageUser;
        private Bunifu.Framework.UI.BunifuImageButton btn_Menu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_infoSoftWare;
        private Bunifu.Framework.UI.BunifuImageButton btn_NumberPhone;
        private Bunifu.Framework.UI.BunifuImageButton btn_menuListGame;
        private Bunifu.Framework.UI.BunifuImageButton btn_menuControlMenu;
        private Bunifu.Framework.UI.BunifuImageButton btn_checkupdate;
        public Bunifu.Framework.UI.BunifuGradientPanel panel_header;
        public Bunifu.Framework.UI.BunifuImageButton btn_closeapp;
        public Bunifu.Framework.UI.BunifuGradientPanel PanelSilderMenu;
        
        private Bunifu.Framework.UI.BunifuImageButton btn_menumanageLicence;
        public Bunifu.Framework.UI.BunifuGradientPanel panel_Body;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Header;
        private System.Windows.Forms.Label lbl_nammenu;
        private Bunifu.Framework.UI.BunifuImageButton btn_Logout;
    }
}