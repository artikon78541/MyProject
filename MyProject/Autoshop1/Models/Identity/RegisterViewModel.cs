using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Identity
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "ФИО")]
        public string Name { get; set; }


        [Display(Name = "Email адрес")]
        [Required(ErrorMessage = "Необходимо ввести Email")]
        [EmailAddress(ErrorMessage = "Неверный формат Email")]
        public string Email { get; set; }

        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Необходимо ввести номер мобильного телефона")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
