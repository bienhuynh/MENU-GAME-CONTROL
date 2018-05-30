namespace FaceRecognition
{
    partial class ChoseFormClose
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
            this.txtNumber = new LollipopTextBox();
            this.cmbListFrm = new System.Windows.Forms.ComboBox();
            this.hcbbook_Label1 = new Hcbbook.Hcbbook_Label();
            this.hcbbook_Label2 = new Hcbbook.Hcbbook_Label();
            this.btnEnter = new LollipopButton();
            this.btn_close = new LollipopButton();
            this.lbltotal = new Hcbbook.Hcbbook_Label();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_maxisize
            // 
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_maxisize.Location = new System.Drawing.Point(320, 5);
            // 
            // btn_minisize
            // 
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_minisize.Location = new System.Drawing.Point(300, 5);
            // 
            // border_top
            // 
            this.border_top.Size = new System.Drawing.Size(360, 30);
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
            this.btn_exit.Location = new System.Drawing.Point(340, 5);
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtNumber.FocusedColor = "#508ef5";
            this.txtNumber.FontColor = "#0000FF";
            this.txtNumber.IsEnabled = true;
            this.txtNumber.Location = new System.Drawing.Point(30, 142);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = false;
            this.txtNumber.Size = new System.Drawing.Size(300, 24);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumber.UseSystemPasswordChar = false;
            // 
            // cmbListFrm
            // 
            this.cmbListFrm.BackColor = System.Drawing.Color.DarkCyan;
            this.cmbListFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListFrm.FormattingEnabled = true;
            this.cmbListFrm.Location = new System.Drawing.Point(30, 83);
            this.cmbListFrm.Name = "cmbListFrm";
            this.cmbListFrm.Size = new System.Drawing.Size(300, 21);
            this.cmbListFrm.TabIndex = 0;
            // 
            // hcbbook_Label1
            // 
            this.hcbbook_Label1.AutoSize = true;
            this.hcbbook_Label1.BackColor = System.Drawing.Color.Transparent;
            this.hcbbook_Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcbbook_Label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hcbbook_Label1.Location = new System.Drawing.Point(30, 53);
            this.hcbbook_Label1.Name = "hcbbook_Label1";
            this.hcbbook_Label1.Size = new System.Drawing.Size(207, 19);
            this.hcbbook_Label1.TabIndex = 13;
            this.hcbbook_Label1.Text = "List Form Find Face Action";
            // 
            // hcbbook_Label2
            // 
            this.hcbbook_Label2.AutoSize = true;
            this.hcbbook_Label2.BackColor = System.Drawing.Color.Transparent;
            this.hcbbook_Label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcbbook_Label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hcbbook_Label2.Location = new System.Drawing.Point(30, 116);
            this.hcbbook_Label2.Name = "hcbbook_Label2";
            this.hcbbook_Label2.Size = new System.Drawing.Size(157, 19);
            this.hcbbook_Label2.TabIndex = 13;
            this.hcbbook_Label2.Text = "Enter Number in List";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BGColor = "#508ef5";
            this.btnEnter.FontColor = "#ffffff";
            this.btnEnter.Location = new System.Drawing.Point(187, 188);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(143, 35);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BGColor = "#508ef5";
            this.btn_close.FontColor = "#ffffff";
            this.btn_close.Location = new System.Drawing.Point(30, 188);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(143, 35);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(30, 27);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(53, 19);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Total: ";
            // 
            // ChoseFormClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 237);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.hcbbook_Label2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.hcbbook_Label1);
            this.Controls.Add(this.cmbListFrm);
            this.Controls.Add(this.txtNumber);
            this.Name = "ChoseFormClose";
            this.Text = "ChoseFormClose";
            this.TopMost = true;
            this.Controls.SetChildIndex(this.border_top, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_maxisize, 0);
            this.Controls.SetChildIndex(this.btn_minisize, 0);
            this.Controls.SetChildIndex(this.btn_menu, 0);
            this.Controls.SetChildIndex(this.pnl_menu, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.cmbListFrm, 0);
            this.Controls.SetChildIndex(this.hcbbook_Label1, 0);
            this.Controls.SetChildIndex(this.lbltotal, 0);
            this.Controls.SetChildIndex(this.hcbbook_Label2, 0);
            this.Controls.SetChildIndex(this.btnEnter, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hcbbook.Hcbbook_Label hcbbook_Label1;
        private Hcbbook.Hcbbook_Label hcbbook_Label2;
        private LollipopButton btnEnter;
        private LollipopButton btn_close;
        public System.Windows.Forms.ComboBox cmbListFrm;
        public LollipopTextBox txtNumber;
        public Hcbbook.Hcbbook_Label lbltotal;
    }
}