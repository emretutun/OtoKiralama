using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralamav2
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_Ekle pt = new Personel_Ekle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel_Güncelle pt = new Personel_Güncelle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            persmaasode pt = new persmaasode();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void listele()
        {
            var personel = from c in db.TBLPERSONEL
                           select new
                           {
                               c.PersID,
                               c.Adı,
                               c.Soyadı,
                               c.Telefon,
                               c.Adres,
                               c.Görevi,
                               c.Maaş,
                           };
            dataGridView2.DataSource = personel.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);

        }

        private void listele2()
        {
            var personel = from c in db.TBLPERSODEME
                           select new
                           {
                               c.OdemeID,
                               c.OdemeTuru,
                               c.OdemeTarihi,
                               c.Odenen,
                               c.TBLPERSONEL.Adı,

                           };
            dataGridView1.DataSource = personel.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
            var toplam1 = personel.Sum(x => x.Odenen);
            TXTMAAS.Text = toplam1.ToString();

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            listele();
            listele2();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secpersid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silpers = db.TBLPERSONEL.Find(secpersid);
            DialogResult cevap = MessageBox.Show("Seçili personeli silmek istediğinizden emin misiniz", "Personeli Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLPERSONEL.Remove(silpers);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLPERSONEL
                           where c.Adı.Contains(ara)
                           select new
                           {
                               c.Adı,
                               c.Soyadı,
                               c.Telefon,
                               c.Görevi

                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var odemeler = from c in db.TBLPERSODEME
                           select new
                           {
                               c.OdemeID,
                               c.OdemeTuru,
                               c.OdemeTarihi,
                               c.Odenen,
                               c.TBLPERSONEL.Adı
                           };
            dataGridView2.DataSource = odemeler.ToList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int secpersid = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());

            var kayit = db.TBLPERSODEME.Find(secpersid);
            int persid = Convert.ToInt32(kayit.PersID);

            var degerler = from c in db.TBLPERSODEME
                           where c.PersID == persid
                           select new
                           {
                               c.OdemeID,
                               c.OdemeTuru,
                               c.OdemeTarihi,
                               c.Odenen,
                               c.TBLPERSONEL.Adı
                           };
            dataGridView2.DataSource = degerler.ToList();



            var odemeler = from c in db.TBLPERSONEL
                           where c.PersID == persid
                           select new
                           {
                               c.PersID,
                               c.Adı,
                               c.Soyadı,
                               c.Telefon,
                               c.Adres,
                               c.Görevi,
                               c.Maaş
                           };
            dataGridView1.DataSource = odemeler.ToList();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var odemeler = from c in db.TBLPERSONEL
                           where c.BaşlangıçTarihi >= dateTimePicker1.Value && c.BaşlangıçTarihi <= dateTimePicker2.Value
                           select new
                           {
                               c.Adı,
                               c.Soyadı,
                               c.Telefon,
                               c.Görevi
                           };
            dataGridView1.DataSource = odemeler.ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satırın index numarasını al
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            // Seçilen satırdaki arac ID'sini al
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            // Veritabanından seçilen arac bilgilerini al
            var arac = db.TBLPERSONEL.Find(secaracid);

            // Eğer arac null ise, kullanıcıya bilgi ver ve fonksiyonu sonlandır
            if (arac == null)
            {
                MessageBox.Show("Seçilen personel bulunamadı.");
                return; // Null olduğunda işlemi sonlandır
            }

            // Eğer arac null değilse, resmi yükle
            string resimYolu = Path.Combine(@"C:\OtoKiralamav2\OtoKiralamav2\bin\Debug\Resimler", arac.Resim);

            // Resim dosyasının var olup olmadığını kontrol et
            if (File.Exists(resimYolu))
            {
                pictureBox1.ImageLocation = resimYolu;
            }
            else
            {
                MessageBox.Show("Resim bulunamadı: " + resimYolu);
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            PersonelAracVer pt = new PersonelAracVer();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }
    }
}