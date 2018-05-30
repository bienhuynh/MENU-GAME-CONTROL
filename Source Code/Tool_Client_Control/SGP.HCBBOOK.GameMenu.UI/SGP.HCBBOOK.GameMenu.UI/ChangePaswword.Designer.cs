namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class ChangePaswword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePaswword));
            this.txtPasswordold = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpasswwordnew = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.btnsave);
            this.pnl_body.Controls.Add(this.txtpasswwordnew);
            this.pnl_body.Controls.Add(this.txtPasswordold);
            this.pnl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_body_Paint);
            // 
            // txtPasswordold
            // 
            this.txtPasswordold.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPasswordold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordold.HintForeColor = System.Drawing.Color.Empty;
            this.txtPasswordold.HintText = "";
            this.txtPasswordold.isPassword = true;
            this.txtPasswordold.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPasswordold.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPasswordold.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPasswordold.LineThickness = 3;
            this.txtPasswordold.Location = new System.Drawing.Point(213, 76);
            this.txtPasswordold.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordold.Name = "txtPasswordold";
            this.txtPasswordold.Size = new System.Drawing.Size(379, 33);
            this.txtPasswordold.TabIndex = 0;
            this.txtPasswordold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpasswwordnew
            // 
            this.txtpasswwordnew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswwordnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpasswwordnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpasswwordnew.HintForeColor = System.Drawing.Color.Empty;
            this.txtpasswwordnew.HintText = "";
            this.txtpasswwordnew.isPassword = true;
            this.txtpasswwordnew.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpasswwordnew.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpasswwordnew.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpasswwordnew.LineThickness = 3;
            this.txtpasswwordnew.Location = new System.Drawing.Point(213, 145);
            this.txtpasswwordnew.Margin = new System.Windows.Forms.Padding(4);
            this.txtpasswwordnew.Name = "txtpasswwordnew";
            this.txtpasswwordnew.Size = new System.Drawing.Size(379, 33);
            this.txtpasswwordnew.TabIndex = 1;
            this.txtpasswwordnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "Save";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 20;
            this.btnsave.IdleFillColor = System.Drawing.Color.White;
            this.btnsave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.Location = new System.Drawing.Point(293, 208);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(181, 41);
            this.btnsave.TabIndex = 3;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(213, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(213, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // ChangePaswword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ChangePaswword";
            this.Text = "ChangePaswword";
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtpasswwordnew;
    }
}