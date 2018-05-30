using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI.HCBBOOK.DesignItem
{
    //[DebuggerStepThrough]
    [DefaultEvent("Click")]
    [ProvideProperty("hcbbookFramework", typeof(Control))]
    public class hcbbookButton : Button
    {
        public hcbbookButton()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SGP.HCBBOOK.GameMenu.UI.Properties.Resources.button;
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
