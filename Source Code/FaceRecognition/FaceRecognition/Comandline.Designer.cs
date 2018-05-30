namespace FaceRecognition
{
    partial class Comandline
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
            this.richtextCommandline = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtextCommandline
            // 
            this.richtextCommandline.BackColor = System.Drawing.Color.DarkSlateGray;
            this.richtextCommandline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextCommandline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextCommandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.richtextCommandline.ForeColor = System.Drawing.Color.Chartreuse;
            this.richtextCommandline.Location = new System.Drawing.Point(0, 0);
            this.richtextCommandline.Name = "richtextCommandline";
            this.richtextCommandline.Size = new System.Drawing.Size(643, 423);
            this.richtextCommandline.TabIndex = 7;
            this.richtextCommandline.Text = "HCB>";
            this.richtextCommandline.Click += new System.EventHandler(this.richtextCommandline_Click);
            this.richtextCommandline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandline_KeyDown);
            this.richtextCommandline.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCommandline_KeyUp);
            // 
            // Comandline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 423);
            this.Controls.Add(this.richtextCommandline);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.Name = "Comandline";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandline";
            this.Controls.SetChildIndex(this.richtextCommandline, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richtextCommandline;
    }
}