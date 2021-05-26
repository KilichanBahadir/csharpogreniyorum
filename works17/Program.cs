using System;
using System.IO;

namespace works17
{
    class Program
    {
        private static ConsoleKeyInfo cki;

        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Adınızı giriniz");
            Console.WriteLine("İsleminiz bitince Esc basiniz");
           /* do
            {
                
               sw.WriteLine(Console.ReadLine());
                cki = Console.ReadKey();
                // do something with each key press until escape key is pressed
            } while (cki.Key != ConsoleKey.Escape);
           */
            while (true)
            {
                string okunanSatir = Console.ReadLine();
                sw.WriteLine(okunanSatir);
                if (okunanSatir == "!")
                {
                    break;
                }
               
            }
           
            sw.Close();

            Console.WriteLine("Kayıt Eklendi.");
            Console.ReadKey();


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
