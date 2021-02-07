using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Autoshop1.Models.DB;
using Autoshop1.Models.Identity;
using Autoshop1.Models.Interfaces;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.Repositories;
using Autoshop1.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Autoshop1.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly IParts _parts;
        private readonly IAdminOrder adorders;
        //ShopUserPartModel supm = new ShopUserPartModel();





        public AdminPanelController(IAdminOrder io, IParts ip)
        {

            adorders = io;
            _parts = ip;
  

        }

        
        public IActionResult Index()
        {

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                ViewBag.managerName = adorders.GetUserEmail(adorders.GetUser(userId));
                ViewBag.managerRole = adorders.GetCurrentRole(userId);
            }



            //return View("Index", adorders.GetUser(userId));
            return View("Index");
        }

        //public IActionResult Search(string searchline)
        //{
        //    //List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);
        //    //PartRepository partRepository = new PartRepository();
        //    //partRepository.FillList((List<SearchPart>)parts);

        //    ////ShopUserPartModel supm = new ShopUserPartModel();
        //    ////List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);
        //    ////shopUserPartModel.SearchParts = (IEnumerable<SearchPart>)parts;


        //    ////return View(shopUserPartModel);

        //    ////List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);
        //    //supm.SearchParts = parts;

        //    //return View(supm);

        //    List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);
        //    adorders.FillList(parts);
        //    supm.SearchParts = parts;

        //    return View(supm);
        //}

        //public PartialViewResult RenderUser()
        //{
        //    //if (supm.appUser == null)
        //    //{
        //    //    supm.appUser = adorders.GetUser(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //    //}

        //    //return PartialView(supm);

        //    AppUser appUser = new AppUser();
        //    if (adorders.getAppUser() == null)
        //    {
        //        appUser = adorders.GetUser(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //    }


        //    var modelCollection = new ModelCollection();
        //    modelCollection.AddModel(appUser);

        //    return PartialView("RenderUser", modelCollection);

        //}



        [HttpPost]
        public JsonResult GetUsers(string searchUser)
        {

            var userlist = adorders.GetUsersList(searchUser);

            List<string> result = new List<string>();
            foreach (AppUser user in userlist)
            {
                string res = user.UserName + " (ФИО: " + user.UserFIO + ", Телефон: " + user.PhoneNumber + ")";
                result.Add(res);
            }

            return Json(result);

        }


        public JsonResult SelectUser(string searchUser)
        {
            //string str = searchUser.Substring(0, searchUser.IndexOf(' '));
            string str;
            if (searchUser is null)
            {
                return Json(null);
            }

            if (searchUser.IndexOf(' ') >= 0)
            {
                str = searchUser.Substring(0, searchUser.IndexOf(' '));
            }
            else
                str = searchUser;


            AppUser au = adorders.GetUserByEmail(str);
            adorders.setAppUser(au);

            int NumOfCartItems = adorders.GetNumOfCartItems(au.NormalizedEmail);

            var dict = new Dictionary<string, int>();
            dict.Add("CartItems", NumOfCartItems);

            var jsonStr = JsonConvert.SerializeObject(au);
            var js = JsonConvert.SerializeObject(dict);


            var arrayOfObjects = JsonConvert.SerializeObject(
               new[] { JsonConvert.DeserializeObject(jsonStr), JsonConvert.DeserializeObject(js) });

            return Json(arrayOfObjects);

        }


        public IActionResult Search(string searchline)
        {

            List<SearchPart> parts = (List<SearchPart>)_parts.Partslistsearch(searchline);
            adorders.FillList(parts);


            var tr = new List<SearchPart>(parts);
            //tr = parts;
            var modelCollection = new ModelCollection();
            modelCollection.AddModel(tr);

            return PartialView("Search", modelCollection);
        }

       
        public void ToCartTest(SendingData sendingData)
        {
            int partId = sendingData.partId;
            int quantity = sendingData.quant;
            string st = sendingData.str;

            adorders.AddToCartAdmin(partId, quantity);



        }





    }
}
