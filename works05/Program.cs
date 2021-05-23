using System;

namespace works05
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            string[] vwcars = { "volkswagen", "seat", "skoda", "lamborgini", "audi" };
            //Console.WriteLine("{0},{1},{2},{3},{4}",vwcars[0], vwcars[1], vwcars[2], vwcars[3], vwcars[4]);
            /* for (int i = 0; i < vwcars.Length; i++)
             {
                 Console.WriteLine(vwcars[i]);


             }*/
            //foreach(string car in vwcars)
            // {
            //Console.WriteLine(car);



            //}
           
            int[] yirmiyekadarciftsayilar = new int[10];
            // .length demek dizini içewrisindeki eleman sayısı kadar demek
            for (int i = 0; i <yirmiyekadarciftsayilar.Length ; i++)
            {
                yirmiyekadarciftsayilar[i] = (i+1) * 2;
                Console.WriteLine(yirmiyekadarciftsayilar[i]);
                

            }

            int[] yirmiyekadarciftsayilar2 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            Console.WriteLine(yirmiyekadarciftsayilar2[4]);
            //yirmiyekadarciftsayilar2[4] sadece köşeli parantez içerisindeki değeri yazdırıyor.  

            int[,] matris = new int[,] { { 1, 2, }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(matris[0, 0]);
            Console.WriteLine(matris[0, 1]);
            Console.WriteLine(matris[1, 0]);
            Console.WriteLine(matris[1, 1]);
            Console.WriteLine(matris[2, 0]);
            Console.WriteLine(matris[2, 1]);

            
            





        }
    }
}
