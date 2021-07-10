using System;
using System.Collections.Generic;
using Assessment.Application.Enumerations;

namespace Assessment.Application.Entities
{
    public class Retainer : BaseEntity
    {

        public string Name { get; set; } 
        public string Description { get; set; }
        public bool Active { get; set; }

        public ICollection<CustomerRetainer> CustomerRetainers { get; set; }

        public Retainer()
        {
        }
    }
}
