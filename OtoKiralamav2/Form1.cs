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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button13_Click(object sender, EventArgs e)
        {
            Hatırlatma pt = new Hatırlatma();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stok_Giriş pt = new Stok_Giriş();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri pt = new Musteri();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Firma pt = new Firma();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personel pt = new Personel();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            STOK pt = new STOK();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kasa pt = new Kasa();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Günlük_Harcama pt = new Günlük_Harcama();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Muhasebe pt = new Muhasebe();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Araç pt = new Araç();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Araç_Kiralama pt = new Araç_Kiralama();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CekSenet  pt = new CekSenet();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    var bugun = DateTime.Now;
        //    var hatirlatmavarmi = db.TBLHATIRLATMA.Where(x => x.Tarih <= bugun & x.Durumu == true).ToList(); //sql de durumu olduğu için true olanları istiyo.

        //    var ucgunsonra = DateTime.Now.AddDays(3);
        //    var cskayitlar = from x in db.TBLÇEKSENET
        //                     where x.Tarihi >= bugun && x.Tarihi <= ucgunsonra && x.Durum == false //ödenme durumu ödenmemiş olanları getir demek.
        //                     select x;

        //    if (hatirlatmavarmi.Count() != 0 || cskayitlar.Count() != 0)
        //    {
        //        Mesaj pt = new Mesaj();
        //        pt.TopLevel = false;
        //        Form1 frm = Application.OpenForms["Form1"] as Form1;
        //        Panel pnl = frm.Controls["Panel1"] as Panel;
        //        pt.TopMost = true;
        //        pt.Show();
        //        pnl.Controls.Add(pt);
        //        pt.BringToFront();
        //    }
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < panel1.Controls.Count; i++)
        //    {
        //        ((Form)panel1.Controls[0]).Close();
        //    }
        }
    }
}
