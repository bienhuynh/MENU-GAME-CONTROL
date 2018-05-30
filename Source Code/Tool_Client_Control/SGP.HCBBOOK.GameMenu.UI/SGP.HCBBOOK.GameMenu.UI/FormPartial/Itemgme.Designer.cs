namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    partial class Itemgme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Itemgme));
            this.picb_icongGame = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_NameGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_icongGame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picb_icongGame
            // 
            this.picb_icongGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_icongGame.BackColor = System.Drawing.Color.Transparent;
            this.picb_icongGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb_icongGame.Image = ((System.Drawing.Image)(resources.GetObject("picb_icongGame.Image")));
            this.picb_icongGame.Location = new System.Drawing.Point(11, 16);
            this.picb_icongGame.Name = "picb_icongGame";
            this.picb_icongGame.Size = new System.Drawing.Size(137, 126);
            this.picb_icongGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_icongGame.TabIndex = 2;
            this.picb_icongGame.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_Description);
            this.panel1.Controls.Add(this.lbl_NameGame);
            this.panel1.Location = new System.Drawing.Point(11, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 57);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Description.Location = new System.Drawing.Point(5, 24);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(160, 26);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Tựa game hot nhất mọi thời đại. \r\nNhập vai game chiến thuật đỉn..";
            // 
            // lbl_NameGame
            // 
            this.lbl_NameGame.AutoSize = true;
            this.lbl_NameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NameGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NameGame.Location = new System.Drawing.Point(7, 6);
            this.lbl_NameGame.Name = "lbl_NameGame";
            this.lbl_NameGame.Size = new System.Drawing.Size(153, 15);
            this.lbl_NameGame.TabIndex = 0;
            this.lbl_NameGame.Text = "LIÊN MINH HUYỀN T...";
            // 
            // Itemgme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picb_icongGame);
            this.DoubleBuffered = true;
            this.Name = "Itemgme";
            this.Size = new System.Drawing.Size(158, 232);
            this.Load += new System.EventHandler(this.Itemgme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb_icongGame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_icongGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_NameGame;
    }
}
