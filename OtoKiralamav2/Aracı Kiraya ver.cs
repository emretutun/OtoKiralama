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
    public partial class Aracı_Kiraya_ver : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public Aracı_Kiraya_ver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listele()
        {

            var sorgu = from c in db.TBLMUSTERİ
                        select c;
            cmbmusteri.DataSource = sorgu.ToList();
            cmbmusteri.ValueMember = "MusteriID";
            cmbmusteri.DisplayMember = "Adi";

            var sorguu = from d in db.TBLMARKA
                         select d;
            cmbmarka.DataSource = sorguu.ToList();
            cmbmarka.ValueMember = "MarkaID";
            cmbmarka.DisplayMember = "MarkaAd";

            var sorguuu = from d in db.TBLMODEL
                         select d;
            cmbmodel.DataSource = sorguuu.ToList();
            cmbmodel.ValueMember = "ModelID";
            cmbmodel.DisplayMember = "ModelAd";
        }

        private void Aracı_Kiraya_ver_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TBLKIRA fl = new TBLKIRA();
            fl.musteriid =Convert.ToInt32(cmbmusteri.SelectedValue);
            fl.markaid = Convert.ToInt32(cmbmarka.SelectedValue);
            fl.modelid = Convert.ToInt32(cmbmodel.SelectedValue);
            fl.tutar = Convert.ToDecimal(txttutar.Text);

            db.TBLKIRA.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }
    }
}
