namespace FaceRecognition
{
    partial class MenuForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognitionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOOLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.tOOLSToolStripMenuItem,
            this.camaraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(47, 34);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontalToolStripMenuItem,
            this.flipVerticalToolStripMenuItem,
            this.recognitionParametersToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.aDDToolStripMenuItem.Text = "SETTINGS";
            // 
            // flipHorizontalToolStripMenuItem
            // 
            this.flipHorizontalToolStripMenuItem.Name = "flipHorizontalToolStripMenuItem";
            this.flipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.flipHorizontalToolStripMenuItem.Text = "FlipHorizontal";
            this.flipHorizontalToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontalToolStripMenuItem_Click);
            // 
            // flipVerticalToolStripMenuItem
            // 
            this.flipVerticalToolStripMenuItem.Name = "flipVerticalToolStripMenuItem";
            this.flipVerticalToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.flipVerticalToolStripMenuItem.Text = "FlipVertical";
            this.flipVerticalToolStripMenuItem.Click += new System.EventHandler(this.flipVerticalToolStripMenuItem_Click);
            // 
            // recognitionParametersToolStripMenuItem
            // 
            this.recognitionParametersToolStripMenuItem.Name = "recognitionParametersToolStripMenuItem";
            this.recognitionParametersToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.recognitionParametersToolStripMenuItem.Text = "Recognition Parameters";
            this.recognitionParametersToolStripMenuItem.Click += new System.EventHandler(this.recognitionParametersToolStripMenuItem_Click);
            // 
            // tOOLSToolStripMenuItem
            // 
            this.tOOLSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandLineToolStripMenuItem});
            this.tOOLSToolStripMenuItem.Name = "tOOLSToolStripMenuItem";
            this.tOOLSToolStripMenuItem.Size = new System.Drawing.Size(65, 34);
            this.tOOLSToolStripMenuItem.Text = "TOOLS";
            // 
            // commandLineToolStripMenuItem
            // 
            this.commandLineToolStripMenuItem.Name = "commandLineToolStripMenuItem";
            this.commandLineToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.commandLineToolStripMenuItem.Text = "CommandLine";
            this.commandLineToolStripMenuItem.Click += new System.EventHandler(this.commandLineToolStripMenuItem_Click);
            // 
            // camaraToolStripMenuItem
            // 
            this.camaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartCamaraToolStripMenuItem,
            this.pauseCamaraToolStripMenuItem,
            this.stopCamaraToolStripMenuItem});
            this.camaraToolStripMenuItem.Name = "camaraToolStripMenuItem";
            this.camaraToolStripMenuItem.Size = new System.Drawing.Size(72, 34);
            this.camaraToolStripMenuItem.Text = "Camara";
            // 
            // restartCamaraToolStripMenuItem
            // 
            this.restartCamaraToolStripMenuItem.Name = "restartCamaraToolStripMenuItem";
            this.restartCamaraToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.restartCamaraToolStripMenuItem.Text = "Restart Camara";
            this.restartCamaraToolStripMenuItem.Click += new System.EventHandler(this.restartCamaraToolStripMenuItem_Click);
            // 
            // pauseCamaraToolStripMenuItem
            // 
            this.pauseCamaraToolStripMenuItem.Name = "pauseCamaraToolStripMenuItem";
            this.pauseCamaraToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.pauseCamaraToolStripMenuItem.Text = "Pause Camara";
            this.pauseCamaraToolStripMenuItem.Click += new System.EventHandler(this.pauseCamaraToolStripMenuItem_Click);
            // 
            // stopCamaraToolStripMenuItem
            // 
            this.stopCamaraToolStripMenuItem.Name = "stopCamaraToolStripMenuItem";
            this.stopCamaraToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.stopCamaraToolStripMenuItem.Text = "Stop Camara";
            this.stopCamaraToolStripMenuItem.Click += new System.EventHandler(this.stopCamaraToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuForm";
            this.Size = new System.Drawing.Size(681, 38);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recognitionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOOLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCamaraToolStripMenuItem;
    }
}
