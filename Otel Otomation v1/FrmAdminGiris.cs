using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Automation_v1
{

    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HotelDb; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "select * from AdminGiris where KullaniciAdi=@kullanici AND Sifre=@sifre";
                //Trim Parametre olarak girilen değerlerdeki boşluk karakterlerini kaldırır. 
                SqlParameter sqlParameter = new SqlParameter("kullanici", TxtKullanıcıAdi.Text.Trim());
                SqlParameter sqlParameter1 = new SqlParameter("sifre", TxdSifre.Text.Trim());
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.Parameters.Add(sqlParameter1);
                //sanal tablo oluşturuyoruz 
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count>0)
                {
                    FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                    frmAnaSayfa.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!!");
            }
        }
    }
}
