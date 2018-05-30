using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.HCBBOOK.GameMenu.UI
{
    static class Program
    {
        //private static ITcpServerConnection tcpServerConnection;
        //private static IHostService hostService;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITcpServerConnection tcpServerConnection;
            IHostService hostService;
            ICallAPIService callAPIService;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            callAPIService = new CallAPIService();
            tcpServerConnection = new TcpServerConnection(callAPIService);
            hostService = new HostService();

            //int port = 3000;
            //int portunUsed = hostService.GetOpenPortUnUsed();
            //bool s = hostService.CheckAvailableServerPort(port);
            //hostService.OpenPort(port);
            //bool s1 = hostService.Test_connection("127.0.0.1", port);
            //var listportUsed = hostService.GetListOpenPortUsed();

            //tcpServerConnection.Start();
            //var listclient = tcpServerConnection.ConnectedClients();
            //TcpClient clientComminicate = tcpServerConnection.LastCommunicatedClient();
            //if (clientComminicate != null)
            //    tcpServerConnection.SendDataToClient(clientComminicate, "Hello Client");

            tcpServerConnection.Start();
            var tcpClient = tcpServerConnection.LastCommunicatedClient();
            HomeMain homeMain = new HomeMain(callAPIService);
            Application.Run((homeMain));
        }
    }
}
