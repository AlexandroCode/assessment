using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class TechnicianConfiguration : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> builder)
        {
            builder.ToTable("Technician");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Birthdate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.Genre)
                .IsRequired()
                .HasMaxLength(16);

            builder.Property(e => e.Active)
                .IsRequired()
                .HasColumnType("bit")
                .HasDefaultValue(0);

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");

            //builder.HasOne(e => e.ApplicationUser).WithOne(a => a.Technician)
            //    .HasForeignKey<ApplicationUser>(f => f.Id)
            //    .OnDelete(DeleteBehavior.NoAction)
            //    .HasConstraintName("FK_Technician_ApplicationUser");

            builder.HasMany(e => e.Tickets).WithOne(e => e.Technician)
                .HasForeignKey(f => f.TechnicianId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Technician_Tickets");
        }
    }
}
