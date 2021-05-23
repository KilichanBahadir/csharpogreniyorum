using System;

namespace works03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 6;
            while (a <= 5) 
            {
                Console.WriteLine(a);
                a++;
              
            }
            int b = 7;
            //do döngüsünde en az döngüde 1 kere çalışır.koşul olsun olmasın.
            do
            {
                Console.WriteLine(b);
                b++;

            } while (b < 6);

            //foreach döngüsü bir sonraki derste görülecek. 
            //koşullu for kullanımı
            for (int i = 0; i <= 10; i=i+1)

            {
                Console.WriteLine(i);
           
            }
            int z = 0;
            //koşulsuz for, sonsuz döngü  sağlıyor.
            for ( ; ; ) 
            {
                //if ve break diyerek bir koşul oluşturup koşula uydurarak döngüden çıkamsını sağlıyoruz.
            if (z > 10) 
             {
                    break;
             }
                Console.WriteLine(z++);
            if (z == 5)
             {
             Console.WriteLine("z değeri {0} olmuştur",z);
             continue;
             }

                
                
            }

            Console.WriteLine(Math.Pow(9, (Math.Sqrt(4))));
            Console.WriteLine(Math.Pow(8, 0.3333333333333333));
        }

    }
}
