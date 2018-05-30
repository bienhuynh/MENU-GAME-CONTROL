using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Service
{
    public class ComputerMACClientService : IComputerMACClientService
    {
        private SGPCloudEntities db;
        public ComputerMACClientService()
        {
            db = new SGPCloudEntities();
        }

        public void AddMachineMasterClient(string userid, string MAC, string nameMachine, string ipaddress)
        {
            try
            {
                db.ComputerMasterClient.Add(new ComputerMasterClient
                {
                    MAC = MAC,
                    DateJoin = DateTime.Now,
                    IsDelete = false,
                    IsDisable = false,
                    NameComputer = nameMachine,
                    SystemOperator = "N/A",
                    UserId = userid,
                    IP = ipaddress
                });
                db.SaveChanges();
            }
            catch
            { }
        }

        public void AppllyKeyForMAC(string userid, string licenceId, string mac)
        {
            try
            {
                var userLicence = db.User_Licence.FirstOrDefault(m => m.Userid == userid && m.LicenceId == licenceId);
                if(userLicence!=null)
                {
                    userLicence.MACMasterId = mac;
                    db.SaveChanges();
                    var lience = db.Licence.Find(licenceId);
                    if (lience != null)
                    {
                        if (lience.MaxNumberDevices > lience.NumberDevicesLiveActive)
                        {
                            lience.NumberDevicesLiveActive++;
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch(Exception ex) { }
        }

        public void ChangeActiveLiveForKey(string userid, string licenceId, string mac)
        {
            var macLicence = db.User_Licence.FirstOrDefault(m => m.Userid == userid && m.LicenceId == licenceId && m.MACMasterId == mac);
            if (macLicence != null)
            {
                macLicence.IsLive = !macLicence.IsLive;
                db.SaveChanges();
            }
        }

        public void DeleteKeyForMAC(string userid, string licenceId, string mac)
        {
            try
            {
                var userLicence = db.User_Licence.FirstOrDefault(m => m.Userid == userid && m.LicenceId == licenceId && m.MACMasterId == mac);
                if (userLicence != null)
                {
                    userLicence.MACMasterId =null;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { }
        }

        public Task<IList<ComputerSubClientModel>> GetAllLisSubClientAync()
        {
            IList<ComputerSubClientModel> computerMACClientModels = new List<ComputerSubClientModel>();
            foreach(var item in db.ComputerSubClient)
            {
                computerMACClientModels.Add(SetData(item));
            }
            return Task.FromResult(computerMACClientModels);
        }

        public IList<ComputerMACClientModel> GetAllListClient()
        {
            IList<ComputerMACClientModel> computerMACClientModels = new List<ComputerMACClientModel>();
            foreach (var item in db.ComputerMasterClient)
            {
                computerMACClientModels.Add(SetData(item));
            }
            return (computerMACClientModels);
        }

        public Task<IList<ComputerMACClientModel>> GetAllListClientAync()
        {
            IList<ComputerMACClientModel> computerMACClientModels = new List<ComputerMACClientModel>();
            foreach (var item in db.ComputerMasterClient)
            {
                computerMACClientModels.Add(SetData(item));
            }
            return Task.FromResult(computerMACClientModels);
        }

        public IList<ComputerSubClientModel> GetAllListSubClient()
        {
            IList<ComputerSubClientModel> computerMACClientModels = new List<ComputerSubClientModel>();
            foreach (var item in db.ComputerSubClient)
            {
                computerMACClientModels.Add(SetData(item));
            }
            return (computerMACClientModels);
        }

        public IList<ComputerSubClientModel> GetAllListSubClient(string macClient)
        {
            IList<ComputerSubClientModel> computerMACClientModels = new List<ComputerSubClientModel>();
            foreach (var item in db.ComputerSubClient.Where(m=>m.MacIdMaster == macClient))
            {
                computerMACClientModels.Add(SetData(item));
            }
            return (computerMACClientModels);
        }

        public Task<IList<ComputerSubClientModel>> GetAllListSubClientAync(string macClient)
        {
            IList<ComputerSubClientModel> computerMACClientModels = new List<ComputerSubClientModel>();
            foreach (var item in db.ComputerSubClient.Where(m=>m.MacIdMaster == macClient))
            {
                computerMACClientModels.Add(SetData(item));
            }
            return Task.FromResult(computerMACClientModels);
        }

        public ComputerMACClientModel GetDetailClient(string mac)
        {
            var cpm = db.ComputerMasterClient.Find(mac);
            if(cpm!=null)
            {
                return SetData(cpm);
            }
            return null;
        }

        public async Task<ComputerMACClientModel> GetDetailClientAync(string mac)
        {
            var cpm = await db.ComputerMasterClient.FindAsync(mac);
            if (cpm != null)
            {
                return SetData(cpm);
            }
            return null;
        }

        public ComputerSubClientModel GetDetailSubClient(string macSubClient)
        {
            var cpm = db.ComputerSubClient.Find(macSubClient);
            if (cpm != null)
            {
                return SetData(cpm);
            }
            return null;
        }

        public async Task<ComputerSubClientModel> GetDetailSubClientAync(string macSubClient)
        {
            var cpm = await db.ComputerSubClient.FindAsync(macSubClient);
            if (cpm != null)
            {
                return SetData(cpm);
            }
            return null;
        }

        

        private ComputerSubClientModel SetData(ComputerSubClient model)
        {
            return new ComputerSubClientModel
            {
                DateJoin = model.DateJoin,
                IP = model.IP,
                IsDelete = model.IsDelete,
                IsDisable = model.IsDisable,
                MAC = model.MAC,
                NameComputer = model.NameComputer,
                MacIdMaster= model.MacIdMaster
            };
        }

        private ComputerMACClientModel SetData(ComputerMasterClient model)
        {
            IList<LicenceLive> licenceLives = new List<LicenceLive>();
            foreach(var item in model.User_Licence.Where(m=>m.MACMasterId == model.MAC))
            {
                var licence = db.Licence.Find(item.LicenceId);
                
                licenceLives.Add(new LicenceLive
                {
                    IsLive = item.IsLive,
                    IsActive = item.IsActive,
                    LicenceId = item.LicenceId,
                    LicenceKey = licence != null ? licence.LicenceKey : "N/A"
                });
            }
            return new ComputerMACClientModel
            {
                DateJoin = model.DateJoin,
                IP = model.IP,
                IsDelete = model.IsDelete,
                IsDisable = model.IsDisable,
                MAC = model.MAC,
                NameComputer = model.NameComputer,
                SystemOperator = model.NameComputer,
                UserId = model.UserId,
                licenceLives = licenceLives
            };
        }
    }
}
