namespace FaceRecognition
{
    partial class Camara
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
            this.components = new System.ComponentModel.Container();
            this.imgbxcamara = new Emgu.CV.UI.ImageBox();
            this.menuForm1 = new FaceRecognition.MenuForm();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbxcamara)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_maxisize
            // 
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_maxisize.Location = new System.Drawing.Point(962, 5);
            this.btn_maxisize.Click += new System.EventHandler(this.btn_maxisize_Click);
            // 
            // btn_minisize
            // 
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_minisize.Location = new System.Drawing.Point(942, 5);
            this.btn_minisize.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // border_top
            // 
            this.border_top.Size = new System.Drawing.Size(1002, 30);
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
            this.btn_exit.Location = new System.Drawing.Point(982, 5);
            // 
            // pnl_menu
            // 
            this.pnl_menu.Location = new System.Drawing.Point(3, 70);
            // 
            // imgbxcamara
            // 
            this.imgbxcamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgbxcamara.Location = new System.Drawing.Point(0, 30);
            this.imgbxcamara.Name = "imgbxcamara";
            this.imgbxcamara.Size = new System.Drawing.Size(1002, 696);
            this.imgbxcamara.TabIndex = 2;
            this.imgbxcamara.TabStop = false;
            // 
            // menuForm1
            // 
            this.menuForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuForm1.Location = new System.Drawing.Point(0, 30);
            this.menuForm1.Name = "menuForm1";
            this.menuForm1.Size = new System.Drawing.Size(1002, 38);
            this.menuForm1.TabIndex = 11;
            // 
            // Camara
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 726);
            this.ControlBox = false;
            this.Controls.Add(this.menuForm1);
            this.Controls.Add(this.imgbxcamara);
            this.Name = "Camara";
            this.Text = "Camara";
            this.Controls.SetChildIndex(this.pnl_menu, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_menu, 0);
            this.Controls.SetChildIndex(this.border_top, 0);
            this.Controls.SetChildIndex(this.btn_maxisize, 0);
            this.Controls.SetChildIndex(this.btn_minisize, 0);
            this.Controls.SetChildIndex(this.imgbxcamara, 0);
            this.Controls.SetChildIndex(this.menuForm1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbxcamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgbxcamara;
        private MenuForm menuForm1;
    }
}