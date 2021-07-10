using System;
using System.Threading.Tasks;
using Assessment.Application.Entities;
using Assessment.Application.Interfaces;
using Assessment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Repositories
{
    public class ApplicationUserRepository : BaseRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(AssessmentContext context) : base(context) { }
        
        public async Task<ApplicationUser> GetLoginByCredentials(ApplicationUserLogin userLogin)
        {
            return await _entities.FirstOrDefaultAsync(x => x.UserName == userLogin.UserName);
        }
    }
}
