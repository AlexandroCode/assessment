using System;
using System.Threading.Tasks;
using Assessment.Application.Interfaces;
using Assessment.Infrastructure.Repositories;

namespace Assessment.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AssessmentContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly ICustomerRepository _customerRepository;

        public UnitOfWork(AssessmentContext assessmentContext) 
        {
            _context = assessmentContext;
        }

        public IApplicationUserRepository ApplicationUserRepository => _applicationUserRepository ?? new ApplicationUserRepository(_context);

        public ICustomerRepository CustomerRepository => _customerRepository ?? new CustomerRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
