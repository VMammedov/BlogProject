using EntityLayer.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name can't be NULL!").NotEmpty().WithMessage("Name can't be Empty!");
            RuleFor(x => x.SurName).NotNull().WithMessage("SurName can't be NULL!").NotEmpty().WithMessage("SurName can't be Empty!");
            RuleFor(x => x.NickName).NotNull().WithMessage("NickName can't be NULL!").NotEmpty().WithMessage("NickName can't be Empty!");
            RuleFor(x => x.Password1).NotNull().WithMessage("Password 1 can't be NULL!").NotEmpty().WithMessage("Password 1 can't be Empty!");
            RuleFor(x => x.Password2).NotNull().WithMessage("Password 2 can't be NULL!").NotEmpty().WithMessage("Password 2 can't be Empty!");
            RuleFor(x => x.Password2).Equal(x => x.Password1).WithMessage("Please make sure the passwords are the same!");
            RuleFor(x => x.Mail).EmailAddress();
        }
    }
}
