using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TopLaptop.Data.Entities.Orders;
using static TopLaptop.Data.Validation.DataValidation;

namespace TopLaptop.Data.Entities.Users
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; }

        public int Password { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
