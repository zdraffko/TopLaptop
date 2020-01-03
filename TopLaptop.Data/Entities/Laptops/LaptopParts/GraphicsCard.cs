using System.Collections.Generic;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class GraphicsCard
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new HashSet<Laptop>();
    }
}
