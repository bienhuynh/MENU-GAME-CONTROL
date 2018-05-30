namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SwitchRememberPass = new Bunifu.Framework.UI.BunifuSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SwitchLoginFirst = new Bunifu.Framework.UI.BunifuSwitch();
            this.lbl_loginFirst = new System.Windows.Forms.Label();
            this.pnl_LoginFirst = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKey4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKey3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKey2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKey1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_LoginFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Email.HintText = "";
            this.txt_Email.isPassword = false;
            this.txt_Email.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Email.LineIdleColor = System.Drawing.Color.Black;
            this.txt_Email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Email.LineThickness = 4;
            this.txt_Email.Location = new System.Drawing.Point(216, 159);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(379, 33);
            this.txt_Email.TabIndex = 0;
            this.txt_Email.Text = "Email";
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.txt_Email.Click += new System.EventHandler(this.btn_Email_Click);
            this.txt_Email.MouseEnter += new System.EventHandler(this.btn_Email_MouseEnter);
            this.txt_Email.MouseLeave += new System.EventHandler(this.btn_Email_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Password.HintText = "";
            this.txt_Password.isPassword = true;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Password.LineIdleColor = System.Drawing.Color.Black;
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Password.LineThickness = 4;
            this.txt_Password.Location = new System.Drawing.Point(216, 243);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(379, 33);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.Text = "Password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.Click += new System.EventHandler(this.btn_Password_Click);
            this.txt_Password.MouseEnter += new System.EventHandler(this.btn_Password_MouseEnter);
            this.txt_Password.MouseLeave += new System.EventHandler(this.btn_Password_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(216, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.White;
            this.btn_login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.Location = new System.Drawing.Point(414, 84);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 41);
            this.btn_login.TabIndex = 12;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // SwitchRememberPass
            // 
            this.SwitchRememberPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchRememberPass.BorderRadius = 0;
            this.SwitchRememberPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRememberPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchRememberPass.Location = new System.Drawing.Point(219, 94);
            this.SwitchRememberPass.Name = "SwitchRememberPass";
            this.SwitchRememberPass.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchRememberPass.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchRememberPass.Size = new System.Drawing.Size(51, 19);
            this.SwitchRememberPass.TabIndex = 13;
            this.SwitchRememberPass.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchRememberPass.Value = false;
            this.SwitchRememberPass.Click += new System.EventHandler(this.SwitchRememberPass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(275, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhớ mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SwitchLoginFirst
            // 
            this.SwitchLoginFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchLoginFirst.BorderRadius = 0;
            this.SwitchLoginFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchLoginFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchLoginFirst.Location = new System.Drawing.Point(219, 297);
            this.SwitchLoginFirst.Name = "SwitchLoginFirst";
            this.SwitchLoginFirst.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchLoginFirst.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchLoginFirst.Size = new System.Drawing.Size(51, 19);
            this.SwitchLoginFirst.TabIndex = 13;
            this.SwitchLoginFirst.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchLoginFirst.Value = false;
            this.SwitchLoginFirst.Click += new System.EventHandler(this.SwitchLoginFirst_Click);
            // 
            // lbl_loginFirst
            // 
            this.lbl_loginFirst.AutoSize = true;
            this.lbl_loginFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_loginFirst.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_loginFirst.Location = new System.Drawing.Point(275, 297);
            this.lbl_loginFirst.Name = "lbl_loginFirst";
            this.lbl_loginFirst.Size = new System.Drawing.Size(411, 37);
            this.lbl_loginFirst.TabIndex = 14;
            this.lbl_loginFirst.Text = "Tôi mới đăng nhập lần đầu.";
            // 
            // pnl_LoginFirst
            // 
            this.pnl_LoginFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_LoginFirst.Controls.Add(this.label8);
            this.pnl_LoginFirst.Controls.Add(this.label7);
            this.pnl_LoginFirst.Controls.Add(this.label6);
            this.pnl_LoginFirst.Controls.Add(this.txtKey5);
            this.pnl_LoginFirst.Controls.Add(this.txtKey4);
            this.pnl_LoginFirst.Controls.Add(this.txtKey3);
            this.pnl_LoginFirst.Controls.Add(this.txtKey2);
            this.pnl_LoginFirst.Controls.Add(this.txtKey1);
            this.pnl_LoginFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_LoginFirst.Location = new System.Drawing.Point(215, 322);
            this.pnl_LoginFirst.Name = "pnl_LoginFirst";
            this.pnl_LoginFirst.Size = new System.Drawing.Size(491, 100);
            this.pnl_LoginFirst.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(182, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 37);
            this.label8.TabIndex = 25;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(82, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nhập Key lience";
            // 
            // txtKey5
            // 
            this.txtKey5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKey5.ForeColor = System.Drawing.Color.Black;
            this.txtKey5.HintForeColor = System.Drawing.Color.Empty;
            this.txtKey5.HintText = "";
            this.txtKey5.isPassword = false;
            this.txtKey5.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKey5.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtKey5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKey5.LineThickness = 4;
            this.txtKey5.Location = new System.Drawing.Point(404, 44);
            this.txtKey5.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey5.Name = "txtKey5";
            this.txtKey5.Size = new System.Drawing.Size(78, 42);
            this.txtKey5.TabIndex = 17;
            this.txtKey5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKey4
            // 
            this.txtKey4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKey4.ForeColor = System.Drawing.Color.Black;
            this.txtKey4.HintForeColor = System.Drawing.Color.Empty;
            this.txtKey4.HintText = "";
            this.txtKey4.isPassword = false;
            this.txtKey4.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKey4.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtKey4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKey4.LineThickness = 4;
            this.txtKey4.Location = new System.Drawing.Point(304, 44);
            this.txtKey4.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey4.Name = "txtKey4";
            this.txtKey4.Size = new System.Drawing.Size(78, 42);
            this.txtKey4.TabIndex = 18;
            this.txtKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey4.OnValueChanged += new System.EventHandler(this.txtKey4_OnValueChanged);
            // 
            // txtKey3
            // 
            this.txtKey3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKey3.ForeColor = System.Drawing.Color.Black;
            this.txtKey3.HintForeColor = System.Drawing.Color.Empty;
            this.txtKey3.HintText = "";
            this.txtKey3.isPassword = false;
            this.txtKey3.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKey3.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtKey3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKey3.LineThickness = 4;
            this.txtKey3.Location = new System.Drawing.Point(200, 44);
            this.txtKey3.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey3.Name = "txtKey3";
            this.txtKey3.Size = new System.Drawing.Size(78, 42);
            this.txtKey3.TabIndex = 19;
            this.txtKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey3.OnValueChanged += new System.EventHandler(this.txtKey3_OnValueChanged);
            // 
            // txtKey2
            // 
            this.txtKey2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKey2.ForeColor = System.Drawing.Color.Black;
            this.txtKey2.HintForeColor = System.Drawing.Color.Empty;
            this.txtKey2.HintText = "";
            this.txtKey2.isPassword = false;
            this.txtKey2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKey2.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtKey2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKey2.LineThickness = 4;
            this.txtKey2.Location = new System.Drawing.Point(99, 44);
            this.txtKey2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(78, 42);
            this.txtKey2.TabIndex = 20;
            this.txtKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey2.OnValueChanged += new System.EventHandler(this.txtKey2_OnValueChanged);
            // 
            // txtKey1
            // 
            this.txtKey1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKey1.ForeColor = System.Drawing.Color.White;
            this.txtKey1.HintForeColor = System.Drawing.Color.Empty;
            this.txtKey1.HintText = "";
            this.txtKey1.isPassword = false;
            this.txtKey1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKey1.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtKey1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKey1.LineThickness = 4;
            this.txtKey1.Location = new System.Drawing.Point(1, 44);
            this.txtKey1.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(78, 42);
            this.txtKey1.TabIndex = 21;
            this.txtKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey1.OnValueChanged += new System.EventHandler(this.txtKey1_OnValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(386, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(285, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "-";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_LoginFirst);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_loginFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SwitchLoginFirst);
            this.Controls.Add(this.SwitchRememberPass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.pnl_body, 0);
            this.Controls.SetChildIndex(this.txt_Email, 0);
            this.Controls.SetChildIndex(this.txt_Password, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_maxisize, 0);
            this.Controls.SetChildIndex(this.btn_minisize, 0);
            this.Controls.SetChildIndex(this.btn_login, 0);
            this.Controls.SetChildIndex(this.SwitchRememberPass, 0);
            this.Controls.SetChildIndex(this.SwitchLoginFirst, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbl_loginFirst, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pnl_LoginFirst, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_LoginFirst.ResumeLayout(false);
            this.pnl_LoginFirst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuSwitch SwitchRememberPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSwitch SwitchLoginFirst;
        private System.Windows.Forms.Label lbl_loginFirst;
        private System.Windows.Forms.Panel pnl_LoginFirst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKey5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKey4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKey3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKey2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKey1;
    }
}