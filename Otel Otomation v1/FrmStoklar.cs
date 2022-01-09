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
            listView1.Items.Clear();
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
            veriler2();

        }
        private void veriler2()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select * from Faturalar", connection);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {

                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = sqlDataReader2["Elektirik"].ToString();
                ekle2.SubItems.Add(sqlDataReader2["Su"].ToString());
                ekle2.SubItems.Add(sqlDataReader2["Internet"].ToString());
              
                listView2.Items.Add(ekle2);

            }
            connection.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Stoklar(Gida,Icecek,TemizlikMalzemeleri,Diger) values('"+txtGıda.Text+"','"+TxtIcecek.Text+"','"+TxtTemizlik.Text+"','"+TxtDiger.Text+"')",connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            veriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("insert into Faturalar(Elektirik,Su,Internet) values('" + TxtElektirik.Text + "','" + TxtSu.Text + "','" + TxtInternet.Text + "')", connection);
            sqlCommand3.ExecuteNonQuery();
            connection.Close();
            veriler2();

        }
    }
}
