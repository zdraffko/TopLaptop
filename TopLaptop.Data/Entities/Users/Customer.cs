using System.Collections.Generic;
using TopLaptop.Data.Entities.Orders;

namespace TopLaptop.Data.Entities.Users
{
    public class Customer
    {
        public int Id { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
