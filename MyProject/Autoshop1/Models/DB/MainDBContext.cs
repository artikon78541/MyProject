using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.MainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Autoshop1.Models.DB
{
    public class MainDBContext : DbContext
    {
        public MainDBContext()
        {
        }

        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options) { }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedPart> OrderedParts { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<CartItem> CartItems { get; set; }


    }

}
