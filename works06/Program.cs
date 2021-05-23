using Matematik;
using System;

namespace works06
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Bir sayı giriniz");
            int x = int.Parse(Console.ReadLine());
            int faktoryel = 1;
            for (int i = 1; i <= x; i++)
            {
                faktoryel = faktoryel*i;
                Console.WriteLine("faktoryel={0}",faktoryel);
            }

            /*
            Console.WriteLine("adınızı giriniz.");
            string firstname = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz.");
            string lastname = Console.ReadLine();
            ismimiyaz(firstname, lastname);
            //int z = 2;
            int f = Usislem.Ussu(2, 3);
            Console.WriteLine(f);
            int k = Usislem.Ussu(5, 4);
            Console.WriteLine(k);

        }
        // int fonksiyona işlem yaptırıyor.
        static int ikikati(int a) 

        {
            return a * 2;
            
        }
        //void de ise sadece return (dönüş )değeri olmadan çalışıyor.
        static void ismimiyaz(string ad,string soyad)
        {
            Console.WriteLine("ismim: {0},{1}'dir.", ad, soyad);
*/

        }
       
    }


}
