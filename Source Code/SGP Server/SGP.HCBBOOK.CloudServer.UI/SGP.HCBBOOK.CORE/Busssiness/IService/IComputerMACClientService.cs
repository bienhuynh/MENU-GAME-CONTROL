using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.IService
{
    public interface IComputerMACClientService
    {
        /// <summary>
        /// Cai dat ban quyen cho Client
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="licenceId"></param>
        /// <param name="mac"></param>
        void AppllyKeyForMAC(string userid, string licenceId, string mac);
        void DeleteKeyForMAC(string userid, string licenceId, string mac);
        void ChangeActiveLiveForKey(string userid, string licenceId, string mac);

        /// <summary>
        /// Lay tat ca danh sach may Client
        /// </summary>
        /// <returns></returns>
        IList<ComputerMACClientModel> GetAllListClient();
        Task<IList<ComputerMACClientModel>> GetAllListClientAync();
        /// <summary>
        /// Danh sach tat ca sub client trong csdl
        /// </summary>
        /// <returns></returns>
        IList<ComputerSubClientModel> GetAllListSubClient();
        Task<IList<ComputerSubClientModel>> GetAllLisSubClientAync();
        /// <summary>
        /// danh sach tat ca may subclient theo dia chi mac may client
        /// </summary>
        /// <returns></returns>
        IList<ComputerSubClientModel> GetAllListSubClient(string macClient);
        Task<IList<ComputerSubClientModel>> GetAllListSubClientAync(string macClient);
        /// <summary>
        /// Laay chi tiet may client theo dia chi mac
        /// </summary>
        /// <param name="mac"></param>
        /// <returns></returns>
        ComputerMACClientModel GetDetailClient(string mac);
        Task<ComputerMACClientModel> GetDetailClientAync(string mac);

        ComputerSubClientModel GetDetailSubClient(string macSubClient);
        Task<ComputerSubClientModel> GetDetailSubClientAync(string macSubClient);

        void AddMachineMasterClient(string userid, string MAC, string nameMachine, string ipaddress);
        
    }
}
