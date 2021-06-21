using System;
using System.IO;

namespace Works18
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            Student bs = new Student();
            Console.WriteLine("Öğrenci No  Girin");
            bs.StudentNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ÖğrenciAdı Girin");
            bs.FirstName = Console.ReadLine();
            Console.WriteLine("Öğrenci Soyadı  Girin");
            bs.LastName = Console.ReadLine();
         
            sw.WriteLine(bs.StringYap());
            sw.Close();
            Console.WriteLine("Kayıt Eklendi.");
            Console.ReadKey();
        }
    }
}
