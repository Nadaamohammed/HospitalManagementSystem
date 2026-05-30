using HospitalManagementSystem.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount)
                   .HasColumnType("decimal(18,2)");

            builder.Property(x => x.PaymentMethod)
                   .HasMaxLength(50);

            builder.HasOne(x => x.Bill)
                   .WithMany(x => x.Payments)
                   .HasForeignKey(x => x.BillId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
