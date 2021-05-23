using System;

namespace works07
{
    class Program
    {

        static int Ussu(int a, int b)
        {
            int y = a;
            for (int i = 1; i < b; i++)
            {
                y = a * y;

            }
            return y;
        }
        
        //aynı isimdeki metodları çalıştırmak istediğimizde öncelik metodun kendi içinde olandır.(int Ussu)
            static void Main(string[] args)

        {
            Console.WriteLine(Ussu(2,3));

             int Ussu(int a, int b)
            {
                int y = a;
                for (int i = 1; i < b; i++)
                {
                    y = a * y;

                }
                return y;
            }
        }
    }
}
