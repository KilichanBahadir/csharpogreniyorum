using System;
using System.Collections.Generic;
using System.Text;

namespace deneme123
{
    public class Ogrenci
    {
        private int _ogrenciNo;
        private string _isim;
        private string _soyisim;

        public int OgrenciNo {
            get {
                return _ogrenciNo;
            }
            set {
                _ogrenciNo = value;
            }
        }
        public string Isim {
            get {
                return _isim;
            }
            set {
                _isim = value;
            }
        }

        public string Soyisim {
            get {
                return _soyisim;
            }
            set {
                _soyisim = value;
            }
        }
        public Ogrenci() { }
    }
}
