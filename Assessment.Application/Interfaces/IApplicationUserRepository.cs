using System;
using System.Threading.Tasks;
using Assessment.Application.Entities;

namespace Assessment.Application.Interfaces
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetLoginByCredentials(ApplicationUserLogin userLogin);
    }
}
