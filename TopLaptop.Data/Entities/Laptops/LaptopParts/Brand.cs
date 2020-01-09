using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        public string BrandName { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
    }
}
