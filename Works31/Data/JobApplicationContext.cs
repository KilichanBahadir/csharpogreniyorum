using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Models;

namespace Works31.Data
{
    public class JobApplicationContext:DbContext
    {
        public JobApplicationContext(DbContextOptions<JobApplicationContext> options) : base(options)
        {

        }
        public DbSet<Personel> Personels { get; set; }


    }
}
