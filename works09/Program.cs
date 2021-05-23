using System;

namespace works09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Bir sayı giriniz");
            int a = int.Parse(Console.ReadLine());
            int faktoriyelsonuc = faktoriyel(a);
            int ussonuc = ussu(a, a);
            int islemsonuc = ussonuc - faktoriyelsonuc;
            Console.WriteLine("islemsonuc={0}", islemsonuc);
            Console.WriteLine("sonuc={0}", faktoriyel(a));
            Console.WriteLine("Ussu sonuc={0}", ussu(a,a));
            
        }
        //fibonaççi serisi yaızalacak. 1+1+2+3+5+8+13 bu seriyi yaz.
        static int faktoriyel(int sayi)
        {
            if (sayi == 0)
                return 1;
            else

                return sayi * faktoriyel(sayi - 1);



        }
        static int ussu(int taban,int us)
        {
            if (us == 0)
                return 1;
            else
                return taban * ussu(taban, us - 1);


            

        }

    }
}
