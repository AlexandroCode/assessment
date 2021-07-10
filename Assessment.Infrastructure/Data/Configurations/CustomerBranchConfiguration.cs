using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class CustomerBranchConfiguration : IEntityTypeConfiguration<CustomerBranch>
    {
        public void Configure(EntityTypeBuilder<CustomerBranch> builder)
        {
            builder.ToTable("CustomerBranch");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Address).IsRequired()
                .HasColumnName("Address")
                .HasMaxLength(500);

            builder.Property(e => e.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasMaxLength(128);

            builder.Property(e => e.State)
                .IsRequired()
                .HasColumnName("CorporateName")
                .HasMaxLength(128);

            builder.Property(e => e.City)
                .IsRequired()
                .HasColumnName("City")
                .HasMaxLength(128);

            builder.Property(e => e.ZipCode)
                .HasColumnName("ZipCode")
                .HasMaxLength(128);

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");

        }
    }
}
