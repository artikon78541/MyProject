using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.Identity;
using Autoshop1.Models.Repositories;

namespace Autoshop1.Models.Interfaces
{
    public interface IAdminOrder
    {
        public AppUser GetUser(string str);
        public string GetUserEmail(AppUser appUser);
        public string GetCurrentRole(string userId);
        public List<AppUser> GetUsersList(string str);
        public AppUser GetUserByEmail(string str);
        public AppUser getAppUser();
        public void setAppUser(AppUser appuser);
        public List<SearchPart> getlist();
        public void FillList(List<SearchPart> list);
        public int GetNumOfCartItems(string str);
        public void AddToCartAdmin(int partId, int quant);

    }

}
