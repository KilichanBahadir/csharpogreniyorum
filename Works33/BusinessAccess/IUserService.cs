using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works33.Models;

namespace Works33.BusinessAccess
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(long id);
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<Boolean> isUserExistAsync(long id);
        Task<Boolean> DeleteUserAsync(long id);
    }
}
