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
        {

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle",connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblKasadakiToplamTutar.Text = sqlDataReader["toplam"].ToString();
            }
            connection.Close();

            //Girilecek personel sayısı kadar ödenecek maaş hesaplama 
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblMaas.Text = (personel * 2250).ToString();
        }
       
      
    }
}
