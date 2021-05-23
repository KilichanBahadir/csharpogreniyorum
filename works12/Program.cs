using System;

namespace works12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            TurkishPerson tp1 = new TurkishPerson();
            // turkishperson.cs deki 14. satırdaki default constructure ı kullanarak 1. kişiye ait bilgileri girdik.
            tp1.Id = 2001137009;
            tp1.FirstName = "Bahadır";
            tp1.LastName = "Senbayrak";
            tp1.Address = "Aksaray";
            
            Console.WriteLine("id={0} ,isim={1}, soyisim={2}, adres={3}, uyruk={4}",tp1.Id,tp1.FirstName, tp1.LastName, tp1.Address, tp1.Nationality("TUR"));
            //turkishperson.cs deki 18. satırı kullanarak 2. kişiye ait bilgileri girdik.
            TurkishPerson tp2 = new TurkishPerson(2, "Yusuf", "Şahin", "Adana");
            Console.WriteLine("id={0} ,isim={1}, soyisim={2}, adres={3}, uyruk={4}", tp2.Id, tp2.FirstName, tp2.LastName, tp2.Address, tp2.Nationality("TUR"));
        }
    }
}
