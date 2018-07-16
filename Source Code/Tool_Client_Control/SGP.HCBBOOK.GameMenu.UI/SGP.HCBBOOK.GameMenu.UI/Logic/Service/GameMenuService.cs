using SGP.HCBBOOK.GameMenu.UI.FormPartial;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class GameMenuService : IGameMenuService
    {
        private ICallAPIService callAPIService;
        private IJsonService jsonService;
        private string pathGame = ReadPath.ReadDiskSaveData;//Directory.GetCurrentDirectory();
        //private MenuGameDBEntities db;
        public GameMenuService(ICallAPIService _callAPIService)
        {
           this.callAPIService = _callAPIService;
            jsonService = new JsonService();
            //db = new MenuGameDBEntities();
        }

        public bool JAddGameInLocal(GameItem gameItem)
        {
            try
            {
                var games = JLoadGameItemFromDataJson();
                games.Add(gameItem);
                jsonService.SaveFile(pathGame, DataFile.FileListGame, games);
                return true;
            }
            catch
            {

            }
            return false;
        }

        public bool JDeletegame(GameItem gameItem)
        {
            try
            {
                var games = JLoadGameItemFromDataJson();
                games.Remove(gameItem);
                jsonService.SaveFile(pathGame, DataFile.FileListGame, games);
            }
            catch
            {

            }
            return false;
        }
        
        public async Task<IList<GameItem>> GetListGameOnServer()
        {
            string url = "apigameservice/GetAllListGame";
            //Dua danh sach game vao RAM
            IList<GameItem> routes_list = await callAPIService.GET(url);
            jsonService.SaveFile(pathGame, DataFile.FileListGame, routes_list);

            return routes_list;
        }

        public IList<GameItem> JLoadGameItemFromDataJson()
        {
            string json = jsonService.ReadFile(pathGame, DataFile.FileListGame);
            JavaScriptSerializer js = new JavaScriptSerializer();
            var games = js.Deserialize<List<GameItem>>(json);
            return games;
        }

        public async Task<IList<GameItem>> JLoadGameItemFromDataJsonAync()
        {
            string json = await jsonService.ReadFileAync(pathGame, DataFile.FileListGame);
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<List<GameItem>>(json);
        }

        public string JRandomIdGame()
        {
            Random r = new Random();
            string id = null;
            IList<GameItem> games;
            do
            {
                id = String.Format("SGP{0}", r.Next(10000, 99999));

                games = JLoadGameItemFromDataJson().Where(m => m.Id == id).ToList();
                if (games == null)
                {
                    break;
                }
            }
            while (games.Count() > 0);
            return id;
        }

        public Task<string> JRandomIdGameAync()
        {
            Random r = new Random();
            string id = null;
            IList<GameItem> games = new List<GameItem>();
            do
            {
                id = String.Format("SGP{0}", r.Next(10000, 99999));

                games = JLoadGameItemFromDataJson();
                if (games == null)
                {
                    break;
                }
            }
            while (games.Where(m => m.Id == id).ToList().Count() > 0);
            return Task.FromResult(id);
        }

        public void RunAppExplorer()
        {
            Process.Start("explorer.exe", System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyComputer));
        }

        public void RunAppSystem(string nameapp)
        {
            Process.Start(nameapp);
        }

        public ResultBasic RunGame(GameItem gameItem)
        {
            try
            {
                System.Diagnostics.Process.Start("CMD.exe", String.Format("/C \"{0}\"", gameItem.URLExecute));
                return new ResultBasic { IsSuccess = true, Message = "Chương trình Run thành công!" };
            }
            catch
            {

            }

            return new ResultBasic { IsSuccess = false, Message = "Chương trình không tồn tại" };
        }

        
        public Task<ResultBasic> RunGameAync(GameItem gameItem)
        {
            try
            {
                System.Diagnostics.Process.Start("CMD.exe", String.Format("/C \"{0}\"", gameItem.URLExecute));
                return Task.FromResult(new ResultBasic { IsSuccess = true, Message = "Chương trình Run thành công!" });
            }
            catch
            {

            }

            return Task.FromResult(new ResultBasic { IsSuccess = false, Message = "Chương trình không tồn tại" });
        }

        public void JSaveGameonDisk(IList<GameItem> gameItems)
        {
            jsonService.SaveFile(pathGame, DataFile.FileListGame, gameItems);
        }

        public async Task JSaveGameonDiskAync(IList<GameItem> gameItems)
        {
            await jsonService.SaveFileAync(pathGame, DataFile.FileListGame, gameItems);
        }

        public IList<GameItem> ScanDiskGame()
        {
            throw new NotImplementedException();
        }

        public bool SyncData()
        {
            throw new NotImplementedException();
        }

        public ResultBasic JUpdateGameToServer(GameItem gameItem)
        {
            string url = "apigameservice/GetAllListGame";
            //Dua danh sach game vao RAM
            
            if (gameItem !=null)
            {
                callAPIService.POST(url, gameItem);
                return new ResultBasic { IsSuccess = true, Message = "Đã cập nhật lên server." };
            }
            return new ResultBasic { IsSuccess = false, Message = "Cập nhật lên server thất bại." };
        }

        public Task<ResultBasic> JUpdateGameToServerAync( GameItem gameItem)
        {
            string url = "apigameservice/GetAllListGame";
            //Dua danh sach game vao RAM

            if (gameItem != null)
            {
                callAPIService.POST(url, gameItem);
                return Task.FromResult(new ResultBasic { IsSuccess = true, Message = "Đã cập nhật lên server." });
            }
            return Task.FromResult(new ResultBasic { IsSuccess = false, Message = "Cập nhật lên server thất bại." });
        }

        /*SQL*/

        //public void DeleteGameItem(GameItem gameItem)
        //{
        //    db.GameItem.Remove(gameItem);
        //    db.SaveChanges();
        //}

        //public void EditGameItem(GameItem model)
        //{
        //    var game = db.GameItem.Find(model.Id);
        //    if (game != null)
        //    {
        //        game = model;
        //        db.SaveChanges();
        //    }
        //}

        //public GameItem GetGamebyId(string id)
        //{
        //    var game = db.GameItem.Find(id);
        //    //if (game != null)
        //    return game;
        //}

        //public IList<GameItem> GetListAllGame()
        //{
        //    return db.GameItem.ToList();
        //}


        //public void SaveGameOnDb(GameItem gameItem)
        //{
        //    db.GameItem.Add(gameItem);
        //    db.SaveChanges();
        //}
    }
}
