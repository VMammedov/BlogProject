using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotNull().WithMessage("Writer Name can't be NULL!").NotEmpty().WithMessage("Writer Name can't be Empty!");
            RuleFor(x => x.WriterSurName).NotNull().WithMessage("Writer SurName can't be NULL!").NotEmpty().WithMessage("Writer SurName can't be Empty!");
            RuleFor(x => x.WriterPassword).NotNull().WithMessage("Password can't be NULL!").NotEmpty().WithMessage("Password can't be Empty!");
            RuleFor(x => x.WriterMail).EmailAddress();
        }
    }
}
