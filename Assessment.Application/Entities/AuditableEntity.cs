using System;
namespace Assessment.Application.Entities
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }

        public AuditableEntity()
        {


        }
    }
}
