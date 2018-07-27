using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class TcpServerConnection : ITcpServerConnection
    {
        private TcpListener _tcpListener;
        private List<TcpClient> _connectedClients;
        private Thread _listenThread;
        private TcpClient _lastCommunicatedClient;
        private IGameMenuService gameMenuService;
        private IJsonService jsonService;
        private int _maxSize;

        public TcpServerConnection(ICallAPIService _callAPIService)
        {
            this._tcpListener = new TcpListener(IPAddress.Any, 3100);
            gameMenuService = new GameMenuService(_callAPIService);
            jsonService = new JsonService();
            this._maxSize = 1024 * 1024 * 5;
        }
        //public delegate void OnMessageReceived(object sender, MessageEventArgs e);
        //public event OnMessageReceived MessageReceived;

        public IList<TcpClient> ConnectedClients()
        {
            return _connectedClients;
        }

        public TcpClient LastCommunicatedClient()
        {
             return _lastCommunicatedClient; 
        }
        
        public void Start()
        {
            this._listenThread = new Thread(new ThreadStart(ListenToClients));
            this._listenThread.Start();
        }

        private void ListenToClients()
        {
            this._tcpListener.Start();
            this._connectedClients = new List<TcpClient>();

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this._tcpListener.AcceptTcpClient();
                this._connectedClients.Add(client);

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[_maxSize];
            int bytesRead;
            try
            {
                while (true)
                {
                    bytesRead = 0;

                    try
                    {
                        //blocks until a client sends a message
                        bytesRead = clientStream.Read(message, 0, _maxSize);
                    }
                    catch (Exception ex)
                    {
                        //a socket error has occured
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        //the client has disconnected from the server
                        break;
                    }

                    this._lastCommunicatedClient = tcpClient;

                    //message has successfully been received
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    string text = encoder.GetString(message, 0, bytesRead);

                    HandleRequest(tcpClient, text);
                }
            }
            catch(Exception ex) { }

            tcpClient.Close();
        }
        private void HandleRequest(TcpClient tcpClient,string clause)
        {
            if(ClauseTCP.GetGame == clause)//Lay game
            {
                string json = jsonService.ReadFile(ReadPath.ReadDiskSaveData, DataFile.FileListGame);
                SendDataToClient(tcpClient, json);
            }
            else if (ClauseTCP.UpdateData == clause)//cap nhat du lieu
            {

            }
            else if (ClauseTCP.Authenticate == clause)//xac thuc may con
            {

            }
            else if(ClauseTCP.DownloadFile == clause)
            {
                FTClientCode.SendFile(String.Format("{0}\\SGP\\Data\\{1}.sgp", ReadPath.ReadDiskSaveData, DataFile.FileListGame));
            }
        }
        public void SendDataToClient(TcpClient tcpClient, string message)
        {
            NetworkStream clientStream = tcpClient.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            //byte[] buffer = encoder.GetBytes(message);
            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
            byte[] buffer = unicodeEncoding.GetBytes(message);
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }
    }
}
