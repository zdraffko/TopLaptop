using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopLaptop.Data.Entities.Users;

namespace TopLaptop.Data.Context.Configurations
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> employee)
        {
            employee.HasIndex(e => e.Email)
                .IsUnique();
        }
    }
}
