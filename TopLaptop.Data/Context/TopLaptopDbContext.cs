using Microsoft.EntityFrameworkCore;
using TopLaptop.Data.Entities.Other;
using TopLaptop.Data.Entities.Laptop;
using TopLaptop.Data.Entities.Users;
using TopLaptop.Data.Entities.Laptop.LaptopParts;

namespace TopLaptop.Data.Context
{
    class TopLaptopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<GraphicsCard> GraphicsCards { get; set; }

        public DbSet<Processor> Processors { get; set; }

        public DbSet<RAMStorage> RAMStorages { get; set; }

        public DbSet<Storage> Storages { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
