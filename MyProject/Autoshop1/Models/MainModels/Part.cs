using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.MainModels
{
    public class Part
    {


        public int PartId { get; set; }

        public int VendorId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(30)]
        public string PartNumber { get; set; }
        [Required]
        public string PartName { get; set; }
        [Required]
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int QuantityInStock { get; set; }


    }
}
