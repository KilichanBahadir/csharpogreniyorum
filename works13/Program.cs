using System;

namespace works13
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektroGitar elektroGitarim = new ElektroGitar();
            elektroGitarim.KulakSayisi = 6;
            elektroGitarim.KulakTipi = "Metal";
            elektroGitarim.TelSayisi = 6;
            elektroGitarim.KlavyeBasamakSayisi = 24;
            elektroGitarim.GövdeSekli = "Elektro";
            elektroGitarim.ManyetikSayisi = 5;
            Console.WriteLine(elektroGitarim.SesVer("A"));


            KlasikGitar klasikGitarim = new KlasikGitar();
            klasikGitarim.KulakSayisi = 6;
            klasikGitarim.KulakTipi = "Tahta";
            klasikGitarim.TelSayisi = 6;
            klasikGitarim.KlavyeBasamakSayisi = 20;
            klasikGitarim.GövdeSekli = "Klasik";
            Console.WriteLine(klasikGitarim.SesVer("C"));

            BassGitar bassGitarim = new BassGitar();
            bassGitarim.KulakSayisi = 4;
            bassGitarim.KulakTipi = "Metal";
            bassGitarim.TelSayisi = 4;
            bassGitarim.KlavyeBasamakSayisi = 26;
            bassGitarim.GövdeSekli = "Bass";
            bassGitarim.ManyetikSayisi = 3;
            bassGitarim.TelKalinligi = 1.2M;
            Console.WriteLine(bassGitarim.SesVer("E"));

            AkustikGitar akustikGitarim=new AkustikGitar();
            akustikGitarim.KulakSayisi = 6;
            akustikGitarim.KulakTipi = "Metal";
            akustikGitarim.TelSayisi = 6;
            akustikGitarim.KlavyeBasamakSayisi = 24;
            akustikGitarim.GövdeSekli = "Akustik";
            Console.WriteLine(akustikGitarim.SesVer("D"));
           








        }
    }
}
