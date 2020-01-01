using JWTAPI.Core.Models;
using JWTAPI.Core.Services.Communication;
using System.Threading.Tasks;

namespace JWTAPI.Core.Services
{
    public interface IUserService
    {
         Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
         Task<User> FindByEmailAsync(string email);
    }
}