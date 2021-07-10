using System;
using Assessment.Application.Enumerations;

namespace Assessment.Application.Entities
{
    public class Ticket : BaseEntity
    {
        //public int Id { get; set; }
        public int TechnicianId { get; set; }
        public int CustomerBranchId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TicketStatus Status { get; set; }
        public string Comments { get; set; }

        public virtual CustomerBranch CustomerBranch { get; private set; }
        public virtual Technician Technician { get; private set; }
        public virtual WorkOrder WorkOrder { get; set; }

        public Ticket()
        {
        }
    }
}
