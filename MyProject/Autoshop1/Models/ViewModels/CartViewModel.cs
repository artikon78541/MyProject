using Autoshop1.Models.MainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal CartTotal { get; set; }

        public int CartItemsNumber { get; set; }




    }
}
