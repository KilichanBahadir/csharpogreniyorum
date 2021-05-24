using System;
using System.Collections.Generic;
using System.Text;

namespace works13
{
    public class BassGitar : GitarBase, IAksesuar
    {
        public int ManyetikSayisi { get; set; }

        public decimal TelKalinligi { get; set; }
        public bool JackVar { get ; set ; }
        public bool DistortionVar { get ; set ; }
        public bool AmfiVar { get ; set ; }
        public bool BoyunAskısıVar { get ; set ; }

        public BassGitar()
        {
        }

        public string SesKirlet(bool distortionAcik)
        {
            if (distortionAcik == true)
            {

                this.DistortionVar = true;
                return "Distourtion Açık, Ses Kirletildi";
            }
            this.DistortionVar = false;
            return "Distortion Kapalı Ses Temiz";
        }
    }
}
