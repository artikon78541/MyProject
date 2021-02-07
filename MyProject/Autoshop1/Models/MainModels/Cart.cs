using Autoshop1.Models.DB;
using Autoshop1.Models.Identity;
using Autoshop1.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace Autoshop1.Models.MainModels
{
    public class Cart
    {
        private readonly MainDBContext mdbContext;

        private Cart(MainDBContext ctx)
        {
            mdbContext = ctx;

        }
        public string CartId { get; set; }

        public List<CartItem> CartItems { get; set; }
        
        public int nCartItems()
        {
            if (!CartItems.Any())
            {
                return 0;
            }
            else return CartItems.Count();
        }


        public void AddItem(SearchPart part, int quantity = 1)
        {

            CartItem cartItem = new CartItem {
                CustomerId = "Anon",
                CartId = CartId,
                CartVendorId = part.VendorId,
                CartBrand = part.Brand,
                CartPartNumber = part.PartNumber,
                CartPartName = part.PartName,
                CartBuyingPrice = part.SellingPrice,
                CartSellingPrice = part.SellingPrice,
                CartQuantity = quantity,
                DeliveryDate = part.DeliveryDate,
                CartDate = DateTime.Now,
                            
            };
            if (cartItem != null)
            {
                mdbContext.CartItems.Add(cartItem);
            }

            mdbContext.SaveChanges();
        }

        public void AddItemUserAuth(SearchPart part, string ui, int quantity = 1)
        {

            CartItem cartItem = new CartItem
            {
                CustomerId = ui,
                CartId = CartId,
                CartVendorId = part.VendorId,
                CartBrand = part.Brand,
                CartPartNumber = part.PartNumber,
                CartPartName = part.PartName,
                CartBuyingPrice = part.BuyingPrice,
                CartSellingPrice = part.SellingPrice,
                CartQuantity = quantity,
                DeliveryDate = part.DeliveryDate,
                CartDate = DateTime.Now,

            };
            if (cartItem != null)
            {
                mdbContext.CartItems.Add(cartItem);
            }

            mdbContext.SaveChanges();
        }

        public int RemoveFromCart(int partid)
        {
            //var cartItem = mdbContext.CartItems
            //    .Where(p => p.CartItemID == cItem.CartItemID)
            //    .FirstOrDefault();
            CartItem cartItem = mdbContext.CartItems.FirstOrDefault(c => c.CartItemID == partid);
            var localAmount = 0;
            if (cartItem != null)
            {
                if (cartItem.CartQuantity > 1)
                {
                    cartItem.CartQuantity--;
                    localAmount = cartItem.CartQuantity;
                }
                else
                {
                    mdbContext.CartItems.Remove(cartItem);
                }

            }
            mdbContext.SaveChanges();
            return localAmount;

        }

        public List<CartItem> GetCartItems()
        {


            var cartItems = mdbContext.CartItems.Where(c => c.CartId == CartId).ToList();
            return cartItems;
            //return CartItems ??
            //    (CartItems = mdbContext.CartItems.Where(p => p.CartId == CartId).ToList());

        }

        public List<CartItem> GetCartItemsUserAuth(string ui)
        {


            var cartItems = mdbContext.CartItems.Where(c => c.CustomerId == ui).ToList();
            return cartItems;
            //return CartItems ??
            //    (CartItems = mdbContext.CartItems.Where(p => p.CartId == CartId).ToList());

        }

        public void ClearCart()
        {
            var cartItems = mdbContext.CartItems
                .Where(cart => cart.CartId == CartId);
            mdbContext.CartItems.RemoveRange(cartItems);
            mdbContext.SaveChanges();
        }

        public decimal GetCartTotal()
        {

            var total = mdbContext.CartItems.Where(p => p.CartId == CartId).Select(c => c.CartSellingPrice * c.CartQuantity).Sum();
            return total;
        }

        public decimal GetCartTotalUserAuth(string ui)
        {

            var total = mdbContext.CartItems.Where(p => p.CustomerId == ui).Select(c => c.CartSellingPrice * c.CartQuantity).Sum();
            return total;
        }


        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<MainDBContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new Cart(context) { CartId = cartId };
        }

        public OrderedPart OrderPart(CartItem cartItem)
        {
            //var cartItem = mdbContext.CartItems.FirstOrDefault(c => c.CartItemID == cartItemId);
            OrderedPart orderedPart = new OrderedPart
            {
                CustomerId = cartItem.CustomerId,
                VendorId = cartItem.CartVendorId,
                OrdBrand = cartItem.CartBrand,
                OrdPartNumber = cartItem.CartPartNumber,
                OrdPartName = cartItem.CartPartName,
                OrdBuyingPrice = cartItem.CartBuyingPrice,
                OrdSellingPrice = cartItem.CartSellingPrice,
                OrdQuantity = cartItem.CartQuantity,
                TotalOrdBuyingPrice = cartItem.CartBuyingPrice * cartItem.CartQuantity,
                TotalOrdSellingPrice = cartItem.CartSellingPrice * cartItem.CartQuantity,
                DeliveryDate = cartItem.DeliveryDate,
                OrderDate = DateTime.Now,

            };
            //if (cartItem != null)
            //{
            //    mdbContext.OrderedParts.Add(orderedPart);
            //}

            //mdbContext.SaveChanges();
            return orderedPart;
        }

        public void Order(string ui, List<CartItem> list)
        {
            List<OrderedPart> orderedParts = new List<OrderedPart>();
            decimal totalSellPrice = 0;
            decimal totalBuyPrice = 0;
            DateTime dateMax = list[0].DeliveryDate;



            foreach (CartItem cartItem in list)
            {
                var opart = OrderPart(cartItem);
                orderedParts.Add(opart);
                //mdbContext.OrderedParts.Add(opart);

                totalBuyPrice += cartItem.CartBuyingPrice;
                totalSellPrice += cartItem.CartSellingPrice;
                if (cartItem.DeliveryDate > dateMax) dateMax = cartItem.DeliveryDate;
            }

            //Order order = new Order
            //{
            //    OrderDate = DateTime.Now,
            //    CustomerId = ui,
            //    //OrderedParts = orderedParts,
            //    OrderedParts = new List<OrderedPart>()
            //    {
            //        new OrderedPart OrderPart()
            //    },

            //    OrderSellingPrice = totalSellPrice,
            //    OrderByuingPrice = totalBuyPrice,
            //    DeliveryType = "Delivery",
            //    ToSellDate = dateMax

            //};
            //if (order != null)
            //{
            //    mdbContext.Orders.Add(order);
            //}

            //mdbContext.SaveChanges();
            Order order = new Order
            {
                OrderDate = DateTime.Now,
                CustomerId = ui,
                OrderedParts = orderedParts,
                OrderSellingPrice = totalSellPrice,
                OrderByuingPrice = totalBuyPrice,
                DeliveryType = "Delivery",
                ToSellDate = dateMax,
                //OrderedParts = orderedParts
            };
            mdbContext.Orders.Add(order);
            mdbContext.SaveChanges();
            //foreach(OrderedPart op in orderedParts)
            //{
            //   new OrderedPart() 
            //}
            //order.OrderedParts.AddRange(orderedParts);
            //mdbContext.SaveChanges();






        }

    }

    public class CartItem
    {
        public int CartItemID { get; set; }

        public int CartVendorId { get; set; }

        public string CartBrand { get; set; }

        public string CartPartNumber { get; set; }

        public string CartPartName { get; set; }

        public decimal CartBuyingPrice { get; set; }
        public decimal CartSellingPrice { get; set; }
        public int CartQuantity { get; set; }
        public string CartId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CartDate { get; set; }
        public string CustomerId { get; set; }


    }
}
