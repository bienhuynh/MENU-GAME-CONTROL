using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client
{
    public partial class rbMenuGame : Form
    {
        public rbMenuGame()
        {
            InitializeComponent();
        }
        
        //Giao diện khi kết nối tới server
        private void rbMain_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(792, 536);
            byte[] ID = new byte[10];
            byte[] result = new byte[512];

            BienToanCuc.clientSocket = new TcpClient();
            BienToanCuc.clientSocket.Connect("124.158.13.36", 80);
            lbConnect.Text = "Đã Kết Nối Được Với Server...";

            Random rNum = new Random();

            //Tạo luồn gửi nhận dữ liệu
            NetworkStream networdStream = BienToanCuc.clientSocket.GetStream();
            //Hàm tạo ID tự động
            int numRandom = rNum.Next(101,65000);

            //Gửi thông tin ID
            ID = BitConverter.GetBytes(numRandom);
            networdStream.Write(ID, 0 ,ID.Length);
            //Nhận thông báo thành công
            networdStream.Read(result, 0, result.Length);
            int temp = BitConverter.ToInt32(result, 0);

            if (temp == 0)
            {
                
                tbMessage.Text = "Id User: " + numRandom;
            }
            else
            {
                tbMessage.Text = "ID USER: " + temp;
            }
        }

        //Hàm thông báo ID User của client
        private void msg(string mesg)
        {
            //throw new NotImplementedException();
            tbMessage.Text = tbMessage.Text + Environment.NewLine + " >> " + mesg + " <<";
        }

        
        /*************HÀM THỰC HIỆN GỬI SỰ KIỆN CLICK CHUỘT VÀ NHẬN URL*************/
        private void Section(int number)
        {
            //Mảng kiểu byte để lưu trữ dữ liệu dưới dạng byte.
            byte[] data = new byte[4];
            byte[] data2 = new byte[512];
            //Chuỗi này dùng để convert từ mảng kiểu byte sang String.
            string strData = "";

            //Tạo ra luồng Stream để gửi và nhận thông tin.
            NetworkStream ns = BienToanCuc.clientSocket.GetStream();

            //Gửi thông điệp về cho Server
            data = BitConverter.GetBytes(number);
            ns.Write(data, 0, data.Length);
            ns.Flush();

            //Nhận thông điệp từ Server - link url
            ns.Read(data2, 0, data2.Length);
            strData = Encoding.ASCII.GetString(data2);
            if (number != 0)
            {
                System.Diagnostics.Process.Start(strData);
            }
            else
            {
                rbMenuGame exit = new rbMenuGame();
                this.Hide();
                exit.Close();
                this.Close();
            }
        }
        
        
        /*************** Tab Giải Trí ********************/

        //01. Mở game Võ Lâm Chi Mộng
        private void pbVLChiMong_Click(object sender, EventArgs e)
        {
            Section(1);
        }
        //02. Mở game Gunny
        private void pbGunny_Click(object sender, EventArgs e)
        {
            Section(2);
        }
        //03. Mở game Khu Vườn Trên Mây
        private void pbKVTrenMay_Click(object sender, EventArgs e)
        {
            Section(3);
        }
        //04. Mở game 3Q
        private void pb3Q_Click(object sender, EventArgs e)
        {
            Section(4);
        }
        //05. Mở game Ra2
        private void pbRa2_Click(object sender, EventArgs e)
        {
            Section(5);
        }
        //06. mở game Độc bá
        private void pbĐBVõLâm_Click(object sender, EventArgs e)
        {
            Section(6);
        }
        //07. mở game Bá Vương
        private void pbBaVuong_Click(object sender, EventArgs e)
        {
            Section(7);
        }
        //08. mở Fbook
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            Section(8);
        }
        //09. mở ZingMe
        private void pbZingMe_Click(object sender, EventArgs e)
        {
            Section(9);
        }
        //10. mở YoutuBe
        private void pbYouTuBe_Click(object sender, EventArgs e)
        {
            Section(10);
        }
        //11. mở Twister
        private void pbTwister_Click(object sender, EventArgs e)
        {
            Section(11);
        }
        //12. mở Zalo
        private void pbZalo_Click(object sender, EventArgs e)
        {
            Section(12);
        }
        //13. mở G+
        private void pbGGPlus_Click(object sender, EventArgs e)
        {
            Section(13);
        }


        /*************** Tab Tin Tức ********************/

        //21. mở báo 24h
        private void pb24hNews_Click(object sender, EventArgs e)
        {
            Section(21);
        }
        //22. mở Báo Mới
        private void pbBaoMoiNews_Click(object sender, EventArgs e)
        {
            Section(22);
        }
        //23. mở báo Dân Trí
        private void pbDanTriNews_Click(object sender, EventArgs e)
        {
            Section(23);
        }
        //24. mở báo Vnexpress
        private void pbVnexpress_Click(object sender, EventArgs e)
        {
            Section(24);
        }
        //25. mở báo Tiếp Thị & Gia Đình
        private void pbTiepThiGiaDinh_Click(object sender, EventArgs e)
        {
            Section(25);
        }
        //26. mở báo Thanh Niên
        private void pbThanhNien_Click(object sender, EventArgs e)
        {
            Section(26);
        }
        //27. mở báo Tuổi Trẻ
        private void pbTuoiTre_Click(object sender, EventArgs e)
        {
            Section(27);
        }


        /*************** Tab Tin Tức ********************/
        //31. mở NCT
        private void pbNCT_Click(object sender, EventArgs e)
        {
            Section(31);
        }
        //32. mở Mp3Zing
        private void pbMp3Zing_Click(object sender, EventArgs e)
        {
            Section(32);
        }
        //33. mở NhacVui
        private void pbNhacVui_Click(object sender, EventArgs e)
        {
            Section(33);
        }
        //34. mở NhacSo
        private void pbNhacSo_Click(object sender, EventArgs e)
        {
            Section(34);
        }



        /*************** Tab Ứng Dụng Của Máy ********************/
        private void pbMyComputer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyComputer));
        }

        private void pbChrome_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void pbVisual_Click(object sender, EventArgs e)
        {
            Section(53);
        }

        private void pbBiDaFlash_Click(object sender, EventArgs e)
        {
            Section(54);
        }

        private void pbRa2OFF_Click(object sender, EventArgs e)
        {
            Section(55);
        }
        private void pbZaloPC_Click(object sender, EventArgs e)
        {
            Section(56);
        }

        ////Section thoát ứng dụng
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Section(0);
        }        
    }

    public class BienToanCuc
    {
        public static TcpClient clientSocket;
    }
}