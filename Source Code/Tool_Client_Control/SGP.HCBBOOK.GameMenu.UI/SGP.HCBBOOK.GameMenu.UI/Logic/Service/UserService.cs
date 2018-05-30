using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Models;
using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
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
    public class UserService : IUserService
    {
        private ICallAPIService callAPIService;
        private IJsonService jsonService;
        private ILoginSessionService loginSessionService;
        private ILicenceService licenceService;
        //private MenuGameDBEntities db;
        private bool _isLoginSuccess;
        private string _email;
        public UserService(ICallAPIService _callAPIService)
        {
            this.callAPIService = _callAPIService;
            Init();
        }

        private void Init()
        {
           // db = new MenuGameDBEntities();
            jsonService = new JsonService();
            licenceService = new LicenceService(callAPIService);
            loginSessionService = new LoginSessionService(this.callAPIService);
            this._isLoginSuccess = false;
        }

        public bool ChangePassword(string newPassword)
        {
            try
            {
                var userSecurity = loginSessionService.GetDataLogin();
                if (userSecurity != null)
                {
                    userSecurity.Password = newPassword;
                    loginSessionService.UpdateDataLogin(userSecurity);
                }
                return true;
            }
            catch(Exception e) { }
            return false;
        }

        public string GetName()
        {
            var user = GetProfile();
            if (user != null)
            {
                return String.Format("{0} {1}", user.FirstName,user.LastName);
            }
            return null;
        }

        public UserProfileModel GetProfile()
        {
            var data = jsonService.ReadFile(Directory.GetCurrentDirectory(), DataFile.UserProfile);
            UserProfileModel userProfileModel = new JavaScriptSerializer().Deserialize<UserProfileModel>(data);
            return userProfileModel;
        }

        public string GetUserId()
        {
            var user = GetProfile();
            if(user!=null)
            {
                return user.UserId;
            }
            return null;
        }

        

        public bool UpdateAvarta()
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(UserProfileModel userProfileModel)
        {
            throw new NotImplementedException();
        }

        public bool IsLoginSuccess()
        {
            return this._isLoginSuccess;
        }

        public bool IsRememberLogin()
        {
            return loginSessionService.IsRememberLogin();
        }

        public Task<ResultBasic> LoginAync(LoginModel loginModel)
        {
            ResultBasic res = null;

            if (loginModel.IsLoginFirst)
            {
                res = licenceService.CheckLience(loginModel);
                this._isLoginSuccess = res.IsSuccess;
            }
            else
            {
                var session = loginSessionService.GetDataLogin();
                if (session == null)
                {
                    _isLoginSuccess = false;
                }
                else if (loginModel.Password == session.Password && loginModel.Email == session.Email)
                {
                   _isLoginSuccess = true;
                }
                res = new ResultBasic { IsSuccess = _isLoginSuccess, CodeError = -1, Message = this._isLoginSuccess ? "Đăng nhập thành công." : "Đăng nhập thất bại." };
            }

            if(this._isLoginSuccess)
            {
                loginSessionService.UpdateDataLogin(loginModel);//cap nhat thong tin dang nhap
                loginSessionService.WriteLoginSession(Setdata(loginModel));//ghi lichj su dang nhap
                this._email = loginModel.Email;
            }

            return Task.FromResult(res);
        }

        public ResultBasic Login(LoginModel loginModel)
        {
            ResultBasic res = null;

            if (loginModel.IsLoginFirst)
            {
                res = licenceService.CheckLience(loginModel);
                this._isLoginSuccess = res.IsSuccess;
            }
            else
            {
                var session = loginSessionService.GetDataLogin();
                if (session == null)
                {
                    _isLoginSuccess = false;
                }
                else if (loginModel.Password == session.Password && loginModel.Email == session.Email)
                {
                    _isLoginSuccess = true;
                }
                res = new ResultBasic { IsSuccess = _isLoginSuccess, CodeError = -1, Message = this._isLoginSuccess ? "Đăng nhập thành công." : "Đăng nhập thất bại." };
            }

            if (this._isLoginSuccess)
            {
                loginSessionService.UpdateDataLogin(loginModel);//cap nhat thong tin dang nhap
                loginSessionService.WriteLoginSession(Setdata(loginModel));//ghi lichj su dang nhap
                this._email = loginModel.Email;
            }
            return res;
        }
        private HistoryLoginSessionModel Setdata(LoginModel loginModel)
        {
            return new HistoryLoginSessionModel
            {
                Email = loginModel.Email,
                IsLoginFirst = loginModel.IsLoginFirst,
                KeyLience = loginModel.KeyLience,
                LoginTime = loginModel.LoginTime,
                Remember = loginModel.Remember,
                IPAddress = loginModel.IPAddress,
                IsLogin = true,
                MACAddress = loginModel.MACAddress,
                NameMachine = loginModel.NameMachine
            };
        }
        public void Logout()
        {
            LoginModel loginModel = loginSessionService.GetDataLogin();
            loginModel.Remember = false;
            loginSessionService.UpdateDataLogin(loginModel);
            loginSessionService.WriteLoginSession(new HistoryLoginSessionModel
            {
                Remember = false,
                Email = loginModel.Email,
                IsLoginFirst = loginModel.IsLoginFirst,
                KeyLience = loginModel.KeyLience,
                LoginTime = DateTime.Now,
                IsLogin = false
            });
        }

        public string GetEmail()
        {
            return this._email;
        }

        public ResultBasic Login(string password)
        {
            var user = loginSessionService.GetDataLogin();
            if(user!=null)
            {
                if(user.Email == _email && user.Password == password)
                {
                    return new ResultBasic { CodeError = 0, IsSuccess = true, Message = "Đăng nhập thành công." };
                }
            }
            return new ResultBasic { CodeError = -1, IsSuccess = false, Message = "Đăng nhập thất bại." };
        }

        public IList<HistoryLoginSessionModel> GetLoginHistory()
        {
            return loginSessionService.GetHistoryLoginSession();
        }
    }
}
