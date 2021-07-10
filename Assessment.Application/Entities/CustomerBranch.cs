using System;
using System.Collections.Generic;

namespace Assessment.Application.Entities
{
    public class CustomerBranch : BaseEntity
    {
        //public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public bool Active { get; set; }

        public virtual Customer Customer { get; private set; }
        public virtual ICollection<Ticket> Tickets { get; private set; }

        public CustomerBranch()
        {
        }
    }
}
