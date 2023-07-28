using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    public partial class IdareGiris : Form
    {
        public IdareGiris()
        {
            InitializeComponent();
        }

        // Sifrenin gizlenip gizlenmemesi
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.checkBoxKontrol(GizleGosterCheckBox, SifreTextBox);
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }

        // Giris butonu bilgiler kontrol edilir
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdTextBox.Text) || string.IsNullOrEmpty(SoyadTextBox.Text) || string.IsNullOrEmpty(SifreTextBox.Text))
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz!!");
            else
            {
                string sorgu = "SELECT Id FROM IdareKullaniciGiris WHERE Adi=@k1 AND Soyadi=@k2 AND Sifre = @sifre";
                SqlParameter[] parameters = { new SqlParameter("@k1", AdTextBox.Text), new SqlParameter("@k2", SoyadTextBox.Text), new SqlParameter("@sifre", SifreTextBox.Text) };
                object result = Helpers.ScalarkomutCalistir(sorgu, parameters);
                string Id = result != null ? result.ToString() : "";
                if (!string.IsNullOrEmpty(Id))
                {
                    Helpers.ekranDegistirme("IdareciAnaEkranı", Id);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Adınızı, soyadınızı veya şifrenizi hatalı girdiniz.");
                    AdTextBox.Text = string.Empty;
                    SoyadTextBox.Text = string.Empty;
                    SifreTextBox.Text = string.Empty;
                    AdTextBox.Focus();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void IdareGiris_Load(object sender, EventArgs e)
        {
            // textbox sifreli yazım
            SifreTextBox.UseSystemPasswordChar = true;
        }

        private void IdareGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }
    }
}
