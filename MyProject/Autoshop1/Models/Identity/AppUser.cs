using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Autoshop1.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string UserFIO { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
