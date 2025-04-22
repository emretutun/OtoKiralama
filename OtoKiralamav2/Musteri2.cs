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
    public partial class Musteri2 : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public Musteri2()
        {
            InitializeComponent();
        }

        private void Musteri2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            var degerler = from x in db.TBLMUSTERİ
                           select new
                           {
                               x.Adi,
                               x.Soyadi,
                               x.TcKimlik,

                           };
            dataGridView1.DataSource = degerler.ToList();
            dataGridView1.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Font = new Font("arial", 13, FontStyle.Bold);


            var kira = from c in db.TBLMUSTERİ
                       select new
                       {

                           c.Cinsiyeti,
                           c.DoğumTarihi,
                           c.Email,
                           c.CepTel,
                           c.Adres,
                       };
            dataGridView2.DataSource = kira.ToList();
            dataGridView2.Font = new Font("verdana", 12, FontStyle.Bold);
            dataGridView2.ForeColor = Color.Red;
            dataGridView2.Font = new Font("arial", 13, FontStyle.Bold);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
