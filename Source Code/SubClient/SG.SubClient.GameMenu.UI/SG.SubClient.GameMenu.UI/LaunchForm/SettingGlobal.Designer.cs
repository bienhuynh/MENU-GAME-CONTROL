namespace SG.SubClient.GameMenu.UI.LaunchForm
{
    partial class SettingGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingGlobal));
            this.txt_ipaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_port = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gr_Customize = new System.Windows.Forms.GroupBox();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ckb_settingdefault = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gr_Customize.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ipaddress
            // 
            this.txt_ipaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ipaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_ipaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ipaddress.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ipaddress.HintText = "";
            this.txt_ipaddress.isPassword = false;
            this.txt_ipaddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ipaddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ipaddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ipaddress.LineThickness = 3;
            this.txt_ipaddress.Location = new System.Drawing.Point(17, 82);
            this.txt_ipaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipaddress.Name = "txt_ipaddress";
            this.txt_ipaddress.Size = new System.Drawing.Size(264, 33);
            this.txt_ipaddress.TabIndex = 0;
            this.txt_ipaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_port
            // 
            this.txt_port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_port.HintForeColor = System.Drawing.Color.Empty;
            this.txt_port.HintText = "";
            this.txt_port.isPassword = false;
            this.txt_port.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_port.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_port.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_port.LineThickness = 3;
            this.txt_port.Location = new System.Drawing.Point(289, 82);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(67, 33);
            this.txt_port.TabIndex = 0;
            this.txt_port.Text = "3000";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "IPAddress Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(285, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // gr_Customize
            // 
            this.gr_Customize.Controls.Add(this.txt_port);
            this.gr_Customize.Controls.Add(this.label3);
            this.gr_Customize.Controls.Add(this.txt_ipaddress);
            this.gr_Customize.Controls.Add(this.label2);
            this.gr_Customize.Location = new System.Drawing.Point(12, 113);
            this.gr_Customize.Name = "gr_Customize";
            this.gr_Customize.Size = new System.Drawing.Size(366, 132);
            this.gr_Customize.TabIndex = 2;
            this.gr_Customize.TabStop = false;
            this.gr_Customize.Text = "Customize";
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "Save";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(118, 283);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(124, 48);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ckb_settingdefault
            // 
            this.ckb_settingdefault.AutoSize = true;
            this.ckb_settingdefault.Location = new System.Drawing.Point(12, 251);
            this.ckb_settingdefault.Name = "ckb_settingdefault";
            this.ckb_settingdefault.Size = new System.Drawing.Size(113, 17);
            this.ckb_settingdefault.TabIndex = 5;
            this.ckb_settingdefault.Text = "Sử dụng mặc định";
            this.ckb_settingdefault.UseVisualStyleBackColor = true;
            this.ckb_settingdefault.CheckedChanged += new System.EventHandler(this.ckb_settingdefault_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Không tìm thấy máy chủ game. Chúng tôi đang chạy trên máy Local và port mặc định!" +
    " Vui lòng cấu hình cho chúng tôi thấy Máy chủ game của bạn qua Form sau:";
            // 
            // SettingGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 376);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ckb_settingdefault);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gr_Customize);
            this.Name = "SettingGlobal";
            this.Text = "SettingGlobal";
            this.Load += new System.EventHandler(this.SettingGlobal_Load);
            this.gr_Customize.ResumeLayout(false);
            this.gr_Customize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ipaddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gr_Customize;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private System.Windows.Forms.CheckBox ckb_settingdefault;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}