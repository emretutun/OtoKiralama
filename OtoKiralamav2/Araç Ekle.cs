using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralamav2
{
    public partial class Araç_Ekle : Form
    {
        public Araç_Ekle()
        {
            InitializeComponent();
        }

        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Araç_Ekle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {

            var sorgu = from c in db.TBLMARKA
                        select c;
            comboBox1.DataSource = sorgu.ToList();
            comboBox1.ValueMember = "MarkaID";
            comboBox1.DisplayMember = "MarkaAd";

            var sorguu = from d in db.TBLMODEL
                         select d;
            comboBox2.DataSource = sorguu.ToList();
            comboBox2.ValueMember = "ModelID";
            comboBox2.DisplayMember = "ModelAd";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni araç oluşturuluyor
                TBLARAC fl = new TBLARAC();
                fl.MarkaID = Convert.ToInt32(comboBox1.SelectedValue); // MarkaID'yi al
                fl.Renk = txtrenk.Text;
                fl.MotorHacmi = txtmotor.Text;
                fl.Kilometresi = txtkm.Text;
                fl.ModelID = Convert.ToInt32(comboBox2.SelectedValue); // ModelID'yi al
                fl.Resim = label3.Text;  // Fotoğrafın adını kaydediyoruz

                // Resmin kaydedileceği dizin kontrolü
                string resimDizin = Application.StartupPath + "\\Resimler\\";
                if (!Directory.Exists(resimDizin))
                {
                    Directory.CreateDirectory(resimDizin);  // Dizin yoksa oluşturuyoruz
                }

                // Resmi kaydediyoruz
                pictureBox1.Image.Save(Path.Combine(resimDizin, label3.Text), System.Drawing.Imaging.ImageFormat.Jpeg);

                // Veritabanına kaydetme işlemi
                db.TBLARAC.Add(fl);
                db.SaveChanges();

                MessageBox.Show("Kayıt Tamamlandı");
                this.Close();

                // Araç listesine yönlendirme
                Araç pt = new Araç();
                pt.TopLevel = false;
                Form1 frm = Application.OpenForms["Form1"] as Form1;
                Panel pnl = frm.Controls["Panel1"] as Panel;
                pt.TopMost = true;
                pt.Show();
                pnl.Controls.Add(pt);
                pt.BringToFront();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriyoruz
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    label3.Text = Path.GetFileName(openFileDialog1.FileName);  // Fotoğrafın adını label3'e atıyoruz
                    button1.Enabled = true;
                }
            }
            catch (Exception)
            {
                // Hata durumunda gerekli işlem yapılabilir.
                MessageBox.Show("Bir hata oluştu.");
            }
        }



    }
 }

