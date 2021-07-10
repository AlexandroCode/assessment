using System;
using Assessment.Application.Entities;
using Assessment.Application.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public class WorkOrderConfiguration : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> builder)
        {
            builder.ToTable("WorkOrder");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Date)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.WorkOrderType)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne(e => e.Ticket).WithOne(e => e.WorkOrder)
                .HasForeignKey<Ticket>(f => f.Id)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_WorkOrder_Ticket");

            builder.HasOne(e => e.CustomerRetainer).WithOne(e => e.WorkOrder)
                .HasForeignKey<CustomerRetainer>(f => f.Id);
        }
    }
}
