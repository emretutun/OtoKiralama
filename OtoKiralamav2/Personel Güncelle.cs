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
    public partial class Personel_Güncelle : Form
    {
        public Personel_Güncelle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personel_Güncelle_Load(object sender, EventArgs e)
        {
            var Kasa = from c in db.TBLPERSONEL
                       select new
                       {
                           c.PersID,
                           c.Adı,
                           c.Soyadı,
                           c.Telefon,
                           c.Adres,
                           c.Görevi,
                           c.Maaş
                       };
            dataGridView1.DataSource = Kasa.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int secpersid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            var pr = db.TBLPERSONEL.Find(secpersid);
            label4.Text = pr.PersID.ToString();
            txtad.Text = pr.Adı.ToString();
            txtsoyad.Text = pr.Soyadı.ToString();
            txtnot.Text = pr.Notu.ToString();
            txtgörev.Text = pr.Görevi.ToString();
            txtmaas.Text = pr.Maaş.ToString();
            txtadres.Text = pr.Adres.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var guncarac = db.TBLPERSONEL.Find(int.Parse(label4.Text));
            guncarac.Adı = txtad.Text;
            guncarac.Soyadı = txtsoyad.Text;
            guncarac.Adres = txtadres.Text;
            guncarac.BaşlangıçTarihi = dateTimePicker1.Value;
            guncarac.Görevi = txtgörev.Text;
            guncarac.Maaş = Convert.ToDecimal(txtmaas.Text);
            guncarac.Notu = txtnot.Text;
            db.SaveChanges();
            MessageBox.Show("Araç kaydınız güncellendi");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile
                    (openFileDialog1.FileName);
                    label7.Text = openFileDialog1.SafeFileName;
                    button1.Enabled = true;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
