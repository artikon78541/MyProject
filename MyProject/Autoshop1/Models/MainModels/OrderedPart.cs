using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.MainModels
{
    public class OrderedPart
    {
            public int OrderedPartId { get; set; }

            public int VendorId { get; set; }
            [Required]
            [MaxLength(30)]
            public string OrdBrand { get; set; }
            [Required]
            [MaxLength(15)]
            public string OrdPartNumber { get; set; }
            [Required]
            public string OrdPartName { get; set; }
            [Required]
            public decimal OrdBuyingPrice { get; set; }
            public decimal OrdSellingPrice { get; set; }
            public int OrdQuantity { get; set; }
            public decimal TotalOrdBuyingPrice { get; set; }
            public decimal TotalOrdSellingPrice { get; set; }
            public string CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime DeliveryDate { get; set; }

            public int OrderId { get; set; }
            //public Order Order { get; set; }


    }
}
