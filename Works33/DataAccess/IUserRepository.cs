using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works33.Models;

namespace Works33.DataAccess
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(long id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task<Boolean> isUserExist(long id);
        Task<Boolean> DeleteUser(long id);
    }
}
