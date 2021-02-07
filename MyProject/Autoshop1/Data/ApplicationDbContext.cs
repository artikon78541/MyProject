using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


//namespace Autoshop1.Data
//{
//    public class ApplicationDbContext : IdentityDbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }
//    }
//}

//namespace Autoshop1.Models.Identity
//{
//    public class AppIdentityDbContext : IdentityDbContext<AppUser>
//    {
//        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }
//    }
//}

namespace Autoshop1.Models.Identity
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
