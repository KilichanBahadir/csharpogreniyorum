using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works32.Models;

namespace Works32.DataAccess
{
     public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }


    }
    
}
