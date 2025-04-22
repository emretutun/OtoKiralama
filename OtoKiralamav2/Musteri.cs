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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button1_Click(object sender, EventArgs e)
        {
            Müşteri_Ekle pt = new Müşteri_Ekle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listele()
        {
            var degerler = from x in db.TBLMUSTERİ
                           select new
                           {
                               x.MusteriID,
                               x.Adi,
                               x.Soyadi,
                               x.TcKimlik,

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);


            var kira = from c in db.TBLMUSTERİ
                       select new
                       {

                           c.Cinsiyeti,
                           c.DoğumTarihi,
                           c.Email,
                           c.CepTel,
                           c.Adres,
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Müşteri_Güncelle pt = new Müşteri_Güncelle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLMUSTERİ.Find(secaracid);
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\" + arac.MüşteriResim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secmusid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silmus = db.TBLMUSTERİ.Find(secmusid);
            DialogResult cevap = MessageBox.Show("kaydı silmek istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLMUSTERİ.Remove(silmus);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLMUSTERİ
                           where c.TcKimlik.Contains(ara)
                           select new
                           {
                               c.MusteriID,
                               c.Adi,
                               c.Soyadi,
                               c.TcKimlik
                               
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLMUSTERİ.Find(secaracid);
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\" + arac.MüşteriResim;
        }
    }
}
