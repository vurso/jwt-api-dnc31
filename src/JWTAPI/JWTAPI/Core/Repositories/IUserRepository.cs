using JWTAPI.Core.Models;
using System.Threading.Tasks;

namespace JWTAPI.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}