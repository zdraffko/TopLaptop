using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopLaptop.Data.Entities.Users;

namespace TopLaptop.Data.Context.Configurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> customer)
        {
            customer.HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}
