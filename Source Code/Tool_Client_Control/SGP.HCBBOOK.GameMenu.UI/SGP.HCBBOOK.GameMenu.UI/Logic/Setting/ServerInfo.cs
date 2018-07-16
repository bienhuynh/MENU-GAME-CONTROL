using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Setting
{
    public static class ServerInfo
    {
        //http://192.158.13.36:81
        public const string IPAddress = "http://124.158.13.36:81/";
    }

    public static class ClientInfo
    {
        public const string IPAddress = "127.0.0.1";
    }

    public static class DataFile
    {
        public const string FileListGame = "DataGame";
        public const string FileDiskSaveData = "DiskSaveData";
        public const string FilHistoryLoginSession = "HistoryLoginSession";
        public const string UserLogin = "UserLogin";
        public const string UserProfile = "UserProfile";
        internal const string CategorysGame = "CategoryGame";
    }
}
