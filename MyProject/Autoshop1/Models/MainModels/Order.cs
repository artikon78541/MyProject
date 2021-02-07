using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.MainModels
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        //public Customer Customer { get; set; }

        public string CustomerId { get; set; }

        public virtual List<OrderedPart> OrderedParts { get; set; }

        public Order()
        {
            OrderedParts = new List<OrderedPart>();
        }

        public decimal OrderSellingPrice { get; set; }
        public decimal OrderByuingPrice { get; set; }
        public DateTime ToSellDate { get; set; }
        [MaxLength(3)]
        public string DeliveryType { get; set; }
    }
}
