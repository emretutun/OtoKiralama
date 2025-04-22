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
    public partial class Personel_Ekle : Form
    {
        public Personel_Ekle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personel_Ekle_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            TBLPERSONEL fl = new TBLPERSONEL();
            fl.Adı = txtad.Text;
            fl.Soyadı = txtsoyad.Text;
            fl.BaşlangıçTarihi = dateTimePicker1.Value;
            fl.Notu = txtnot.Text;
            fl.Görevi = txtgörev.Text;
            fl.Maaş = Convert.ToDecimal(txtmaas.Text);
            fl.Adres = txtadres.Text;

            db.TBLPERSONEL.Add(fl);
            db.SaveChanges();

            
            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TBLPERSONEL fl = new TBLPERSONEL();
            fl.Adı = txtad.Text;
            fl.Soyadı = txtsoyad.Text;
            fl.Notu = txtnot.Text;
            fl.BaşlangıçTarihi = dateTimePicker1.Value;
            fl.Görevi = txtgörev.Text;
            fl.Maaş = Convert.ToDecimal(txtmaas.Text);
            fl.Adres = txtadres.Text;


            db.TBLPERSONEL.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }
    }
}
