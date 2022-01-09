using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Automation_v1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {   //Kasadaki toplam tutar
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblKasadakiToplamTutar.Text = sqlDataReader["toplam"].ToString();
            }
            connection.Close();
            //Stokların Giderleri 
            connection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select sum(Gida+Icecek+TemizlikMalzemeleri+Diger) as toplam1 from Stoklar", connection);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                LblUrunTutarı.Text = sqlDataReader1["toplam1"].ToString();
            }
            connection.Close();
            //Fatura tutarları 
            connection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select sum(Elektirik+Su+Internet) as toplam2 from Faturalar", connection);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                LblFatura.Text = sqlDataReader2["toplam2"].ToString();
            }
            connection.Close();


            //Girilecek personel sayısı kadar ödenecek maaş hesaplama 

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            int toplamsonuc;
            personel = Convert.ToInt32(textBox1.Text);
            LblMaas.Text = (personel * 2250).ToString();
            toplamsonuc = Convert.ToInt32(LblKasadakiToplamTutar.Text) - ((Convert.ToInt32(LblMaas.Text) + Convert.ToInt32(LblFatura.Text) + Convert.ToInt32(LblUrunTutarı.Text)));
            LblSonuc.Text = toplamsonuc.ToString();
        }

        private void LblFatura_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
        }
    }
}
