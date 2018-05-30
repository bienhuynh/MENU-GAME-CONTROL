using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.IService
{
    public interface IGameService
    {
        /// <summary>
        /// Lay toan bo danh sach game
        /// </summary>
        /// <returns></returns>
        IList<GameItem> GetAllGameList();
        Task<IList<GameItem>> GetAllGameListAync();
        /// <summary>
        /// Lay danh sach game theo UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IList<GameItem> GetGameListbyUserId(string userId);
        Task<IList<GameItem>> GetGameListbyUserIdAync(string userId);
        /// <summary>
        /// Lay danh sach game theo Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IList<GameItem> GetGameListbyEmail(string email);
        Task<IList<GameItem>> GetGameListbyEmailAync(string email);
        /// <summary>
        /// Them game
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        bool AddNewGame(GameItem gameItem);
        Task<bool> AddNewGameAync(GameItem gameItem);
        /// <summary>
        /// xoa game cua nguoi dung
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        bool DeleteGame(string userId, string gameId);
        Task<bool> DeleteGameAync(string userId, string gameId);
        /// <summary>
        /// Cap nhat thong tin game
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        bool UpdateGame(GameItem gameItem);
        /// <summary>
        /// Cap nhat game menu cua nguoi dung
        /// </summary>
        /// <param name="gameItem"></param>
        /// <returns></returns>
        bool UpdateGame(ControlGameMenu gameItem);
        Task<bool> UpdateGameAync(GameItem gameItem);
    }
}
