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
    public class CheckVersion : ICheckVersion
    {
        private SGPCloudEntities db;
        public CheckVersion()
        {
            db = new SGPCloudEntities();
        }

        private VersionHistory SetData(CheckVersionInfoModel checkVersionInfoModel)
        {
            VersionHistory version = new VersionHistory();
            version.InstallerArgs = checkVersionInfoModel.InstallerArgs;
            version.IsUpdateAvailable = checkVersionInfoModel.IsUpdateAvailable;
            version.Mandatory = checkVersionInfoModel.Mandatory;
            version.SoftName = checkVersionInfoModel.Softname;
            version.Version = checkVersionInfoModel.Version;
            version.HashingAlgorithm = checkVersionInfoModel.HashingAlgorithm;
            version.ChangeLog = SecurityService.Base64Encode(checkVersionInfoModel.ChangeLogs);
            version.Checksum = checkVersionInfoModel.Checksum;
            version.DateChange = checkVersionInfoModel.DateChange;
            return version;
        }

        private CheckVersionInfoModel SetData(VersionHistory checkVersionInfoModel)
        {
            CheckVersionInfoModel version = new CheckVersionInfoModel();
            version.InstallerArgs = checkVersionInfoModel.InstallerArgs;
            version.IsUpdateAvailable = (bool)checkVersionInfoModel.IsUpdateAvailable;
            version.Mandatory = (bool)checkVersionInfoModel.Mandatory;
            version.Softname = checkVersionInfoModel.SoftName;
            version.Version = checkVersionInfoModel.Version;
            version.HashingAlgorithm = checkVersionInfoModel.HashingAlgorithm;
            version.ChangeLogs = SecurityService.Base64Decode(checkVersionInfoModel.ChangeLog);
            version.Checksum = checkVersionInfoModel.Checksum;
            version.ID = checkVersionInfoModel.Id;
            version.DateChange = checkVersionInfoModel.DateChange;
            version.CurrentVersion = new Version(checkVersionInfoModel.Version);
            return version;
        }

        public bool AddNewVersion(CheckVersionInfoModel checkVersionInfoModel)
        {
            try
            {
                foreach(var item in db.VersionHistory.Where(m=>m.SoftName == checkVersionInfoModel.Softname))
                {
                    item.IsUpdateAvailable = false;
                }
                db.SaveChanges();
                db.VersionHistory.Add(SetData(checkVersionInfoModel));
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public CheckVersionInfoModel CheckVersionSGPMG()
        {
            var version = db.VersionHistory.FirstOrDefault(m => m.IsUpdateAvailable == true && m.SoftName == Softname.SGPMG);
            if (version != null)
            {
                return SetData(version);
            }
            return null;
        }

        public CheckVersionInfoModel CheckVersionSGPMGC()
        {
            var version = db.VersionHistory.FirstOrDefault(m=>m.IsUpdateAvailable == true && m.SoftName == Softname.SGPMGC);
            if (version != null)
            {
                return SetData(version);
            }
            return null;
        }

        public IList<CheckVersionInfoModel> GetAllList()
        {
            IList<CheckVersionInfoModel> List = new List<CheckVersionInfoModel>();
            foreach(var item in db.VersionHistory.OrderByDescending(m=>m.Version))
            {
                List.Add(SetData(item));
            }
            return List;
        }

        public CheckVersionInfoModel GetDetail(int id)
        {
            var version = db.VersionHistory.Find(id);
            if(version!=null)
            {
                return SetData(version);
            }
            return null;
        }

        public bool ModifiedInfoVersion(CheckVersionInfoModel checkVersionInfoModel)
        {
            try
            {
                var version = db.VersionHistory.Find(checkVersionInfoModel.ID);
                version.InstallerArgs = checkVersionInfoModel.InstallerArgs;
                version.IsUpdateAvailable = checkVersionInfoModel.IsUpdateAvailable;
                version.Mandatory = checkVersionInfoModel.Mandatory;
                version.SoftName = checkVersionInfoModel.Softname;
                version.Version = checkVersionInfoModel.Version;
                version.HashingAlgorithm = checkVersionInfoModel.HashingAlgorithm;
                version.ChangeLog = SecurityService.Base64Encode(checkVersionInfoModel.ChangeLogs);
                version.Checksum = checkVersionInfoModel.Checksum;
                version.DateChange = checkVersionInfoModel.DateChange;
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
    }
}
