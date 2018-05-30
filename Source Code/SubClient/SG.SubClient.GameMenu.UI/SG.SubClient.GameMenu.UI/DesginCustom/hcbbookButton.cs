using SG.SubClient.GameMenu.UI.LaunchForm;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.DesginCustom
{
    //[DebuggerStepThrough]
    [DefaultEvent("Click")]
    [ProvideProperty("hcbbookFramework", typeof(Control))]
    public class hcbbookButton : Button
    {
        public hcbbookButton()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SG.SubClient.GameMenu.UI.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.Name = "btn_";
            this.Size = new System.Drawing.Size(179, 58);
            this.UseVisualStyleBackColor = false;
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected override bool ShowFocusCues
        {
            get
            {
                //return base.ShowFocusCues;
                return false;
            }
        }
    }

    //[DebuggerStepThrough]
    [DefaultEvent("Click")]
    [ProvideProperty("hcbbookFramework", typeof(Control))]
    public class hcbbookButton2 : Button
    {
        public hcbbookButton2()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SG.SubClient.GameMenu.UI.Properties.Resources.btngame2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.Name = "btn_";
            this.Size = new System.Drawing.Size(179, 58);
            this.UseVisualStyleBackColor = false;
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected override bool ShowFocusCues
        {
            get
            {
                //return base.ShowFocusCues;
                return false;
            }
        }
    }

    //[DebuggerStepThrough]
    [DefaultEvent("Click")]
    [ProvideProperty("hcbbookFramework", typeof(Control))]
    public class hcbbookButton3 : Button
    {
        public hcbbookButton3()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SG.SubClient.GameMenu.UI.Properties.Resources.btngame3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.Name = "btn_";
            this.Size = new System.Drawing.Size(179, 58);
            this.UseVisualStyleBackColor = false;
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected override bool ShowFocusCues
        {
            get
            {
                //return base.ShowFocusCues;
                return false;
            }
        }
    }

    //[DebuggerStepThrough]
    [DefaultEvent("Click")]
    [ProvideProperty("hcbbookFramework", typeof(Control))]
    public class hcbbookButtonPlayGame : Button
    {   
        public hcbbookButtonPlayGame()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SG.SubClient.GameMenu.UI.Properties.Resources.button_play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.Name = "btn_";
            this.Size = new System.Drawing.Size(179, 58);
            this.UseVisualStyleBackColor = false;
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected override bool ShowFocusCues
        {
            get
            {
                //return base.ShowFocusCues;
                return false;
            }
        }
    }
}
