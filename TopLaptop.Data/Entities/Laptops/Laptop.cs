using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TopLaptop.Data.Entities.Laptops.LaptopParts;
using TopLaptop.Data.Entities.Orders;
using TopLaptop.Data.Entities.Other;
using TopLaptop.Data.Entities.Users;
using static TopLaptop.Data.Validation.DataValidation;

namespace TopLaptop.Data.Entities.Laptops
{
    public class Laptop
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal MinDiscauntedPrice { get; set; }

        public double? Discount { get; set; }

        public int Quantity { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public Image Image { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ProcessorId { get; set; }
        public Processor Processor { get; set; }

        public int GraphicsCardId { get; set; }
        public GraphicsCard GraphicsCard { get; set; }

        public int RamStorageId { get; set; }
        public RAMStorage RAM { get; set; }

        public int StorageId { get; set; }
        public Storage Storage { get; set; }

        public int EmployeeId { get; set; }
        public Employee EmployeeRespondent { get; set; }

        public ICollection<LaptopOrder> ParticipationOrders { get; set; } = new List<LaptopOrder>();
    }
}
