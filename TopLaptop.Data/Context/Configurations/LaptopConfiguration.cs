using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopLaptop.Data.Entities.Laptops;
using TopLaptop.Data.Entities.Laptops.LaptopParts;
using TopLaptop.Data.Entities.Other;

namespace TopLaptop.Data.Context.Configurations
{
    class LaptopConfiguration : IEntityTypeConfiguration<Laptop>
    {
        public void Configure(EntityTypeBuilder<Laptop> laptop)
        {
            laptop.HasOne(l => l.Brand)
                .WithMany(b => b.Laptops)
                .HasForeignKey(l => l.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            laptop.HasOne(l => l.GraphicsCard)
                .WithMany(g => g.Laptops)
                .HasForeignKey(l => l.GraphicsCardId)
                .OnDelete(DeleteBehavior.Restrict);

            laptop.HasOne(l => l.Processor)
                .WithMany(p => p.Laptops)
                .HasForeignKey(l => l.ProcessorId)
                .OnDelete(DeleteBehavior.Restrict);

            laptop.HasOne(l => l.RAM)
                .WithMany(r => r.Laptops)
                .HasForeignKey(l => l.RamStorageId)
                .OnDelete(DeleteBehavior.Restrict);

            laptop.HasOne(l => l.Storage)
                .WithMany(s => s.Laptops)
                .HasForeignKey(l => l.StorageId)
                .OnDelete(DeleteBehavior.Restrict);

            laptop.HasOne(l => l.Image)
                .WithOne(i => i.Laptop)
                .HasForeignKey<Image>(i => i.LaptopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
