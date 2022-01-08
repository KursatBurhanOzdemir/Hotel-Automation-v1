
namespace Hotel_Automation_v1
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxdSifre = new System.Windows.Forms.TextBox();
            this.TxtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(494, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(576, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TxdSifre
            // 
            this.TxdSifre.BackColor = System.Drawing.SystemColors.Info;
            this.TxdSifre.Location = new System.Drawing.Point(638, 320);
            this.TxdSifre.Name = "TxdSifre";
            this.TxdSifre.Size = new System.Drawing.Size(212, 32);
            this.TxdSifre.TabIndex = 2;
            this.TxdSifre.UseSystemPasswordChar = true;
            this.TxdSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtKullanıcıAdi
            // 
            this.TxtKullanıcıAdi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtKullanıcıAdi.Location = new System.Drawing.Point(638, 260);
            this.TxtKullanıcıAdi.Name = "TxtKullanıcıAdi";
            this.TxtKullanıcıAdi.Size = new System.Drawing.Size(212, 32);
            this.TxtKullanıcıAdi.TabIndex = 3;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGirisYap.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnGirisYap.Location = new System.Drawing.Point(638, 380);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(158, 37);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Otel_Automation_v1.Properties.Resources.photo_1596386461350_326ccb383e9f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtKullanıcıAdi);
            this.Controls.Add(this.TxdSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxdSifre;
        private System.Windows.Forms.TextBox TxtKullanıcıAdi;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}

