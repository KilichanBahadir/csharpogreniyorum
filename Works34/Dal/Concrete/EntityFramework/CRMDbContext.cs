using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Entities;

namespace Works34.Dal.Concrete.EntityFramework
{
    public class CRMDbContext:DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
