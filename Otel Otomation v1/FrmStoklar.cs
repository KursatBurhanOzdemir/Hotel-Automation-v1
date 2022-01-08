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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void veriler()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Stoklar", connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = sqlDataReader["Gida"].ToString();
                ekle.SubItems.Add(sqlDataReader["Icecek"].ToString());
                ekle.SubItems.Add(sqlDataReader["TemizlikMalzemeleri"].ToString());
                ekle.SubItems.Add(sqlDataReader["Diger"].ToString());
                listView1.Items.Add(ekle);

            }
            connection.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
