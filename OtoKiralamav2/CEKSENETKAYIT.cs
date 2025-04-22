using DevExpress.XtraWaitForm;
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
    public partial class CEKSENETKAYIT : Form
    {
        OtoKiralamav2Entities2 db = new OtoKiralamav2Entities2();
        public CEKSENETKAYIT()
        {
            InitializeComponent();

        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLÇEKSENET CS = new TBLÇEKSENET();
            CS.Tarihi = Convert.ToDateTime(dateTimePicker1.Value);
            CS.Acıklama = textBox1.Text;
            CS.Tutar = Convert.ToDecimal(txttutar.Text);
            CS.Firma = textBox2.Text;
            CS.Durum = true;
            CS.Durum = false;
            if (radioButton1.Checked)
            {
                CS.Türü = "çek";
            }

            if (radioButton2.Checked)
            {
                CS.Türü = "senet";
            }
            db.TBLÇEKSENET.Add(CS);
            db.SaveChanges();
            MessageBox.Show("ÇEK / SENET KAYDINIZ TAMAMLANDI.");
            
            this.Close();
            this.Close();
            CekSenet pt = new CekSenet();
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
            
        }

        private void CEKSENETKAYIT_Load(object sender, EventArgs e)
        {

        }
    }
}
