using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoKiralamav2
{
    public partial class Kiralama2 : Form
    {
        public Kiralama2()
        {
            InitializeComponent();
        }
        string baglanti = "Data Source=DESKTOP-U70UINJ;Initial Catalog= KIRALAMA;Integrated Security=True";
        void dtMusteri_Doldur()
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("SELECT * FROM KIRA ", baglan))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtMusteri.DataSource = dt;
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());

                    }
                }
            }
        }
        void dtGArac_Doldur()
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {

                using (SqlCommand komut = new SqlCommand("SELECT * FROM ARAC", baglan))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtGArac.DataSource = dt;
                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }

                }
            }
        }
        void cmbMarka_Doldur()
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {

                using (SqlCommand komut = new SqlCommand("SELECT DISTINCT(Marka) FROM ARAC ORDER BY Marka", baglan))
                {
                    try
                    {
                        baglan.Open();
                        SqlDataReader oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            cmbmarka.Items.Add(oku.GetValue(0).ToString());
                        }
                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        baglan.Close();
                    }

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtMusteri_Doldur();
            dtGArac_Doldur();
            cmbMarka_Doldur();

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("SELECT MAd AD, MSoyad SOYAD, MTel TEL, MAdres ADRES FROM MUSTERI WHERE MAd LIKE'" + txtad.Text + "%' ORDER BY MAd ", baglan))
                {

                    try
                    {
                        baglan.Open();
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtMusteri.DataSource = dt;

                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Text = "";
            cmbmodel.Items.Clear();
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("SELECT Model FROM ARAC WHERE Marka='" + cmbmarka.Text + "'ORDER BY Model", baglan))
                {
                    try
                    {
                        baglan.Open();
                        SqlDataReader oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            cmbmodel.Items.Add(oku.GetValue(0).ToString());
                        }
                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void btntslet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("dbo.AracTeslimEt", baglan))
                {
                    try
                    {
                        komut.Parameters.AddWithValue("@MAd", txtad.Text);
                        komut.Parameters.AddWithValue("@MSoyad", txtsoyad.Text);
                        komut.Parameters.AddWithValue("@TCKimlikNo", txtTcKimlik.Text);
                        komut.Parameters.AddWithValue("@MAdres", txtadres.Text);
                        komut.Parameters.AddWithValue("@MTel", txttelefon.Text);
                        komut.Parameters.AddWithValue("@Plaka", btnplaka.Text);
                        komut.CommandType = CommandType.StoredProcedure;
                        baglan.Open();
                        komut.ExecuteNonQuery();
                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
            dtMusteri_Doldur();
        }

        private void btntslal_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("dbo.AracTeslimAl", baglan))
                {

                    try
                    {
                        komut.Parameters.AddWithValue("@Plaka", btnplaka.Text);


                        komut.CommandType = CommandType.StoredProcedure;

                        baglan.Open();

                        komut.ExecuteNonQuery();

                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());

                    }

                    finally
                    {
                        baglan.Close();
                    }

                }

            }
        }
        int Musteri_Id;
        bool Kirada = false;
        private void cmbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglan = new SqlConnection(baglanti))
            {
                using (SqlCommand komut = new SqlCommand("SELECT Plaka,Fiyat,Kirada FROM ARAC WHERE Marka=@Marka AND Model=@Model", baglan))
                {
                    try
                    {
                        baglan.Open();
                        komut.Parameters.AddWithValue("@Marka", cmbmarka.Text);
                        komut.Parameters.AddWithValue("@Model", Convert.ToInt32(cmbmodel.Text));
                        SqlDataReader oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            btnplaka.Text = oku.GetValue(0).ToString();
                            btnfiyat.Text = oku.GetValue(1).ToString();
                            Kirada = Convert.ToBoolean(oku.GetValue(2).ToString());


                        }
                        oku.Close();
                        if (Kirada)
                        {
                            btnkirada.Visible = true;
                            using (SqlCommand musteri = new SqlCommand("SELECT dbo.Musteri(@Plaka) FROM MUSTERI", baglan))
                            {
                                try
                                {
                                    musteri.CommandType = CommandType.StoredProcedure;
                                    musteri.Parameters.AddWithValue("@Plaka", btnplaka.Text);
                                    Musteri_Id = Convert.ToInt32(musteri.ExecuteScalar());
                                    using (SqlCommand MusBilgi = new SqlCommand("SELECT * FROM MUSTERI WHERE Musteri_Id=@Musteri_Id", baglan))
                                    {
                                        try
                                        {
                                            MusBilgi.Parameters.AddWithValue("@Musteri_Id", Musteri_Id);
                                            SqlDataReader MusBilgiOku = MusBilgi.ExecuteReader();
                                            while (MusBilgiOku.Read())
                                            {
                                                txtad.Text = MusBilgiOku.GetValue(1).ToString();
                                                txtsoyad.Text = MusBilgiOku.GetValue(2).ToString();
                                                txtTcKimlik.Text = MusBilgiOku.GetValue(5).ToString();
                                                txtadres.Text = MusBilgiOku.GetValue(3).ToString();
                                                txttelefon.Text = MusBilgiOku.GetValue(4).ToString();
                                            }
                                        }
                                        catch (SqlException se)
                                        {

                                            MessageBox.Show(se.ToString());
                                        }
                                    }

                                }
                                catch (SqlException se)
                                {

                                    MessageBox.Show(se.ToString());
                                }

                            }
                        }
                        else
                        {
                            btnkirada.Visible = false;
                        }
                    }
                    catch (SqlException se)
                    {

                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }
        private void dtMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dtMusteri.CurrentRow.Cells[0].Value.ToString();
            txtsoyad.Text = dtMusteri.CurrentRow.Cells[1].Value.ToString();
            txtTcKimlik.Text = dtMusteri.CurrentRow.Cells[2].Value.ToString();
            txttelefon.Text = dtMusteri.CurrentRow.Cells[3].Value.ToString();
        }

        private void Kiralama2_Load(object sender, EventArgs e)
        {

            dtMusteri_Doldur();
            dtGArac_Doldur();
            cmbMarka_Doldur();
        }

        private void dtMusteri_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // txtad.Text = dtMusteri.CurrentRow.Cells[1].Value.ToString();
            //cmbmarka.Text = dtMusteri.CurrentRow.Cells[2].Value.ToString();
            //txtTcKimlik.Text = dtMusteri.CurrentRow.Cells[3].Value.ToString();
           // txttelefon.Text = dtMusteri.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

