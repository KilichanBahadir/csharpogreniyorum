using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Models;

namespace Works31.DataAccess
{
    public interface IPersonelRepository
    {


        Task<List<Personel>> GetPersonels();
        Task<Personel> GetPersonelById(long id);
        Task<Personel> AddPersonel(Personel personel);
        Task<Personel> UpdatePersonel(Personel personel);
        Task<Boolean> isPersonelExist(long id);
        Task<Boolean> DeletePersonel(long id);
    }

}
