namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    partial class IconGameDisplaySpace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconGameDisplaySpace));
            this.pnl_itemgame = new System.Windows.Forms.Panel();
            this.lbl_detail = new System.Windows.Forms.Label();
            this.lbl_namegame = new System.Windows.Forms.LinkLabel();
            this.pic_IconGame = new System.Windows.Forms.PictureBox();
            this.pnl_itemgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_itemgame
            // 
            this.pnl_itemgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_itemgame.BackgroundImage")));
            this.pnl_itemgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_itemgame.Controls.Add(this.lbl_detail);
            this.pnl_itemgame.Controls.Add(this.lbl_namegame);
            this.pnl_itemgame.Controls.Add(this.pic_IconGame);
            this.pnl_itemgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_itemgame.Location = new System.Drawing.Point(0, 0);
            this.pnl_itemgame.Name = "pnl_itemgame";
            this.pnl_itemgame.Size = new System.Drawing.Size(165, 86);
            this.pnl_itemgame.TabIndex = 6;
            // 
            // lbl_detail
            // 
            this.lbl_detail.AutoSize = true;
            this.lbl_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_detail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_detail.Location = new System.Drawing.Point(83, 44);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Size = new System.Drawing.Size(71, 15);
            this.lbl_detail.TabIndex = 1;
            this.lbl_detail.Text = "Xem chi tiết";
            // 
            // lbl_namegame
            // 
            this.lbl_namegame.AutoSize = true;
            this.lbl_namegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_namegame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_namegame.Location = new System.Drawing.Point(80, 13);
            this.lbl_namegame.Name = "lbl_namegame";
            this.lbl_namegame.Size = new System.Drawing.Size(82, 17);
            this.lbl_namegame.TabIndex = 1;
            this.lbl_namegame.TabStop = true;
            this.lbl_namegame.Text = "Tencent...";
            // 
            // pic_IconGame
            // 
            this.pic_IconGame.Image = ((System.Drawing.Image)(resources.GetObject("pic_IconGame.Image")));
            this.pic_IconGame.Location = new System.Drawing.Point(11, 11);
            this.pic_IconGame.Name = "pic_IconGame";
            this.pic_IconGame.Size = new System.Drawing.Size(66, 62);
            this.pic_IconGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_IconGame.TabIndex = 0;
            this.pic_IconGame.TabStop = false;
            // 
            // IconGameDisplaySpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_itemgame);
            this.Name = "IconGameDisplaySpace";
            this.Size = new System.Drawing.Size(165, 86);
            this.pnl_itemgame.ResumeLayout(false);
            this.pnl_itemgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_itemgame;
        private System.Windows.Forms.Label lbl_detail;
        private System.Windows.Forms.LinkLabel lbl_namegame;
        private System.Windows.Forms.PictureBox pic_IconGame;
    }
}
