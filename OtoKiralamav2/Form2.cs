using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralamav2
{
    public partial class Form2 : Form
    {
        // DbContext örneğini oluşturuyoruz
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Veritabanı üzerinden kontrol yapıyoruz
            var kullanici = db.TBLGIRIS
                              .FirstOrDefault(k => k.usr == kullaniciAdi && k.pwd == sifre);

            // Eğer kullanıcı bulunduysa giriş başarılı
            if (kullanici != null)
            {
                MessageBox.Show("GİRİŞ İŞLEMİ BAŞARILI");
                this.Hide(); // Form2'yi gizle
                             // Form1'i aç
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("GİRİŞ İŞLEMİ BAŞARISIZ OLDU. LÜTFEN TEKRAR DENEYİNİZ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Eğer başlangıçta bir işlem yapılacaksa buraya ekleyebilirsiniz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKayit formKayit = new FormKayit();
            formKayit.Show();
            
        }
    }
}
