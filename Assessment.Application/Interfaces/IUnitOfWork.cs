using System;
using System.Threading.Tasks;

namespace Assessment.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository ApplicationUserRepository { get; }

        ICustomerRepository CustomerRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
