namespace FaceRecognition
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
            this.txtUsername = new LollipopTextBox();
            this.hcbbook_BtnLogin = new Hcbbook.Hcbbook_Button();
            this.txtPassword = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_maxisize
            // 
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_maxisize.Location = new System.Drawing.Point(543, 5);
            // 
            // btn_minisize
            // 
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_minisize.Location = new System.Drawing.Point(523, 5);
            // 
            // border_top
            // 
            this.border_top.Size = new System.Drawing.Size(583, 30);
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exit.Location = new System.Drawing.Point(563, 5);
            // 
            // txtUsername
            // 
            this.txtUsername.FocusedColor = "#508ef5";
            this.txtUsername.FontColor = "#999999";
            this.txtUsername.IsEnabled = true;
            this.txtUsername.Location = new System.Drawing.Point(139, 92);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(300, 24);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // hcbbook_BtnLogin
            // 
            this.hcbbook_BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.hcbbook_BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hcbbook_BtnLogin.Image = null;
            this.hcbbook_BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hcbbook_BtnLogin.Location = new System.Drawing.Point(215, 195);
            this.hcbbook_BtnLogin.Name = "hcbbook_BtnLogin";
            this.hcbbook_BtnLogin.Size = new System.Drawing.Size(146, 41);
            this.hcbbook_BtnLogin.TabIndex = 13;
            this.hcbbook_BtnLogin.Text = "Login";
            this.hcbbook_BtnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.hcbbook_BtnLogin.Click += new System.EventHandler(this.hcbbook_BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.FocusedColor = "#508ef5";
            this.txtPassword.FontColor = "#999999";
            this.txtPassword.IsEnabled = true;
            this.txtPassword.Location = new System.Drawing.Point(139, 139);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(300, 24);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 348);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.hcbbook_BtnLogin);
            this.Controls.Add(this.txtUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.Controls.SetChildIndex(this.border_top, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_maxisize, 0);
            this.Controls.SetChildIndex(this.btn_minisize, 0);
            this.Controls.SetChildIndex(this.btn_menu, 0);
            this.Controls.SetChildIndex(this.pnl_menu, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.hcbbook_BtnLogin, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopTextBox txtUsername;
        private Hcbbook.Hcbbook_Button hcbbook_BtnLogin;
        private LollipopTextBox txtPassword;
    }
}