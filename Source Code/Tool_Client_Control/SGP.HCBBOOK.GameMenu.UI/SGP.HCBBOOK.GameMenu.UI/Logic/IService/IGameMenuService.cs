using SGP.HCBBOOK.GameMenu.UI.FormPartial;
using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.IService
{
    public interface IGameMenuService
    {
        /// <summary>
        /// Lấy danh sách game trên server và lưu vào file json
        /// </summary>
        /// <returns></returns>
        Task<IList<GameItem>> GetListGameOnServer();
        /// <summary>
        /// Quet ổ game chỉ lấy game thuộc về SGP
        /// </summary>
        /// <returns></returns>
        IList<GameItem> ScanDiskGame();
        /// <summary>
        /// Thêm game vào data file json
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        bool JAddGameInLocal(GameItem gameItem);
        /// <summary>
        /// Xóa game trong file Json
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        bool JDeletegame(GameItem gameItem);
        /// <summary>
        /// Cập nhật file Json lên server sau đó lấy lại file json mới
        /// </summary>
        /// <returns></returns>
        bool SyncData();
        /// <summary>
        /// Lấy dữ liều từ file json và đỗ vào danh sách game shoư ra giao diện
        /// </summary>
        /// <returns></returns>
        //IList<Itemgme> GetItemgmes();
        //Task<IList<Itemgme>> GetItemgmesAync();
        /// <summary>
        /// Load vào danh sách GameItem dữ liệu thô từ data json
        /// </summary>
        /// <returns></returns>
        IList<GameItem> JLoadGameItemFromDataJson();
        Task<IList<GameItem>> JLoadGameItemFromDataJsonAync();

        /// <summary>
        /// return mot id cho game tren may hien tai
        /// </summary>
        /// <returns></returns>
        string JRandomIdGame();
        Task<string> JRandomIdGameAync();

        /// <summary>
        /// Luu game da scan duoc vao dia dang file json
        /// </summary>
        /// <param name="gameItems"></param>
        /// <returns></returns>
        Task JSaveGameonDiskAync(IList<GameItem> gameItems);
        void JSaveGameonDisk(IList<GameItem> gameItems);
        /// <summary>
        /// Chay game 
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        ResultBasic RunGame(GameItem gameItem);
        Task<ResultBasic> RunGameAync(GameItem gameItem);

        void RunAppExplorer();
        void RunAppSystem(string nameapp);
        ResultBasic JUpdateGameToServer(GameItem gameItem);
        Task<ResultBasic> JUpdateGameToServerAync(GameItem gameItem);
        /*SQL*/
        //void SaveGameOnDb(GameItem gameItem);
        //GameItem GetGamebyId(string id);
        //IList<GameItem> GetListAllGame();
        //void DeleteGameItem(GameItem gameItem);
        //void EditGameItem(GameItem model);
    }
}
