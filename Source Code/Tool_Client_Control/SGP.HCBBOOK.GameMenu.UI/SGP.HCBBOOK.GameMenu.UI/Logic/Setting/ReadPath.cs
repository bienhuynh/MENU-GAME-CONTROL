using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Setting
{
    public static class ReadPath
    {
        private static IJsonService jsonService;
        
        public static string ReadDiskSaveData
        {
            get
            {
                try
                {
                    jsonService = new JsonService();
                    string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.FileDiskSaveData);
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    SettingGlobal settingModel = js.Deserialize<SettingGlobal>(data);
                    return settingModel != null ? String.Format("{0}", settingModel.DiskSaveData) : null;
                }
                catch(Exception e)
                {

                }
                return null;
            }
        }

        public static string IpAddressCloud
        {
            get
            {
                try
                {
                    jsonService = new JsonService();
                    string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.FileDiskSaveData);
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    SettingGlobal settingModel = js.Deserialize<SettingGlobal>(data);
                    return settingModel != null ? String.Format("{0}", settingModel.IpAddressCloud) : null;
                }
                catch (Exception e)
                {

                }
                return null;
            }
        }

        public static int? PortCloud
        {
            get
            {
                try
                {
                    jsonService = new JsonService();
                    string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.FileDiskSaveData);
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    SettingGlobal settingModel = js.Deserialize<SettingGlobal>(data);
                    return settingModel != null ? settingModel.portCloud : null;
                }
                catch (Exception e)
                {

                }
                return null;
            }
        }
    }
}
