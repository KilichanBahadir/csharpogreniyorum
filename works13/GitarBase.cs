using System;
using System.Collections.Generic;
using System.Text;

namespace works13
{
    public abstract class GitarBase:IGitar
    {
        public int ID { get; set; }
        public int TelSayisi { get; set; }
        public int KulakSayisi { get; set; }
        public string KulakTipi { get; set; }
        public int KlavyeBasamakSayisi { get; set; }
        public string GövdeSekli { get; set; }
       

        public string SesVer(string nota)
        {

            if (nota == "A")
            {
                return "Naber La";
            }
            if (nota == "B")
            {
                return "Si";

            }
            if (nota == "C")
            {
                return "Do";
            }
            if (nota == "D")
            {
                return "Re";

            }
            if (nota == "E")
            {
                return "Mi";
            }
            if (nota == "F")
            {
                return "Fa";
            }
            if (nota == "G")
            {
                return "Sol";
            }
            return "SesYok";
        }


    }
}
