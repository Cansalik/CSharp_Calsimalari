using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Siniflar
{
    class Araba: ArabaDetay
    {
        public string Renk;
        public int Hiz;
        public double Motor;
        public char Durum;
        public int Fiyat;
        private int Yil;
        private string Marka;

        public int YIL
        {
            get { return Yil; }
            set { Yil = Math.Abs(value); }
        }


        public string Markasi 
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); } 
        }
    }
}
