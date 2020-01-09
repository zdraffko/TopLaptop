using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class Storage
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public int Size { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
    }
}
