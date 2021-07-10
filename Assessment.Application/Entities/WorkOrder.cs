using System;
using Assessment.Application.Enumerations;

namespace Assessment.Application.Entities
{
    public class WorkOrder : BaseEntity
    {

        public int TicketId { get; set; }
        public int? CustomerRetainerId { get; set; }
        public WorkOrderType WorkOrderType { get; set; }
        public DateTime? Date { get; set; }

        public virtual Ticket Ticket { get; private set; }
        public virtual CustomerRetainer CustomerRetainer { get; private set; }

        public WorkOrder()
        {
        }
    }
}
