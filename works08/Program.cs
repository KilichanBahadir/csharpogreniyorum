using System;

namespace works08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            
            Console.WriteLine("sonuc={0}", faktoriyel(sayi));
            static int faktoriyel(int a)
            {
                int sonuc = 1;
                for (int i = 1; i <= a; i++)

                {
                    sonuc = sonuc * i;


                }
                return sonuc;




            }



        }


    }
}
