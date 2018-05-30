using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGP.HCBBOOK.CORE.Database;
namespace SGP.HCBBOOK.CORE.Busssiness.Service
{
    public class GameService : IGameService
    {
        private SGPCloudEntities db;
        public GameService()
        {
            db = new SGPCloudEntities();
        }
        public bool AddNewGame(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddNewGameAync(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGame(string userId, string gameId)
        {
            var game = db.User_Game_Owner.FirstOrDefault(m => m.UserId == userId && m.GameId == gameId);
            if (game != null)
            {
                db.User_Game_Owner.Remove(game);
                db.SaveChanges();
                return true;
            }
            return (false);
        }

        public Task<bool> DeleteGameAync(string userId, string gameId)
        {
            var game = db.User_Game_Owner.FirstOrDefault(m => m.UserId == userId && m.GameId == gameId);
            if(game !=null)
            {
                db.User_Game_Owner.Remove(game);
                db.SaveChanges();
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public IList<GameItem> GetAllGameList()
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.List_Game_Disk)
            {
                res.Add(SetGameItem(null, item));
            }
            return res;
        }

        private GameItem SetGameItem(User_Game_Owner user_Game_Owner, List_Game_Disk item)
        {
            bool ishot = true;
            if(user_Game_Owner==null)
            {
                ishot = false;
            }
            return new GameItem
            {
                DateScan = item.DateScan,
                Description = item.Description != null ? item.Description : "N/A",
                IconImage = item.IconImage != null ? item.IconImage : new byte[1],
                IconUrL = item.IconUrL != null ? item.IconUrL : @"C:\SGP\IMG\icons8_Information_96px.png",
                IcoUrL = item.IcoUrl != null ? item.IconUrL : @"C:\SGP\IMG\icons8_Information_96px.png",
                Id = item.Id,
                NameGame = item.NameGame != null ? item.NameGame : "N/A",
                Size = item.Size != null ? item.Size : 0,
                URLExecute = item.URLExecute != null ? item.URLExecute : @"C:\SGP\IMG\Notfound.jpg",
                Version = item.Version != null ? item.Version : "1.0",
                IsGameOnline = (bool)item.IsGameOnline,
                IsGameChienThuat = (bool)item.IsGameChienThuat,
                IsGameHot = ishot
            };
        }

        public Task<IList<GameItem>> GetAllGameListAync()
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.List_Game_Disk)
            {
                res.Add(SetGameItem(null, item));
            }
            return Task.FromResult(res);
        }

        public IList<GameItem> GetGameListbyUserId(string userId)
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.User_Game_Owner.Where(m => m.UserId == userId))
            {
                var game = db.List_Game_Disk.Find(item);
                res.Add(SetGameItem(item, game));
            }
            return res;
        }

        public async Task<IList<GameItem>> GetGameListbyUserIdAync(string userId)
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.User_Game_Owner.Where(m => m.UserId == userId))
            {
                var game = await db.List_Game_Disk.FindAsync(item);
                res.Add(SetGameItem(item, game));
            }
            return res;
        }

        public bool UpdateGame(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGameAync(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public IList<GameItem> GetGameListbyEmail(string email)
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.User_Game_Owner.Where(m => m.UserId == email))
            {
                var game = db.List_Game_Disk.Find(item);
                res.Add(SetGameItem(item, game));
            }
            return res;
        }

        public async Task<IList<GameItem>> GetGameListbyEmailAync(string email)
        {
            IList<GameItem> res = new List<GameItem>();
            foreach (var item in db.User_Game_Owner.Where(m => m.UserId == email))
            {
                var game = await db.List_Game_Disk.FindAsync(item);
                res.Add(SetGameItem(item, game));
            }
            return res;
        }

        public bool UpdateGame(ControlGameMenu gameItem)
        {
            throw new NotImplementedException();
        }
    }
}
