using System;
using Assessment.Application.Entities;
using Assessment.Application.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUser");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id);

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.LastLogin)
                .HasColumnType("datetime");

            builder.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(20)
                .HasConversion(x => x.ToString()
                ,x => (RolType)Enum.Parse(typeof(RolType), x));

            builder.Property(e => e.Active)
                .HasColumnType("bit")
                .HasDefaultValue(0);

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");
        }
    }
}
