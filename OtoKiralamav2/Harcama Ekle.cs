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
    public partial class Harcama_Ekle : Form
    {
        public Harcama_Ekle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void Harcama_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLGÜNLÜKHARCAMA fl = new TBLGÜNLÜKHARCAMA();
            fl.Tarih = dateTimePicker1.Value;
            fl.Acıklama = txtaciklama.Text;
            fl.HarcananYer = txtyer.Text;
            fl.Tutar = Convert.ToDecimal(txtmiktar.Text);

            db.TBLGÜNLÜKHARCAMA.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            TBLKASACIKIS g = new TBLKASACIKIS();
            g.Adı = txtaciklama.Text;
            g.Tarih = dateTimePicker1.Value;
            g.Tutar = int.Parse(txtmiktar.Text);
            db.TBLKASACIKIS.Add(g);
            db.SaveChanges();
           
            this.Close();
            this.Close();
            Günlük_Harcama pt = new Günlük_Harcama();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();

        }
    }
}
