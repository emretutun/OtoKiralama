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
    public partial class Firma_Ekle : Form
    {
        public Firma_Ekle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLFİRMA ksa = new TBLFİRMA();
            ksa.FirmaAd = txtad.Text;
            ksa.Yetkili = txtyetkili.Text;
            ksa.Adres = txtadres.Text;
            ksa.Telefon = txttelefon.Text;
            ksa.Faks = txtfaks.Text;
            ksa.Eposta = txteposta.Text;

            db.TBLFİRMA.Add(ksa);
            db.SaveChanges();
            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }

        private void Firma_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
