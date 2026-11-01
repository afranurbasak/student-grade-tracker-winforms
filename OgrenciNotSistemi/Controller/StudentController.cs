using OgrenciNotSistemi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace OgrenciNotSistemi.Controller
{

    internal class StudentController
    {
        private List<Student> ogrenciler = new List<Student>(); // öğrencileri tutan listeyi tanımladım

        public bool OgrenciEkle(Student s)
        {
            if (string.IsNullOrWhiteSpace(s.Numara) || string.IsNullOrWhiteSpace(s.Ad) || string.IsNullOrWhiteSpace(s.Soyad))
            {
                MessageBox.Show("Lütfen öğrenci bilgilerini eksiksiz girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // eksik bilgi varsa eklemeyi iptal ettim
            }

            if (ogrenciler.Any(o => o.Numara == s.Numara))
            {
                MessageBox.Show("Bu numaraya sahip bir öğrenci zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;  // aynı numarayla öğrenci varsa tekrar eklemeyi engelledim
            }


            ogrenciler.Add(s); // öğrenci bilgilerini listeye ekledim
            MessageBox.Show("Öğrenci eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void DersEkle(string numara, Course c)
        {
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Numara == numara);  // numaraya göre öğrenciyi buldum


            if (ogrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(c.DersKodu) || string.IsNullOrWhiteSpace(c.DersAdi))
            {
                MessageBox.Show("Ders adı ve kodu boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // boş ders bilgilerini kabul etmedim
            }

            if (ogrenci.Dersler.Any(d => d.DersKodu == c.DersKodu))
            {
                MessageBox.Show("Bu öğrenci bu dersi zaten alıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // aynı kodlu dersi bir daha almasına izin vermedim
            }


            if (ogrenci.Dersler.Any(d => d.DersAdi == c.DersAdi && d.DersKodu != c.DersKodu))
            {
                MessageBox.Show("Bu ders adı daha önce farklı bir ders koduyla eşleşmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // aynı ders adına farklı kod girilmişse hata verdim
            }

            c.OgrenciNumarasi = numara;   // derse öğrencinin numarasını atadım
            ogrenci.Dersler.Add(c);       // dersi öğrencinin ders listesine ekledim
            MessageBox.Show("Ders başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public List<Course> DersleriGetir(string numara)
        {
            return ogrenciler.FirstOrDefault(o => o.Numara == numara)?.Dersler ?? new List<Course>(); // numaraya göre öğrencinin derslerini getirdim

        }

        public List<Student> TumOgrenciler()
        {
            return ogrenciler;    // tüm öğrenci listesini döndürdüm
        }
    }
}
