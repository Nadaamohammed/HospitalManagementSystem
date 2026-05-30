using HospitalManagementSystem.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Configuration
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MedicineName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Dosage)
                   .HasMaxLength(100);

            builder.Property(x => x.Instructions)
                   .HasMaxLength(1000);

            builder.HasOne(x => x.MedicalRecord)
                   .WithMany()
                   .HasForeignKey(x => x.MedicalRecordId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
