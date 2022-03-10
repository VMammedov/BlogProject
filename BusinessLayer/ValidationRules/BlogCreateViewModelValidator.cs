using BusinessLayer.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogCreateViewModelValidator:AbstractValidator<BlogCreateViewModel>
    {
        public BlogCreateViewModelValidator()
        {
            RuleFor(x => x.BlogTitle).NotNull().WithMessage("Blog's Title can't get null value!").NotEmpty().WithMessage("Please, fill Blog Title area!");
            RuleFor(x => x.BlogContent).NotNull().WithMessage("Blog's Content can't get null value!").NotEmpty().WithMessage("Please, fill Blog Content area!");
            RuleFor(x => x.BlogImage).NotNull().WithMessage("Blog's Image can't get null value!").NotEmpty().WithMessage("Please, select a Blog Image!");
            RuleFor(x => x.BlogThumbnailImage).NotNull().WithMessage("Blog's Thumbnail Image can't get null value!").NotEmpty().WithMessage("Please, select a Blog Thumbnail Image!");
            RuleFor(x => x.CategoryID).NotNull().WithMessage("Blog's Category can't get null value!").NotEmpty().WithMessage("Please, select a Category for your Blog!");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("The Blog's Title can get minimum 3 characters!").MaximumLength(50).WithMessage("The Blog's Title can get maximum 50 characters!");
            RuleFor(x => x.BlogContent).MinimumLength(30).WithMessage("The Blog's Content must be a minimum of 30 characters!").MaximumLength(1250).WithMessage("The Blog's Content can get maximum 1250 characters!");
            RuleFor(x => x.BlogImage).MaximumLength(300).WithMessage("The Blog's Image's path must be a maximum of 300 characters!");
            RuleFor(x => x.BlogThumbnailImage).MaximumLength(300).WithMessage("The Blog's Thumbnail Image's path must be a maximum of 300 characters!");
        }
    }
}
