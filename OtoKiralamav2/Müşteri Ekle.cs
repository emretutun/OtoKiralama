using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OtoKiralamav2
{
    public partial class Müşteri_Ekle : Form
    {
        public Müşteri_Ekle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    label1.Text = openFileDialog1.SafeFileName;  // Fotoğraf adını label1'e atıyoruz
                    button1.Enabled = true;
                }
            }
            catch (Exception)
            {
                // Hata durumunda gerekli işlem yapılabilir.
                MessageBox.Show("Bir hata oluştu.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni müşteri oluşturuluyor
                TBLMUSTERİ fl = new TBLMUSTERİ();
                fl.Adi = txtad.Text;
                fl.Soyadi = txtsoyad.Text;
                fl.DoğumTarihi = dateTimePicker1.Value;
                fl.Cinsiyeti = txtcinsiyet.Text;
                fl.Email = txtmail.Text;
                fl.CepTel = txttel.Text;
                fl.TcKimlik = txttc.Text;
                fl.Adres = txtadres.Text;
                fl.MüşteriResim = label1.Text;  // Fotoğrafın adını MüşteriResim alanına kaydediyoruz

                // Resmin kaydedileceği dizin kontrolü
                string resimDizin = Application.StartupPath + "\\Resimler\\";
                if (!Directory.Exists(resimDizin))
                {
                    Directory.CreateDirectory(resimDizin);  // Dizin yoksa oluşturuyoruz
                }

                // Resmi kaydediyoruz
                pictureBox1.Image.Save(resimDizin + openFileDialog1.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Veritabanına kaydetme işlemi
                db.TBLMUSTERİ.Add(fl);
                db.SaveChanges();

                MessageBox.Show("Kayıt Tamamlandı");
                this.Close();
                this.Close();
                Musteri pt = new Musteri();
                pt.TopLevel = false;
                Form1 frm = Application.OpenForms["Form1"] as Form1;
                Panel pnl = frm.Controls["Panel1"] as Panel;
                pt.TopMost = true;
                pt.Show();
                pnl.Controls.Add(pt);
                pt.BringToFront();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriyoruz
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Müşteri_Ekle_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox'a tıklanması durumunda yapılacak işlemler
        }
    }
}
