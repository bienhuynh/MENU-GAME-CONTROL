namespace SGP.HCBBOOK.GameMenu.UI
{
    partial class HomeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMain));
            
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeapp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackgroundImage = null;
            // 
            // btn_closeapp
            // 
            this.btn_closeapp.Click += new System.EventHandler(this.btn_closeapp_Click_1);
            // 
            // containUpdateProfile1
            // 
            //this.containUpdateProfile1.BackColor = System.Drawing.Color.Transparent;
            //this.containUpdateProfile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.containUpdateProfile1.Location = new System.Drawing.Point(5, 78);
            //this.containUpdateProfile1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            //this.containUpdateProfile1.Name = "containUpdateProfile1";
            //this.containUpdateProfile1.Size = new System.Drawing.Size(701, 492);
            //this.containUpdateProfile1.TabIndex = 3;
            // 
            // HomeMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeMain";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.HomeMain_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeapp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
    }
}