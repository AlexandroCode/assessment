using System.Threading.Tasks;
using Assessment.Application.Entities;

namespace Assessment.Application.Services
{
    public interface IApplicationUserService
    {
        Task<ApplicationUser> GetLoginByCredentials(ApplicationUserLogin userLogin);
        Task RegisterApplicationUser(ApplicationUser applicationUser);
    }
}