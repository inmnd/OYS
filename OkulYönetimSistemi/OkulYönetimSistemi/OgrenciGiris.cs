using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace OkulYönetimSistemi
{
    public partial class OgrenciGiris : Form
    {

        public OgrenciGiris()
        {
            InitializeComponent();
        }
        
        // Sifrenin görünüp görünmeyeceği
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.checkBoxKontrol(GosterGizleCheckBox, SifreTextBox);
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }
        
        // Giris butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NoTextBox.Text) || string.IsNullOrEmpty(SifreTextBox.Text))//Textbox bos olup olmadıgının kontrolu
                    MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz.");
                else
                {
                   
                    string sorgu = "SELECT Id FROM Ogrenci WHERE No = @no AND Sifre =@sifre";
                    SqlParameter[] parameters = { new SqlParameter("@no", NoTextBox.Text), new SqlParameter("@sifre", SifreTextBox.Text) };
                    string Id = Helpers.ScalarkomutCalistir(sorgu, parameters);
                    if (string.IsNullOrEmpty(Id))
                    {
                        MessageBox.Show("Numarınızı veya şifrenizi hatalı girdiniz.");
                        NoTextBox.Text = string.Empty;
                        SifreTextBox.Text = string.Empty;
                        NoTextBox.Focus();
                    }
                    else
                    {
                        Helpers.ekranDegistirme("OgrenciAnaEkranı", NoTextBox.Text);
                        Dispose();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı");
            }
            finally { Helpers.baglantiKapat(); }
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            SifreTextBox.UseSystemPasswordChar = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void OgrenciGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }
    }
}
