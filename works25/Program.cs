using System;

namespace works25
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EnstrumantContext())
            {
                //elle tek tek properties girmek istersek bu şekilde yazarız.
                Console.WriteLine("Inserting a new guitar");
                Guitar myGuitar = new Guitar();
                Console.WriteLine("insert a name");
                myGuitar.Name = Console.ReadLine();
                Console.WriteLine("insert a Brand");
                myGuitar.Brand = Console.ReadLine();
                Console.WriteLine("insert a Model");
                myGuitar.Model = Console.ReadLine();
                Console.WriteLine("insert a Description");
                myGuitar.Description = Console.ReadLine();

                db.Add(myGuitar);
                db.SaveChanges();
            }
            //aşağıdaki şekilde de yapılabilir.
            //Console.WriteLine("Inserting a new guitar");
            //db.Add(new Guitar { Name = "Yamaha FZ-10", Brand = "Yamaha", Model = "FZ-10", Description = "Acustic, eigth string" });
            // db.SaveChanges();
            
        }
    }
}
