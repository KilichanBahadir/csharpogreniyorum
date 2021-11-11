using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Bal.Abstract;
using Works34.Dal.Abstract;
using Works34.Entities;

namespace Works34.Bal.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;     
        }

        public async Task AddAsync(Contact contact)
        {
            await _contactDal.AddAsync(contact, true);
            
        }

        public async Task DeleteAsync(int contactId)
        {
            await _contactDal.DeleteAsync(contactId, true);
        }

        public async Task<IList<Contact>> GetAllAsync()
        {
            return await _contactDal.GetAllAsync();
        }

        public async Task<Contact> GetByIdAsync(int contactId)
        {
            return await _contactDal.GetByIdAsync(contactId);
        }

        public async Task UpdateAsync(Contact contact)
        {
            await _contactDal.UpdateAsync(contact, contact.Id,true);
        }
    }
}
