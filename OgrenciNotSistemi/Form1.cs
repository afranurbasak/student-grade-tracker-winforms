using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciNotSistemi.Model;
using OgrenciNotSistemi.Controller;

namespace OgrenciNotSistemi
{
    public partial class Form1 : Form
    {
        StudentController controller = new StudentController(); // controller sınıfından bir nesne oluşturdum

        public Form1()
        {
            InitializeComponent(); // form bileşenlerini başlattım
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textbox'lardan alınan bilgilerle yeni bir öğrenci nesnesi oluşturdum
            Student s = new Student()
            {
                Ad = textBox1.Text,
                Soyad = textBox2.Text,
                Numara = textBox3.Text,
                Bolum = textBox4.Text
            };

            // öğrenci başarıyla eklendiyse combobox'lara numarasını ekledim
            if (controller.OgrenciEkle(s))
            {
                comboBox1.Items.Add(s.Numara); // ders eklemek için kullanılacak
                comboBox2.Items.Add(s.Numara); // listeleme için kullanılacak
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // önce öğrenci seçilip seçilmediğini kontrol ettim
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçin.");
                return;
            }

            // ders kodunu aldım ve geçerlilik kontrollerini yaptım
            string dersKodu = textBox6.Text.Trim();

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Lütfen ders kodunu girin.");
                return;
            }

            if (dersKodu.Length < 2 || dersKodu.Length > 7)
            {
                MessageBox.Show("Ders kodu en az 2, en fazla 7 karakter olmalıdır.");
                return;
            }

            // ders bilgileriyle yeni bir Course nesnesi oluşturdum
            Course c = new Course()
            {
                DersAdi = textBox5.Text,
                DersKodu = textBox6.Text,
                Kredi = (int)numericUpDown1.Value,
                Vize = (int)numericUpDown2.Value,
                Final = (int)numericUpDown3.Value
            };

            // seçilen öğrencinin numarasına göre dersi ekledim
            controller.DersEkle(comboBox1.SelectedItem.ToString(), c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
                return; // öğrenci seçilmemişse işlem yapmasın istedim

            string no = comboBox2.SelectedItem.ToString(); // seçilen öğrencinin numarasını aldım
            var dersler = controller.DersleriGetir(no); // öğrencinin ders listesini aldım
            dataGridView1.DataSource = null; // grid'i temizledim
            dataGridView1.DataSource = dersler; // ders listesini grid'e aktardım
        }

        // ad kutusuna sadece harf girilmesini sağladım kontrol işlemi yani
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ad alanına sadece harf girebilirsiniz.");
            }
        }

        // soyad kutusuna sadece harf girilmesini sağladım kontrol işlemi yani
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Soyad alanına sadece harf girebilirsiniz.");
            }
        }

        // numara kutusuna sadece rakam girilmesini sağladım kontrol işlemi yani
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numara alanına sadece rakam girebilirsiniz.");
            }
        }

        // bölüm kutusuna sadece harf girilmesini sağladım kontrol işlemi yani
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bölüm alanına sadece harf girebilirsiniz.");
            }
        }
    }
}
