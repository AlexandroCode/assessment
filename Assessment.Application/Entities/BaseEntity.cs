using System;
namespace Assessment.Application.Entities
{
    public abstract class BaseEntity : AuditableEntity
    {
        public int Id { get; set; }

    }
}
