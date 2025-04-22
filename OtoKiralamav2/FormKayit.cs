using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralamav2
{
    public partial class FormKayit : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public FormKayit()
        {
            InitializeComponent();

        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKayitKullaniciAdi.Text;
            string sifre = txtKayitSifre.Text;
            string sifreTekrar = txtKayitSifreTekrar.Text;

            // Kullanıcı adı ve şifre boş mu diye kontrol et
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Şifrelerin eşleşip eşleşmediğini kontrol et
            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyin.");
                return;
            }

            // Şifrenin uzunluğunu kontrol et (6 karakterden fazla olmalı)
            if (sifre.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter uzunluğunda olmalıdır.");
                return;
            }

            // Aynı kullanıcı adı var mı kontrol et
            var mevcutKullanici = db.TBLGIRIS.FirstOrDefault(k => k.usr == kullaniciAdi);
            if (mevcutKullanici != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı giriniz.");
                return;
            }

            // Yeni kullanıcı oluştur ve veritabanına ekle
            TBLGIRIS yeniKullanici = new TBLGIRIS();
            yeniKullanici.usr = kullaniciAdi;
            yeniKullanici.pwd = sifre;

            db.TBLGIRIS.Add(yeniKullanici);
            db.SaveChanges();

            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");



        }
    }
}
