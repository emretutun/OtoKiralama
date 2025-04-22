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
    public partial class STOK : Form
    {
        public STOK()
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
            StokEkle pt = new StokEkle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }
        public void stokgetir()
        {
            var degerler = from x in db.TBLURUN
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.KATEGORI,
                               x.MARKASI,
                               x.ALISFIYATI,
                               x.SATISFIYATI,
                               x.STOKADET,
                               x.TUTAR
                           };
            dataGridView2.DataSource = degerler.ToList();
            var toplam = degerler.Sum(x => x.TUTAR);
            txtodeme.Text = toplam.ToString();


            var odemeler = from x in db.TBLFIRMAODEME
                           select new
                           {
                               x.ID,
                               x.FIRMAADI,
                               x.TARIH,
                               x.MIKTAR,
                               x.ACIKLAMA
                           };
            dataGridView3.DataSource = odemeler.ToList();
            var toplam1 = odemeler.Sum(x => x.MIKTAR);
            txtod.Text = toplam1.ToString();

            var kalan = toplam - toplam1;
            txtkalan.Text = kalan.ToString();

        }

        private void STOK_Load(object sender, EventArgs e)
        {
            stokgetir();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            int securunid = int.Parse(dataGridView2.Rows[secilen].Cells[0].Value.ToString());

            var kayit = db.TBLURUN.Find(securunid);
            int firmaid = Convert.ToInt32(kayit.FIRMA);

            var degerler = from x in db.TBLURUN
                           where x.FIRMA == firmaid
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.TBLKATEGORI.KATEGORIAD,
                               x.MARKASI,
                               x.ALISFIYATI,
                               x.SATISFIYATI,
                               x.STOKADET,
                               x.TUTAR
                           };
            dataGridView2.DataSource = degerler.ToList();
            var toplam = degerler.Sum(x => x.TUTAR);
            txtodeme.Text = toplam.ToString();


            var odemeler = from x in db.TBLFIRMAODEME
                           where x.ID == firmaid
                           select new
                           {
                               x.ID,
                               x.FIRMAADI,
                               x.TARIH,
                               x.MIKTAR,
                               x.ACIKLAMA
                           };
            dataGridView3.DataSource = odemeler.ToList();
            var toplam1 = odemeler.Sum(x => x.MIKTAR);
            txtod.Text = toplam1.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            int secmusid = int.Parse(dataGridView2.Rows[sec].Cells[0].Value.ToString());

            var silmus = db.TBLURUN.Find(secmusid);
            DialogResult cevap = MessageBox.Show("ürünü silmek istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLURUN.Remove(silmus);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                stokgetir();
            }
        }
    }
}
