using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works33.Models;

namespace Works33.DataAccess
{
    public class UserRepository : IUserRepository


    {
        private readonly CRMDbContext _crmDbContext;
        public UserRepository(CRMDbContext crmDbContext)
        {
            _crmDbContext = crmDbContext;
        }
        public async Task<User> AddUser(User user)
        {
            await _crmDbContext.Users.AddAsync(user);
            User u = new User();
            await _crmDbContext.SaveChangesAsync();
            u.Id = user.Id;
            u.Username = user.Username;
            u.Password = user.Password;
            u.Email = user.Email;
            
            return u;
        }

        public async Task<bool> DeleteUser(long id)
        {
            if (!await isUserExist(id)) { return false; }
            try
            {
                User u = await _crmDbContext.Users.FindAsync(id);

                _crmDbContext.Users.Remove(u);
                await _crmDbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public async Task<User> GetUserById(long id)
        {
            return await _crmDbContext.Users.FindAsync(id);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _crmDbContext.Users.ToListAsync();
        }

        public async Task<bool> isUserExist(long id)
        {
            return await _crmDbContext.Users.AnyAsync(u => u.Id == id);
        }

        public async Task<User> UpdateUser(User user)
        {
            _crmDbContext.Users.Update(user);
            User u = new User();
            await _crmDbContext.SaveChangesAsync();
            u.Id = user.Id;
            u.Username = user.Username;
            u.Password = user.Password;
            u.Email = user.Email;
            return u;

        }
    }
}
