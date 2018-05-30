using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition
{
    public class ReadAllBytesApp
    {
        public string ReadAllBitApp()
        {
            byte[] bytes = File.ReadAllBytes(Application.ExecutablePath);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string value = Convert.ToString(bytes[i], 2);
                value = value.PadLeft(8, '0');
                sb.Append(value + ' ');
            }
            return sb.ToString();
        }
    }
}
