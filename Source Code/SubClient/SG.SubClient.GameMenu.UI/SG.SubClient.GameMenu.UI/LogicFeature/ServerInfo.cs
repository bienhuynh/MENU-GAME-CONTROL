using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SG.SubClient.GameMenu.UI.LogicFeature
{
    public static class ServerInfo
    {
        //124.158.13.36
        public const string IPAddressDefault = "127.0.0.1";
        public const int PortDefault = 3100;

        public static string IPAddress
        {
            get
            {
                IJsonService jsonService = new JsonService();
                string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), FileNameStore.SettingGlobal);
                var settingGlobalModel = new JavaScriptSerializer().Deserialize<SettingGlobalModel>(data);

                return settingGlobalModel != null ? settingGlobalModel.IpAddress : null;
            }
        }

        public static int? Port
        {
            get
            {
                IJsonService jsonService = new JsonService();
                string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), FileNameStore.SettingGlobal);
                var settingGlobalModel = new JavaScriptSerializer().Deserialize<SettingGlobalModel>(data);
                return settingGlobalModel != null ? settingGlobalModel.port : null;
            }
        }

        public static bool SaveConfig(SettingGlobalModel settingGlobalModel)
        {
            if(settingGlobalModel!=null)
            {
                try
                {
                    IJsonService jsonService = new JsonService();
                    string setingdata = new JavaScriptSerializer().Serialize(settingGlobalModel);
                    jsonService.SaveFile(Directory.GetCurrentDirectory(), FileNameStore.SettingGlobal, setingdata);
                    return true;
                }
                catch( Exception ex)
                {

                }
            }
            return false;
        }
    }

}
