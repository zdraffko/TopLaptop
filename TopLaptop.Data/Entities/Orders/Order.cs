using System;
using System.Collections.Generic;
using TopLaptop.Data.Entities.Users;

namespace TopLaptop.Data.Entities.Orders
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<LaptopOrder> OrderedLaptops { get; set; } = new HashSet<LaptopOrder>();
    }
}
