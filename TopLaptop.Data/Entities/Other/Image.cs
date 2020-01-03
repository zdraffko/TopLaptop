using System;
using System.Collections.Generic;
using System.Text;
using TopLaptop.Data.Entities.Laptops;

namespace TopLaptop.Data.Entities.Other
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }

        public int LaptopId { get; set; }
        public Laptop Laptop { get; set; }
    }
}
