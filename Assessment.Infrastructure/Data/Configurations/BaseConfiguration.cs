using System;
using Assessment.Application.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.Data.Configurations
{
    public abstract class BaseConfiguration
    {
        public void ConfigureBase(EntityTypeBuilder<BaseEntity> builder)
        {


        }
    }
}
