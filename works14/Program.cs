using System;
using System.IO;

namespace works14
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            Console.Write("Adınız : ");
            string adSoyad = Console.ReadLine();
            sw.WriteLine(adSoyad);
            sw.Close();
            Console.WriteLine("Kayıt Eklendi.");
            Console.ReadKey();

        }
    }
}
