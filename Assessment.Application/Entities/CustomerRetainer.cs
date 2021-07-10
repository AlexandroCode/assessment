using System;
using Assessment.Application.Enumerations;

namespace Assessment.Application.Entities
{
    public class CustomerRetainer : BaseEntity
    {

        public int RetainerId { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public RetainerPeriodicity Periodicity { get; set; }
        public string Comments { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Retainer Retainer { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }

        public CustomerRetainer()
        {
        }
    }
}
