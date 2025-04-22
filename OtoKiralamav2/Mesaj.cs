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
    public partial class Mesaj : Form
    {
        public Mesaj()
        {
            InitializeComponent();
        }
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        private void button1_Click(object sender, EventArgs e)
        {
            var bugun = DateTime.Now;
            var hatirlatmavarmi = db.TBLHATIRLATMA.Where(x => x.Tarih <= bugun & x.Durumu == true).ToList();
            hatirlatmavarmi.FirstOrDefault().Durumu = false;
            db.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hatırlatma pt = new Hatırlatma();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Çek_Senet pt = new Çek_Senet();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
            this.Close();
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {
            var bugun = DateTime.Now;
            var hatirlatmavarmi = db.TBLHATIRLATMA.Where(x => x.Tarih <= bugun & x.Durumu == true).ToList();

            if (hatirlatmavarmi.Count() == 1)
            {
                groupBox1.Visible = true;
                label2.Text = hatirlatmavarmi.FirstOrDefault().Acıklama;
            }
            if (hatirlatmavarmi.Count() > 1)
            {
                groupBox2.Visible = true;
                label4.Text = "HATIRLATMALARINIZA GÖZ ATIN.";
            }
            //3 gün içerisinde ödenecek çek senet kaydı varsa uyarı versin
            var ucgunsonra = DateTime.Now.AddDays(3);
            var cskayitlar = from x in db.TBLÇEKSENET
                             where x.Tarihi >= bugun && x.Tarihi <= ucgunsonra && x.Durum == false //ödenme durumu ödenmemiş olanları getir demek.
                             select x;
            if (cskayitlar.Count() != 0) //kayıt varsa
            {
                groupBox3.Visible = true;
                label5.Text = "3 gün içerisinde ödeme kaydınız var";
            }
        }
    }
}
