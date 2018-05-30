namespace FaceRecognition
{
    partial class FormMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.trackBarOpacityform = new Hcbbook.Hcbbook_TrackBar();
            this.btn_down = new System.Windows.Forms.Button();
            this.lblopacityform = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_minisize = new System.Windows.Forms.Button();
            this.btn_maxisize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.border_top = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_menu.Controls.Add(this.trackBarOpacityform);
            this.pnl_menu.Controls.Add(this.btn_down);
            this.pnl_menu.Controls.Add(this.lblopacityform);
            resources.ApplyResources(this.pnl_menu, "pnl_menu");
            this.pnl_menu.Name = "pnl_menu";
            // 
            // trackBarOpacityform
            // 
            this.trackBarOpacityform.JumpToMouse = false;
            resources.ApplyResources(this.trackBarOpacityform, "trackBarOpacityform");
            this.trackBarOpacityform.Maximum = 10;
            this.trackBarOpacityform.Minimum = 0;
            this.trackBarOpacityform.Name = "trackBarOpacityform";
            this.trackBarOpacityform.Value = 0;
            this.trackBarOpacityform.ValueDivison = Hcbbook.Hcbbook_TrackBar.ValueDivisor.By1;
            this.trackBarOpacityform.ValueToSet = 0F;
            this.trackBarOpacityform.ValueChanged += new Hcbbook.Hcbbook_TrackBar.ValueChangedEventHandler(this.trackBarOpacityform_ValueChanged);
            // 
            // btn_down
            // 
            this.btn_down.BackgroundImage = global::FaceRecognition.Properties.Resources.icon_chevron_down_128;
            resources.ApplyResources(this.btn_down, "btn_down");
            this.btn_down.FlatAppearance.BorderSize = 0;
            this.btn_down.Name = "btn_down";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // lblopacityform
            // 
            resources.ApplyResources(this.lblopacityform, "lblopacityform");
            this.lblopacityform.ForeColor = System.Drawing.Color.White;
            this.lblopacityform.Name = "lblopacityform";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::FaceRecognition.Properties.Resources.menu_alt_512;
            resources.ApplyResources(this.btn_menu, "btn_menu");
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_minisize
            // 
            resources.ApplyResources(this.btn_minisize, "btn_minisize");
            this.btn_minisize.BackgroundImage = global::FaceRecognition.Properties.Resources.minimumsize;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.UseVisualStyleBackColor = true;
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // btn_maxisize
            // 
            resources.ApplyResources(this.btn_maxisize, "btn_maxisize");
            this.btn_maxisize.BackgroundImage = global::FaceRecognition.Properties.Resources.maximumsize;
            this.btn_maxisize.FlatAppearance.BorderSize = 0;
            this.btn_maxisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_maxisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_maxisize.Name = "btn_maxisize";
            this.btn_maxisize.UseVisualStyleBackColor = true;
            this.btn_maxisize.Click += new System.EventHandler(this.btn_maxisize_Click);
            // 
            // btn_exit
            // 
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.BackgroundImage = global::FaceRecognition.Properties.Resources.btn_exit;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // border_top
            // 
            this.border_top.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.border_top, "border_top");
            this.border_top.Name = "border_top";
            this.border_top.TabStop = false;
            this.border_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseDown);
            this.border_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseMove);
            this.border_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_top_MouseUp);
            // 
            // FormMaster
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_minisize);
            this.Controls.Add(this.btn_maxisize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.border_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaster";
            this.ResizeBegin += new System.EventHandler(this.FormMaster_ResizeBegin);
            this.Click += new System.EventHandler(this.FormMaster_Click);
            this.Resize += new System.EventHandler(this.FormMaster_ResizeBegin);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hcbbook.Hcbbook_TrackBar trackBarOpacityform;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Label lblopacityform;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btn_maxisize;
        public System.Windows.Forms.Button btn_minisize;
        public System.Windows.Forms.PictureBox border_top;
        public System.Windows.Forms.Button btn_menu;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Panel pnl_menu;
    }
}