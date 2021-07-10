using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class RetainerConfiguration : IEntityTypeConfiguration<Retainer>
    {
        public void Configure(EntityTypeBuilder<Retainer> builder)
        {
            builder.ToTable("Retainer");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(64);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasMaxLength(512);

            builder.Property(e => e.Active)
                .IsRequired()
                .HasColumnName("Active")
                .HasColumnType("bit")
                .HasDefaultValue(0);

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");


            builder.HasMany(e => e.CustomerRetainers).WithOne(e => e.Retainer)
                .HasForeignKey(f => f.RetainerId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Retainer_CustomerRetainer");

        }
    }
}
