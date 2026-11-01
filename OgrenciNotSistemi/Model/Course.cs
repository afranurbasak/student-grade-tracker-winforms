using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemi.Model
{
    internal class Course
    {
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int Kredi { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public string OgrenciNumarasi { get; set; }
        public double Ortalama => (Vize * 0.4) + (Final * 0.6);
        public string GectiMi => Ortalama >= 50 ? "Geçti" : "Kaldı";
    }
}
