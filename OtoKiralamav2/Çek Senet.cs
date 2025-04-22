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
    public partial class Çek_Senet : Form
    {
        public Çek_Senet()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listele()
        {
            var degerler = from x in db.TBLÇEKSENET
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tutar,
                               x.Tarihi,
                               x.Türü

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

        }

        private void Çek_Senet_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TBLÇEKSENET fl = new TBLÇEKSENET();
            fl.Tarihi = dateTimePicker1.Value;
            fl.Türü = txttur.Text;
            fl.Firma = txtfirma.Text;
            fl.Tutar = Convert.ToDecimal(txtödenecektutar.Text);
            fl.Acıklama = txtaciklama.Text;


            db.TBLÇEKSENET.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secçekid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silcek = db.TBLÇEKSENET.Find(secçekid);
            DialogResult cevap = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?", "Kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLÇEKSENET.Remove(silcek);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var guncarac = db.TBLÇEKSENET.Find(int.Parse(txtid.Text));
            guncarac.Türü = txttur.Text;
            guncarac.Tarihi = dateTimePicker1.Value;
            guncarac.Firma = txtfirma.Text;
            guncarac.Tutar = Convert.ToDecimal(txttur.Text);
            guncarac.Acıklama = txtaciklama.Text;
            db.SaveChanges();
            MessageBox.Show("kaydınız güncellendi");
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLÇEKSENET
                           where x.Tarihi >= dateTimePicker3.Value && x.Tarihi <= dateTimePicker2.Value
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tutar,
                               x.Tarihi,
                               x.Türü

                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLÇEKSENET
                           where c.Firma.Contains(ara) // durumu true olanları arıyıcak
                           select new
                           {
                               c.Türü,
                               c.Tarihi,
                               c.Firma,
                               c.Tutar,
                               c.Acıklama
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var degerler = from c in db.TBLÇEKSENET
                           where c.Tarihi >= dateTimePicker1.Value && c.Tarihi <= dateTimePicker2.Value
                           select new
                           {
                               c.Türü,
                               c.Tarihi,
                               c.Firma,
                               c.Tutar,
                               c.Acıklama
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var kayit = db.TBLÇEKSENET.Find(int.Parse(label4.Text));
            int firmaid = Convert.ToInt32(kayit.Firma);

            string tur = "";
            if (radioButton1.Checked)
            {
                tur = "cek";
            }
            if (radioButton2.Checked)
            {
                tur = "snt";
            }

            var degerler = from c in db.TBLÇEKSENET
                           //where c.Firma == firmaid && c.Türü == tur
                           select new
                           {
                               c.Türü,
                               c.Tarihi,
                               c.Firma,
                               c.Tutar,
                               c.Acıklama
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int seccekkayit = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            label4.Text = seccekkayit.ToString();
            label10.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int secid = int.Parse(label5.Text);
            var odenecekkayit = db.TBLÇEKSENET.Find(secid);
            odenecekkayit.Durum = true;
            db.SaveChanges();
            MessageBox.Show("ÖDEDİM");
            listele();
            //bu ödeme kasaya gelir olarak kaydedilsin.
            TBLGELİR g = new TBLGELİR();
            g.Adı = txtaciklama.Text;
            g.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            g.Tutar = int.Parse(txtödenecektutar.Text);
            db.TBLGELİR.Add(g);
            db.SaveChanges();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
