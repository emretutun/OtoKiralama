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
    public partial class KasaYedek : Form
    {
        public KasaYedek()
        {
            InitializeComponent();
        }
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void kasagetir()
        {
            var gelirler = db.TBLKASA.ToList();
            dataGridView1.DataSource = gelirler;
            txttoplam1.Text = gelirler.Sum(x => x.Miktar).ToString() + " ₺";

            var giderler = db.TBLKASACIKIS.ToList();
            dataGridView2.DataSource = giderler;
            txttoplam2.Text = giderler.Sum(x => x.Tutar).ToString() + " ₺";
        }
        private void KasaYedek_Load(object sender, EventArgs e)
        {
            kasagetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLKASA g = new TBLKASA();
            g.Acıklama = textBox6.Text;
            g.Tarih = dateTimePicker1.Value;
            g.Miktar = Convert.ToDecimal(textBox1.Text);
            db.TBLKASA.Add(g);
            db.SaveChanges();
            kasagetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLKASA
                           where x.Tarih >= dateTimePicker3.Value && x.Tarih <= dateTimePicker4.Value //BURASI TARİH ARASINDA ARAMA.
                           select new
                           {
                               x.Acıklama,
                               x.Tarih,
                               x.Miktar
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TBLKASACIKIS y = new TBLKASACIKIS();
            y.Adı = textBox2.Text;
            y.Tarih = dateTimePicker6.Value;
            y.Tutar = Convert.ToDecimal(textBox3.Text);
            db.TBLKASACIKIS.Add(y);
            db.SaveChanges();
            kasagetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLKASACIKIS
                           where x.Tarih >= dateTimePicker5.Value && x.Tarih <= dateTimePicker2.Value //BURASI TARİH ARASINDA ARAMA.
                           select new
                           {
                               x.Adı,
                               x.Tarih,
                               x.Tutar
                           };
            dataGridView2.DataSource = degerler.ToList();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var Kasa = from c in db.TBLKASA
                       where c.Ad.Contains(ara)
                       select new
                       {
                           c.KasaID,
                           c.işlem,
                           c.Tarih,
                           c.Ad,
                           c.Acıklama,
                           c.Miktar
                       };
            dataGridView1.DataSource = Kasa.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var Kasa = from c in db.TBLKASACIKIS
                       where c.Adı.Contains(ara)
                       select new
                       {
                           c.CiskisID,
                           c.Adı,
                           c.Tarih,
                           c.Islem,
                           c.Tutar
                       };
            dataGridView2.DataSource = Kasa.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
