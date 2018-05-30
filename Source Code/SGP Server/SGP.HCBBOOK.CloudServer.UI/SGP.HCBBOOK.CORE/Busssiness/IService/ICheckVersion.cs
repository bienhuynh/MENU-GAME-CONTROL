using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.IService
{
    public interface ICheckVersion
    {
        CheckVersionInfoModel CheckVersionSGPMGC();
        CheckVersionInfoModel CheckVersionSGPMG();
        IList<CheckVersionInfoModel> GetAllList();
        bool AddNewVersion(CheckVersionInfoModel checkVersionInfoModel);
        bool ModifiedInfoVersion(CheckVersionInfoModel checkVersionInfoModel);
        CheckVersionInfoModel GetDetail(int id);
    }
}
