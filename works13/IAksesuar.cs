using System;
using System.Collections.Generic;
using System.Text;

namespace works13
{
    public interface IAksesuar
    {
        public bool JackVar { get; set; }
        public bool DistortionVar { get; set; }
        public bool AmfiVar { get; set; }
        public bool BoyunAskısıVar { get; set; }

        public string SesKirlet(bool distortionAcik);

    }
}
