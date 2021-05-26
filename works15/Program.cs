using System;
using System.IO;

namespace works15
{
    class Program
    {
        static void Main(string[] args)
        
        {

            Console.Write("Adınız : ");
            FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(Console.ReadLine());

            sw.Close();
            StreamReader sr = new StreamReader("C:\\deneme\\deneme.txt");
            Console.WriteLine(sr.ReadToEnd());
            Console.ReadKey();
        }
    }
}
