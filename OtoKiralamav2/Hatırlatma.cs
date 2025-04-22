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
    public partial class Hatırlatma : Form
    {
        public Hatırlatma()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hatırlatma_Ekle pt = new Hatırlatma_Ekle();
            pt.TopLevel = false;
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            Panel pnl = frm.Controls["Panel1"] as Panel;
            pt.TopMost = true;
            pt.Show();
            pnl.Controls.Add(pt);
            pt.BringToFront();
        }
        
        private void listele()
        {
            var degerler = from x in db.TBLHATIRLATMA
                           select new
                           {
                               x.HatırlatmaID,
                               x.Tarih,
                               x.Acıklama
                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);

        }

        private void Hatırlatma_Load(object sender, EventArgs e)
        {
            listele();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            int sechatirlatmaid = int.Parse(dataGridView1.Rows[sec].Cells[0].Value.ToString());

            var silhatirlatma = db.TBLHATIRLATMA.Find(sechatirlatmaid);
            DialogResult cevap = MessageBox.Show("kaydı silmek istediğinizden emin misiniz?", "kaydı Sil", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                db.TBLHATIRLATMA.Remove(silhatirlatma);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLHATIRLATMA
                           where x.Tarih >= dateTimePicker1.Value && x.Tarih <= dateTimePicker2.Value
                           select new
                           {
                               x.HatırlatmaID,
                               x.Tarih,
                               x.Acıklama
                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
