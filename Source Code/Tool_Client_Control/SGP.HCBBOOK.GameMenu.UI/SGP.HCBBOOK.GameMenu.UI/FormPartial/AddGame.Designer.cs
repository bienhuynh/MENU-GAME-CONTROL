namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    partial class AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.btn_ChooseGame = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_saveGame = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNamegame = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescriptionGame = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGamedisplay = new System.Windows.Forms.Panel();
            this.btn_choosePicture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.progressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            // 
            // btn_minisize
            // 
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            // 
            // btn_maxisize
            // 
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.progressBar1);
            this.pnl_body.Controls.Add(this.pnlGamedisplay);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.txtDescriptionGame);
            this.pnl_body.Controls.Add(this.txtNamegame);
            this.pnl_body.Controls.Add(this.btn_saveGame);
            this.pnl_body.Controls.Add(this.btn_choosePicture);
            this.pnl_body.Controls.Add(this.btn_ChooseGame);
            // 
            // btn_ChooseGame
            // 
            this.btn_ChooseGame.ActiveBorderThickness = 1;
            this.btn_ChooseGame.ActiveCornerRadius = 20;
            this.btn_ChooseGame.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_ChooseGame.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ChooseGame.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ChooseGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ChooseGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChooseGame.BackgroundImage")));
            this.btn_ChooseGame.ButtonText = "Chọn Game";
            this.btn_ChooseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChooseGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ChooseGame.IdleBorderThickness = 1;
            this.btn_ChooseGame.IdleCornerRadius = 20;
            this.btn_ChooseGame.IdleFillColor = System.Drawing.Color.White;
            this.btn_ChooseGame.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ChooseGame.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ChooseGame.Location = new System.Drawing.Point(293, 324);
            this.btn_ChooseGame.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChooseGame.Name = "btn_ChooseGame";
            this.btn_ChooseGame.Size = new System.Drawing.Size(181, 41);
            this.btn_ChooseGame.TabIndex = 2;
            this.btn_ChooseGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChooseGame.Click += new System.EventHandler(this.btn_ChooseGame_Click);
            // 
            // btn_saveGame
            // 
            this.btn_saveGame.ActiveBorderThickness = 1;
            this.btn_saveGame.ActiveCornerRadius = 20;
            this.btn_saveGame.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_saveGame.ActiveForecolor = System.Drawing.Color.White;
            this.btn_saveGame.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_saveGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_saveGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saveGame.BackgroundImage")));
            this.btn_saveGame.ButtonText = "Lưu";
            this.btn_saveGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_saveGame.IdleBorderThickness = 1;
            this.btn_saveGame.IdleCornerRadius = 20;
            this.btn_saveGame.IdleFillColor = System.Drawing.Color.White;
            this.btn_saveGame.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_saveGame.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_saveGame.Location = new System.Drawing.Point(542, 324);
            this.btn_saveGame.Margin = new System.Windows.Forms.Padding(5);
            this.btn_saveGame.Name = "btn_saveGame";
            this.btn_saveGame.Size = new System.Drawing.Size(181, 41);
            this.btn_saveGame.TabIndex = 2;
            this.btn_saveGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveGame.Click += new System.EventHandler(this.btn_saveGame_Click);
            // 
            // txtNamegame
            // 
            this.txtNamegame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNamegame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNamegame.HintForeColor = System.Drawing.Color.Empty;
            this.txtNamegame.HintText = "";
            this.txtNamegame.isPassword = false;
            this.txtNamegame.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNamegame.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNamegame.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNamegame.LineThickness = 3;
            this.txtNamegame.Location = new System.Drawing.Point(293, 44);
            this.txtNamegame.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamegame.Name = "txtNamegame";
            this.txtNamegame.Size = new System.Drawing.Size(430, 33);
            this.txtNamegame.TabIndex = 3;
            this.txtNamegame.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamegame.OnValueChanged += new System.EventHandler(this.txtNamegame_OnValueChanged);
            // 
            // txtDescriptionGame
            // 
            this.txtDescriptionGame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescriptionGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescriptionGame.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescriptionGame.HintText = "";
            this.txtDescriptionGame.isPassword = false;
            this.txtDescriptionGame.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescriptionGame.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescriptionGame.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescriptionGame.LineThickness = 3;
            this.txtDescriptionGame.Location = new System.Drawing.Point(293, 120);
            this.txtDescriptionGame.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionGame.Name = "txtDescriptionGame";
            this.txtDescriptionGame.Size = new System.Drawing.Size(430, 185);
            this.txtDescriptionGame.TabIndex = 4;
            this.txtDescriptionGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(293, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô tả";
            // 
            // pnlGamedisplay
            // 
            this.pnlGamedisplay.Location = new System.Drawing.Point(78, 24);
            this.pnlGamedisplay.Name = "pnlGamedisplay";
            this.pnlGamedisplay.Size = new System.Drawing.Size(158, 232);
            this.pnlGamedisplay.TabIndex = 6;
            // 
            // btn_choosePicture
            // 
            this.btn_choosePicture.ActiveBorderThickness = 1;
            this.btn_choosePicture.ActiveCornerRadius = 20;
            this.btn_choosePicture.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_choosePicture.ActiveForecolor = System.Drawing.Color.White;
            this.btn_choosePicture.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_choosePicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_choosePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_choosePicture.BackgroundImage")));
            this.btn_choosePicture.ButtonText = "Chọn hình khác";
            this.btn_choosePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choosePicture.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_choosePicture.IdleBorderThickness = 1;
            this.btn_choosePicture.IdleCornerRadius = 20;
            this.btn_choosePicture.IdleFillColor = System.Drawing.Color.White;
            this.btn_choosePicture.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_choosePicture.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_choosePicture.Location = new System.Drawing.Point(65, 324);
            this.btn_choosePicture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_choosePicture.Name = "btn_choosePicture";
            this.btn_choosePicture.Size = new System.Drawing.Size(181, 41);
            this.btn_choosePicture.TabIndex = 2;
            this.btn_choosePicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.BorderRadius = 5;
            this.progressBar1.Location = new System.Drawing.Point(76, 275);
            this.progressBar1.MaximumValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.progressBar1.Size = new System.Drawing.Size(159, 10);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.Load += new System.EventHandler(this.AddGame_Load);
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGamedisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescriptionGame;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNamegame;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_saveGame;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_choosePicture;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ChooseGame;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}