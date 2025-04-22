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
    public partial class Para_Girişi : Form
    {
        public Para_Girişi()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLKASA ksa = new TBLKASA();
            ksa.işlem = txtişlem.Text;
            ksa.Tarih = dateTimePicker1.Value;
            ksa.Ad = txtişlemadı.Text;
            ksa.Acıklama = txtacıklama.Text;
            ksa.Miktar = Convert.ToDecimal(txtmiktar.Text);


            db.TBLKASA.Add(ksa);
            db.SaveChanges();
            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
        }

        private void Para_Girişi_Load(object sender, EventArgs e)
        {

        }
    }
}
