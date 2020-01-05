using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static TopLaptop.Data.Validation.DataValidation;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class GraphicsCard
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(InfoTextMaxLength)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(InfoTextMaxLength)]
        public string Model { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
    }
}
