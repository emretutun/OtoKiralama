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
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firma_Ekle pt = new Firma_Ekle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void load1()
        {
            var kira = from c in db.TBLFİRMA
                       select new
                       {
                           c.FirmaID,
                           c.FirmaAd,
                           c.Yetkili,
                           c.Adres,
                           c.Telefon,
                           c.Faks,
                           c.Eposta
                       };
            dataGridView1.DataSource = kira.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

            if (db.TBLARAC.Count() > 0)
            {
                var arac = db.TBLFİRMA.FirstOrDefault();
                txtad.Text = arac.FirmaAd.ToString();
                txtadres.Text = arac.Adres.ToString();
                txtfaks.Text = arac.Faks.ToString();
                txtmail.Text = arac.Eposta.ToString();
                txttelefon.Text = arac.Telefon.ToString();
                txtyetkili.Text = arac.Yetkili.ToString();
            }
        }

        private void load2()
        {
            var kira = from c in db.TBLFirmaUrun
                       select new
                       {
                           c.FirmaUrunID,
                           c.TBLFİRMA.FirmaAd,
                           c.UrunAd,
                           c.AlinmaTarihi,
                           c.Miktar,
                           c.Tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
            txtödenen.Text = kira.Sum(x => x.Tutar).ToString() + " ₺";
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            load1();
            load2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secfirmaid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var firma = db.TBLFİRMA.Find(secfirmaid); 
            txtad.Text = firma.FirmaAd.ToString();
            txtyetkili.Text = firma.Yetkili.ToString();
            txtadres.Text = firma.Adres.ToString();
            txttelefon.Text = firma.Telefon.ToString();
            txtfaks.Text = firma.Faks.ToString();
            txtmail.Text = firma.Eposta.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLFİRMA
                           where c.FirmaAd.Contains(ara)
                           select new
                           {
                               c.FirmaID,
                               c.FirmaAd,
                               c.Adres,
                               c.Yetkili,
                               c.Telefon,
                               c.Faks
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kira = from c in db.TBLFirmaUrun
                       where c.AlinmaTarihi >= dateTimePicker1.Value && c.AlinmaTarihi <= dateTimePicker2.Value
                       select new
                       {
                           c.FirmaUrunID,
                           c.TBLFİRMA.FirmaAd,
                           c.UrunAd,
                           c.AlinmaTarihi,
                           c.Miktar,
                           c.Tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Seçilen firma ID'sini almak
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int selectedFirmaID = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString());

            // Veritabanından ilgili firmayı bulmak
            var firmaToUpdate = db.TBLFİRMA.Find(selectedFirmaID);

            // Firma bulunamazsa hata mesajı
            if (firmaToUpdate == null)
            {
                MessageBox.Show("Firma bulunamadı.");
                return;
            }

            // Formdaki textBox'lardan yeni bilgileri alıp, ilgili firma kaydını güncelliyoruz
            firmaToUpdate.FirmaAd = txtad.Text;
            firmaToUpdate.Yetkili = txtyetkili.Text;
            firmaToUpdate.Adres = txtadres.Text;
            firmaToUpdate.Telefon = txttelefon.Text;
            firmaToUpdate.Faks = txtfaks.Text;
            firmaToUpdate.Eposta = txtmail.Text;

            // Değişiklikleri kaydediyoruz
            db.SaveChanges();

            // Güncelleme sonrası DataGridView'i yeniden yükleyerek güncel veriyi gösteriyoruz
            load1();

            // Kullanıcıya başarılı mesajı gösteriyoruz
            MessageBox.Show("Firma bilgileri güncellenmiştir.");
        }
    }
}
