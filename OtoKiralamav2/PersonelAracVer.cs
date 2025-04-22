using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; 

namespace OtoKiralamav2
{
    public partial class PersonelAracVer : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public PersonelAracVer()
        {
            InitializeComponent();
        }
        public void satislistele()
        {
            var degerler = (from x in db.TBLSATISLAR
                            select new
                            {
                                x.SeansID,
                                x.KoltukNo,
                                x.Isim,
                                x.SatisTarihi,
                            }).OrderByDescending(x => x.SeansID);

            dataGridView1.DataSource = degerler.ToList();
        }
        private void PersonelAracVer_Load(object sender, EventArgs e)
        {
            satislistele();
            salongoster();
        }
        Button[] btn=new Button[21];
        void salongoster()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i < 20; i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(50,30);
                btn[i].Location = new Point(i*30+20,i*30+30);
                btn[i].Text = i.ToString();
                btn[i].Name = i.ToString();
                btn[i].BackColor = Color.Red;
                flowLayoutPanel1.Controls.Add(btn[i]);
                btn[i].Click += BiletSatis_Click;
            }
           
        }
        private void BiletSatis_Click(object sender , EventArgs e)
        {
            Button btn = sender as Button;
            txtarabano.Text = btn.Text;
            listBox1.Items.Add(btn.Text);

        }
        int seansid;

        void koltukrenklendir(int id)
        {
            List<string>koltuklar =((from x in db.TBLSATISLAR
                                      where x.Seans == id
                                      select x.KoltukNo.ToString()).ToList());
            foreach (var a in koltuklar)
            {
                int no = int.Parse(a);
                btn[no].BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                TBLSATISLAR s = new TBLSATISLAR();
                s.Isim = txtadsoyad.Text;
                s.KoltukNo = int.Parse(listBox1.Items[i].ToString());
                s.SatisTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                s.Seans = seansid;
                db.TBLSATISLAR.Add(s);
                db.SaveChanges();
                btn[int.Parse(listBox1.Items[i].ToString())].BackColor = Color.Red;

                
                db.SaveChanges();
            }
            salongoster();
            koltukrenklendir(seansid);
            satislistele();


            MessageBox.Show("Bilet Satıldı");

            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int secsatisid = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());

            var silineceksatis = db.TBLSATISLAR.Find(secsatisid);

            DialogResult cevap = MessageBox.Show("Seçilen satışı silmek istediğinizden eminmisiniz?", "Satışı sil", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                db.TBLSATISLAR.Remove(silineceksatis);
                db.SaveChanges();
                MessageBox.Show("Satışı Sildim");

            }

            salongoster();
            koltukrenklendir(seansid);
            satislistele();
            txtadsoyad.Clear();
            txtarabano.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
