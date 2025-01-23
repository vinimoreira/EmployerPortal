using EmployerPortal.Models;

namespace EmployerPortal.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByUsernameAssync(string username);
    }
}
