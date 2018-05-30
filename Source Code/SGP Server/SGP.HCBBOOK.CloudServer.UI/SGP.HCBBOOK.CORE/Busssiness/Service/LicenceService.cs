using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Result;
using SGP.HCBBOOK.CORE.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Service
{
    public class LicenceService : ILicenceService
    {
        private IUserService userService;
        private IComputerMACClientService computerMACClientService;
        private SGPCloudEntities db;
        public LicenceService()
        {
            db = new SGPCloudEntities();
            userService = new UserService();
            computerMACClientService = new ComputerMACClientService();
        }
        public bool CheckLience(string Key)
        {
            try
            {
                var lience = db.Licence.FirstOrDefault(m => m.LicenceKey == Key && m.IsActive == true);
                if (lience != null)
                {
                    if (lience.MaxNumberDevices > lience.NumberDevicesLiveActive)
                    {
                        //lience.NumberDevicesLiveActive++;
                        //db.SaveChanges();
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        public Task<bool> CheckLienceAync(string Key)
        {
            try
            {
                var lience = db.Licence.FirstOrDefault(m => m.LicenceKey == Key && m.IsActive == true);
                if (lience != null)
                {
                    if (lience.MaxNumberDevices > lience.NumberDevicesLiveActive)
                    {
                        //lience.NumberDevicesLiveActive++;
                        //db.SaveChanges();
                        return Task.FromResult(true);
                    }
                }
            }
            catch { }
            return Task.FromResult(false);
        }

        private LicenceDetailModel SetData(Licence licence, User_Licence user_Licence)
        {
            var result = new LicenceDetailModel();
            if(user_Licence!=null)
            {
                result.DateEnd = user_Licence.DateEnd;
                result.Userid = user_Licence.Userid;
                result.DateStart = user_Licence.DateStart;
            }
            if(licence!=null)
            {
                result.LicenceId = licence.Id;     
                result.DateCreate = licence.DateCreate;             
                result.IsActive = licence.IsActive;
                result.LicenceKey = licence.LicenceKey;
                result.MaxNumberDevices = licence.MaxNumberDevices;
                result.NumberDevicesLiveActive = licence.NumberDevicesLiveActive;
                result.Price = licence.Price;          
                result.UserIdCreate = licence.UserIdCreate;
            }
            return result;
        }

        public IList<LicenceDetailModel> GetAllLicence()
        {
            var licences = db.Licence;
            IList<LicenceDetailModel> list = new List<LicenceDetailModel>();
            
            foreach(var item in licences)
            {
                list.Add(SetData(item, db.User_Licence.Where(m => m.LicenceId == item.Id).OrderByDescending(m => m.DateEnd).FirstOrDefault()));
            }
            return list;
        }

        public IList<LicenceDetailModel> GetAllLicence(string email)
        {
            string userid = userService.GetUserId(email);
            IList<LicenceDetailModel> licenceDetailModels = new List<LicenceDetailModel>();
            foreach(var item in db.User_Licence.Where(m=>m.Userid == userid))
            {
                var licence = db.Licence.Find(item.LicenceId);
                licenceDetailModels.Add(SetData(licence, item));
            }
            return licenceDetailModels;
        }

        public Task<IList<LicenceDetailModel>> GetAllLicenceAync()
        {
            IList<LicenceDetailModel> licenceDetailModels = new List<LicenceDetailModel>();
            foreach (var item in db.Licence)
            {
                licenceDetailModels.Add(SetData(item, null));
            }
            return Task.FromResult(licenceDetailModels);
        }

        public Task<IList<LicenceDetailModel>> GetAllLicenceAync(string email)
        {
            string userid = userService.GetUserId(email);
            IList<LicenceDetailModel> licenceDetailModels = new List<LicenceDetailModel>();
            foreach (var item in db.User_Licence.Where(m => m.Userid == userid))
            {
                var licence = db.Licence.Find(item.LicenceId);
                licenceDetailModels.Add(SetData(licence, item));
            }
            return Task.FromResult(licenceDetailModels);
        }

        public void AddLicence(LicenceDetailModel licenceDetailModel)
        {
            db.Licence.Add(new Licence
            {
                DateCreate = licenceDetailModel.DateCreate,
                Id = licenceDetailModel.LicenceId,
                IsActive = licenceDetailModel.IsActive,
                LicenceKey = licenceDetailModel.LicenceKey,
                MaxNumberDevices = licenceDetailModel.MaxNumberDevices,
                NumberDevicesLiveActive = licenceDetailModel.NumberDevicesLiveActive,
                Price = licenceDetailModel.Price,
                UserIdCreate = licenceDetailModel.UserIdCreate
            });
            db.SaveChanges();
        }

        public async Task AddLicenceAync(LicenceDetailModel licenceDetailModel)
        {
            db.Licence.Add(new Licence
            {
                DateCreate = licenceDetailModel.DateCreate,
                Id = licenceDetailModel.LicenceId,
                IsActive = licenceDetailModel.IsActive,
                LicenceKey = licenceDetailModel.LicenceKey,
                MaxNumberDevices = licenceDetailModel.MaxNumberDevices,
                NumberDevicesLiveActive = licenceDetailModel.NumberDevicesLiveActive,
                Price = licenceDetailModel.Price,
                UserIdCreate = licenceDetailModel.UserIdCreate
            });
            await db.SaveChangesAsync();
        }

        public bool CheckLience(string userid, string Key)
        {
            var userlicence = db.User_Licence.FirstOrDefault(m => m.Userid == userid && m.Licence.LicenceKey == Key && m.IsActive == true && m.DateEnd > DateTime.Now);
            if(userlicence!=null)
            {
                return true;
            }
            return false;
        }

        public Task<bool> CheckLienceAync(string userid, string Key)
        {
            var userlicence = db.User_Licence.FirstOrDefault(m => m.Userid == userid && m.Licence.LicenceKey == Key && m.IsActive == true && m.DateEnd > DateTime.Now);
            if (userlicence != null)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public ResultBasic CheckLience(string userid, string Key, string MAC, string nameMachine, string ipaddress)
        {
            if (CheckLience(userid, Key))
            {
                var computerWithMAC = db.ComputerMasterClient.Find(MAC);

                if(computerWithMAC==null)
                {
                    if(MAC!=null)
                    {
                        if(MAC.Length>0)
                        {
                            computerMACClientService.AddMachineMasterClient(userid, MAC, nameMachine, ipaddress);
                        }
                    }
                }

                var licence = GetDetailLicence(Key);
                var result = db.User_Licence.FirstOrDefault(m => m.MACMasterId == MAC && m.Userid == userid && m.LicenceId == licence.LicenceId);
                if(result!=null)
                {
                    if(result.IsLive==true)//khong dc kich hoat cho may nay
                    {
                        return new ResultBasic
                        {
                            CodeError = 0,
                            IsSuccess = true,
                            Message = "Licence khả dụng."
                        };
                    }
                }

                computerMACClientService.AppllyKeyForMAC(userid, licence.LicenceId, MAC);

                return new ResultBasic
                {
                    CodeError = 1,
                    IsSuccess = false,
                    Message = "Máy này vừa kích hoạt bản quyền trên hệ thống."
                };
            }
            return new ResultBasic
            {
                CodeError = -2,
                IsSuccess = false,
                Message = "Sai Bản quyền."
            };
        }

        public async Task<ResultBasic> CheckLienceAync(string userid, string Key, string MAC, string namemachine, string ipaddress)
        {
            if (CheckLience(userid, Key))
            {
                var computerWithMAC = await db.ComputerMasterClient.FindAsync(MAC);

                if (computerWithMAC == null)
                {
                    return new ResultBasic
                    {
                        CodeError = -1,
                        IsSuccess = false,
                        Message = "Máy này chưa đăng kí trên hệ thống."
                    };
                }

                var licence = GetDetailLicence(Key);
                var result = db.User_Licence.FirstOrDefault(m => m.MACMasterId == MAC && m.Userid == userid && m.LicenceId == licence.LicenceId);
                if (result != null)
                {
                    if (result.IsLive == true)//khong dc kich hoat cho may nay
                    {
                        return new ResultBasic
                        {
                            CodeError = 0,
                            IsSuccess = true,
                            Message = "Licence khả dụng."
                        };
                    }
                }

                computerMACClientService.AppllyKeyForMAC(userid, licence.LicenceId, MAC);
                return new ResultBasic
                {
                    CodeError = 1,
                    IsSuccess = true,
                    Message = "Máy này vừa kích hoạt bản quyền trên hệ thống."
                };
            }
            return new ResultBasic
            {
                CodeError = -2,
                IsSuccess = false,
                Message = "Sai thông tin đăng nhập."
            };
        }

        public LicenceDetailModel GetDetailLicence(string key)
        {
            LicenceDetailModel licenceDetail = null;
            var licence = db.Licence.FirstOrDefault(m => m.LicenceKey == key);
            if(licence != null)
            {
                licenceDetail = SetData(licence, null);
            }
            return licenceDetail;
        }

        public Task<LicenceDetailModel> GetDetailLicenceAync(string key)
        {
            LicenceDetailModel licenceDetail = null;
            var licence = db.Licence.FirstOrDefault(m => m.LicenceKey == key);
            if (licence != null)
            {
                licenceDetail = SetData(licence, null);
            }
            return Task.FromResult(licenceDetail);
        }
    }
}
