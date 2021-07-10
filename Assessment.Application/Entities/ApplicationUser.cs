using System;
using Assessment.Application.Enumerations;

namespace Assessment.Application.Entities
{
    public class ApplicationUser : BaseEntity
    {
        //public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public RolType Role { get; set; }
        public bool Active { get; set; }

        public Technician Technician { get; set; }

        public ApplicationUser()
        {
        }
    }
}
