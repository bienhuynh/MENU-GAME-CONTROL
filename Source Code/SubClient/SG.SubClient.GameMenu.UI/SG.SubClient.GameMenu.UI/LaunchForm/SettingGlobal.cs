using SG.SubClient.GameMenu.UI.LogicFeature;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LaunchForm
{
    public partial class SettingGlobal : Form
    {
        private IJsonService jsonService;
        
        public string IpAddress { get; set; }
        public int port { get; set; }
        public SettingGlobal()
        {
            InitializeComponent();
            jsonService = new JsonService();
        }

        private void SettingGlobal_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.ckb_settingdefault.Checked)
                {
                    this.IpAddress = txt_ipaddress.Text;
                    this.port = Int32.Parse(txt_port.Text);
                }
                else
                {
                    this.IpAddress = ServerInfo.IPAddressDefault;
                    this.port = ServerInfo.PortDefault;
                }
                //Lưu cấu hình
                bool res = ServerInfo.SaveConfig(new SettingGlobalModel { port = this.port, IpAddress = this.IpAddress });
                if(!res)
                {
                    MessageBox.Show("Lưu không thành công! Đĩa chỉ cho đọc");
                }
                else
                {
                    MessageBox.Show("Lưu cấu hình thành công! Vui lòng khởi động lại chương trình.");
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập IPAddress hoặc Port Sai");
            }
        }

        private void ckb_settingdefault_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_settingdefault.Checked)
            {
                gr_Customize.Enabled = false;
            }
            else
            {
                gr_Customize.Enabled = true;
            }
        }
    }
}
