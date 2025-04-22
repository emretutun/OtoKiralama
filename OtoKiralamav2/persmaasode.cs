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
    public partial class persmaasode : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public persmaasode()
        {
            InitializeComponent();
        }

        private void listele()
        {
            var sorgu = from s in db.TBLPERSONEL
                        select s;
            comboBox1.DataSource = sorgu.ToList();
            comboBox1.ValueMember = "PersID";
            comboBox1.DisplayMember = "Adı";
        }

        private void persmaasode_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLPERSODEME pr = new TBLPERSODEME();
            pr.PersID = Convert.ToInt32(comboBox1.SelectedValue);
            pr.Odenen = Convert.ToDecimal(txtmaas.Text);
            pr.OdemeTarihi = dateTimePicker1.Value;
            if (radioButton1.Checked)
            {
                pr.OdemeTuru = "Maaş";
            }
            if (radioButton2.Checked)
            {
                pr.OdemeTuru = "İkramiye";
            }
            db.TBLPERSODEME.Add(pr);
            db.SaveChanges();
            MessageBox.Show("Yeni personel kaydınız yapıldı");
            this.Close();
        }
    }
}
