using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Autoshop1.Models.DB;
using Autoshop1.Models.Interfaces;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.Repositories;
using Autoshop1.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Autoshop1.Controllers
{
    public class CartController : Controller
    {
        private readonly IParts repository;
        private readonly Cart cart;
        public CartController(IParts repo, Cart cart)
        {
            repository = repo;
            this.cart = cart;
        }


        public ViewResult Index()
        {

            //var items = cart.GetCartItems();
            //cart.CartItems = items;

            //var cVM = new CartViewModel
            //{
            //    Cart = cart,
            //    CartTotal = cart.GetCartTotal()
            //};
            //return View(cVM);
            decimal cartTotal=0;

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.Identity.IsAuthenticated)
            {
                cart.CartItems = cart.GetCartItems();
                cartTotal = Math.Round(cart.GetCartTotal());
            }
            else 
            { 
                cart.CartItems = cart.GetCartItemsUserAuth(userid);
                cartTotal = Math.Round(cart.GetCartTotalUserAuth(userid));
            }

            var cVM = new CartViewModel
            {
                Cart = cart,
                CartTotal = cartTotal
            };
            return View(cVM);
        }

        public RedirectToActionResult AddToCart(int partId)
        {
            //var selectedPart = repository.selectedItem(partId);
            //if (selectedPart != null)
            //{
            //    cart.AddItem(selectedPart, 1);
            //}
            //return RedirectToAction("Index");
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var selectedPart = repository.selectedItem(partId);
            if (selectedPart != null)
            {
                if (!User.Identity.IsAuthenticated)
                {
                    cart.AddItem(selectedPart, 1);
                }
                else cart.AddItemUserAuth(selectedPart, userid, 1);
            }
            return RedirectToAction("Index");

        }

        public RedirectToActionResult RemoveFromCart(int partId)
        {
            //var selectedPart = repository.Partslist().FirstOrDefault(p => p.CartItemID == partId);
            //if (selectedPart != null)
            //{
            //    cart.RemoveFromCart(selectedPart);
            //}
            //return RedirectToAction("Index");

            //var selectedPart = repository.selectedCartItem(partId);
            //if (selectedPart != null)
            //{
                cart.RemoveFromCart(partId);
            //}
            return RedirectToAction("Index");

        }

        public RedirectToActionResult MakeOrder()
        {
            var cartItems = cart.GetCartItemsUserAuth(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            cart.Order(userid, cartItems);

            return RedirectToAction("Index");

        }

        public ActionResult CartSummary()
        {
            

            ViewBag.Count = cart.nCartItems();
            return PartialView("_CartPartial");
        }



    }
}
