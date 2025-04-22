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
    public partial class Günlük_Harcama : Form
    {
        public Günlük_Harcama()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button3_Click(object sender, EventArgs e)
        {
            Kasa pt = new Kasa();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Harcama_Ekle pt = new Harcama_Ekle();
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
            var degerler = from x in db.TBLGÜNLÜKHARCAMA
                           select new
                           {
                               x.HarcamaID,
                               x.HarcananYer,
                               x.Tarih,
                               x.Acıklama,
                               x.Tutar

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
            var toplam1 = degerler.Sum(x => x.Tutar);
            txttoplam.Text = toplam1.ToString();

            //db.TBLGÜNLÜKHARCAMA.Where(x => x.HarcamaID == id).ToList();

            //dataGridView1.DataSource = günlükharcama.ToList();
            //decimal toplamveresiye = Convert.ToDecimal(günlükharcama.Sum(x => x.TUTAR));
            //txttoplam.Text = toplam.ToString() + "  ₺"; // kalan tutarı yazdık.
        }

        private void Günlük_Harcama_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secharcamaid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silhatirlatmaid = db.TBLGÜNLÜKHARCAMA.Find(secharcamaid);
            DialogResult cevap = MessageBox.Show("kaydı silmek istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLGÜNLÜKHARCAMA.Remove(silhatirlatmaid);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLGÜNLÜKHARCAMA
                           where x.Tarih >= dateTimePicker1.Value && x.Tarih <= dateTimePicker2.Value
                           select new
                           {
                               x.HarcamaID,
                               x.HarcananYer,
                               x.Tarih,
                               x.Acıklama,
                               x.Tutar

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
            var toplam1 = degerler.Sum(x => x.Tutar);
            txttoplam.Text = toplam1.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
