using Microsoft.VisualBasic.Logging;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class HostService:IHostService
    {
        public bool CheckAvailableServerPort(int port)
        {
            bool isAvailable = true;

            // Evaluate current system tcp connections. This is the same information provided
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endpoint in tcpConnInfoArray)
            {
                if (endpoint.Port == port)
                {
                    isAvailable = false;
                    break;
                }
            }
            
            return isAvailable;
        }

        public List<int> GetListOpenPortUsed()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndPoints = properties.GetActiveTcpListeners();

            List<int> usedPorts = tcpEndPoints.Select(p => p.Port).ToList<int>();
            
            return usedPorts;
        }

        public int GetOpenPortUnUsed()
        {
            int PortStartIndex = 1000;
            int PortEndIndex = 2000;
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndPoints = properties.GetActiveTcpListeners();

            List<int> usedPorts = tcpEndPoints.Select(p => p.Port).ToList<int>();
            int unusedPort = 0;

            for (int port = PortStartIndex; port < PortEndIndex; port++)
            {
                if (!usedPorts.Contains(port))
                {
                    unusedPort = port;
                    break;
                }
            }
            return unusedPort;
        }

        public bool OpenPort(int port)
        {
            var tcpListener = default(TcpListener);

            try
            {
                //var ipAddress = Dns.GetHostEntry("127.0.0.1").AddressList[0];
                var ipAddress = (IPAddress)Dns.GetHostAddresses("127.0.0.1")[0];
                tcpListener = new TcpListener(ipAddress, port);
                tcpListener.Start();

                return true;
            }
            catch (SocketException)
            {
            }
            finally
            {
                if (tcpListener == null)
                    tcpListener.Stop();
            }

            return false;
        }

        public bool Test_connection(string hostname, int portno)
        {
            IPAddress ipa = (IPAddress)Dns.GetHostAddresses(hostname)[0];
            try
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
                sock.Connect(ipa, portno);
                if (sock.Connected == true)
                {
                    //MessageBox.Show("Port is in use");
                    return true;
                }

                sock.Close();
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                if (ex.ErrorCode == 10060)
                {
                    //MessageBox.Show("No connection.");
                    
                }
            }
            return false;
        }
    }
}
