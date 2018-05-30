using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Server
{
    //Khái các các thủ tục
    public class BienToanCuc
    {
        public static LinkedList<int> ListID;
        public static int Exit; //Báo Thoát
        public static int counter_User;
    }

    /********************Chương trình chính**********************/
    class Server
    {
        static void Main(string[] args)
        {
            List<IPAddress> ips;

            ips = Dns.GetHostAddresses("").Where(i => i.AddressFamily == AddressFamily.InterNetwork).ToList(); 

            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("    {0}", ip);
            }
            Console.ReadKey();
            BienToanCuc.counter_User = 0;
            BienToanCuc.Exit = 1;

            TcpListener serverSocket = new TcpListener(8888);
            TcpClient clientSocket = default(TcpClient);
            //TcpClient clientSocket = new TcpClient[10];

            serverSocket.Start();
            Console.WriteLine("----->> Server is Onine");

            //Khai báo danh sách User
            BienToanCuc.ListID = new LinkedList<int>();

            while (true)
            {
                BienToanCuc.counter_User += 1;

                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("----->> Accept connection from User " + BienToanCuc.counter_User);


                handleClient Handleclient = new handleClient();
                //Xử Lí tiến trình
                Handleclient.StartThread(clientSocket, 
                                                    serverSocket, BienToanCuc.ListID);

                //clientSocket[BienToanCuc.counter_User].Close();
            }
            serverSocket.Stop();
            Console.WriteLine("-----> EXIT");
            Console.WriteLine();
        }
    }

    public class handleClient
    {
        TcpClient clientSocket;

        public void StartThread(TcpClient client, TcpListener server, LinkedList<int> linked)
        {
            this.clientSocket = client;
            byte[] ID = new byte[10];
            byte[] result = new byte[512];
            int sucess;

            //Tạo luồn gửi nhận dữ liệu
            NetworkStream networkStream = clientSocket.GetStream();
            //Nhận ID
            networkStream.Read(ID, 0, ID.Length);
            int temp = BitConverter.ToInt32(ID, 0);
            Console.WriteLine("-->> User ID " + temp + " is loggin");

            LinkedListNode<int> node = linked.Find(temp);
            if (node == null)
            {
                linked.AddLast(temp);
                sucess = 0;
            }
            else
            {
                Random r = new Random();
                sucess = r.Next(1, 100);
                Console.WriteLine("ID " + temp + " is online in system");
                foreach (var value in linked)
                {
                    Console.WriteLine("----------------->" + value);
                }
                Console.WriteLine("Accept using special ID -> " + sucess);
            }

            //Gửi thông tin thành công(0) hay không thành công(!=0)
            result = BitConverter.GetBytes(sucess);
            networkStream.Write(result, 0, result.Length);
            networkStream.Flush();

            /*****************Bắt đầu xử lí việc mở ứng dụng***********************/
            Thread ctThread = new Thread(Processing);
            ctThread.Start();


            //clientSocket.Close();
        }

        //Section mở ứng dụng
        private void Processing()
        {
            byte[] data = new byte[4];
            byte[] data2 = new byte[512];
            string strData = "";

            //throw new NotImplementedException();
            NetworkStream networkStream = clientSocket.GetStream();
            while(BienToanCuc.Exit == 1)
            {
                try
                {
                    //Nhận dữ liệu click chuột từ user
                    networkStream.Read(data, 0, data.Length);
                    int Data = BitConverter.ToInt32(data, 0);
                    //Gửi link url tương ứng cho người dùng
                    switch (Data)
                    {
                        case 1:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 2:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 3:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 4:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 5:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 6:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 7:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 8:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 9:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 10:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 11:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 12:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 13:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 21:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 22:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 23:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 24:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 25:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 26:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 27:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 31:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 32:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 33:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 34:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 53:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 54:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 55:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                        case 56:
                            Section(ref data2, ref strData, networkStream, Data);
                            break;

                        default:
                            BienToanCuc.Exit = 0;
                            Section(ref data2, ref strData, networkStream, Data);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }

        //Section Gửi URL cho Client
        private void Section(ref byte[] data2, ref string strData, NetworkStream networkStream, int Icau)
        {
            strData = readFile(Icau);
            data2 = Encoding.ASCII.GetBytes(strData);
            networkStream.Write(data2, 0, data2.Length);
            networkStream.Flush();
        }

        //Đọc File dữ liệu link URL
        private string readFile(int isentence)
        {
            int temp = 0;
            string strData = "";
            StreamReader sr = File.OpenText(@"C:\Users\TrungVi\Desktop\MenuGameSocket\Server\Data.txt");
            string input = null;
            while ((input = sr.ReadLine()) != null)
            {
                if (temp == isentence)
                {
                    strData = input;
                }
                temp++;
            }
            return strData;
        }
    }
}
