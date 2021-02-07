using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.MainModels
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [MaxLength(30)]
        public string VendorName { get; set; }
        public int DeliveryTime { get; set; }
    }
}
