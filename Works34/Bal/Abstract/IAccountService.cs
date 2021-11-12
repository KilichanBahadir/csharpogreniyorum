using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Entities;

namespace Works34.Bal.Abstract
{
    public interface IAccountService
    {
        Task<IList<Account>> GetAllAsync();
        Task AddAsync(Account account);
        Task UpdateAsync(Account account);
        Task DeleteAsync(int accountId);
        Task<Account> GetByIdAsync(int accountId);
    }
}
