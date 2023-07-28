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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OkulYönetimSistemi
{
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
            
        }
        

        // Parolanın gizlenip gizlenmemesi
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.checkBoxKontrol(GosterGizleChecBox, SifreTextBox);
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            SifreTextBox.UseSystemPasswordChar = true;
            
        }

        // Giris butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SicilNoTextBox.Text) || string.IsNullOrEmpty(SifreTextBox.Text))
                    MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz.");
                else
                {
                    string sorgu = "SELECT Id FROM Ogretmen WHERE SicilNo = @no AND Sifre =@sifre";
                    SqlParameter[] parameters = { new SqlParameter("@no", SicilNoTextBox.Text), new SqlParameter("@sifre", SifreTextBox.Text) };
                    string Id = Helpers.ScalarkomutCalistir(sorgu, parameters);
                    if (string.IsNullOrEmpty(Id))
                    {
                        MessageBox.Show("Numarınızı veya şifrenizi hatalı girdiniz.");
                        SicilNoTextBox.Text = string.Empty;
                        SifreTextBox.Text = string.Empty;
                        SicilNoTextBox.Focus();
                    }
                    else
                    {
                        Helpers.ekranDegistirme("OgretmenAnaEkran", SicilNoTextBox.Text);
                        Dispose();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı");
            }
            finally { }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);            
        }

        private void OgretmenGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }
    }
}
