using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.MainModels
{
    public class Customer
    {
        public string CustomerId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(14)]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        public virtual List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
