using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace works25
{
    public class EnstrumantContext:DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS; User Id=sa;Password=Provera@2016; Initial Catalog=EnstrumantDb");
        }
    }

}

