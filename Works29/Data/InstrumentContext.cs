using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works29.Data;
using Works29.Models;

namespace Works29.Data
{
    public class InstrumentContext:DbContext

    {
        public InstrumentContext(DbContextOptions<InstrumentContext> options):base(options)
        {

        }
        public DbSet<Instrument> Instruments { get; set; }
    }
}
