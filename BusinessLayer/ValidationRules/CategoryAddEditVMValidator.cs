using BusinessLayer.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryAddEditVMValidator:AbstractValidator<CategoryAddEditViewModel>
    {
        public CategoryAddEditVMValidator()
        {
            RuleFor(x => x.CategoryName).NotNull().WithMessage("Category's Name field can't get null value!").NotEmpty().WithMessage("Please, fill Category Name area!");
            RuleFor(x => x.CategoryDescription).NotNull().WithMessage("Category's Description field can't get null value!").NotEmpty().WithMessage("Please, fill Category Description area!");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Category's Name field can get minimum 2 characters!").MaximumLength(60).WithMessage("Category's Name field can get maximum 50 characters!");
            RuleFor(x => x.CategoryDescription).MinimumLength(30).WithMessage("Category's Description must be a minimum of 30 characters!").MaximumLength(500).WithMessage("Category's Description can get maximum 500 characters!");
        }
    }
}
