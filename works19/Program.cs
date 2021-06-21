using System;
using System.IO;
using System.Collections.Generic;

namespace works19
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ys = new Student(7050, "Yusuf", "Sahin");
            Student bs = new Student(7009, "Bahadır", "Şenbayrak");
            Student ek = new Student(7020, "Elçin", "Koyuncu");
            Student gs = new Student(7010, "Gökçe", "Şenbyarak");
            Student ch=  new Student(7030, "Ceyda", "Hergül");
            Student eb = new Student(7040, "Emir", "Bestami");
            Student yk = new Student(7060, "Yakup", "Karaman");

            List <Student> fizikOgrencileri = new List<Student>();
            fizikOgrencileri.Add(ys);
            fizikOgrencileri.Add(bs);
            fizikOgrencileri.Add(gs);
            fizikOgrencileri.Add(ch);
            fizikOgrencileri.Add(ek);
            fizikOgrencileri.Add(eb);
            fizikOgrencileri.Add(yk);
            FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var student in fizikOgrencileri)
                
            {
                Console.WriteLine("{0}-{1} {2}", student.StudentNumber, student.FirstName, student.LastName);
                sw.WriteLine("{0}-{1} {2}",student.StudentNumber,student.FirstName,student.LastName);
                
            }
            sw.Close();
            


        }
    }
}
/*
FileStream fs = new FileStream("C:\\deneme\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Adınızı giriniz");
            Console.WriteLine("İsleminiz bitince Esc basiniz");
           /* do
            {
                
               sw.WriteLine(Console.ReadLine());
                cki = Console.ReadKey();
                // do something with each key press until escape key is pressed
            } while (cki.Key != ConsoleKey.Escape);
           
while (true)
{
    string okunanSatir = Console.ReadLine();
    sw.WriteLine(okunanSatir);
    if (okunanSatir == "!")
    {
        break;
    }

}

sw.Close();

Console.WriteLine("Kayıt Eklendi.");
Console.ReadKey();


StreamReader sr = new StreamReader("C:\\deneme\\deneme.txt");
string satir = "";
while (true)
{
    satir = sr.ReadLine();
    if (satir == null)
    {
        break;
    }
    Console.WriteLine(satir);
}

Console.ReadKey();
*/
