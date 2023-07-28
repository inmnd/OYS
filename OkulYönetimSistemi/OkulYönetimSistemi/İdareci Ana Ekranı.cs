using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OkulYönetimSistemi.Helpers;

namespace OkulYönetimSistemi
{
    public partial class İdareci_Ana_Ekranı : Form
    {
        // Giris sayfasindan veri almak icin
        public string ad;
        public İdareci_Ana_Ekranı(string AD)
        {
            InitializeComponent();
            ad = AD;
        }
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        // Ogrenci kayıtlarının duzenlenicegi sayfaya gider
        private void button1_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("OgrenciKayıt", ad);
            Dispose();
        }

        // Ogretmen kayıtlarının düzenlenicegi sayfaya gider
        private void button2_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("OgretmenKayıt", ad);
            Dispose();
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }
        
        // Ogretmen sinif atamasi yapildigi sayfaya gider
        private void button4_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("OgretmenSinifAtama", ad);
            Dispose();
        }
        
        // Bilgilerin verildigi yer
        private void İdareci_Ana_Ekranı_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT Adi FROM IdareKullaniciGiris WHERE Id = @ad";
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ad", ad);
                string adi = Helpers.ScalarkomutCalistir(sorgu, parameters);

                sorgu = "SELECT Resim FROM IdareKullaniciGiris WHERE Id = @NO";
                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", ad);
            Helpers.baglantiAc();
                object resimObject = komut.ExecuteScalar();
                if (resimObject != null && resimObject != DBNull.Value)
                {
                    byte[] fotoBytes = (byte[])resimObject;
                    if (fotoBytes != null && fotoBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(fotoBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                        pictureBox1.Image = null;
                }
                else
                    pictureBox1.Image = null;
                
                Helpers.baglantiAc();
                this.komut = new SqlCommand("SELECT Adi,Soyadi,Statü FROM IdareKullaniciGiris WHERE Id = @ad", SqlBaglanti.baglanti);
                this.komut.Parameters.AddWithValue("@ad", ad);
                da = new SqlDataAdapter(this.komut);
                da.Fill(dt);

                AdTextBox.Text = dt.Rows[0][0].ToString();
                SoyadTextBox.Text = dt.Rows[0][1].ToString();
                StatuTextBox.Text = dt.Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show("Bilgiler yüklenemedi");
            }
            finally { Helpers.baglantiKapat(); }
        }
        
        // Sifre degistirme sayfasina gider
        private void button5_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("SifreDegistirmeEkranı", ad, "Idare");
            Dispose();
        }
       
        private void İdareci_Ana_Ekranı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button3_Click(sender, e);
            }
        }
    }
}
