using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Result;
using SGP.HCBBOOK.GameMenu.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGP.HCBBOOK.GameMenu.UI.Logic.Service
{
    public class LicenceService : ILicenceService
    {
        private ICallAPIService callAPIService;
        private ILoginSessionService loginSessionService;

        public LicenceService(ICallAPIService _callAPIService)
        {
            this.callAPIService = _callAPIService;
            loginSessionService = new LoginSessionService(_callAPIService);
        }
        public bool CheckLience(string lienceKey)
        {
            var loginsesion = loginSessionService.GetDataLogin();
            if (loginsesion != null)
            {
                if (loginsesion.KeyLience == lienceKey)
                    return true;
            }
            return false;
        }

        public ResultBasic CheckLience(LoginModel loginModel)
        {
            ResultBasic resultBasic = new ResultBasic();
            string result = "";
            try
            {
                string url = "Account/ApiLogin";
                string data = new JavaScriptSerializer().Serialize(loginModel);
                result = callAPIService.POST(url, data);                
                resultBasic.IsSuccess = Boolean.Parse(result);
                resultBasic.Message = "Đăng nhập thành công.";
                resultBasic.CodeError = 0;
            }
            catch(Exception ex)
            {
                resultBasic.IsSuccess = false;
                resultBasic.Message = result;
                resultBasic.CodeError = -1;
            }
            return resultBasic;
        }
    }
}
