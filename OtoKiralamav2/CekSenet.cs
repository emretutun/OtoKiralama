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
    public partial class CekSenet : Form
    {
        public CekSenet()
        {
           
            InitializeComponent();
            
            
        }
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void CekSenet_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLÇEKSENET
                           where x.Firma.Contains(textBox1.Text)
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Türü,
                               x.Tutar,
                               x.Acıklama,
                               x.Durum,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ"
                           };
            dataGridView1.DataSource = degerler.ToList();
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺";
        }

        

       

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());//bu günün tarihi
            MessageBox.Show(bugun.ToString());
            var degerler = from x in db.TBLÇEKSENET
                           where (x.Tarihi) == bugun.Date && x.Durum == false
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Acıklama,
                               x.Türü,
                               x.Tutar,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ"
                           };
            dataGridView1.DataSource = degerler.ToList();
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺";
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime yarin = DateTime.Now.AddDays(1);//şimdiki güne kaç gün eklediysek o tarihi verir.
            MessageBox.Show(yarin.ToString());
            var degerler = from x in db.TBLÇEKSENET
                           where (x.Tarihi) == yarin.Date && x.Durum == false
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Acıklama,
                               x.Türü,
                               x.Tutar,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ"
                           };
            dataGridView1.DataSource = degerler.ToList();
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺";
        }
        public void listele()
        {
            var degerler = from x in db.TBLÇEKSENET
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Acıklama,
                               x.Türü,
                               x.Tutar,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ" // Durumu kontrol ediyoruz
                           };

            // DataGridView'i güncelliyoruz
            dataGridView1.DataSource = degerler.ToList();

            // Toplam tutarı güncelliyoruz
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int secid = int.Parse(label5.Text);
            var odenecekkayit = db.TBLÇEKSENET.Find(secid);
            odenecekkayit.Durum = true;
            db.SaveChanges();
            MessageBox.Show("ÖDEDİM");
            listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CEKSENETKAYIT pt = new CEKSENETKAYIT();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
            
        }

       
        private void button10_Click(object sender, EventArgs e)
        {
            int SECİD = int.Parse(label5.Text);
            var silinecekkayit = db.TBLÇEKSENET.Find(SECİD);
            db.TBLÇEKSENET.Remove(silinecekkayit);
            db.SaveChanges();
            MessageBox.Show("SİLDİM");
            listele();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int secid = int.Parse(label5.Text);
            var odenecekkayit = db.TBLÇEKSENET.Find(secid);
            odenecekkayit.Durum = false;
            db.SaveChanges();
            MessageBox.Show("ÖDENMEDİ OLARAK GÜNCELLEDİM");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int seccekkayit = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            label5.Text = seccekkayit.ToString();
            label3.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLÇEKSENET
                           where x.Tarihi >= dateTimePicker1.Value && x.Tarihi <= dateTimePicker2.Value
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Acıklama,
                               x.Türü,
                               x.Tutar,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ" // BİT KULLANDIĞIMIZ İÇİN EĞER FALSE İSE ÖDENMEDİ DEMEK.
                           };
            dataGridView1.DataSource = degerler.ToList();
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Durumu "ÖDENDİ" olan senetleri filtreliyoruz
            var degerler = from x in db.TBLÇEKSENET
                           where x.Durum == true  // Durumu "ÖDENDİ" olanları seçiyoruz
                           select new
                           {
                               x.çeksenetID,
                               x.Firma,
                               x.Tarihi,
                               x.Türü,
                               x.Tutar,
                               x.Acıklama,
                               Ödenme = x.Durum == false ? "ÖDENMEDİ" : "ÖDENDİ" // Durumu kontrol ediyoruz
                           };

            // Ödenen senetleri DataGridView'de gösteriyoruz
            dataGridView1.DataSource = degerler.ToList();
            txttoplam.Text = degerler.Sum(x => x.Tutar).ToString() + " ₺"; // Toplam tutarı gösteriyoruz
        }
    }
}
