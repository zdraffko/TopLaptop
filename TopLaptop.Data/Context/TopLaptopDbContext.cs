using Microsoft.EntityFrameworkCore;
using TopLaptop.Data.Entities.Orders;
using TopLaptop.Data.Entities.Other;
using TopLaptop.Data.Entities.Laptops;
using TopLaptop.Data.Entities.Users;
using TopLaptop.Data.Entities.Laptops.LaptopParts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TopLaptop.Data.Identity;

namespace TopLaptop.Data.Context
{
    public class TopLaptopDbContext : IdentityDbContext<ApplicationUser>
    {
        public TopLaptopDbContext(DbContextOptions<TopLaptopDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

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

        public DbSet<LaptopOrder> LaptopOrders { get; set; }
    }
}
