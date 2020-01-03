using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopLaptop.Data.Entities.Orders;

namespace TopLaptop.Data.Context.Configurations
{
    public class LaptopOrderConfiguration : IEntityTypeConfiguration<LaptopOrder>
    {
        public void Configure(EntityTypeBuilder<LaptopOrder> laptopOrder)
        {
            laptopOrder.HasKey(lo => new { lo.LaptopId, lo.OrderId });

            laptopOrder.HasOne(lo => lo.Laptop)
                .WithMany(l => l.ParticipationOrders)
                .HasForeignKey(lo => lo.LaptopId)
                .OnDelete(DeleteBehavior.Restrict);

            laptopOrder.HasOne(lo => lo.Order)
                .WithMany(l => l.OrderedLaptops)
                .HasForeignKey(lo => lo.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
