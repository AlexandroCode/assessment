using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class CustomerRetainerConfiguration :IEntityTypeConfiguration<CustomerRetainer>
    {
        public void Configure(EntityTypeBuilder<CustomerRetainer> builder)
        {
            builder.ToTable("CustomerRetainer");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(e => e.Comments)
                .HasMaxLength(500);

            builder.Property(e => e.Date)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.Periodicity)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");

        }
    }
}
