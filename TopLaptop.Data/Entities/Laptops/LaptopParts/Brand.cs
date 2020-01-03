using System.Collections.Generic;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class Brand
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new HashSet<Laptop>();
    }
}
