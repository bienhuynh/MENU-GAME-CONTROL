using SG.SubClient.GameMenu.UI.LaunchForm;
using SG.SubClient.GameMenu.UI.LogicFeature;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.LogicFeature.Service;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI
{
    static class Program
    {
        private static ITcpClientConnection _tcpClientConnection;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if(ServerInfo.IPAddress != null && ServerInfo.Port != null)
                {
                    _tcpClientConnection = new TcpClientConnection(ServerInfo.IPAddress, (int)ServerInfo.Port);                    
                }
                else
                {
                    SettingGlobal settingGlobal = new SettingGlobal();
                    settingGlobal.Show();
                    _tcpClientConnection = new TcpClientConnection(ServerInfo.IPAddressDefault, (int)ServerInfo.PortDefault);
                    //MessageBox.Show("Không tìm thấy máy chủ game. Chúng tôi đang chạy trên máy Local và port mặc định! Vui lòng cấu hình cho chúng tôi thấy Máy chủ game của bạn qua Form sau:");
                }
                //_tcpClientConnection.FormWork(formMaster);
                _tcpClientConnection.Connect();
                //_tcpClientConnection.SendData(ClauseTCP.GetGame);
            }
            catch(Exception ec)
            {
                MessageBox.Show("Máy chủ game Không liên lạc được.");
                SettingGlobal settingGlobal = new SettingGlobal();
                settingGlobal.Show();
                _tcpClientConnection = new TcpClientConnection(ServerInfo.IPAddressDefault, (int)ServerInfo.PortDefault);
                //Environment.Exit(1);
            }
            
            //FormMaster formMaster = new FormMaster(_tcpClientConnection);
            //formMaster.LoadIconGame();
            //HomeMain form = new HomeMain(_tcpClientConnection);
            //form.LoadIconGame();

            Application.Run(new Laucher(_tcpClientConnection));
        }
    }
}
