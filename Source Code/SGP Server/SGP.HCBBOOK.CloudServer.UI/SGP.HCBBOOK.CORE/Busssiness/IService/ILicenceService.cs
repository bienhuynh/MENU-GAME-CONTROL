using SGP.HCBBOOK.CORE.Busssiness.Models;
using SGP.HCBBOOK.CORE.Busssiness.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.IService
{
    public interface ILicenceService
    {
        /// <summary>
        /// Lay tat ca Licence trong database
        /// </summary>
        /// <returns></returns>
        IList<LicenceDetailModel> GetAllLicence();
        Task<IList<LicenceDetailModel>> GetAllLicenceAync();
        IList<LicenceDetailModel> GetAllLicence(string email);
        Task<IList<LicenceDetailModel>> GetAllLicenceAync(string email);
        LicenceDetailModel GetDetailLicence(string key);
        Task<LicenceDetailModel> GetDetailLicenceAync(string key);
        void AddLicence(LicenceDetailModel licenceDetailModel);
        Task AddLicenceAync(LicenceDetailModel licenceDetailModel);
        /// <summary>
        /// kiem tra ban quyen con active hay khong{0}-{1}-{2}-{3}-{4}
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        bool CheckLience(string Key);
        Task<bool> CheckLienceAync(string Key);
        /// <summary>
        /// Kiểm tra lience cua nguoi dung, nếu lience con active va con han su dung thi tra ve true
        /// </summary>
        /// <param name="username"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        bool CheckLience(string userid, string Key);
        Task<bool> CheckLienceAync(string userid, string Key);
        ResultBasic CheckLience(string userid, string Key, string MAC, string namemachine, string ipaddress);
        Task<ResultBasic> CheckLienceAync(string userid, string Key, string MAC, string namemachine, string ipaddress);
    }
}
