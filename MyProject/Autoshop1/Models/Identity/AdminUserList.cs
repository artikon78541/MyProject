using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.ViewModels;
using Autoshop1.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Autoshop1.Models.DB;
using Microsoft.Extensions.DependencyInjection;

namespace Autoshop1.Models.Identity
{
    public class AdminUserList
    {
        private MainDBContext mdbContext;
        private ApplicationDbContext appContext;
        private UserManager<AppUser> userManager;

        public AdminUserList(MainDBContext ctx, ApplicationDbContext applicationDb, UserManager<AppUser> userMrg)
        {
            mdbContext = ctx;
            appContext = applicationDb;
            userManager = userMrg;
        }

        public List<AdminUserViewModel> SelectedUsers(string userLogin, DateTime fromDate, DateTime toDate)
        {

            List<AppUser> userlist = new List<AppUser>();

            if (userLogin == "" && fromDate == null && toDate == null)
            {
                userlist = (List<AppUser>)userManager.Users.ToList();
            }
            else if (userLogin.Length > 0 && fromDate == null && toDate == null)
            {
                userlist = (List<AppUser>)userManager.Users.Where(u => u.PhoneNumber.Contains(userLogin)).ToList();
                userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.NormalizedEmail.Contains(userLogin.ToUpper())).ToList());
                userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.UserFIO.ToLower().Contains(userLogin.ToLower())).ToList());
            }
            else if (userLogin.Length == 0)
            {
                if (fromDate == null) fromDate = new DateTime(2020, 6, 20, 0, 00, 00);
                if (toDate == null) toDate = DateTime.Now;
                var result = userManager.Users.Where(u => u.RegistrationDate.Date >= fromDate && u.RegistrationDate.Date <= toDate);
                userlist = result.Cast<AppUser>().ToList();
            }
            else if(userLogin.Length > 0)
            {
                userlist = (List<AppUser>)userManager.Users.Where(u => u.PhoneNumber.Contains(userLogin)).ToList();
                userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.NormalizedEmail.Contains(userLogin.ToUpper())).ToList());
                userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.UserFIO.ToLower().Contains(userLogin.ToLower())).ToList());

                if (fromDate == null) fromDate = new DateTime(2020, 6, 20, 0, 00, 00);
                if (toDate == null) toDate = DateTime.Now;

                userlist = (List<AppUser>)userlist.Where(u => u.RegistrationDate.Date >= fromDate && u.RegistrationDate.Date <= toDate).ToList();
            }

            List<AdminUserViewModel> auvwList = new List<AdminUserViewModel>();
            int i = 0;
            foreach (AppUser user in userlist) {

                List<string> rolesStr = new List<string>();
                var roles = appContext.UserRoles.Where(u => u.UserId == user.Id).Select(u=>u.RoleId);
                foreach (string role in roles)
                {
                    var r = appContext.Roles.Find(role).Name;
                    rolesStr.Add(r.ToString());
                }

                string roleString = string.Join(",", rolesStr.ToList());
                int mbdNum;
                try
                {
                    mbdNum = mdbContext.Customers.Where(c => c.CustomerId == user.Id).SingleOrDefault().CustomerNumber;
                }
                catch(Exception e)
                {
                    mbdNum = 0;
                }

                

                AdminUserViewModel auvw = new AdminUserViewModel
                {
                    Num = ++i,
                    Id = user.Id,
                    Email = user.Email,
                    UserFIO = user.UserFIO,
                    PhoneNumber = user.PhoneNumber,
                    RegistrationDate = user.RegistrationDate,
                    MdbNumber = mbdNum,
                    Roles = roleString

                };
                auvwList.Add(auvw);
            }

            return auvwList;
        }


    }
}
