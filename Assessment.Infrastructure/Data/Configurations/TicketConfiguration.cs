using System;
using Assessment.Application.Entities;
using Assessment.Application.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {

        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.Date)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.StartDate)
                   .HasColumnType("datetime");

            builder.Property(e => e.EndDate)
                .HasColumnType("datetime");

            builder.Property(e => e.Status)
                .IsRequired()
                .HasColumnType("int")
                .HasDefaultValue(TicketStatus.New);

            builder.Property(e => e.CreatedBy).HasMaxLength(100);

            builder.Property(e => e.Created).HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy).HasMaxLength(100);

            builder.Property(e => e.Modified).HasColumnType("datetime");

            builder.HasOne(e => e.CustomerBranch).WithMany(e => e.Tickets)
                .HasForeignKey(f => f.CustomerBranchId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Ticket_CustomerBranch");
        }
    }
}
