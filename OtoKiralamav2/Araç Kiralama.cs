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
    public partial class Araç_Kiralama : Form
    {
        public Araç_Kiralama()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void listele()
        {
            var degerler = from x in db.TBLARAC
                           select new
                           {
                               x.AraçID,
                               DURUM = x.DURUM == false ? "KİRADA DEĞİL" : "KİRADA",
                               x.TBLMARKA.MarkaAd,
                               x.TBLMODEL.ModelAd,
                               x.MotorHacmi,
                               x.Fiyat,
                               x.Yıl,
                               x.Resim
                              
                           }; 
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\";
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

            var kira = from c in db.TBLKIRA
                       select new
                       {
                           c.kiraid,
                           c.TBLMUSTERİ.Adi,
                           c.TBLMUSTERİ.Soyadi,
                           c.TBLMARKA.MarkaAd,
                           c.TBLMODEL.ModelAd,
                           c.aracid,
                           c.tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);

            var musteri = from c in db.TBLMUSTERİ
                          select new
                          {
                              c.MusteriID,
                              c.Adi,
                              c.Soyadi,
                              c.CepTel
                          };
            dataGridView3.DataSource = musteri.ToList();
            dataGridView3.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView3.ForeColor = Color.Red;
            dataGridView3.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void Araç_Kiralama_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guncarac = db.TBLARAC.Find(int.Parse(txtaracid.Text));
            guncarac.DURUM = true;

            TBLKIRA fl = new TBLKIRA();
            fl.musteriid = int.Parse(txtmusid.Text);
            fl.markaid = int.Parse(txtmarkaid.Text);
            fl.modelid = int.Parse(txtmodelid.Text);
            fl.tutar = int.Parse(txtkiraucret.Text);
            fl.aracid = int.Parse(txtaracid.Text);
           
            

            db.TBLKIRA.Add(fl);
            TBLKASA ksa = new TBLKASA();
            ksa.işlem = "Kiralama";
            ksa.Tarih = dateTimePicker1.Value;
            ksa.Ad = "Erkan İnan";
            ksa.Acıklama = "Araç Kiraya Verildi";
            ksa.Miktar = Convert.ToDecimal(txtkiraucret.Text);
            db.TBLKASA.Add(ksa);
            db.SaveChanges();

            MessageBox.Show("Kiralama İşlemi Tamamlandı");
            listele();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLARAC.Find(secaracid);
            txtmarkaid.Text = arac.MarkaID.ToString();
            txtmarka.Text = arac.TBLMARKA.MarkaAd;
            txtmodel.Text = arac.TBLMODEL.ModelAd;
            txtfiyat.Text = arac.Fiyat.ToString();
            txtaracid.Text = arac.AraçID.ToString();
            txtmodelid.Text = arac.ModelID.ToString();
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\" + arac.Resim;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string ara = textBox1.Text; // değişken tanımlandı
            //var degerler = from c in db.TBLARAC
            //               where c.TBLMARKA.MarkaAd.Contains(ara)
            //               select new
            //               {
            //                   DURUM = c.DURUM == false ? "KİRADA DEĞİL" : "KİRADA",
            //                   c.AraçID,
            //                   c.TBLMARKA.MarkaAd,
            //                   c.TBLMODEL.ModelAd,
            //                   c.Yıl,
            //                   c.Fiyat,
            //                   c.MotorHacmi
            //               };
            //dataGridView1.DataSource = degerler.ToList();

           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var guncarac = db.TBLARAC.Find(int.Parse(txtaracid.Text));
            guncarac.DURUM = false;
            db.SaveChanges();

            int sec = dataGridView2.SelectedCells[0].RowIndex;
            int secmusid = int.Parse(dataGridView2.Rows[sec].Cells[0].Value.ToString());

            var silmus = db.TBLKIRA.Find(secmusid);
            DialogResult cevap = MessageBox.Show("kiradan almak istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLKIRA.Remove(silmus);
                db.SaveChanges();
                MessageBox.Show("Kiradan Alındı");
                listele();
            }
            listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView2.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLKIRA.Find(secaracid);
            txtmusid.Text = arac.kiraid.ToString();
            txtad.Text = arac.TBLMUSTERİ.Adi;
            txtsoyad.Text = arac.TBLMUSTERİ.Soyadi;
            txtfiyat.Text = arac.tutar.ToString();
            txtmarka.Text = arac.TBLMARKA.MarkaAd;
            txtmodel.Text = arac.TBLMODEL.ModelAd;
            txtaracid.Text = arac.aracid.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView3.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView3.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLMUSTERİ.Find(secaracid);
            txtmusid.Text = arac.MusteriID.ToString();
            txtad.Text = arac.Adi;
            txtsoyad.Text = arac.Soyadi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtfiyat.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            txtkiraucret.Text = Convert.ToString(sayi1 * sayi2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox3.Text; // değişken tanımlandı
            var degerler = from c in db.TBLMUSTERİ
                           where c.Adi.Contains(ara)
                           select new
                           {
                               c.MusteriID,
                               c.Adi,
                               c.Soyadi,
                               c.CepTel
                           };
            dataGridView3.DataSource = degerler.ToList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox4.Text; // değişken tanımlandı
            var degerler = from c in db.TBLKIRA
                           where c.TBLMUSTERİ.Adi.Contains(ara)
                           select new
                           {
                               c.kiraid,
                               c.TBLMUSTERİ.Adi,
                               c.TBLMUSTERİ.Soyadi,
                               c.TBLMARKA.MarkaAd,
                               c.TBLMODEL.ModelAd,
                               c.aracid,
                               c.tutar
                           };
            dataGridView3.DataSource = degerler.ToList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Musteri pt = new Musteri();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //string ara = textBox5.Text; // değişken tanımlandı
            //var degerler = from c in db.TBLARAC
            //               where c.Yıl.ToString().Contains(ara)
            //               select new
            //               {
            //                   DURUM = c.DURUM == false ? "KİRADA DEĞİL" : "KİRADA",
            //                   c.AraçID,
            //                   c.TBLMARKA.MarkaAd,
            //                   c.TBLMODEL.ModelAd,
            //                   c.Fiyat,
            //                   c.Yıl,
            //                   c.MotorHacmi
            //               };
            //dataGridView1.DataSource = degerler.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBox5.ToString());
            var degerler = from x in db.TBLARAC
                           where x.Yıl==a &&x.TBLMARKA.MarkaAd==textBox1.Text
                           select new
                           {
                               x.AraçID,
                               DURUM = x.DURUM == false ? "KİRADA DEĞİL" : "KİRADA",
                               x.TBLMARKA.MarkaAd,
                               x.TBLMODEL.ModelAd,
                               x.MotorHacmi,
                               x.Fiyat,
                               x.Yıl,
                               x.Resim

                           };
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\";
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
        }
    }
}
