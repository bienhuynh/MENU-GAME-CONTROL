namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class FrmAddGameIntoCategory
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
            this.cbm_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_addall = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_GameofCategory = new System.Windows.Forms.Panel();
            this.pnl_allGAme = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_category = new System.Windows.Forms.Panel();
            this.txt_decription = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_datecreate = new System.Windows.Forms.TextBox();
            this.txt_urlexec = new System.Windows.Forms.TextBox();
            this.txt_namegame = new System.Windows.Forms.TextBox();
            this.txt_version = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_iconUrl = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_addgameindatabase = new System.Windows.Forms.Button();
            this.btn_loadagain = new System.Windows.Forms.Button();
            this.btn_AddGame = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_exe = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbm_Category
            // 
            this.cbm_Category.FormattingEnabled = true;
            this.cbm_Category.Location = new System.Drawing.Point(36, 43);
            this.cbm_Category.Name = "cbm_Category";
            this.cbm_Category.Size = new System.Drawing.Size(215, 21);
            this.cbm_Category.TabIndex = 0;
            this.cbm_Category.SelectedIndexChanged += new System.EventHandler(this.cbm_Category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Danh mục";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.lbl_Category);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_removeall);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.btn_addall);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.pnl_GameofCategory);
            this.panel1.Controls.Add(this.pnl_allGAme);
            this.panel1.Location = new System.Drawing.Point(36, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 432);
            this.panel1.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(370, 342);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Load Lại";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(370, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(476, 18);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(56, 13);
            this.lbl_Category.TabIndex = 10;
            this.lbl_Category.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tất cả game";
            // 
            // btn_removeall
            // 
            this.btn_removeall.Location = new System.Drawing.Point(370, 260);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(75, 23);
            this.btn_removeall.TabIndex = 6;
            this.btn_removeall.Text = "<<<";
            this.btn_removeall.UseVisualStyleBackColor = true;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(370, 221);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "<<";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addall
            // 
            this.btn_addall.Location = new System.Drawing.Point(370, 181);
            this.btn_addall.Name = "btn_addall";
            this.btn_addall.Size = new System.Drawing.Size(75, 23);
            this.btn_addall.TabIndex = 8;
            this.btn_addall.Text = ">>>";
            this.btn_addall.UseVisualStyleBackColor = true;
            this.btn_addall.Click += new System.EventHandler(this.btn_addall_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(370, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_GameofCategory
            // 
            this.pnl_GameofCategory.AutoScroll = true;
            this.pnl_GameofCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_GameofCategory.Location = new System.Drawing.Point(479, 36);
            this.pnl_GameofCategory.Name = "pnl_GameofCategory";
            this.pnl_GameofCategory.Size = new System.Drawing.Size(317, 380);
            this.pnl_GameofCategory.TabIndex = 4;
            // 
            // pnl_allGAme
            // 
            this.pnl_allGAme.AutoScroll = true;
            this.pnl_allGAme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_allGAme.Location = new System.Drawing.Point(11, 36);
            this.pnl_allGAme.Name = "pnl_allGAme";
            this.pnl_allGAme.Size = new System.Drawing.Size(317, 380);
            this.pnl_allGAme.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exe);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pnl_category);
            this.panel2.Controls.Add(this.txt_decription);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_datecreate);
            this.panel2.Controls.Add(this.txt_urlexec);
            this.panel2.Controls.Add(this.txt_namegame);
            this.panel2.Controls.Add(this.txt_version);
            this.panel2.Controls.Add(this.txt_size);
            this.panel2.Controls.Add(this.txt_iconUrl);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.btn_addgameindatabase);
            this.panel2.Controls.Add(this.btn_loadagain);
            this.panel2.Controls.Add(this.btn_AddGame);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Location = new System.Drawing.Point(36, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 282);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(96, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_category
            // 
            this.pnl_category.AutoScroll = true;
            this.pnl_category.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_category.Location = new System.Drawing.Point(245, 115);
            this.pnl_category.Name = "pnl_category";
            this.pnl_category.Size = new System.Drawing.Size(200, 145);
            this.pnl_category.TabIndex = 5;
            // 
            // txt_decription
            // 
            this.txt_decription.Location = new System.Drawing.Point(462, 96);
            this.txt_decription.Name = "txt_decription";
            this.txt_decription.Size = new System.Drawing.Size(189, 164);
            this.txt_decription.TabIndex = 4;
            this.txt_decription.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(462, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày tạo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "File Thực thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phiên bản Game";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Danh mục game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kích thước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đường dẫn Icon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id";
            // 
            // txt_datecreate
            // 
            this.txt_datecreate.Enabled = false;
            this.txt_datecreate.Location = new System.Drawing.Point(247, 71);
            this.txt_datecreate.Name = "txt_datecreate";
            this.txt_datecreate.Size = new System.Drawing.Size(189, 20);
            this.txt_datecreate.TabIndex = 2;
            // 
            // txt_urlexec
            // 
            this.txt_urlexec.Location = new System.Drawing.Point(462, 27);
            this.txt_urlexec.Name = "txt_urlexec";
            this.txt_urlexec.Size = new System.Drawing.Size(189, 20);
            this.txt_urlexec.TabIndex = 2;
            // 
            // txt_namegame
            // 
            this.txt_namegame.Location = new System.Drawing.Point(247, 27);
            this.txt_namegame.Name = "txt_namegame";
            this.txt_namegame.Size = new System.Drawing.Size(189, 20);
            this.txt_namegame.TabIndex = 2;
            // 
            // txt_version
            // 
            this.txt_version.Location = new System.Drawing.Point(28, 240);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(189, 20);
            this.txt_version.TabIndex = 2;
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(28, 192);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(189, 20);
            this.txt_size.TabIndex = 2;
            // 
            // txt_iconUrl
            // 
            this.txt_iconUrl.Enabled = false;
            this.txt_iconUrl.Location = new System.Drawing.Point(28, 148);
            this.txt_iconUrl.Name = "txt_iconUrl";
            this.txt_iconUrl.Size = new System.Drawing.Size(189, 20);
            this.txt_iconUrl.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(28, 104);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(189, 20);
            this.txt_id.TabIndex = 2;
            // 
            // btn_addgameindatabase
            // 
            this.btn_addgameindatabase.Location = new System.Drawing.Point(721, 129);
            this.btn_addgameindatabase.Name = "btn_addgameindatabase";
            this.btn_addgameindatabase.Size = new System.Drawing.Size(75, 39);
            this.btn_addgameindatabase.TabIndex = 0;
            this.btn_addgameindatabase.Text = "Thêm vào CSDL";
            this.btn_addgameindatabase.UseVisualStyleBackColor = true;
            this.btn_addgameindatabase.Click += new System.EventHandler(this.btn_addgameindatabase_Click);
            // 
            // btn_loadagain
            // 
            this.btn_loadagain.Location = new System.Drawing.Point(721, 54);
            this.btn_loadagain.Name = "btn_loadagain";
            this.btn_loadagain.Size = new System.Drawing.Size(75, 23);
            this.btn_loadagain.TabIndex = 0;
            this.btn_loadagain.Text = "Khôi phục";
            this.btn_loadagain.UseVisualStyleBackColor = true;
            // 
            // btn_AddGame
            // 
            this.btn_AddGame.Location = new System.Drawing.Point(721, 83);
            this.btn_AddGame.Name = "btn_AddGame";
            this.btn_AddGame.Size = new System.Drawing.Size(75, 40);
            this.btn_AddGame.TabIndex = 0;
            this.btn_AddGame.Text = "Thêm game mới";
            this.btn_AddGame.UseVisualStyleBackColor = true;
            this.btn_AddGame.Click += new System.EventHandler(this.btn_AddGame_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(721, 25);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thông tin game";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_exe
            // 
            this.btn_exe.Location = new System.Drawing.Point(594, 50);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(57, 23);
            this.btn_exe.TabIndex = 7;
            this.btn_exe.Text = "Duyệt";
            this.btn_exe.UseVisualStyleBackColor = true;
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FrmAddGameIntoCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbm_Category);
            this.Controls.Add(this.label10);
            this.Name = "FrmAddGameIntoCategory";
            this.Text = "Chèn game vào các danh mục";
            this.Load += new System.EventHandler(this.FrmAddGameIntoCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbm_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeall;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addall;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_GameofCategory;
        private System.Windows.Forms.Panel pnl_allGAme;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_loadagain;
        private System.Windows.Forms.Button btn_AddGame;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_addgameindatabase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_datecreate;
        private System.Windows.Forms.TextBox txt_urlexec;
        private System.Windows.Forms.TextBox txt_namegame;
        private System.Windows.Forms.TextBox txt_version;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.TextBox txt_iconUrl;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RichTextBox txt_decription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}