using SG.SubClient.GameMenu.UI.LaunchForm;
using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG.SubClient.GameMenu.UI.LogicFeature.Service
{
    public class TcpClientConnection : ITcpClientConnection
    {
        private TcpClient _tcpClient;
        private IPEndPoint _serverEndpoint;
        private int _maxsize;
        private string result;
        private FormCustom _form;
        //public delegate void OnMessageReceived(string data);
        //public event OnMessageReceived MessageReceived;

        public TcpClientConnection(string serverAddress, int port)
        {
            this._tcpClient = new TcpClient();
            this._serverEndpoint = new IPEndPoint(IPAddress.Parse(serverAddress), port);
            this._maxsize = 4;
            result = "";
            this._form = null;
        }

        public string Result()
        {
            return result;
        }

        public void Connect()
        {
            this._tcpClient.Connect(this._serverEndpoint);
        }

        public void SendData(string message)
        {
            NetworkStream clientStream = this._tcpClient.GetStream();

            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(message);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            //byte[] result = new byte[1024*_maxsize];
            ReceiveResponseFromServerAsync();
        }

        public void ReceiveResponseFromServerAsync()
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    try
                    {
                        NetworkStream networkStream = _tcpClient.GetStream();
                        byte[] bufferToRead = new byte[1024*_maxsize];
                        int len = networkStream.Read(bufferToRead, 0, bufferToRead.Length);
                        if (len > 0)
                        {
                            //result += encoder.GetString(bufferToRead, 0, len);
                            //result += Encoding.Unicode.GetString(bufferToRead);
                            result += System.Text.UnicodeEncoding.Unicode.GetString(bufferToRead, 0, len);
                            //this._form.OnLoad();
                        }
                        else
                        {
                            //if (MessageReceived != null)
                            //{
                            //    MessageReceived(result);
                            //}
                            
                            
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            });
        }

        public void ResetResult()
        {
            this.result = "";
        }

        public void FormWork(FormCustom form)
        {
            this._form = form;
        }

        public FormCustom FormIsAction()
        {
            return this._form;
        }
    }
}
