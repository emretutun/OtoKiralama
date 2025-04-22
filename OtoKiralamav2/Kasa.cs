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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Para_Girişi pt = new Para_Girişi();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int seckasaid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silkasa = db.TBLKASA.Find(seckasaid);
            DialogResult cevap = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?", "Kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLKASA.Remove(silkasa);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void listele()
        {
            var Kasa = from c in db.TBLKASA
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
            textBox2.Text = Kasa.Sum(x => x.Miktar).ToString() + " ₺";
            textBox1.Text = Kasa.Sum(x => x.Miktar).ToString() + " ₺";

        
           
        }

        private void listele2()
        {
            var kira = from x in db.TBLKASACIKIS
                       //where x.Tarih >= dateTimePicker4.Value && x.Tarih <= dateTimePicker3.Value
                       select new
                       {
                           x.CiskisID,
                           x.Adı,
                           x.Tarih,
                           x.Islem,
                           x.Tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
            textBox3.Text = kira.Sum(x => x.Tutar).ToString() + " ₺";
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Kasa = from c in db.TBLKASA
                       where c.Tarih >= dateTimePicker1.Value && c.Tarih <= dateTimePicker2.Value
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
            KasaYedek pt = new KasaYedek();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string ara = textBox1.Text; // değişken tanımlandı
            var Kasa = from c in db.TBLKASA
                       where  c.Ad.Contains(ara)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            var kira = from x in db.TBLKASACIKIS
                           where x.Tarih >= dateTimePicker4.Value && x.Tarih <= dateTimePicker3.Value
                       select new
                       {
                           x.CiskisID,
                           x.Adı,
                           x.Tarih,
                           x.Islem,
                           x.Tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
            textBox3.Text = kira.Sum(x => x.Tutar).ToString() + " ₺";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLKASA
                           where c.Ad.Contains(ara) // durumu true olanları arıyıcak
                           select new
                           {
                               c.Ad,
                               c.Acıklama,
                               c.işlem,
                               c.Miktar,
                               c.Tarih
                           };
            dataGridView1.DataSource = degerler.ToList();
            
        }
    }
}
