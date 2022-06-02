using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserSignUpViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter First Name!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Last Name!")]
        public string LastName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password!")]
        public string Password { get; set; }

        [Display(Name = "Password Confirm")]
        [Compare("Password",ErrorMessage = "Passwords are not the same!")]
        public string ConfirPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email!")]
        public string Email { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter User Name!")]
        public string UserName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please select Country!")]
        public int CountryID { get; set; }
    }
}
