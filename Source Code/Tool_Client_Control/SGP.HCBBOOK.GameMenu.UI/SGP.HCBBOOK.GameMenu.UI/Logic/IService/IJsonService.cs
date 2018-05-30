using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    interface IJsonService
    {
        /// <summary>
        /// Lưu  file json với tên filename và dữ liệu là biến data
        /// </summary>
        /// <param name="fileName">tên file</param>
        /// <param name="data">dữ liệu json</param>
        /// <returns></returns>
        Task SaveFileAync(string Path, string fileName, string data);
        void SaveFile(string Path, string fileName, string data);
        /// <summary>
        /// Lưu  file json với tên filename và dữ liệu là biến data
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task SaveFileAync(string Path, string fileName, IList<GameItem> data);
        void SaveFile(string Path, string fileName, IList<GameItem> data);
        /// <summary>
        /// Load file json dữ liệu vào ram
        /// </summary>
        /// <param name="fileName">tên file</param>
        /// <returns></returns>
        string ReadFile(string Path, string fileName);
        Task<string> ReadFileAync(string Path, string fileName);
    }
}
