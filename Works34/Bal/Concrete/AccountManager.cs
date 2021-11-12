using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Bal.Abstract;
using Works34.Dal.Abstract;
using Works34.Entities;

namespace Works34.Bal.Concrete
{
    public class AccountManager:IAccountService
    {
        private readonly IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public async Task AddAsync(Account account)
        {
            await _accountDal.AddAsync(account, true);

        }

        
        public async Task DeleteAsync(int accountId)
        {
            await _accountDal.DeleteAsync(accountId, true);
        }

        public async Task<IList<Account>> GetAllAsync()
        {
            return await _accountDal.GetAllAsync();
        }

        public async Task<Account> GetByIdAsync(int accountId)
        {
            return await _accountDal.GetByIdAsync(accountId);
        }

        public async Task UpdateAsync(Account account)
        {
            await _accountDal.UpdateAsync(account, account.Id, true);
        }

     }
}
