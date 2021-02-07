using Autoshop1.Models.DB;
using Autoshop1.Models.Identity;
using Autoshop1.Models.Interfaces;
using Autoshop1.Models.MainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Autoshop1.Models.Repositories
{
    public class AdminOrderRepository : IAdminOrder
    {
        private ApplicationDbContext appDbContext;
        private MainDBContext mDbContext;
        private UserManager<AppUser> userManager;
        private Cart cart;

        public static AppUser appUser = new AppUser();
        public AppUser getAppUser()
        {
            return appUser;
        }

        public void setAppUser(AppUser appuser)
        {
            appUser = appuser;
        }



        public static List<SearchPart> SearchParts = new List<SearchPart>();

        public List<SearchPart> getlist()
        {
            return SearchParts;
        }
        public void FillList(List<SearchPart> list)
        {
            SearchParts.Clear();
            SearchParts.AddRange(list);
        }



        public AdminOrderRepository(ApplicationDbContext adb, MainDBContext mdb, UserManager<AppUser> usrM, Cart cart)
        {
            appDbContext = adb;
            mDbContext = mdb;
            userManager = usrM;
            this.cart = cart;
        }

        public AppUser GetUser(string str)
        {

            var user = userManager.Users.Where(u => u.Id == str).FirstOrDefault();
            return user;
        }


        public AppUser GetUserByEmail(string str)
        {
            var user = userManager.Users.Where(u => u.NormalizedUserName == str.ToUpper()).FirstOrDefault();
            return user;
        }

        public string GetUserEmail(AppUser appUser)
        {
            return appUser.UserName;
        }


        public string GetCurrentRole(string userId)
        {
            string roleId = appDbContext.UserRoles.Where(u => u.UserId == userId).FirstOrDefault().RoleId;
            string role = appDbContext.Roles.Find(roleId).Name;
            return role;
        }

        public List<AppUser> GetUsersList(string str)
        {

            List<AppUser> userlist = new List<AppUser>();

            userlist = (List<AppUser>)userManager.Users.Where(u => u.PhoneNumber.Contains(str)).ToList();
            userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.NormalizedEmail.Contains(str.ToUpper())).ToList());
            userlist.AddRange((List<AppUser>)userManager.Users.Where(u => u.UserFIO.ToLower().Contains(str.ToLower())).ToList());

            return userlist;
        }

        public int GetNumOfCartItems(string str)
        {
            string Id = userManager.Users.Where(u => u.UserName.ToUpper() == str.ToUpper()).FirstOrDefault().Id;
            //List<CartItem> cartItems = (List<CartItem>)mDbContext.CartItems.Where(u => u.CustomerId == Id);
            //int num = cartItems.Count();
            int num = mDbContext.CartItems.Where(u => u.CustomerId == Id).Count();

            return num;
        }

        public void AddToCartAdmin(int partId, int quant)
        {
            var userid = getAppUser();

            var selectedPart = getlist().Where(p=> p.PartId == partId).FirstOrDefault();

            cart.AddItemUserAuth(selectedPart, userid.Id, quant);


        }

    }
}
