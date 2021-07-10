using System;
using System.Reflection;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Data
{
    public class AssessmentContext : DbContext
    {
        public AssessmentContext()
        {
        }

        public AssessmentContext(DbContextOptions<AssessmentContext> options) : base(options) { }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerBranch> CustomerBranches { get; set; }
        public virtual DbSet<Retainer> Retainers { get; set; }
        public virtual DbSet<Technician> Technicians { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            //modelBuilder.Entity<Customer>().ToTable("Customer");
            //modelBuilder.Entity<CustomerBranch>().ToTable("CustomerBranch");
            //modelBuilder.Entity<Retainer>().ToTable("Retainer");
            //modelBuilder.Entity<Technician>().ToTable("Technician");
            //modelBuilder.Entity<Ticket>().ToTable("Ticket");
            //modelBuilder.Entity<WorkOrder>().ToTable("WorkOrder");
        }
    }
}
