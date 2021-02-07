using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Autoshop1.Models.DB;
using Autoshop1.Models.Identity;
using Autoshop1.Models.MainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Autoshop1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        private readonly MainDBContext mdbContext;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, MainDBContext ctx)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            mdbContext = ctx;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { UserFIO=model.Name, UserName = model.Email, Email = model.Email, PhoneNumber = model.Phone, RegistrationDate = DateTime.Now};


                var result = await userManager.CreateAsync(user, model.Password);
 
                if (result.Succeeded)
                {

                    await userManager.AddToRoleAsync(user, "User");
                    await signInManager.SignInAsync(user, isPersistent: false);

                    Customer customer = new Customer
                    {
                        CustomerId = user.Id,
                        Name = model.Name,
                        Phone = model.Phone,
                        Email = model.Email,

                    };
                    mdbContext.Customers.Add(customer);
                    mdbContext.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    
                }

                ModelState.AddModelError(string.Empty, "Пользователь не найден");

            }

            return View(model);
        }

    }
}
