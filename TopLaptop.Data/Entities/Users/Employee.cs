using System.Collections.Generic;
using TopLaptop.Data.Entities.Laptops;

namespace TopLaptop.Data.Entities.Users
{
    public class Employee
    {
        public int Id { get; set; }

        public decimal? Revenue { get; set; }

        public ICollection<Laptop> ManagedLaptops { get; set; } = new List<Laptop>();
    }
}
