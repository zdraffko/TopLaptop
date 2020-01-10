using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TopLaptop.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Remote("CheckIfUsernameIsInUse", "Account")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Remote("CheckIfEmailIsInUse", "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Registration Type")]
        public string RegistrationType { get; set; }
    }
}
