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
    public partial class StokEkle : Form
    {
        public StokEkle()
        {
            InitializeComponent();
        }
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void StokEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {

            var sorgu = from c in db.TBLKATEGORI
                        select c;
            comboBox1.DataSource = sorgu.ToList();
            comboBox1.ValueMember = "KATEGORIID";
            comboBox1.DisplayMember = "KATEGORIAD";

            var sorguu = from d in db.TBLFİRMA
                         select d;
            comboBox2.DataSource = sorguu.ToList();
            comboBox2.ValueMember = "FirmaID";
            comboBox2.DisplayMember = "FirmaAd";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLURUN fl = new TBLURUN();
            fl.URUNAD = txtad.Text;
            fl.MARKASI = txtmarka.Text;
            fl.KATEGORI = Convert.ToInt32(comboBox1.SelectedValue);
            fl.FIRMA = Convert.ToInt32(comboBox2.SelectedValue);
            fl.ALISFIYATI = Convert.ToDecimal(txtalıs.Text);
            fl.SATISFIYATI = Convert.ToDecimal(txtsatıs.Text);
            //fl.STOKADET = txtstokadet.Text;
            fl.TUTAR = Convert.ToDecimal(txttutar.Text);

            db.TBLURUN.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }
    }
}
