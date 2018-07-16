using SG.SubClient.GameMenu.UI.LogicFeature.IService;
using SG.SubClient.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SG.SubClient.GameMenu.UI.LogicFeature.Service
{
    public class GameMenuService: IGameMenuService
    {
        private ITcpClientConnection tcpClientConnection;
        public GameMenuService(ITcpClientConnection _tcpClientConnection)
        {
            this.tcpClientConnection = _tcpClientConnection;
        }

        public ResultBasic CloseGame(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public Task<ResultBasic> CloseGameAync(GameItem gameItem)
        {
            throw new NotImplementedException();
        }

        public IList<GameItem> GetListAllGame()
        {
            string data = tcpClientConnection.Result();
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var res = js.Deserialize<List<GameItem>>(data);
                tcpClientConnection.ResetResult();
                return res;
            }
            catch (Exception e)
            {

            }
            tcpClientConnection.ResetResult();
            return null;
        }

        public Task<IList<GameItem>> GetListAllGameAync()
        {
            string data = tcpClientConnection.Result();
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                IList<GameItem> res = js.Deserialize<List<GameItem>>(data);
                tcpClientConnection.ResetResult();
                return Task.FromResult(res);
            }
            catch (Exception e)
            {

            }
            tcpClientConnection.ResetResult();
            return null;
        }

        public IList<GameItem> GetListGameHot()
        {
            return new  List<GameItem>();
        }

        public Task<IList<GameItem>> GetListGameHotAync()
        {
            throw new NotImplementedException();
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
    }
}
