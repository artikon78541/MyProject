using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Identity
{
    public class CreateModel
    {
        [Required]
        [Display(Name = "ФИО")]
        public string Name { get; set; }


        [Display(Name = "Email адрес")]
        [Required(ErrorMessage = "Необходимо ввести Email")]
        [EmailAddress(ErrorMessage = "Неверный формат Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }



    }

    public class RoleEditмodel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }

    public class RoleМodificationМodel
    {
        [Required]

        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}

