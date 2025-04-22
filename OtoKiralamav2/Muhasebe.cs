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
    public partial class Muhasebe : Form
    {
        public Muhasebe()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list1()
        {
            var degerler = from x in db.TBLGELİR
                           select new
                           {
                               x.GelirID,
                               x.Adı,
                               x.Tarih,
                               x.İslem,
                               x.Tutar

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

            var toplam = degerler.Sum(x => x.Tutar);
            textBox1.Text = toplam.ToString();
        }
        private void list2()
        {

            var degerler = from x in db.TBLGİDER
                           select new
                           {
                               x.GiderID,
                               x.Adı,
                               x.Tarih,
                               x.İslem,
                               x.Tutar

                           };
            dataGridView2.DataSource = degerler.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);

            var toplam1 = degerler.Sum(x => x.Tutar);
            textBox2.Text = toplam1.ToString();
            
            

        }

        private void Muhasebe_Load(object sender, EventArgs e)
        {
            list1();
            list2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLGELİR
                           where x.Tarih >= dateTimePicker1.Value && x.Tarih <= dateTimePicker2.Value
                           select new
                           {
                               x.GelirID,
                               x.Adı,
                               x.Tarih,
                               x.İslem,
                               x.Tutar

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

            var toplam1 = degerler.Sum(x => x.Tutar);
            textBox1.Text = toplam1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kira = from x in db.TBLGİDER
                       where x.Tarih >= dateTimePicker4.Value && x.Tarih <= dateTimePicker3.Value
                       select new
                       {
                           x.GiderID,
                           x.Adı,
                           x.Tarih,
                           x.İslem,
                           x.Tutar
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
            var toplam = kira.Sum(x => x.Tutar);
            textBox2.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GelirEkle pt = new GelirEkle();
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
            GiderEkle pt = new GiderEkle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
