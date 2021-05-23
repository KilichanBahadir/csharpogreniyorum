using System;

namespace works04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" a,b ve c değerlerini giriniz");
          
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //casting işlemi(kesirli değeri tam sayı dsedğerine çevirdik)
            int delta = (int)Math.Pow(b, 2) - (4 * a * c);
            
            if (delta > 0) {
                double x1 = (-b + Math.Sqrt(delta))/(2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 değeri={0}", x1);
                Console.WriteLine("x2 değeri={0}", x2);


            }
           if (delta < 0)
            {
                Console.WriteLine("çözüm yoktur.");

            }

            if (delta == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("x değeri={0}", x);


            }

          
        }
    }
}
