using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Automation_v1
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmAdminGiris = new FrmAdminGiris();
            frmAdminGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();
            frmYeniMusteri.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
