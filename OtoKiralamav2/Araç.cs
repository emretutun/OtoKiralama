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
    public partial class Araç : Form
    {
        public Araç()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listele()
        {
            var degerler = from x in db.TBLARAC
                           select new
                           {
                               x.AraçID,
                               x.TBLMARKA.MarkaAd,
                               x.TBLMODEL.ModelAd,
                               x.Renk,
                               x.MotorHacmi,
                               x.Kilometresi,
                               x.Resim
                           };
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\";
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

            if (db.TBLARAC.Count() > 0)
            {
                var arac = db.TBLARAC.FirstOrDefault();
                txtmarka.Text = arac.MarkaID.ToString();
                txtmodel.Text = arac.ModelID.ToString();
                txtmotor.Text = arac.MotorHacmi.ToString();
                txtrenk.Text = arac.Renk.ToString();
                txtkm.Text = arac.Kilometresi.ToString();
                txtid.Text = arac.AraçID.ToString();

                //dataGridView2.DataSource = odemeler.ToList();
                //decimal toplamodeme = Convert.ToDecimal(odemeler.Sum(x => x.TUTAR));
                //txtodeme.Text = toplamodeme.ToString();
            }


        }

        private void Araç_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araç_Ekle pt = new Araç_Ekle();
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
            var arac = db.TBLARAC.Find(secaracid);
            txtmarka.Text = arac.TBLMARKA.MarkaAd;
            txtmodel.Text = arac.TBLMODEL.ModelAd;
            txtkm.Text = arac.Kilometresi.ToString();
            txtrenk.Text = arac.Renk.ToString();
            txtmotor.Text = arac.MotorHacmi.ToString();
            txtid.Text = arac.AraçID.ToString();
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\" + arac.Resim;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silarac = db.TBLARAC.Find(secaracid);
            DialogResult cevap = MessageBox.Show("kaydı silmek istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLARAC.Remove(silarac);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var guncarac = db.TBLARAC.Find(int.Parse(txtid.Text));
            guncarac.TBLMARKA.MarkaAd = txtmarka.Text;
            guncarac.TBLMODEL.ModelAd = txtmodel.Text;
            guncarac.Renk= txtrenk.Text;
            guncarac.MotorHacmi = txtmotor.Text;
            guncarac.Kilometresi = txtkm.Text;
            db.SaveChanges();
            MessageBox.Show("Araç kaydınız güncellendi");
            listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLARAC
                           where c.TBLMARKA.MarkaAd.Contains(ara)
                           select new
                           {
                               c.AraçID,
                               c.TBLMARKA.MarkaAd,
                               c.TBLMODEL.ModelAd,
                               c.Renk,
                               c.MotorHacmi,
                               c.Kilometresi
                           };
            dataGridView1.DataSource = degerler.ToList();

            //yukarıyı da değiştirmeden listelemez önce yukarısının listelenesi lazım
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
