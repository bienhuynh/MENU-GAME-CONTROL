namespace FaceRecognition
{
    partial class CamaraBox
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
            this.components = new System.ComponentModel.Container();
            this.imgbxcamara = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbxcamara)).BeginInit();
            this.SuspendLayout();
            // 
            // imgbxcamara
            // 
            this.imgbxcamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgbxcamara.Location = new System.Drawing.Point(0, 0);
            this.imgbxcamara.Name = "imgbxcamara";
            this.imgbxcamara.Size = new System.Drawing.Size(1054, 721);
            this.imgbxcamara.TabIndex = 2;
            this.imgbxcamara.TabStop = false;
            // 
            // CamaraBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgbxcamara);
            this.Name = "CamaraBox";
            this.Size = new System.Drawing.Size(1054, 721);
            this.Load += new System.EventHandler(this.CamaraBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbxcamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgbxcamara;
    }
}
