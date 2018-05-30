using SGP.HCBBOOK.CORE.Busssiness.IService;
using SGP.HCBBOOK.CORE.Busssiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGP.HCBBOOK.CORE.Database;
namespace SGP.HCBBOOK.CORE.Busssiness.Service
{
    public class UserService : IUserService
    {
        private SGPCloudEntities db;
        public UserService()
        {
            db = new SGPCloudEntities();
        }

        public bool AddUserProfile(UserProfileModel userProfileModel)
        {
            if (userProfileModel == null)
                return false;
            db.UserProfile.Add(new UserProfile
            {
                Address = userProfileModel.Address,
                DateCreate = DateTime.Now,
                FirstName =userProfileModel.FirstName,
                IsDelete = false,
                IsDisable = false,
                LastName = userProfileModel.LastName,
                LogoUrl = userProfileModel.LogoUrl,
                NumberPhone =userProfileModel.NumberPhone,
                UserId = userProfileModel.UserId                
            });
            db.SaveChanges();

            return true;
        }

        public async Task<bool> AddUserProfileaAync(UserProfileModel userProfileModel)
        {
            if (userProfileModel == null)
                return false;
            db.UserProfile.Add(new UserProfile
            {
                Address = userProfileModel.Address,
                DateCreate = DateTime.Now,
                FirstName = userProfileModel.FirstName,
                IsDelete = false,
                IsDisable = false,
                LastName = userProfileModel.LastName,
                LogoUrl = userProfileModel.LogoUrl,
                NumberPhone = userProfileModel.NumberPhone,
                UserId = userProfileModel.UserId
            });

            await db.SaveChangesAsync();

            return true;
        }

        public bool CheckAdminSysRole(string userid)
        {
            var userRole = db.AspNetUserRoles.Where(m => m.UserId == userid);
            if(userRole.Count()>0)
            {
                foreach(var item in userRole)
                {
                    var role = db.AspNetRoles.Find(item.RoleId);
                    if(role !=null)
                    {
                        if (role.Name == RolesSys.Admin)
                            return true;
                    }
                }
            }
            return false;
        }

        public bool CheckRole(string userid, string roleName)
        {
            var userRole = db.AspNetUserRoles.Where(m => m.UserId == userid);
            if (userRole.Count() > 0)
            {
                foreach (var item in userRole)
                {
                    var role = db.AspNetRoles.Find(item.RoleId);
                    if (role != null)
                    {
                        if (role.Name == roleName)
                            return true;
                    }
                }
            }
            return false;
        }

        public bool CheckAdminSysRole(string email, string role)
        {
            var result = from r in db.AspNetRoles
                         join ur in db.AspNetUserRoles
                         on r.Id equals ur.RoleId
                         into roleus from p in roleus
                         join u in db.AspNetUsers
                         on p.UserId equals u.Id
                         where u.Email == email && r.Name == role
                         select new { r.Name, p.UserId, u.Email };
            if(result.Count()>0)
                return true;
            return false;
        }

        public async Task<bool> CheckAdminSysRoleAync(string userid)
        {
            var userRole = db.AspNetUserRoles.Where(m => m.UserId == userid);
            if (userRole.Count() > 0)
            {
                foreach (var item in userRole)
                {
                    var role = await db.AspNetRoles.FindAsync(item.RoleId);
                    if (role != null)
                    {
                        if (role.Name == RolesSys.Admin)
                            return true;
                    }
                }
            }
            return false;
        }

        public Task<bool> CheckAdminSysRoleAync(string email, string role)
        {
            var result = from r in db.AspNetRoles
                         join ur in db.AspNetUserRoles
                         on r.Id equals ur.RoleId
                         into roleus
                         from p in roleus
                         join u in db.AspNetUsers
                         on p.UserId equals u.Id
                         where u.Email == email && r.Name == role
                         select new { r.Name, p.UserId, u.Email };
            if (result.Count() > 0)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }
        

        public IList<UserProfileModel> GetAllUser()
        {
            IList<UserProfileModel> list = new List<UserProfileModel>();
            foreach (var item in db.AspNetUsers)
            {
                list.Add(GetProfile(item.Email));
            }
            return list;
        }

        public Task<IList<UserProfileModel>> GetAllUserAync()
        {
            IList<UserProfileModel> list = new List<UserProfileModel>();
            foreach (var item in db.AspNetUsers)
            {
                list.Add(GetProfile(item.Email));
            }
            return Task.FromResult(list);
        }

        public string GetNameByEmailId(string email)
        {
            string userId = GetUserId(email);
            return GetNameByUserId(userId);
        }

        public  async Task<string> GetNameByEmailIdAync(string email)
        {
            string userId = GetUserId(email);
            return await GetNameByUserIdAync(userId);
        }

        public string GetNameByUserId(string userId)
        {
            var user = db.UserProfile.Find(userId);
            if (user != null)
                return String.Format("{0} {1}", user.FirstName, user.LastName);
            return "N/A";
        }

        public async Task<string> GetNameByUserIdAync(string userId)
        {
            var user = await db.UserProfile.FindAsync(userId);
            if (user != null)
                return String.Format("{0} {1}", user.FirstName, user.LastName);
            return "N/A";
        }

        public string GetNameCompanyByEmail(string Email)
        {
            string userId = GetUserId(Email);
            return GetNameByUserId(userId);
        }

        public async Task<string> GetNameCompanyByEmailAync(string Email)
        {
            string userId = GetUserId(Email);
            return await GetNameCompanyByEmailAync(userId);
        }

        public string GetNameCompanyByUserId(string userid)
        {
            var user = db.UserProfile.Find(userid);
            if (user != null)
                return String.Format("{0}", user.NetName);
            return "N/A";
        }

        public async Task<string> GetNameCompanyByUserIdAync(string userid)
        {
            var user = await db.UserProfile.FindAsync(userid);
            if (user != null)
                return String.Format("{0}", user.NetName);
            return "N/A";
        }

        public UserProfileModel GetProfile(string email)
        {
            var user = db.AspNetUsers.FirstOrDefault(m=>m.Email == email);
            if(user!=null)
            {
                return SetDataProfile(user, db.UserProfile.Find(user.Id));
            }
            return null;
        }

        public Task<UserProfileModel> GetProfileAync(string email)
        {
            var user = db.AspNetUsers.FirstOrDefault(m => m.Email == email);
            if (user != null)
            {
                return Task.FromResult(SetDataProfile(user, db.UserProfile.Find(user.Id)));
            }
            return null;
        }

        public UserProfileModel GetProfileByUserId(string userid)
        {
            var user = db.AspNetUsers.FirstOrDefault(m => m.Id == userid);
            if (user != null)
            {
                return (SetDataProfile(user, db.UserProfile.Find(user.Id)));
            }
            return null;
        }

        public Task<UserProfileModel> GetProfileByUserIdAync(string userid)
        {
            var user = db.AspNetUsers.FirstOrDefault(m => m.Id == userid);
            if (user != null)
            {
                return Task.FromResult(SetDataProfile(user, db.UserProfile.Find(user.Id)));
            }
            return null;
        }

        public string GetUserId(string email)
        {
            var user = db.AspNetUsers.FirstOrDefault(m => m.Email == email);
            if(user !=null)
            {
                return user.Id;
            }
            return null;
        }

        public Task<string> GetUserIdAync(string email)
        {
            var user = db.AspNetUsers.FirstOrDefault(m => m.Email == email);
            if (user != null)
            {
                return Task.FromResult(user.Id);
            }
            return null;
        }

        public void UpdateLogo(string userid, string UrlLogo)
        {
            var user = db.UserProfile.Find(userid);
            if(user!=null)
            {
                user.LogoUrl = UrlLogo;
                db.SaveChanges();
            }
        }

        public async Task UpdateLogoAync(string userid, string UrlLogo)
        {
            var user = await db.UserProfile.FindAsync(userid);
            if (user != null)
            {
                user.LogoUrl = UrlLogo;
                db.SaveChanges();
            }
        }

        public void UpdateProfile(UserProfileModel userProfileModel)
        {
            var user = db.UserProfile.Find(userProfileModel.UserId);
            if(user!=null)
            {
                user.NumberPhone = userProfileModel.NumberPhone;
                user.Address = userProfileModel.Address;
                user.FirstName = userProfileModel.FirstName;
                user.LastName = userProfileModel.LastName;
                db.SaveChanges();
            }
        }

        public async Task UpdateProfileAync(UserProfileModel userProfileModel)
        {
            var user = await db.UserProfile.FindAsync(userProfileModel.UserId);
            if (user != null)
            {
                user.NumberPhone = userProfileModel.NumberPhone;
                user.Address = userProfileModel.Address;
                user.FirstName = userProfileModel.FirstName;
                user.LastName = userProfileModel.LastName;
                db.SaveChanges();
            }
        }

        public bool WriteLoginSession(LoginModel loginModel)
        {
            try
            {
                db.HistoryLoginSession.Add(new HistoryLoginSession
                {
                    IPAddress = loginModel.IPAddress,
                    TimeStartLogin = loginModel.LoginTime,
                    UserId=GetUserId(loginModel.Email)
                });
                db.SaveChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }

        public Task<bool> WriteLoginSessionAync(LoginModel loginModel)
        {
            try
            {
                db.HistoryLoginSession.Add(new HistoryLoginSession
                {
                    IPAddress = loginModel.IPAddress,
                    TimeStartLogin = loginModel.LoginTime,
                    UserId = GetUserId(loginModel.Email),
                    NameMachine = loginModel.NameMachine,
                    MacAddress = loginModel.MACAddress
                });
                db.SaveChanges();
                return Task.FromResult(true);
            }
            catch
            {

            }
            return Task.FromResult(false);
        }

        private UserProfileModel SetDataProfile(AspNetUsers user, UserProfile userProfile)
        {
            return new UserProfileModel
            {
                Email = user.Email,
                UserId = user.Id,
                Address = userProfile.Address,
                DateCreate = userProfile.DateCreate,
                FirstName = userProfile.FirstName,
                IsDelete = userProfile.IsDelete,
                IsDisable = userProfile.IsDisable,
                LastName = userProfile.LastName,
                LogoUrl = userProfile.LogoUrl,
                NumberPhone = userProfile.NumberPhone                
            };
        }
    }
}
