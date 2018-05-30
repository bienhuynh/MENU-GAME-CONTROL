using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.SubClient.GameMenu.UI.LogicFeature.IService
{
    public interface IGameMenuService
    {
        /// <summary>
        /// Lấy danh sách game
        /// </summary>
        /// <returns></returns>
        IList<GameItem> GetListAllGame();
        /// <summary>
        /// Lấy dang sách game
        /// </summary>
        /// <returns></returns>
        Task<IList<GameItem>> GetListAllGameAync();
        IList<GameItem> GetListGameHot();
        Task<IList<GameItem>> GetListGameHotAync();
        /// <summary>
        /// Chay game 
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        ResultBasic RunGame(GameItem gameItem);
        Task<ResultBasic> RunGameAync(GameItem gameItem);
        /// <summary>
        /// Dóng game
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        ResultBasic CloseGame(GameItem gameItem);
        Task<ResultBasic> CloseGameAync(GameItem gameItem);
        void RunAppSystem(string nameapp);
        void RunAppExplorer();
    }
}
