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
    public partial class Hatırlatma_Ekle : Form
    {
        public Hatırlatma_Ekle()
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
            TBLHATIRLATMA fl = new TBLHATIRLATMA();
            fl.Tarih = dateTimePicker1.Value;
            fl.Acıklama = txtaciklama.Text;
           

            db.TBLHATIRLATMA.Add(fl);
            db.SaveChanges();

            MessageBox.Show("Kayıt Tamamlandı");
            this.Close();
            this.Close();
            Hatırlatma pt = new Hatırlatma();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void Hatırlatma_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
