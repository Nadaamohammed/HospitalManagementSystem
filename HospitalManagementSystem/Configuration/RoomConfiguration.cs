using HospitalManagementSystem.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoomNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.HasIndex(x => x.RoomNumber)
                   .IsUnique();
        }
    }
}
