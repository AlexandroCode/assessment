using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Application.Dtos;
using Assessment.Application.Entities;
using Assessment.Application.Interfaces;
using Assessment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AssessmentContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            //var customers = Enumerable.Range(1, 10).Select(x => new CustomerDto()
            //{
            //    Id = x,
            //    Rfc = $"XXXXXXXXXXX{x}",
            //    Name = $"Description {x}",
            //    CorporateName = $"Corporate name {x}"
            //});
            //await Task.Delay(100);
            return await _entities.ToListAsync();
        }
    }
}
