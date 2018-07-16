
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface ICallAPIService
    {
        /// <summary>
        /// Goi phuong thuc post tra ve kieu json
        /// </summary>
        /// <param name="url">example: api/get/3</param>
        /// <returns></returns>
        Task<IList<GameItem>> GET(string url);
        /// <summary>
        /// Goi phuong thuc get tra ve kieu json
        /// </summary>
        /// <param name="url">example: api/get</param>
        /// <returns></returns>
        Task<IList<GameItem>> POST(string url);
        Task POST(string url, GameItem gameItem);
        //Task GET(string url, GameItem gameItem);
        string POST(string url, string data);
        Task<string> POSTAync(string url, string data);
    }
}
