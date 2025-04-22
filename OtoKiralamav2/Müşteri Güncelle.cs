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
    public partial class Müşteri_Güncelle : Form
    {
        public Müşteri_Güncelle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBLMUSTERİ fl = new TBLMUSTERİ();
            fl.Adi = txtad.Text;
            fl.Soyadi = txtsoyad.Text;
            fl.DoğumTarihi = dateTimePicker1.Value;
            fl.Cinsiyeti = txtcinsiyet.Text;
            fl.Email = txtmail.Text;
            fl.CepTel = txttel.Text;
            fl.TcKimlik = txttc.Text;

            db.TBLMUSTERİ.Add(fl);
            db.SaveChanges();

            pictureBox1.Image.Save(Application.StartupPath + "\\Resimler" + openFileDialog1.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }

        private void Müşteri_Güncelle_Load(object sender, EventArgs e)
        {
            var kira = from c in db.TBLMUSTERİ
                       select new
                       {

                           c.MusteriID,
                           c.Adi,
                           c.Soyadi,
                           c.CepTel,
                           c.Cinsiyeti,
                           c.DoğumTarihi,
                           c.Email,
                           c.TcKimlik,
                           c.Adres,
                       };
            dataGridView1.DataSource = kira.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secaracid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var arac = db.TBLMUSTERİ.Find(secaracid);
            pictureBox1.ImageLocation = Application.StartupPath + "\\Resimler\\" + arac.MüşteriResim;
            txtad.Text = arac.Adi;
            txtsoyad.Text = arac.Soyadi;
            txttel.Text = arac.CepTel;
            txtcinsiyet.Text = arac.Cinsiyeti;
            dateTimePicker1.Value = Convert.ToDateTime(arac.DoğumTarihi);
            txtmail.Text = arac.Email;
            txttc.Text = arac.TcKimlik;
            txtadres.Text = arac.Adres;
        }
    }
}
