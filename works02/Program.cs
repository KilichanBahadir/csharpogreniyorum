using System;

namespace works02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int a = int.Parse(Console.ReadLine());
            
            
            if (a < 10)
            {
                Console.WriteLine("Girilen sayı ondan küçüktür");


            }
            else if (a == 10) 
            {
                //Console.WriteLine("Girilen sayı ona eşittir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı ondan büyüktür");
            }
            
            switch (a%7) {
                
                case 6:
                    Console.WriteLine("{a} cumartesi");
                    break;
                case 0:
                    Console.WriteLine("{a} pazar");
                    break;
                default:
                    Console.WriteLine("hafta içi");
                    break;
                       

            }

        }
    }
}
