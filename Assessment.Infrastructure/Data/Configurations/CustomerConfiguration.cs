using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Rfc).IsRequired()
                .HasColumnName("Rfc")
                .HasMaxLength(13);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(500);

            builder.Property(e => e.CorporateName)
                .IsRequired()
                .HasColumnName("CorporateName")
                .HasMaxLength(500);

            builder.Property(e => e.Active)
                .HasColumnType("bit");

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");

            builder.HasMany(e => e.CustomerBranchs).WithOne(e => e.Customer)
                .HasForeignKey(f => f.CustomerId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Customer_CustomerBranch");

            builder.HasMany(e => e.CustomerRetainers).WithOne(e => e.Customer)
                .HasForeignKey(f => f.CustomerId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Customer_CustomerRetainers");
        }

    }
}
