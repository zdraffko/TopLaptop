using System.ComponentModel.DataAnnotations;

namespace TopLaptop.Web.ViewModels
{
    public class LogInViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Required]
        [Display(Name = "Remember me")]
        public bool IsRemembered { get; set; }
    }
}
