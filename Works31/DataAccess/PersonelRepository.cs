using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Data;
using Works31.Models;

namespace Works31.DataAccess
{
    public class PersonelRepository : IPersonelRepository

    {
        private readonly JobApplicationContext jobApplicationContext;
        public PersonelRepository(JobApplicationContext jobApplicationContext)
        {
            this.jobApplicationContext = jobApplicationContext;
        }

        public async Task<Personel> AddPersonel(Personel personel)
        {
           jobApplicationContext.Personels.AddAsync(personel);
            Personel p = new Personel();
            await jobApplicationContext.SaveChangesAsync();
            p.Id = personel.Id;
            p.Name = personel.Name;
            p.Nationality = personel.Nationality;
            p.Age = personel.Age;
            p.Gender = personel.Gender;
            return p;

        }

        public async Task<bool> DeletePersonel(long id)
        {
           if (!await isPersonelExist(id)) { return false; }
            try
            {
              Personel p = await jobApplicationContext.Personels.FindAsync(id);

              jobApplicationContext.Personels.Remove(p);
              await jobApplicationContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public async Task<Personel> GetPersonelById(long id)
        {
            return await jobApplicationContext.Personels.FindAsync(id);
        }

        public async Task<List<Personel>> GetPersonels()

        {
            return await jobApplicationContext.Personels.ToListAsync();
            
        }

        public async Task<bool> isPersonelExist(long id)
        {
            return await jobApplicationContext.Personels.AnyAsync(p=> p.Id == id);

  
        }

        public async Task<Personel> UpdatePersonel(Personel personel)
        {
           jobApplicationContext.Personels.Update(personel);
            Personel p = new Personel();
            await jobApplicationContext.SaveChangesAsync();
            p.Id = personel.Id;
            p.Name = personel.Name;
            p.Nationality = personel.Nationality;
            p.Age = personel.Age;
            p.Gender = personel.Gender;
            return p;

        }
    }
}
