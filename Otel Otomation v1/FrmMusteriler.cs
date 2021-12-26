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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["MusteriId"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["Soyadi"].ToString());
                ekle.SubItems.Add(reader["Cinsiyet"].ToString());
                ekle.SubItems.Add(reader["Telefon"].ToString());
                ekle.SubItems.Add(reader["Mail"].ToString());
                ekle.SubItems.Add(reader["TC"].ToString());
                ekle.SubItems.Add(reader["OdaNo"].ToString());
                ekle.SubItems.Add(reader["Ucret"].ToString());
                ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);

            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            VerileriGoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void MskTxtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where MusteriId=(" + id + ")", connection);
            SqlCommand komut2 = new SqlCommand("delete from Oda" + TxtOdaNo.Text, connection);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            connection.Close();
            listView1.Items.Clear();
            VerileriGoster();

            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();

            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'where MusteriId=" + id + "", connection);
            komut.ExecuteNonQuery();
            connection.Close();
            listView1.Items.Clear();
            VerileriGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        { 

            listView1.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + TxtAra.Text + "%'", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["MusteriId"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["Soyadi"].ToString());
                ekle.SubItems.Add(reader["Cinsiyet"].ToString());
                ekle.SubItems.Add(reader["Telefon"].ToString());
                ekle.SubItems.Add(reader["Mail"].ToString());
                ekle.SubItems.Add(reader["TC"].ToString());
                ekle.SubItems.Add(reader["OdaNo"].ToString());
                ekle.SubItems.Add(reader["Ucret"].ToString());
                ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            connection.Close();
        }
    }
}
