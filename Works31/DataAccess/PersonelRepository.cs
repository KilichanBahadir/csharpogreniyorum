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

        public async Task<Personel> GetPersonelById(long id)
        {
            return await jobApplicationContext.Personels.FindAsync(id);
        }

        public async Task<List<Personel>> GetPersonels()

        {
            return await jobApplicationContext.Personels.ToListAsync();
            
        }

    }
}
