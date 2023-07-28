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
    public partial class Şifre_Değiştirme_Ekranı : Form
    {
        // Şifre değiştirmek için gerekli bilgiler
        public string Id, konum;

        // Konum geldigi sayfa
        public Şifre_Değiştirme_Ekranı(string ıd, string Konum)
        {
            InitializeComponent();
            Id = ıd;
            konum = Konum;
        }

        // Kaydet butonu - Sifre guncellenir
        private void button1_Click(object sender, EventArgs e)
        {
            if (Yeni2TextBox.Text == Yeni1TextBox.Text)
            {
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    string sorgu = null, gidilecekEkran = null;
                    if (konum == "Ogrenci")
                    {
                        sorgu = "UPDATE Ogrenci SET Sifre = @sifre WHERE No = @oId";
                        gidilecekEkran = "OgrenciAnaEkranı";
                    }
                    else if (konum == "Ogretmen")
                    {
                        sorgu = "UPDATE Ogretmen SET Sifre = @sifre WHERE SicilNo = @oId";
                        gidilecekEkran = "OgretmenAnaEkran";
                    }
                    else if (konum == "Idare")
                    {
                        sorgu = "UPDATE IdareKullaniciGiris SET Sifre = @sifre WHERE Id = @oId";
                        gidilecekEkran = "IdareciAnaEkranı";
                    }
                    parameters[0] = new SqlParameter("@sifre", Yeni2TextBox.Text);
                    parameters[1] = new SqlParameter("@oId", Id);
                    Helpers.NonQueryKomutCalistir(sorgu, parameters);
                    MessageBox.Show("Şifre değiştirildi");
                    Helpers.ekranDegistirme(gidilecekEkran, Id);
                    Dispose();
                }
                catch
                {
                    MessageBox.Show("Şifre değiştirilemedi");
                }
                finally { SqlBaglanti.baglanti.Close(); }
            }
            else
                MessageBox.Show("Yeni şifrenizi hatalı girdiniz!!");
        }

        // Textbox gizliligi
        private void Şifre_Değiştirme_Ekranı_Load(object sender, EventArgs e)
        {
            Yeni2TextBox.UseSystemPasswordChar = true;
            Yeni1TextBox.UseSystemPasswordChar = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        // Geri butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (konum == "Ogrenci")
                Helpers.ekranDegistirme("OgrenciAnaEkranı", Id);

            else if (konum == "Ogretmen")
                Helpers.ekranDegistirme("OgretmenAnaEkran", Id);
            else if (konum == "Idare")
                Helpers.ekranDegistirme("IdareciAnaEkranı", Id);
            Dispose();
        }

        private void Şifre_Değiştirme_Ekranı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button2_Click(sender, e);
        }
    }
}
