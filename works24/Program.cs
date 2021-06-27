using System;
using System.Linq;

namespace works24
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UniversityContext())
            {
                // Note: Bu örnek, çalıştırmadan önce veritabanının oluşturulmasını gerektirir.

                // Create
                Console.WriteLine("Inserting a new Department");
                db.Add(new Department { Name = "Fizik" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a Department");


            }
            using (var db = new UniversityContext())
            {
                var department = db.Departments.Where(d => d.Name == "Fizik").FirstOrDefault();

                db.Add(new Student { FirstName = "Yusuf", LastName = "Şahin", StudentNumber = "20017050", DepartmentId = department.Id });
                db.SaveChanges();

            }
            Console.ReadLine();
        }
    }
}
