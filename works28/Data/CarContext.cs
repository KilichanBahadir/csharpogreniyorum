using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using works28.Models;

namespace works28.Data
{
    public class CarContext: DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
