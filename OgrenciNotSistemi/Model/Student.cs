using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemi.Model
{
    internal class Student
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public string Bolum { get; set; }
        public List<Course> Dersler { get; set; } = new List<Course>();
    }
}
