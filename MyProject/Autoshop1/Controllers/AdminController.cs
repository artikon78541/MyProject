using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Autoshop1.Models.ViewModels;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.DB;
using OfficeOpenXml;
using System.IO;
using Autoshop1.Models.XLSForms;

namespace Autoshop1.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        private MainDBContext mainDBContext;
        private ApplicationDbContext applicationDbContext;

        //public string searchUser;
        //public DateTime dateFrom;
        //public DateTime dateTo;


        public ViewResult Index() => View(userManager.Users);
        public ViewResult Create() => View();



        //For Edit function
        private IUserValidator<AppUser> userValidator;
        private IPasswordValidator<AppUser> passwordValidator;
        private IPasswordHasher<AppUser> passwordHasher;

        public AdminController(UserManager<AppUser> usrMgr, IUserValidator<AppUser> userValid, IPasswordValidator<AppUser> passValid, IPasswordHasher<AppUser> passwordНash, MainDBContext mdb, ApplicationDbContext adb)
        {
            userManager = usrMgr;
            userValidator = userValid;
            passwordValidator = passValid;
            passwordHasher = passwordНash;

            mainDBContext = mdb;
            applicationDbContext = adb;


        }

        public async Task<IActionResult> Edit(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
           
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string password)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.Email = email;
                IdentityResult validEmail = await userValidator.ValidateAsync(userManager, user);
                if (!validEmail.Succeeded)
                {
                    AddErrorsFromResult(validEmail);
                }
                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, password);
                    if (validPass.Succeeded)
                    {
                        user.PasswordHash = passwordHasher.HashPassword(user, password);
                    }
                    else
                    {
                        AddErrorsFromResult(validPass);
                    }
                }
                if ((validEmail.Succeeded && validPass == null) || (validEmail.Succeeded && password != string.Empty && validPass.Succeeded))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        AddErrorsFromResult(result);
                    }
                }



            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View(user);
        }

        //


        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {

                    UserName = model.Email,
                    Email = model.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", userManager.Users);
        }


        public ViewResult Clients()
        {
            return View();
        }

        public ViewResult ClientsList(string search, DateTime DateFrom, DateTime DateTo)
        {
            var date = new DateTime(2000, 1, 1, 0, 00, 00);
            if (search is null) search = "";
            if (DateFrom < date) DateFrom = new DateTime(2020, 6, 20, 0, 00, 00);
            if (DateTo < date ) DateTo = DateTime.Now;

            ViewBag.search = search + ";" + DateFrom.ToString() + ";" + DateTo.ToString();

            AdminUserList aulist = new AdminUserList(mainDBContext, applicationDbContext, userManager);
            var selUsers = aulist.SelectedUsers(search, DateFrom, DateTo);
            return View(selUsers);
        }


        public IActionResult ClientsToExcel(string searchToLoad)
        {
            string[] searchArray = searchToLoad.Split(new char[] { ';' });
            string searchUser = searchArray[0];
            DateTime dateFrom = Convert.ToDateTime(searchArray[1]);
            DateTime dateTo = Convert.ToDateTime(searchArray[2]);

            AdminUserList aulist = new AdminUserList(mainDBContext, applicationDbContext, userManager);
            var selUsers = aulist.SelectedUsers(searchUser, dateFrom, dateTo);

            Reports rep = new Reports();
            var stream = rep.ClientsReport(selUsers);
            string excelname = $"Clients-{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelname);

        }








        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

    }
}
