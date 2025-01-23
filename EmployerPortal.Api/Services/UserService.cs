using EmployerPortal.Data;
using EmployerPortal.Models;
using EmployerPortal.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployerPortal.Services
{
    public class UserService : IUserService
    {

        private readonly EmployerPortalDbContext _dbContext;

        public UserService(EmployerPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> GetUserByUsernameAssync(string username)
        {
            return await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Username == username);
        }
    }
}
