using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Setting;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    class LoginSessionService: ILoginSessionService
    {
        private ICallAPIService callAPIService;
        private IJsonService jsonService;
        private bool _isRememberLogin;

        public LoginSessionService(ICallAPIService _callAPIService)
        {
            this.callAPIService = _callAPIService;
            Init();
        }
        private void Init()
        {
            jsonService = new JsonService();
        }

        public bool IsRememberLogin()
        {
            var user = GetDataLogin();
            if (user != null)
                this._isRememberLogin = user.Remember;
            return this._isRememberLogin;
        }

        public bool WriteLoginSession(HistoryLoginSessionModel loginModel)
        {
            try
            {
                var historys = GetHistoryLoginSession();
                if(historys==null)
                {
                    historys = new List<HistoryLoginSessionModel>();
                }
                historys.Add(loginModel);
                historys = historys.OrderByDescending(m => m.LoginTime).ToList();
                string data = new JavaScriptSerializer().Serialize(historys);
                jsonService.SaveFile(Directory.GetCurrentDirectory(), DataFile.FilHistoryLoginSession, data);
                return true;
            }
            catch(Exception ex) { }
            return false;
        }

        

        public LoginModel GetLoginSession()
        {
            LoginModel loginModel = null;
            try
            {
                string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.UserLogin);
                loginModel = new JavaScriptSerializer().Deserialize<LoginModel>(data);
                loginModel.Password = EncodingForBase64.DecodeBase64(Encoding.Unicode, loginModel.Password);
            }
            catch { }
            return loginModel;
        }

        public void UpdateDataLogin(LoginModel loginModel)
        {
            try
            {
                loginModel.Password = EncodingForBase64.EncodeBase64(Encoding.Unicode, loginModel.Password);
                string data = new JavaScriptSerializer().Serialize(loginModel);
                jsonService.SaveFile(Directory.GetCurrentDirectory(), DataFile.UserLogin, data);
            }
            catch { }
        }

        public IList<HistoryLoginSessionModel> GetHistoryLoginSession()
        {
            IList<HistoryLoginSessionModel> historylogin = null;
            try
            {
                string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.FilHistoryLoginSession);
                historylogin = new JavaScriptSerializer().Deserialize<IList<HistoryLoginSessionModel>>(data);
                return historylogin.OrderByDescending(m => m.LoginTime).ToList();
            }
            catch(Exception ex) { }
            return null;
        }

        public LoginModel GetDataLogin()
        {
            LoginModel loginModel = null;
            try
            {
                string data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.UserLogin);
                loginModel = new JavaScriptSerializer().Deserialize<LoginModel>(data);
                loginModel.Password = EncodingForBase64.DecodeBase64(Encoding.Unicode, loginModel.Password);
            }
            catch { }
            return loginModel;
        }
    }
}
