using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class GraphicsCard
    {
        public int Id { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
    }
}
