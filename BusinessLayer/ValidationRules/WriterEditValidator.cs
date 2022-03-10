using BusinessLayer.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterEditValidator:AbstractValidator<WriterEditViewModel>
    {
        public WriterEditValidator()
        {
            RuleFor(x => x.WriterName).NotNull().WithMessage("Name can't be NULL!").NotEmpty().WithMessage("Name can't be Empty!").MaximumLength(20).WithMessage("Name can be maximum 20 character!").MinimumLength(5).WithMessage("Name can be minimum 5 character!");
            RuleFor(x => x.WriterSurName).NotNull().WithMessage("SurName can't be NULL!").NotEmpty().WithMessage("Last Name can't be Empty!").MaximumLength(30).WithMessage("Last Name can be maximum 30 character!").MinimumLength(5).WithMessage("Last Name can be minimum 5 character!");
            RuleFor(x => x.WriterNickName).NotNull().WithMessage("NickName can't be NULL!").NotEmpty().WithMessage("NickName can't be Empty!").MaximumLength(25).WithMessage("NickName can be maximum 25 character!").MinimumLength(5).WithMessage("NickName can be minimum 5 character!");
            RuleFor(x => x.WriterMail).EmailAddress();
            //RuleFor(x => x.WriterImage.Length).NotNull().LessThanOrEqualTo(100).WithMessage("File size is larger than allowed");
            //RuleFor(x => x.WriterImage.ContentType).NotNull().Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png")).WithMessage("File type is larger than allowed");
        }
    }
}
