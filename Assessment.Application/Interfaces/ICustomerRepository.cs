using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assessment.Application.Dtos;
using Assessment.Application.Entities;

namespace Assessment.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
    }
}
