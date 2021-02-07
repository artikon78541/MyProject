using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.Identity;
using System.Text.RegularExpressions;

namespace Autoshop1.Models.Identity.Infrastructure
{
    public class CustomUserValidator : UserValidator<AppUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            IdentityResult result = await base.ValidateAsync(manager, user);
            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();
            //if (!user.Email.ToLower().EndsWith("@spam.com")) 
            //{ 
            //    errors.Add(new IdentityError { 

            //        Code = "EmailDomainError",
            //        Description = "Only example.com email addresses are allowed"
            //    }
            //    );
            //}
            bool emailisValid = Validator.EmailIsValid(user.Email);
            if (!emailisValid)
            {
                errors.Add(new IdentityError
                {

                    Code = "EmailDomainError",
                    Description = "Не верный формат Email"
                }
                        );
            }

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        }
    }

    public static class Validator
    {

        static Regex ValidEmailRegex = CreateValidEmailRegex();
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
    }
}
