using System;
using System.Collections.Generic;

namespace Assessment.Application.Entities
{
    public class Technician : BaseEntity
    {
        //public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Genre { get; set; }
        public bool Active { get; set; }

        public virtual ApplicationUser ApplicationUser { get; private set;}
        public virtual ICollection<Ticket> Tickets { get; private set; }

        public Technician()
        {
        }
    }
}
