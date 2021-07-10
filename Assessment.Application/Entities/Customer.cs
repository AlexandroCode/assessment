using System;
using System.Collections.Generic;

namespace Assessment.Application.Entities
{
    public class Customer : BaseEntity
    {
        //public int Id { get; set; }
        public string Rfc { get; set; }
        public string Name { get; set; }
        public string CorporateName { get; set; }
        public bool Active { get; set; }

        public ICollection<CustomerBranch> CustomerBranchs { get; set; }
        public ICollection<CustomerRetainer> CustomerRetainers { get; set; }

        public Customer()
        {
        }
    }
}
