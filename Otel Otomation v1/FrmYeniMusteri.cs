using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Automation_v1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HotelDb; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "15";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda1_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "1";
        }

        private void BtnOda2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "2";
        }

        private void BtnOda3_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "3";
        }

        private void BtnOda4_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "4";
        }

        private void BtnOda5_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "5";
        }

        private void BtnOda6_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "6";
        }

        private void BtnOda7_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7";
        }

        private void BtnOda8_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "8";
        }

        private void BtnOda9_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "9";

        }

        private void BtnOda10_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "10";
        }

        private void BtnOda11_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "11";
        }

        private void BtnOda12_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "12";
        }

        private void BtnOda13_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "13";
        }

        private void BtnOda14_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "14";
        }

        private void BtnOda16_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "15";
        }


        private void BtnOdaBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi Renkli Butonlar Boş Odaları Gösterir");
        }

        private void BtnOdaDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime girisTarihi = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime cikisTarihi = Convert.ToDateTime(DtpCikisTarihi.Text);

            //timespan aradaki gün farkını hesaplar
            TimeSpan fark = cikisTarihi - girisTarihi;
            label11.Text = fark.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 90;
            TxtUcret.Text = ucret.ToString();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values(@Adi,@Soyadi,@Cinsiyet,@Telefon,@Mail,@TC,@OdaNo,@Ucret,@GirisTarihi,@CikisTarihi)", connection);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtKimlikNo.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Kaydedildi");
            connection.Close();
            connection.Open();
            SqlCommand komut_2 = new SqlCommand("insert into Oda" + TxtOdaNo.Text + " (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", connection);
            komut_2.ExecuteNonQuery();
            connection.Close(); 
        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //1. ODa
            connection.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda1", connection);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                BtnOda1.Text = reader1["Adi"].ToString() + " " + reader1["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda1.Text != "Oda 1")
            {
                BtnOda1.BackColor = Color.Red;
                BtnOda1.Enabled = false;
            }
            //2. Oda
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda2", connection);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                BtnOda2.Text = reader2["Adi"].ToString() + " " + reader2["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda2.Text != "Oda 2")
            {
                BtnOda2.BackColor = Color.Red;
                BtnOda2.Enabled = false;
            }
            //3.Oda

            connection.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Oda3", connection);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                BtnOda3.Text = reader3["Adi"].ToString() + " " + reader3["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda3.Text != "Oda 3")
            {
                BtnOda3.BackColor = Color.Red;
                BtnOda3.Enabled = false;
            }

            //4.Oda

            connection.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Oda4", connection);
            SqlDataReader reader4 = komut4.ExecuteReader();
            while (reader4.Read())
            {
                BtnOda4.Text = reader4["Adi"].ToString() + " " + reader4["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda4.Text != "Oda 4")
            {
                BtnOda4.BackColor = Color.Red;
                BtnOda4.Enabled = false;
            }

            //5.Oda

            connection.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Oda5", connection);
            SqlDataReader reader5 = komut5.ExecuteReader();
            while (reader5.Read())
            {
                BtnOda5.Text = reader5["Adi"].ToString() + " " + reader5["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda5.Text != "Oda 5")
            {
                BtnOda5.BackColor = Color.Red;
                BtnOda5.Enabled = false;
            }

            //6.Oda

            connection.Open();
            SqlCommand komut6 = new SqlCommand("Select * from Oda6", connection);
            SqlDataReader reader6 = komut6.ExecuteReader();
            while (reader6.Read())
            {
                BtnOda6.Text = reader6["Adi"].ToString() + " " + reader6["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda6.Text != "Oda 6")
            {
                BtnOda6.BackColor = Color.Red;
                BtnOda6.Enabled = false;
            }
            //7.Oda

            connection.Open();
            SqlCommand komut7 = new SqlCommand("Select * from Oda7", connection);
            SqlDataReader reader7 = komut7.ExecuteReader();
            while (reader7.Read())
            {
                BtnOda7.Text = reader7["Adi"].ToString() + " " + reader7["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda7.Text != "Oda 7")
            {
                BtnOda7.BackColor = Color.Red;
                BtnOda7.Enabled = false;
            }

            //8.Oda

            connection.Open();
            SqlCommand komut8 = new SqlCommand("Select * from Oda8", connection);
            SqlDataReader reader8 = komut8.ExecuteReader();
            while (reader8.Read())
            {
                BtnOda8.Text = reader8["Adi"].ToString() + " " + reader8["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda8.Text != "Oda 8")
            {
                BtnOda8.BackColor = Color.Red;
                BtnOda8.Enabled = false;
            }
            //9.Oda

            connection.Open();
            SqlCommand komut9 = new SqlCommand("Select * from Oda9", connection);
            SqlDataReader reader9 = komut9.ExecuteReader();
            while (reader9.Read())
            {
                BtnOda9.Text = reader9["Adi"].ToString() + " " + reader9["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda9.Text != "Oda 9")
            {
                BtnOda9.BackColor = Color.Red;
                BtnOda9.Enabled = false;
            }
            //10.Oda

            connection.Open();
            SqlCommand komut10 = new SqlCommand("Select * from Oda10", connection);
            SqlDataReader reader10 = komut10.ExecuteReader();
            while (reader10.Read())
            {
                BtnOda10.Text = reader10["Adi"].ToString() + " " + reader10["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda10.Text != "Oda 10")
            {
                BtnOda10.BackColor = Color.Red;
                BtnOda10.Enabled = false;
            }
            //11.Oda

            connection.Open();
            SqlCommand komut11 = new SqlCommand("Select * from Oda11", connection);
            SqlDataReader reader11 = komut11.ExecuteReader();
            while (reader11.Read())
            {
                BtnOda11.Text = reader11["Adi"].ToString() + " " + reader11["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda11.Text != "Oda 11")
            {
                BtnOda11.BackColor = Color.Red;
                BtnOda11.Enabled = false;
            }
            //12.Oda

            connection.Open();
            SqlCommand komut12 = new SqlCommand("Select * from Oda12", connection);
            SqlDataReader reader12 = komut12.ExecuteReader();
            while (reader12.Read())
            {
                BtnOda12.Text = reader12["Adi"].ToString() + " " + reader12["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda12.Text != "Oda 12")
            {
                BtnOda12.BackColor = Color.Red;
                BtnOda12.Enabled = false;
            }
            //13.Oda

            connection.Open();
            SqlCommand komut13 = new SqlCommand("Select * from Oda13", connection);
            SqlDataReader reader13 = komut13.ExecuteReader();
            while (reader13.Read())
            {
                BtnOda13.Text = reader13["Adi"].ToString() + " " + reader13["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda13.Text != "Oda 13")
            {
                BtnOda13.BackColor = Color.Red;
                BtnOda13.Enabled = false;
            }
            //14.Oda

            connection.Open();
            SqlCommand komut14 = new SqlCommand("Select * from Oda14", connection);
            SqlDataReader reader14 = komut14.ExecuteReader();
            while (reader14.Read())
            {
                BtnOda14.Text = reader14["Adi"].ToString() + " " + reader14["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda14.Text != "Oda 14")
            {
                BtnOda14.BackColor = Color.Red;
                BtnOda14.Enabled = false;
            }
            //15.Oda

            connection.Open();
            SqlCommand komut15 = new SqlCommand("Select * from Oda15", connection);
            SqlDataReader reader15 = komut15.ExecuteReader();
            while (reader15.Read())
            {
                BtnOda15.Text = reader15["Adi"].ToString() + " " + reader15["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda15.Text != "Oda 15")
            {

                BtnOda15.BackColor = Color.Red;
                BtnOda15.Enabled = false;
            }
            //16.Oda

            connection.Open();
            SqlCommand komut16 = new SqlCommand("Select * from Oda16", connection);
            SqlDataReader reader16 = komut16.ExecuteReader();
            while (reader16.Read())
            {
                BtnOda16.Text = reader16["Adi"].ToString() + " " + reader16["Soyadi"].ToString();
            }
            connection.Close();

            if (BtnOda16.Text != "Oda 16")
            {
                BtnOda16.BackColor = Color.Red;
                BtnOda16.Enabled = false;
            }
        }
    }
    
}
