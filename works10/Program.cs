using System;

namespace works10
{
    class Program

    {
        enum IdentityCard
            //enum liste  oluşturmayı sağlıyor
        {
           NufusCuzdani,
           SurucuBelgesi=9,
           Pasaport=15,

        }
        static void Main(string[] args)
        {
            IdentityCard myIdentityCard = IdentityCard.NufusCuzdani;
            Console.WriteLine("My Identitity Card is {0}",myIdentityCard);
            int myIdentityCard2 = (int)IdentityCard.Pasaport;
            Console.WriteLine("My Identitity Card type number is {0}", myIdentityCard2);
        }
    }
}
