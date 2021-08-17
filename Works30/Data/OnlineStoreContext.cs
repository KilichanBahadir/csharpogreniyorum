using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works30.Models;

namespace Works30.Data
{
    public class OnlineStoreContext : DbContext
    {
      public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) :base(options)
        {

        }
    public DbSet<Product> Products { get; set; }

    }
}
