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
    public partial class GiderEkle : Form
    {
        public GiderEkle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button1_Click(object sender, EventArgs e)
        {
            TBLGİDER fl = new TBLGİDER();
            fl.Adı = textBox1.Text;
            fl.Tarih = dateTimePicker1.Value;
            fl.İslem = textBox2.Text;
            fl.Tutar = Convert.ToDecimal(textBox3.Text);

            db.TBLGİDER.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");

            TBLKASACIKIS ksa = new TBLKASACIKIS();
            ksa.Islem = textBox2.Text;
            ksa.Tarih = dateTimePicker1.Value;
            ksa.Adı = textBox1.Text;
            ksa.Tutar = Convert.ToDecimal(textBox3.Text);
            db.TBLKASACIKIS.Add(ksa);
            db.SaveChanges();
            this.Close();
            this.Close();
            Muhasebe pt = new Muhasebe();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void GiderEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
