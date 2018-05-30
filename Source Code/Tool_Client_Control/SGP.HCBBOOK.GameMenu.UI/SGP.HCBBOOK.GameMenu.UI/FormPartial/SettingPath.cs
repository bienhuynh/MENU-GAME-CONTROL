using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SGP.HCBBOOK.GameMenu.UI.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class SettingPath : FormHcbbook
    {
        private IJsonService jsonService;
        private SettingGlobal settingGlobal;
        private DriveInfo[] myDrives;
        public SettingPath()
        {
            InitializeComponent();
            settingGlobal = new SettingGlobal();
            jsonService = new JsonService();
            base.RenameTitleForm("Setting");
        }

        private void cmbDiak_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingGlobal.DiskSaveData = cmbDiak.SelectedValue.ToString();
        }

        private void SettingPath_Load(object sender, EventArgs e)
        {
            try
            {
                myDrives = DriveInfo.GetDrives();
                DataTable dt = new DataTable("Drive");
                dt.Columns.Add("Value", typeof(string));
                dt.Columns.Add("Display", typeof(string));
                foreach (DriveInfo drive in myDrives)
                {
                    //if (drive.IsReady != true)
                    //{
                    //    //Console.WriteLine("Vol Label:" + drive.VolumeLabel);
                    //    //Console.WriteLine("File System: " + drive.DriveFormat);
                    //    dt.NewRow();
                    //    dt.Rows.Add(new Object[]
                    //    {
                    //        drive.Name,
                    //        String.Format("{0}({1})",drive.Name,drive.DriveType)
                    //    });
                    //}
                    
                    dt.NewRow();
                    dt.Rows.Add(new Object[]
                    {
                            drive.Name,
                            String.Format("{0}({1})",drive.Name,drive.DriveType)
                    });
                }
                cmbDiak.ValueMember = "Value";
                cmbDiak.DisplayMember = "Display";
                cmbDiak.DataSource = dt;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_saveChangeSeetingStorage_Click(object sender, EventArgs e)
        {
            try
            {
                string setingdata = new JavaScriptSerializer().Serialize(settingGlobal);
                jsonService.SaveFile(Directory.GetCurrentDirectory(), DataFile.FileDiskSaveData, setingdata);
                MessageBox.Show("Đã lưu.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể lưu Cài đặt.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveico_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveChangeSeetingStorage_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_saveico_Click_1(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            txt_locationico.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                settingGlobal.DiskSaveData = txt_locationico.Text;
                settingGlobal.IpAddressCloud = txt_IpAddressCloudSGp.Text;
                settingGlobal.portCloud = Int32.Parse(txtPortCloudSGP.Text);
                string setingdata = new JavaScriptSerializer().Serialize(settingGlobal);
                jsonService.SaveFile(Directory.GetCurrentDirectory(), DataFile.FileDiskSaveData, setingdata);
                MessageBox.Show("Lưu cài đặt thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu Cài đặt. Vui lòng điền đúng thông tin.");
            }
        }
    }
}
