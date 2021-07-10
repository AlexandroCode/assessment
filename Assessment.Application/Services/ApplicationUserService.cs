using System.Threading.Tasks;
using Assessment.Application.Entities;
using Assessment.Application.Interfaces;

namespace Assessment.Application.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApplicationUser> GetLoginByCredentials(ApplicationUserLogin userLogin)
        {
            return await _unitOfWork.ApplicationUserRepository.GetLoginByCredentials(userLogin);
        }

        public async Task RegisterApplicationUser(ApplicationUser applicationUser)
        {
            await _unitOfWork.ApplicationUserRepository.Add(applicationUser);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
