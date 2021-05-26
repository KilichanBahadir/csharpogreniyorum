using System;
using System.IO;

namespace works16
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\deneme\\deneme.txt");
            string satir = "";
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }
                Console.WriteLine(satir);
            }

            Console.ReadKey();
            
        }
    }
}
