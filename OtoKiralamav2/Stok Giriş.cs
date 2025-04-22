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
    public partial class Stok_Giriş : Form
    {
        public Stok_Giriş()
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

        }

        private void Stok_Giriş_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = textBox1.Text; // değişken tanımlandı
            var degerler = from c in db.TBLFİRMA
                           where c.FirmaAd.Contains(ara)
                           select new
                           {
                               c.FirmaID,
                               c.FirmaAd,
                               c.Adres,
                               c.Yetkili,
                               c.Telefon,
                               c.Faks
                           };
        }
    }
}
