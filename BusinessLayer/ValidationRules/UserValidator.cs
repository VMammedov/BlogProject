using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("User Name can't be NULL!").NotEmpty().WithMessage("User Name can't be Empty!");
            RuleFor(x => x.UserLastName).NotNull().WithMessage("User SurName can't be NULL!").NotEmpty().WithMessage("User SurName can't be Empty!");
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
