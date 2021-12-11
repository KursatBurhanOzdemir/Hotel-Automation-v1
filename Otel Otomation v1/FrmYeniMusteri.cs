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
        }
    }
    
}
