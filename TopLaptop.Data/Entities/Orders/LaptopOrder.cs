using System;
using System.Collections.Generic;
using System.Text;
using TopLaptop.Data.Entities.Laptops;

namespace TopLaptop.Data.Entities.Orders
{
    public class LaptopOrder
    {
        public int LaptopId { get; set; }
        public Laptop Laptop { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
