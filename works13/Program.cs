using System;

namespace works13
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektroGitar elektroGitarim = new ElektroGitar();
            elektroGitarim.ID = 1;
            elektroGitarim.KulakSayisi = 6;
            elektroGitarim.KulakTipi = "Metal";
            elektroGitarim.TelSayisi = 6;
            elektroGitarim.KlavyeBasamakSayisi = 24;
            elektroGitarim.GövdeSekli = "Elektro";
            elektroGitarim.ManyetikSayisi = 5;
            elektroGitarim.AmfiVar = true;
            elektroGitarim.BoyunAskısıVar = true;
            elektroGitarim.DistortionVar = true;
            elektroGitarim.JackVar = true;
            Console.WriteLine(elektroGitarim.SesVer("A"));
            Console.WriteLine(elektroGitarim.SesKirlet(true));


            KlasikGitar klasikGitarim = new KlasikGitar();
            klasikGitarim.ID = 2;
            klasikGitarim.KulakSayisi = 6;
            klasikGitarim.KulakTipi = "Tahta";
            klasikGitarim.TelSayisi = 6;
            klasikGitarim.KlavyeBasamakSayisi = 20;
            klasikGitarim.GövdeSekli = "Klasik";
            Console.WriteLine(klasikGitarim.SesVer("C"));

            BassGitar bassGitarim = new BassGitar();
            bassGitarim.ID = 3;
            bassGitarim.KulakSayisi = 4;
            bassGitarim.KulakTipi = "Metal";
            bassGitarim.TelSayisi = 4;
            bassGitarim.KlavyeBasamakSayisi = 26;
            bassGitarim.GövdeSekli = "Bass";
            bassGitarim.ManyetikSayisi = 3;
            bassGitarim.TelKalinligi = 1.2M;
            bassGitarim.AmfiVar = true;
            bassGitarim.BoyunAskısıVar = true;
            bassGitarim.DistortionVar = true;
            bassGitarim.JackVar = true;
            Console.WriteLine(bassGitarim.SesVer("E"));
            Console.WriteLine(bassGitarim.SesKirlet(false));
            Console.WriteLine(bassGitarim.DistortionVar.ToString());

            AkustikGitar akustikGitarim=new AkustikGitar();
            akustikGitarim.ID = 4;
            akustikGitarim.KulakSayisi = 6;
            akustikGitarim.KulakTipi = "Metal";
            akustikGitarim.TelSayisi = 6;
            akustikGitarim.KlavyeBasamakSayisi = 24;
            akustikGitarim.GövdeSekli = "Akustik";
            Console.WriteLine(akustikGitarim.SesVer("D"));

            //IGitar igitar = new IGitar() Not: interface ler inşa edilemez.

           // GitarBase myGitar = new AkustikGitar(); özünden nesne türetimi sağladık.



           








        }
    }
}
