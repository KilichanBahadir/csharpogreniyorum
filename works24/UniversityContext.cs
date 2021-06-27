
using Microsoft.EntityFrameworkCore;

namespace works24
{
    public class UniversityContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=.\SQLEXPRESS; User Id=sa;Password=Provera@2016; Initial Catalog=UniDb");

    }
}
