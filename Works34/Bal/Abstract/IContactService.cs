using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Entities;

namespace Works34.Bal.Abstract
{
    public interface IContactService
    {
        Task<IList<Contact>> GetAllAsync();
        Task AddAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task DeleteAsync(int contactId);
        Task<Contact> GetByIdAsync(int contactId);

    }
}
