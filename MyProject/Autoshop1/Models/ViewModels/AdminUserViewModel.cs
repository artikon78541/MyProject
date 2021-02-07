using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.ViewModels
{
    public class AdminUserViewModel
    {
        public int Num { get; set; }
        public string Id { get; set; }
        public int MdbNumber { get; set; }
        public string Email { get; set; }
        public string UserFIO { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Roles { get; set; }
    }
}
