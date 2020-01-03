using System.Collections.Generic;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class Storage
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new HashSet<Laptop>();
    }
}
