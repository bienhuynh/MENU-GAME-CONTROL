namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class FormHcbbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHcbbook));
            this.border_top = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minisize = new System.Windows.Forms.Button();
            this.btn_maxisize = new System.Windows.Forms.Button();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabelHCBBOOK = new System.Windows.Forms.LinkLabel();
            this.linkLabelSGP = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // border_top
            // 
            this.border_top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.border_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.border_top.Location = new System.Drawing.Point(0, 0);
            this.border_top.Name = "border_top";
            this.border_top.Size = new System.Drawing.Size(800, 30);
            this.border_top.TabIndex = 0;
            this.border_top.TabStop = false;
            this.border_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseDown);
            this.border_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseMove);
            this.border_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(360, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "From";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(620, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(15, 15);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minisize
            // 
            this.btn_minisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minisize.BackgroundImage")));
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_minisize.Location = new System.Drawing.Point(579, 9);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(15, 15);
            this.btn_minisize.TabIndex = 10;
            this.btn_minisize.UseVisualStyleBackColor = true;
            this.btn_minisize.Click += new System.EventHandler(this.btn_maxisize_Click);
            // 
            // btn_maxisize
            // 
            this.btn_maxisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maxisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maxisize.BackgroundImage")));
            this.btn_maxisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_maxisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maxisize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_maxisize.Location = new System.Drawing.Point(599, 9);
            this.btn_maxisize.Name = "btn_maxisize";
            this.btn_maxisize.Size = new System.Drawing.Size(15, 15);
            this.btn_maxisize.TabIndex = 11;
            this.btn_maxisize.UseVisualStyleBackColor = true;
            this.btn_maxisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.label9);
            this.pnl_footer.Controls.Add(this.linkLabelHCBBOOK);
            this.pnl_footer.Controls.Add(this.linkLabelSGP);
            this.pnl_footer.Controls.Add(this.label10);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 428);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(800, 22);
            this.pnl_footer.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(548, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Được phát triển bởi";
            // 
            // linkLabelHCBBOOK
            // 
            this.linkLabelHCBBOOK.AutoSize = true;
            this.linkLabelHCBBOOK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabelHCBBOOK.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelHCBBOOK.Location = new System.Drawing.Point(646, 4);
            this.linkLabelHCBBOOK.Name = "linkLabelHCBBOOK";
            this.linkLabelHCBBOOK.Size = new System.Drawing.Size(153, 13);
            this.linkLabelHCBBOOK.TabIndex = 19;
            this.linkLabelHCBBOOK.TabStop = true;
            this.linkLabelHCBBOOK.Text = "HCBBOOK Dev. Mai Trúc Lâm";
            this.linkLabelHCBBOOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelSGP
            // 
            this.linkLabelSGP.AutoSize = true;
            this.linkLabelSGP.Location = new System.Drawing.Point(396, 5);
            this.linkLabelSGP.Name = "linkLabelSGP";
            this.linkLabelSGP.Size = new System.Drawing.Size(115, 13);
            this.linkLabelSGP.TabIndex = 18;
            this.linkLabelSGP.TabStop = true;
            this.linkLabelSGP.Text = "Siêu Giải Pháp @2018";
            this.linkLabelSGP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSGP_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bản quyền thuộc về ";
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 30);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(800, 398);
            this.pnl_body.TabIndex = 13;
            // 
            // FormHcbbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.btn_minisize);
            this.Controls.Add(this.btn_maxisize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.border_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHcbbook";
            this.Text = "FormHcbbook";
            this.Load += new System.EventHandler(this.FormHcbbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox border_top;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_minisize;
        public System.Windows.Forms.Button btn_maxisize;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.LinkLabel linkLabelSGP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabelHCBBOOK;
        public System.Windows.Forms.Panel pnl_body;
    }
}