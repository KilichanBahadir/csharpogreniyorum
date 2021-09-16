using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works33.DataAccess;
using Works33.Models;

namespace Works33.BusinessAccess
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUserAsync(User user)=>await _userRepository.AddUser(user);
        

        public async Task<bool> DeleteUserAsync(long id)=> await _userRepository.DeleteUser(id);
       

        public async Task<User> GetUserByIdAsync(long id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<bool> isUserExistAsync(long id)
        {
            return await _userRepository.isUserExist(id);
        }

        public async Task<User> UpdateUserAsync(User user)=>await _userRepository.UpdateUser(user);
        
    }
}
