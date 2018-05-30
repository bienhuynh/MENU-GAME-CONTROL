namespace SG.SubClient.GameMenu.UI.LaunchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer_updateGame = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_bodyContent = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.hcbbookButton2 = new SG.SubClient.GameMenu.UI.DesginCustom.hcbbookButton();
            this.hcbbookButton1 = new SG.SubClient.GameMenu.UI.DesginCustom.hcbbookButton();
            this.hcbbookButton3 = new SG.SubClient.GameMenu.UI.DesginCustom.hcbbookButton();
            this.hcbbookButton4 = new SG.SubClient.GameMenu.UI.DesginCustom.hcbbookButton();
            this.hcbbookButton5 = new SG.SubClient.GameMenu.UI.DesginCustom.hcbbookButton();
            this.panel2.SuspendLayout();
            this.pnl_bodyContent.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnl_header;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer_updateGame
            // 
            this.timer_updateGame.Tick += new System.EventHandler(this.timer_updateGame_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hcbbookButton5);
            this.panel2.Controls.Add(this.hcbbookButton4);
            this.panel2.Controls.Add(this.hcbbookButton3);
            this.panel2.Controls.Add(this.hcbbookButton1);
            this.panel2.Controls.Add(this.hcbbookButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 484);
            this.panel2.TabIndex = 0;
            // 
            // pnl_bodyContent
            // 
            this.pnl_bodyContent.AutoScroll = true;
            this.pnl_bodyContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_bodyContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_bodyContent.Controls.Add(this.panel2);
            this.pnl_bodyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bodyContent.Location = new System.Drawing.Point(0, 280);
            this.pnl_bodyContent.Name = "pnl_bodyContent";
            this.pnl_bodyContent.Size = new System.Drawing.Size(1024, 488);
            this.pnl_bodyContent.TabIndex = 7;
            this.pnl_bodyContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel21_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(102, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "GAME All";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(214, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 20);
            this.label20.TabIndex = 3;
            this.label20.Text = "GAME HOT";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(343, 163);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 20);
            this.label21.TabIndex = 3;
            this.label21.Text = "GAME ONLINE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(582, 163);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "GAME OFFLINE";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(733, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "KHUYẾN MÃI";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(866, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "EXIT ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(491, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 38);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_header.BackgroundImage")));
            this.pnl_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_header.Controls.Add(this.panel1);
            this.pnl_header.Controls.Add(this.label24);
            this.pnl_header.Controls.Add(this.label23);
            this.pnl_header.Controls.Add(this.label22);
            this.pnl_header.Controls.Add(this.label21);
            this.pnl_header.Controls.Add(this.label20);
            this.pnl_header.Controls.Add(this.label19);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1024, 280);
            this.pnl_header.TabIndex = 3;
            // 
            // hcbbookButton2
            // 
            this.hcbbookButton2.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton2.BackgroundImage")));
            this.hcbbookButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton2.Location = new System.Drawing.Point(10, 33);
            this.hcbbookButton2.Name = "hcbbookButton2";
            this.hcbbookButton2.Size = new System.Drawing.Size(179, 58);
            this.hcbbookButton2.TabIndex = 3;
            this.hcbbookButton2.Text = "Tất cả game";
            this.hcbbookButton2.UseVisualStyleBackColor = false;
            // 
            // hcbbookButton1
            // 
            this.hcbbookButton1.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton1.BackgroundImage")));
            this.hcbbookButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton1.Location = new System.Drawing.Point(10, 106);
            this.hcbbookButton1.Name = "hcbbookButton1";
            this.hcbbookButton1.Size = new System.Drawing.Size(179, 58);
            this.hcbbookButton1.TabIndex = 3;
            this.hcbbookButton1.Text = "Game Hot";
            this.hcbbookButton1.UseVisualStyleBackColor = false;
            // 
            // hcbbookButton3
            // 
            this.hcbbookButton3.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton3.BackgroundImage")));
            this.hcbbookButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton3.Location = new System.Drawing.Point(10, 179);
            this.hcbbookButton3.Name = "hcbbookButton3";
            this.hcbbookButton3.Size = new System.Drawing.Size(179, 58);
            this.hcbbookButton3.TabIndex = 3;
            this.hcbbookButton3.Text = "Game Online";
            this.hcbbookButton3.UseVisualStyleBackColor = false;
            // 
            // hcbbookButton4
            // 
            this.hcbbookButton4.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton4.BackgroundImage")));
            this.hcbbookButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton4.Location = new System.Drawing.Point(10, 253);
            this.hcbbookButton4.Name = "hcbbookButton4";
            this.hcbbookButton4.Size = new System.Drawing.Size(179, 58);
            this.hcbbookButton4.TabIndex = 3;
            this.hcbbookButton4.Text = "Game Offline";
            this.hcbbookButton4.UseVisualStyleBackColor = false;
            // 
            // hcbbookButton5
            // 
            this.hcbbookButton5.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton5.BackgroundImage")));
            this.hcbbookButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton5.Location = new System.Drawing.Point(10, 321);
            this.hcbbookButton5.Name = "hcbbookButton5";
            this.hcbbookButton5.Size = new System.Drawing.Size(179, 58);
            this.hcbbookButton5.TabIndex = 3;
            this.hcbbookButton5.Text = "Game Chiến thuật";
            this.hcbbookButton5.UseVisualStyleBackColor = false;
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnl_bodyContent);
            this.Controls.Add(this.pnl_header);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaster";
            this.Text = "FormMaster";
            this.panel2.ResumeLayout(false);
            this.pnl_bodyContent.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnl_bodyContent;
        private System.Windows.Forms.Panel panel2;
        private DesginCustom.hcbbookButton hcbbookButton5;
        private DesginCustom.hcbbookButton hcbbookButton4;
        private DesginCustom.hcbbookButton hcbbookButton3;
        private DesginCustom.hcbbookButton hcbbookButton1;
        private DesginCustom.hcbbookButton hcbbookButton2;
        private System.Windows.Forms.Timer timer_updateGame;
    }
}