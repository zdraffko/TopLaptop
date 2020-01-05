using System.ComponentModel.DataAnnotations;
using TopLaptop.Data.Entities.Laptops;
using static TopLaptop.Data.Validation.DataValidation;

namespace TopLaptop.Data.Entities.Other
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string ImageTitle { get; set; }

        [Required]
        public byte[] ImageData { get; set; }

        public int LaptopId { get; set; }
        public Laptop Laptop { get; set; }
    }
}
