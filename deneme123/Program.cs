using System;

namespace deneme123
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = a + b;


            Console.WriteLine(c.ToString());
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciNo = 111;
            ogrenci1.Isim = "keremYigit";
            ogrenci1.Soyisim = "Senbayrak";
            Console.WriteLine(ogrenci1.OgrenciNo + ")" + ogrenci1.Isim + " " + ogrenci1.Soyisim);
        }
    }
}
