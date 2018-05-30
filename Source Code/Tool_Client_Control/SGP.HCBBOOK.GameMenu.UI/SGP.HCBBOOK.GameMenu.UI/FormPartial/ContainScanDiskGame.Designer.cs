namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    partial class ContainScanDiskGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainScanDiskGame));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_contain_piup = new System.Windows.Forms.Panel();
            this.pnl_Containresult = new System.Windows.Forms.Panel();
            this.btn_UploadToServer = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_SelectPath = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Addgame = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.hcbbookButton3 = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.btn_selectPath = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.hcbbookButton2 = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.btn_Scan = new SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem.hcbbookButton();
            this.panel1.SuspendLayout();
            this.pnl_contain_piup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quét Disk Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 47);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnl_contain_piup
            // 
            this.pnl_contain_piup.BackColor = System.Drawing.Color.Black;
            this.pnl_contain_piup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_contain_piup.Controls.Add(this.pnl_Containresult);
            this.pnl_contain_piup.Controls.Add(this.btn_UploadToServer);
            this.pnl_contain_piup.Location = new System.Drawing.Point(30, 139);
            this.pnl_contain_piup.Name = "pnl_contain_piup";
            this.pnl_contain_piup.Size = new System.Drawing.Size(409, 356);
            this.pnl_contain_piup.TabIndex = 4;
            // 
            // pnl_Containresult
            // 
            this.pnl_Containresult.AutoScroll = true;
            this.pnl_Containresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Containresult.Location = new System.Drawing.Point(28, 25);
            this.pnl_Containresult.Name = "pnl_Containresult";
            this.pnl_Containresult.Size = new System.Drawing.Size(358, 247);
            this.pnl_Containresult.TabIndex = 0;
            // 
            // btn_UploadToServer
            // 
            this.btn_UploadToServer.BackColor = System.Drawing.Color.Black;
            this.btn_UploadToServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UploadToServer.BackgroundImage")));
            this.btn_UploadToServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UploadToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UploadToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_UploadToServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.btn_UploadToServer.Location = new System.Drawing.Point(196, 282);
            this.btn_UploadToServer.Name = "btn_UploadToServer";
            this.btn_UploadToServer.Size = new System.Drawing.Size(190, 47);
            this.btn_UploadToServer.TabIndex = 3;
            this.btn_UploadToServer.TabStop = false;
            this.btn_UploadToServer.Text = "Cập nhật lên server";
            this.btn_UploadToServer.UseVisualStyleBackColor = false;
            this.btn_UploadToServer.Click += new System.EventHandler(this.btn_UploadToServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 603);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(608, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.RoyalBlue;
            this.label34.ForeColor = System.Drawing.Color.Maroon;
            this.label34.Location = new System.Drawing.Point(48, 582);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 13);
            this.label34.TabIndex = 6;
            this.label34.Text = "Processing: ";
            // 
            // lbl_SelectPath
            // 
            this.lbl_SelectPath.AutoSize = true;
            this.lbl_SelectPath.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_SelectPath.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SelectPath.Location = new System.Drawing.Point(120, 582);
            this.lbl_SelectPath.Name = "lbl_SelectPath";
            this.lbl_SelectPath.Size = new System.Drawing.Size(22, 13);
            this.lbl_SelectPath.TabIndex = 6;
            this.lbl_SelectPath.Text = "C:/";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.RoyalBlue;
            this.label35.ForeColor = System.Drawing.Color.Maroon;
            this.label35.Location = new System.Drawing.Point(576, 582);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(38, 13);
            this.label35.TabIndex = 6;
            this.label35.Text = "Count:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Count.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Count.Location = new System.Drawing.Point(619, 583);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(13, 13);
            this.lbl_Count.TabIndex = 6;
            this.lbl_Count.Text = "0";
            this.lbl_Count.Click += new System.EventHandler(this.lbl_Count_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 69);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Addgame
            // 
            this.btn_Addgame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Addgame.BackColor = System.Drawing.Color.Black;
            this.btn_Addgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Addgame.BackgroundImage")));
            this.btn_Addgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Addgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Addgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.btn_Addgame.Location = new System.Drawing.Point(498, 433);
            this.btn_Addgame.Name = "btn_Addgame";
            this.btn_Addgame.Size = new System.Drawing.Size(157, 45);
            this.btn_Addgame.TabIndex = 3;
            this.btn_Addgame.TabStop = false;
            this.btn_Addgame.Text = "Thêm game";
            this.btn_Addgame.UseVisualStyleBackColor = false;
            this.btn_Addgame.Click += new System.EventHandler(this.btn_Addgame_Click);
            // 
            // hcbbookButton3
            // 
            this.hcbbookButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbbookButton3.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton3.BackgroundImage")));
            this.hcbbookButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hcbbookButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton3.Location = new System.Drawing.Point(498, 362);
            this.hcbbookButton3.Name = "hcbbookButton3";
            this.hcbbookButton3.Size = new System.Drawing.Size(157, 45);
            this.hcbbookButton3.TabIndex = 3;
            this.hcbbookButton3.TabStop = false;
            this.hcbbookButton3.Text = "Dừng";
            this.hcbbookButton3.UseVisualStyleBackColor = false;
            // 
            // btn_selectPath
            // 
            this.btn_selectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectPath.BackColor = System.Drawing.Color.Black;
            this.btn_selectPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_selectPath.BackgroundImage")));
            this.btn_selectPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_selectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_selectPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.btn_selectPath.Location = new System.Drawing.Point(498, 64);
            this.btn_selectPath.Name = "btn_selectPath";
            this.btn_selectPath.Size = new System.Drawing.Size(157, 39);
            this.btn_selectPath.TabIndex = 3;
            this.btn_selectPath.TabStop = false;
            this.btn_selectPath.Text = "Browser";
            this.btn_selectPath.UseVisualStyleBackColor = false;
            this.btn_selectPath.Click += new System.EventHandler(this.btn_selectPath_Click);
            // 
            // hcbbookButton2
            // 
            this.hcbbookButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hcbbookButton2.BackColor = System.Drawing.Color.Black;
            this.hcbbookButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcbbookButton2.BackgroundImage")));
            this.hcbbookButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcbbookButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hcbbookButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hcbbookButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.hcbbookButton2.Location = new System.Drawing.Point(498, 292);
            this.hcbbookButton2.Name = "hcbbookButton2";
            this.hcbbookButton2.Size = new System.Drawing.Size(157, 45);
            this.hcbbookButton2.TabIndex = 3;
            this.hcbbookButton2.TabStop = false;
            this.hcbbookButton2.Text = "Xóa bỏ";
            this.hcbbookButton2.UseVisualStyleBackColor = false;
            // 
            // btn_Scan
            // 
            this.btn_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Scan.BackColor = System.Drawing.Color.Black;
            this.btn_Scan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Scan.BackgroundImage")));
            this.btn_Scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.btn_Scan.Location = new System.Drawing.Point(498, 129);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(157, 45);
            this.btn_Scan.TabIndex = 3;
            this.btn_Scan.TabStop = false;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = false;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // ContainScanDiskGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_SelectPath);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnl_contain_piup);
            this.Controls.Add(this.btn_Addgame);
            this.Controls.Add(this.hcbbookButton3);
            this.Controls.Add(this.btn_selectPath);
            this.Controls.Add(this.hcbbookButton2);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ContainScanDiskGame";
            this.Size = new System.Drawing.Size(698, 674);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_contain_piup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private HCBBOOK.DesignItem.hcbbookButton btn_Scan;
        private System.Windows.Forms.Panel pnl_contain_piup;
        private System.Windows.Forms.Panel pnl_Containresult;
        private HCBBOOK.DesignItem.hcbbookButton hcbbookButton2;
        private HCBBOOK.DesignItem.hcbbookButton hcbbookButton3;
        private HCBBOOK.DesignItem.hcbbookButton btn_Addgame;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private HCBBOOK.DesignItem.hcbbookButton btn_selectPath;
        private HCBBOOK.DesignItem.hcbbookButton btn_UploadToServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_SelectPath;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lbl_Count;
    }
}
