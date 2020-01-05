using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static TopLaptop.Data.Validation.DataValidation;

namespace TopLaptop.Data.Entities.Laptops.LaptopParts
{
    public class RAMStorage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(InfoTextMaxLength)]
        public string Type { get; set; }

        public int Size { get; set; }

        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
    }
}
