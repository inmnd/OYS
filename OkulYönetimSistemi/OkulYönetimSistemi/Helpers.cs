using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Text.RegularExpressions;

namespace OkulYönetimSistemi
{
    public class SqlBaglanti
    {
        public static SqlConnection baglanti = baglanti = new SqlConnection("Data Source=ISMINE\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        static SqlBaglanti()
        {

        }

    }
    internal class Helpers
    {
        Helpers()
        {

        }
        static SqlCommand komut;

        // Formlar arasi gecis
        public static void ekranDegistirme(string gidilecekEkran)
        {
            if (gidilecekEkran == "IdareGiris")
            {
                IdareGiris i = new IdareGiris();
                i.Show();
            }
            else if (gidilecekEkran == "OgrenciGiris")
            {
                OgrenciGiris o = new OgrenciGiris();
                o.Show();
            }
            else if (gidilecekEkran == "OgretmenGiris")
            {
                OgretmenGiris o = new OgretmenGiris();
                o.Show();
            }
            else if (gidilecekEkran == "AnaGiris")
            {
                AnaGiris a = new AnaGiris();
                a.Show();
            }
        }
        public static void ekranDegistirme(string gidilecekEkran, string Bilgi)
        {
            if (gidilecekEkran == "IdareciAnaEkranı")
            {
                İdareci_Ana_Ekranı i = new İdareci_Ana_Ekranı(Bilgi);
                i.Show();
            }
            else if (gidilecekEkran == "OgrenciAnaEkranı")
            {
                SinifTextBox o = new SinifTextBox(Convert.ToInt32(Bilgi));
                o.Show();
            }
            else if (gidilecekEkran == "OgrenciKayıt")
            {
                Öğrenci_Kayıt_ve_Güncelleme o = new Öğrenci_Kayıt_ve_Güncelleme(Bilgi);
                o.Show();
            }
            else if (gidilecekEkran == "OgretmenAnaEkran")
            {
                Öğretmen_Ekran o = new Öğretmen_Ekran(Convert.ToInt32(Bilgi));
                o.Show();
            }
            else if (gidilecekEkran == "OgretmenSinifAtama")
            {
                Öğretmen_Sınıf_Ataması o = new Öğretmen_Sınıf_Ataması(Bilgi);
                o.Show();
            }
            else if (gidilecekEkran == "OgretmenKayıt")
            {
                Öğretmen_Kayıt_ve_Güncelleme o = new Öğretmen_Kayıt_ve_Güncelleme(Bilgi);
                o.Show();
            }
        }
        public static void ekranDegistirme(string gidilecekEkran, string Bilgi, string eskiKonum)
        {
            Şifre_Değiştirme_Ekranı s = new Şifre_Değiştirme_Ekranı(Bilgi, eskiKonum);
            s.Show();
        }

        public static string Id_Sorgu(string tabloAdi, string kontrolBilgi)
        {
            string id = null;
            try
            {
                string sorgu = null;
                if (tabloAdi == "Ogrenci")
                    sorgu = "SELECT Id FROM Ogrenci WHERE No=@NO";
                else if (tabloAdi == "Ogretmen")
                    sorgu = "SELECT Id FROM Ogretmen WHERE SicilNo=@NO";
                else if (tabloAdi == "Sinif")
                    sorgu = "SELECT Id FROM Sinif WHERE Adi=@NO";
                else if (tabloAdi == "Ders")
                    sorgu = "SELECT Id FROM Ders WHERE Adi=@NO";
                komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", kontrolBilgi);
                baglantiAc();
                id = komut.ExecuteScalar()?.ToString();
            }
            catch
            {
                MessageBox.Show("Id için bağlantı kurulamadı");
            }
            finally
            {
                baglantiKapat();
            }

            return id;
        }

        // Sifre gorunup gorunmeyecegi
        public static void checkBoxKontrol(System.Windows.Forms.CheckBox c, System.Windows.Forms.TextBox t)
        {
            if (c.CheckState == CheckState.Checked)
            {
                t.UseSystemPasswordChar = false;
                c.Text = "Gizle";
            }
            else if (c.CheckState == CheckState.Unchecked)
            {
                t.UseSystemPasswordChar = true;
                c.Text = "Göster";
            }
        }

        // Gerekli verilerin veri tabanından istenilen combobox'a aktarımı
        public static void comboBoxAktarım(string tabloAdi, System.Windows.Forms.ComboBox c)
        {
            try
            {
                komut = new SqlCommand("SELECT * FROM " + tabloAdi, SqlBaglanti.baglanti);
                baglantiAc();
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        c.Items.Add(dr["Adi"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Combobox bağlanamadı: " + ex.Message);
            }
            finally { baglantiKapat(); }

        }

        // Gerekli verilerin veri tabanından datagridview'a aktarımı
        public static void DataGridListele(string sorgu, System.Windows.Forms.DataGridView d)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlBaglanti.baglanti);
                baglantiAc();
                da.Fill(dt);
                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Veriler Listelenemedi");
            }
            finally
            {
                Helpers.baglantiKapat();
            }
        }

        // Datagridview uzerinde arama
        public static void noAra(string tabloAdi, System.Windows.Forms.DataGridView d, string aranan)
        {
            try
            {
                string sorgu = null;

                if (tabloAdi == "Ogrenci")
                    sorgu = "SELECT O.No, O.Adi, O.Soyadi, O.Telefon, O.Adres, s.Adi AS Sinif " +
               "FROM Ogrenci AS O " +
               "JOIN Sinif AS s ON O.SinifId = s.Id " +
               "WHERE O.No LIKE @aranan + '%' " +
               "ORDER BY O.No";
                else if (tabloAdi == "Ogretmen")
                    sorgu = "SELECT o.SicilNo, o.Adi, o.Soyadi, o.Telefon, o.Adres, d.Adi AS Branş " +
                            "FROM Ogretmen AS o " +
                            "JOIN Ders AS d ON d.Id = o.DersId " +
                            "WHERE o.SicilNo LIKE @aranan + '%' " +
                            "ORDER BY SicilNo";

                komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@aranan", aranan);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                baglantiAc();
                da.Fill(dt);

                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No araması yapılamadı");
            }
            finally { baglantiKapat(); }
        }
        public static void adAra(string tabloAdi, System.Windows.Forms.DataGridView d, string aranan)
        {
            try
            {
                string sorgu = null;

                if (tabloAdi == "Ogrenci")
                    sorgu = "SELECT O.No, O.Adi, O.Soyadi, O.Telefon, O.Adres, s.Adi AS Sinif " +
                            "FROM Ogrenci AS O " +
                            "JOIN Sinif AS s ON O.SinifId = s.Id " +
                            "WHERE O.Adi LIKE @aranan + '%' " +
                            "ORDER BY O.No";
                else if (tabloAdi == "DersSinifOgretmenAtama")
                    sorgu = "SELECT Ogretmen.Adi, Ogretmen.Soyadi, Ders.Adi AS Ders, Sinif.Adi AS Sinif " +
                             "FROM DersSinifOgretmenAtama " +
                             "JOIN Ogretmen ON DersSinifOgretmenAtama.OgretmenId = Ogretmen.Id " +
                             "JOIN Sinif ON DersSinifOgretmenAtama.SinifId = Sinif.ID " +
                             "JOIN Ders ON DersSinifOgretmenAtama.DersId = Ders.Id " +
                             "WHERE Ogretmen.Adi LIKE @aranan + '%' " +
                             "ORDER BY Sinif.Adi";
                else if (tabloAdi == "Ogretmen")
                    sorgu = "SELECT o.SicilNo, o.Adi, o.Soyadi, o.Telefon, o.Adres, d.Adi AS Branş " +
                            "FROM Ogretmen AS o " +
                            "JOIN Ders AS d ON d.Id = o.DersId " +
                            "WHERE o.Adi LIKE @aranan + '%' " +
                            "ORDER BY SicilNo";

                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@aranan", aranan);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                baglantiAc();
                da.Fill(dt);

                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ad araması yapılamadı");
            }
            finally { baglantiKapat(); }
        }
        public static void soyadAra(string tabloAdi, System.Windows.Forms.DataGridView d, string aranan)
        {
            try
            {
                string sorgu = null;
                if (tabloAdi == "Ogrenci")
                    sorgu = "SELECT O.No, O.Adi, O.Soyadi, O.Telefon, O.Adres, s.Adi AS Sinif " +
                            "FROM Ogrenci AS O " +
                            "JOIN Sinif AS s ON O.SinifId = s.Id " +
                            "WHERE O.Soyadi LIKE @aranan + '%' " +
                            "ORDER BY O.No";
                else if (tabloAdi == "DersSinifOgretmenAtama")
                    sorgu = "SELECT o.SicilNo, o.Adi, o.Soyadi, o.Telefon, o.Adres, d.Adi AS Branş " +
                            "FROM Ogretmen AS o " +
                            "JOIN Ders AS d ON d.Id = o.DersId " +
                            "WHERE o.Soyadi LIKE @aranan + '%' " +
                            "ORDER BY SicilNo";
                else if (tabloAdi == "Ogretmen")
                    sorgu = "SELECT o.SicilNo, o.Adi, o.Soyadi, o.Telefon, o.Adres, d.Adi AS Branş " +
                            "FROM Ogretmen AS o " +
                            "JOIN Ders AS d ON d.Id = o.DersId " +
                            "WHERE o.Soyadi LIKE @aranan + '%' " +
                            "ORDER BY SicilNo";

                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@aranan", aranan);

                DataTable dt = new DataTable();
                baglantiAc();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Soyad araması yapılamadı");
            }
            finally { baglantiKapat(); }
        }
        public static void sinifAra(string tabloAdi, System.Windows.Forms.DataGridView d, string aranan)
        {
            try
            {
                string sorgu = null;

                if (tabloAdi == "Ogrenci")
                    sorgu = "SELECT O.No, O.Adi, O.Soyadi, O.Telefon, O.Adres, s.Adi AS Sinif " +
                            "FROM Ogrenci AS O " +
                            "JOIN Sinif AS s ON O.SinifId = s.Id " +
                            "WHERE s.Adi = @aranan " +
                            "ORDER BY O.No";
                else if (tabloAdi == "DersSinifOgretmenAtama")
                    sorgu = "SELECT Ogretmen.Adi, Ogretmen.Soyadi, Ders.Adi AS Ders, Sinif.Adi AS Sinif " +
                             "FROM DersSinifOgretmenAtama " +
                             "JOIN Ogretmen ON DersSinifOgretmenAtama.OgretmenId = Ogretmen.Id " +
                             "JOIN Sinif ON DersSinifOgretmenAtama.SinifId = Sinif.ID " +
                             "JOIN Ders ON DersSinifOgretmenAtama.DersId = Ders.Id " +
                             "WHERE Sinif.Adi = @aranan " +
                             "ORDER BY Sinif.Adi";

                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@aranan", aranan);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                baglantiAc();
                da.Fill(dt);
                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Sınıf araması yapılamadı");
            }
            finally { baglantiKapat(); }
        }
        public static void dersAra(string tabloAdi, System.Windows.Forms.DataGridView d, string aranan)
        {
            try
            {
                string sorgu = null;
                SqlBaglanti.baglanti.Open();
                if (tabloAdi == "DersSinifOgretmenAtama")
                    sorgu = "SELECT Ogretmen.Adi, Ogretmen.Soyadi, Ders.Adi AS Ders, Sinif.Adi AS Sinif " +
                             "FROM DersSinifOgretmenAtama " +
                             "JOIN Ogretmen ON DersSinifOgretmenAtama.OgretmenId = Ogretmen.Id " +
                             "JOIN Sinif ON DersSinifOgretmenAtama.SinifId = Sinif.ID " +
                             "JOIN Ders ON DersSinifOgretmenAtama.DersId = Ders.Id " +
                             "WHERE Ders.Adi = @aranan " +
                             "ORDER BY Sinif.Adi";
                else if (tabloAdi == "Ogretmen")
                    sorgu = "SELECT o.SicilNo, o.Adi, o.Soyadi, o.Telefon, o.Adres, d.Adi AS Branş " +
                            "FROM Ogretmen AS o " +
                            "JOIN Ders AS d ON d.Id = o.DersId " +
                            "WHERE d.Adi = @aranan " +
                            "ORDER BY SicilNo";

                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@aranan", aranan);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ders araması yapılamadı");
            }
            finally { SqlBaglanti.baglanti.Close(); }
        }

        // Picturebox ve veritabani arasinda yapılan veri alıs-verisi
        public static void resimButonGetirme(OpenFileDialog ofd, System.Windows.Forms.PictureBox pb, ref string impath)
        {
            ofd.Title = "Resim Seç";
            ofd.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                impath = ofd.FileName.ToString();
                pb.ImageLocation = impath;
            }
        }
        public static byte[] resimBinaryCevirme(string impath)
        {
            byte[] resim;
            using (FileStream fs = new FileStream(impath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    resim = br.ReadBytes((int)fs.Length);
                }
            }
            return resim;
        }

        // Veri tabanina kaydedilen telefon verisinin nasil bir duzende oldugu ayarlanir
        public static bool IsValidMobilePhoneNumber(string phoneNumber)
        {
            // Geçerli desene uygunluğu kontrol etmek için regex kullanılır
            // Desen: 5XX-XXXXXXX (5 ile başlayan alan kodu ve 7 haneli yerel numara)
            string pattern = @"^5[0-9]{2}[0-9]{7}$";

            // Regex.IsMatch yöntemi ile desene uygunluk kontrolü yapılır
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static string ScalarkomutCalistir(string sorgu, SqlParameter[] parameters)
        {
            string donecekVeri = null;
            try
            {
                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                if (parameters != null)
                    komut.Parameters.AddRange(parameters);
                baglantiAc();
                donecekVeri = komut.ExecuteScalar()?.ToString();
            }
            catch
            {
                MessageBox.Show("Sorgu çalışmadı");
            }
            finally { baglantiKapat(); }
            return donecekVeri;
        }
        public static void NonQueryKomutCalistir(string sorgu, SqlParameter[] parameters)
        {
            try
            {
                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                if (parameters != null)
                    komut.Parameters.AddRange(parameters);
                baglantiAc();
                komut.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Sorgu çalışmadı");
            }
            finally { baglantiKapat(); }
        }

        public static void formuYenile(KeyEventArgs e, Form form)
        {
            if (e.KeyCode == Keys.F5)
                form.Refresh();
        }

        public static void DataGridViewSatirEkle(System.Windows.Forms.DataGridView d, string deger1, string deger2, string deger3, string deger4, string deger5, string deger6)
        {
            DataTable dataTable = (DataTable)d.DataSource;
            DataRow yeniSatir = dataTable.NewRow();
            if (string.IsNullOrEmpty(deger5) && string.IsNullOrEmpty(deger6))
            {
                yeniSatir["Adi"] = deger1;
                yeniSatir["Soyadi"] = deger2;
                yeniSatir["Ders"] = deger3;
                yeniSatir["Sinif"] = deger4;
            }
            else
            {
                yeniSatir[0] = deger1;
                yeniSatir[1] = deger2;
                yeniSatir[2] = deger3;
                yeniSatir[3] = deger4;
                yeniSatir[4] = deger5;
                yeniSatir[5] = deger6;
            }
            dataTable.Rows.Add(yeniSatir);
        }

        public static void DataGridViewSatirSil(System.Windows.Forms.DataGridView d)
        {
            int rowIndex = d.SelectedRows[0].Index;
            d.Rows.RemoveAt(rowIndex);
        }

        public static void baglantiAc()
        {
            if (ConnectionState.Open != SqlBaglanti.baglanti.State)
                SqlBaglanti.baglanti.Open();
        }

        public static void baglantiKapat()
        {
            if (ConnectionState.Open == SqlBaglanti.baglanti.State)
                SqlBaglanti.baglanti.Close();
        }
    }
}
