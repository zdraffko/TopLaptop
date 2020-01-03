using System.Collections.Generic;
using TopLaptop.Data.Entities.Orders;

namespace TopLaptop.Data.Entities.Users
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
