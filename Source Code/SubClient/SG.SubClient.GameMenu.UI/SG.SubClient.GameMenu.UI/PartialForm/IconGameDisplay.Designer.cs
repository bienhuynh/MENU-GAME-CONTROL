namespace SG.SubClient.GameMenu.UI.PartialForm
{
    partial class IconGameDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconGameDisplay));
            this.pnl_background = new System.Windows.Forms.Panel();
            this.lbl_namegame = new System.Windows.Forms.Label();
            this.pic_IconGame = new System.Windows.Forms.PictureBox();
            this.pnl_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.Controls.Add(this.lbl_namegame);
            this.pnl_background.Controls.Add(this.pic_IconGame);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(85, 103);
            this.pnl_background.TabIndex = 24;
            // 
            // lbl_namegame
            // 
            this.lbl_namegame.AutoSize = true;
            this.lbl_namegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_namegame.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_namegame.Location = new System.Drawing.Point(8, 76);
            this.lbl_namegame.Name = "lbl_namegame";
            this.lbl_namegame.Size = new System.Drawing.Size(56, 15);
            this.lbl_namegame.TabIndex = 6;
            this.lbl_namegame.Text = "Gam fish";
            this.lbl_namegame.Click += new System.EventHandler(this.lbl_namegame_Click);
            // 
            // pic_IconGame
            // 
            this.pic_IconGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_IconGame.BackgroundImage")));
            this.pic_IconGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_IconGame.Image = ((System.Drawing.Image)(resources.GetObject("pic_IconGame.Image")));
            this.pic_IconGame.Location = new System.Drawing.Point(8, 3);
            this.pic_IconGame.Name = "pic_IconGame";
            this.pic_IconGame.Size = new System.Drawing.Size(68, 69);
            this.pic_IconGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_IconGame.TabIndex = 5;
            this.pic_IconGame.TabStop = false;
            this.pic_IconGame.DoubleClick += new System.EventHandler(this.pic_IconGame_DoubleClick);
            // 
            // IconGameDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_background);
            this.Name = "IconGameDisplay";
            this.Size = new System.Drawing.Size(85, 103);
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_background;
        private System.Windows.Forms.Label lbl_namegame;
        private System.Windows.Forms.PictureBox pic_IconGame;
    }
}
