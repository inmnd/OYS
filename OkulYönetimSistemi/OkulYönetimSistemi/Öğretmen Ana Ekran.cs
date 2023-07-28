using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulYönetimSistemi
{
    public partial class Öğretmen_Ekran : Form
    {
        string eskiBilgi, kolonAdi, yeniDeger;
        int sinav1, sinav2, sinav3, sözlü1, sözlü2, sözlü3, ort = 0, kolonIndex, satırIndex;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        private int NO;

        // Ogretmen giris ekranından sicil no alınır
        public Öğretmen_Ekran(int Numara)
        {
            InitializeComponent();
            NO = Numara;
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }

        // Bilgi Aktarimi - Sinif Aktarimi
        private void Öğretmen_Ekran_Load(object sender, EventArgs e)
        {
            SqlCommand komut;

            // Ogretmen bilgileri aktarılır
            try
            {
                string Id = Helpers.Id_Sorgu("Ogretmen", NO.ToString());
                Helpers.baglantiAc();
                komut = new SqlCommand("SELECT Adi,Soyadi,DersId FROM Ogretmen WHERE SicilNo=@NO", SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", NO);
                da = new SqlDataAdapter(komut);
                da.Fill(dt);

                string sorgu = "SELECT Resim FROM Ogretmen WHERE SicilNo = @NO";
                komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", NO);
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

                SicilNoTextBox.Text = NO.ToString();
                AdTextBox.Text = dt.Rows[0]["Adi"].ToString();
                SoyadTextBox.Text = dt.Rows[0]["Soyadi"].ToString();
                komut = new SqlCommand("SELECT Adi FROM Ders WHERE Id = @dId", SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@dId", dt.Rows[0]["DersId"].ToString());
                BransTextBox.Text = komut.ExecuteScalar()?.ToString();
            }
            catch
            {
                MessageBox.Show("Bilgiler kısmına baglanilamadi ");
            }
            finally { Helpers.baglantiKapat(); }

            // Ogretmenin girdigi siniflar comboboxa yazma       
            try
            {
                string oId = Helpers.Id_Sorgu("Ogretmen", NO.ToString());
                komut = new SqlCommand("SELECT Sinif.Adi FROM DersSinifOgretmenAtama INNER JOIN Sinif ON " +
                    "DersSinifOgretmenAtama.SinifId = Sinif.Id AND DersSinifOgretmenAtama.OgretmenId = @oId", SqlBaglanti.baglanti);//Ders
                komut.Parameters.AddWithValue("@oId", oId);
                Helpers.baglantiAc();
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                {
                    SinifListeleComboBox.Items.Add(dr2["Adi"]);
                }
            }
            catch
            {
                MessageBox.Show("Combobox2 bağlanamadı");
            }
            finally { Helpers.baglantiKapat(); }

        }

        private void ButtonYazdir_Click(object sender, EventArgs e)
        {
            if (SinifListeleComboBox.SelectedIndex != -1)
            {
                string sorgu;
                SqlParameter[] parameters = new SqlParameter[1];
                string sinifId = Helpers.Id_Sorgu("Sinif", SinifListeleComboBox.SelectedItem.ToString());
                sorgu = "SELECT DersId FROM Ogretmen WHERE SicilNo=@NO";
                parameters[0] = new SqlParameter("@NO", NO);
                string dersId = Helpers.ScalarkomutCalistir(sorgu, parameters);
                ÖğrenciNotRapor o = new ÖğrenciNotRapor(dersId, sinifId);
                o.ShowDialog();
            }
            else
                MessageBox.Show("Lütfen sınıf seçiniz");
        }

        public void listele()
        {
            if (SinifListeleComboBox.SelectedIndex != -1)
            {
                try
                {
                    string sorgu;
                    SqlParameter[] parameters = new SqlParameter[1];
                    string sinifId = Helpers.Id_Sorgu("Sinif", SinifListeleComboBox.SelectedItem.ToString());
                    sorgu = "SELECT DersId FROM Ogretmen WHERE SicilNo=@NO";
                    parameters[0] = new SqlParameter("@NO", NO);
                    string dersId = Helpers.ScalarkomutCalistir(sorgu, parameters);

                    Helpers.baglantiAc();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT o.No, o.Adi, o.Soyadi, ot.Sinav1, ot.Sinav2, ot.Sinav3, ot.Sözlü1, ot.Sözlü2, ot.Sözlü3, ot.Ortalama " +
                                            "FROM OgrenciNot AS ot " +
                                            "INNER JOIN Ogrenci AS o ON o.Id = ot.OgrenciId AND ot.DersId = @dersId AND o.SinifId = @sinifId", SqlBaglanti.baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@dersId", dersId);
                    da.SelectCommand.Parameters.AddWithValue("@sinifId", sinifId);
                    da.Fill(dt);
                    OgrenciListeDataGridView.DataSource = dt;

                    List<int> veriListesi = new List<int>();
                    SqlCommand komut = new SqlCommand("SELECT ot.Ortalama FROM OgrenciNot as ot INNER JOIN Ogrenci o ON  ot.OgrenciId = o.Id AND o.SinifId =  @sId AND ot.DersId = @dId", SqlBaglanti.baglanti);
                    komut.Parameters.AddWithValue("@sId", sinifId);
                    komut.Parameters.AddWithValue("@dId", dersId);
                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int veri = reader.GetInt32(0);
                            veriListesi.Add(veri);
                        }
                    }
                    int[] veriDizisi = veriListesi.ToArray();
                    int ort = 0;
                    int temp = 0;
                    if (veriDizisi.Length > 0)
                    {
                        for (int i = 0; i < veriDizisi.Length; i++)
                        {
                            if (veriDizisi[i] != 0)
                            {
                                ort += veriDizisi[i];
                                temp++;
                            }
                        }
                    }

                    if (ort != 0)
                    {
                        ort = ort / temp;
                        SinifOrtalamaTextBox.Text = ort.ToString();
                    }
                    else
                    { 
                        SinifOrtalamaTextBox.Text = "Notlar Girilmedi"; }
                    OgrenciListeDataGridView.Columns["No"].ReadOnly = true;
                    OgrenciListeDataGridView.Columns["Adi"].ReadOnly = true;
                    OgrenciListeDataGridView.Columns["Soyadi"].ReadOnly = true;
                    OgrenciListeDataGridView.Columns["Ortalama"].ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("Listeleme başarısız oldu.");
                }
                finally { Helpers.baglantiKapat(); }
            }
        }

        // Secilen sinifin ogrencileri listelenir
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();

        }

        // Sifre Degistir butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("SifreDegistiremEkranı", NO.ToString(), "Ogretmen");
            Dispose();
        }

        // Guncelleme islemi
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            kolonAdi = OgrenciListeDataGridView.Columns[OgrenciListeDataGridView.CurrentCell.ColumnIndex].Name;
            satırIndex = OgrenciListeDataGridView.CurrentCell.RowIndex;
            kolonIndex = OgrenciListeDataGridView.CurrentCell.ColumnIndex;
            yeniDeger = OgrenciListeDataGridView.Rows[satırIndex].Cells[kolonIndex].Value.ToString();

            if (Convert.ToInt32(yeniDeger) >= 0 && Convert.ToInt32(yeniDeger) <= 100)
            {
                sinav1 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav1"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav1"].Value) : 0;
                sinav2 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav2"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav2"].Value) : 0;
                sinav3 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav3"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sinav3"].Value) : 0;
                sözlü1 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü1"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü1"].Value) : 0;
                sözlü2 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü2"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü2"].Value) : 0;
                sözlü3 = OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü3"].Value != DBNull.Value ? Convert.ToInt32(OgrenciListeDataGridView.Rows[satırIndex].Cells["Sözlü3"].Value) : 0;

                ortHesapla(sinav1, sinav2, sinav3, sözlü1, sözlü2, sözlü3, ref ort);
            }
            else
            {
                MessageBox.Show("Gireceğiniz değerler en fazla 100 en az 0 değerini alabilir!");
                OgrenciListeDataGridView.Rows[satırIndex].Cells[kolonIndex].Value = eskiBilgi;
            }
        }

        // Hatalı guncelleme sonucu kontrol
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int satırIndex = OgrenciListeDataGridView.CurrentCell.RowIndex;
            int kolonIndex = OgrenciListeDataGridView.CurrentCell.ColumnIndex;
            eskiBilgi = OgrenciListeDataGridView.Rows[satırIndex].Cells[kolonIndex].Value.ToString();
        }

        // Temizle butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            listele();
            NoAraTextBox.Text = string.Empty;
            AdAraTextBox.Text = string.Empty;
            SoyadAraTextBox.Text = string.Empty;
        }

        private void Öğretmen_Ekran_KeyDown(object sender, KeyEventArgs e)
        {
            Helpers.formuYenile(e, this);
            if (e.KeyCode == Keys.Escape)
            {
                button3_Click(sender, e);
            }
        }

        // Listele butonu
        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SinifListeleComboBox.SelectedIndex != -1)
                {
                    string sorgu = "SELECT DersId FROM Ogretmen WHERE SicilNo=@NO";
                    SqlParameter[] parameters = { new SqlParameter("@NO", NO) };
                    string dersId = Helpers.ScalarkomutCalistir(sorgu, parameters);
                    string sinifId = Helpers.Id_Sorgu("Sinif", SinifListeleComboBox.SelectedItem.ToString());
                    Helpers.baglantiAc();
                    if (!string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(NoAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT o.No, o.Adi, o.Soyadi, ot.Sinav1, ot.Sinav2, ot.Sinav3, ot.Sözlü1, ot.Sözlü2, ot.Sözlü3, ot.Ortalama " +
                                                                "FROM OgrenciNot AS ot " +
                                                                "INNER JOIN Ogrenci AS o ON o.Id = ot.OgrenciId AND ot.DersId = @dersId AND o.SinifId = @sinifId " +
                                                                "WHERE o.Adi LIKE '%' + @aranan + '%'", SqlBaglanti.baglanti);
                        da.SelectCommand.Parameters.AddWithValue("@dersId", dersId);
                        da.SelectCommand.Parameters.AddWithValue("@sinifId", sinifId);

                        if (!string.IsNullOrEmpty(AdAraTextBox.Text))
                        {
                            da.SelectCommand.Parameters.AddWithValue("@aranan", AdAraTextBox.Text);
                            da.Fill(dt);
                            OgrenciListeDataGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Ad araması başarısız oldu.");
                        }
                    }
                    else if (string.IsNullOrEmpty(AdAraTextBox.Text) && !string.IsNullOrEmpty(NoAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text))
                    {
                        if (dersId != null && sinifId != null && !string.IsNullOrEmpty(NoAraTextBox.Text))
                        {
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT o.No, o.Adi, o.Soyadi, ot.Sinav1, ot.Sinav2, ot.Sinav3, ot.Sözlü1, ot.Sözlü2, ot.Sözlü3, ot.Ortalama " +
                                                                    "FROM OgrenciNot AS ot " +
                                                                    "INNER JOIN Ogrenci AS o ON o.Id = ot.OgrenciId AND ot.DersId = @dersId AND o.SinifId = @sinifId " +
                                                                    "WHERE o.No LIKE '%' + @aranan + '%'", SqlBaglanti.baglanti);
                            da.SelectCommand.Parameters.AddWithValue("@dersId", dersId);
                            da.SelectCommand.Parameters.AddWithValue("@sinifId", sinifId);
                            da.SelectCommand.Parameters.AddWithValue("@aranan", NoAraTextBox.Text);
                            da.Fill(dt);
                            OgrenciListeDataGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No araması başarısız oldu.");
                        }
                    }
                    else if (string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(NoAraTextBox.Text) && !string.IsNullOrEmpty(SoyadAraTextBox.Text))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT o.No, o.Adi, o.Soyadi, ot.Sinav1, ot.Sinav2, ot.Sinav3, ot.Sözlü1, ot.Sözlü2, ot.Sözlü3, ot.Ortalama " +
                                                                "FROM OgrenciNot AS ot " +
                                                                "INNER JOIN Ogrenci AS o ON o.Id = ot.OgrenciId AND ot.DersId = @dersId AND o.SinifId = @sinifId " +
                                                                "WHERE o.Soyadi LIKE '%' + @aranan + '%'", SqlBaglanti.baglanti);
                        da.SelectCommand.Parameters.AddWithValue("@dersId", dersId);
                        da.SelectCommand.Parameters.AddWithValue("@sinifId", sinifId);

                        if (!string.IsNullOrEmpty(SoyadAraTextBox.Text))
                        {
                            da.SelectCommand.Parameters.AddWithValue("@aranan", SoyadAraTextBox.Text);
                            da.Fill(dt);
                            OgrenciListeDataGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Soyad araması başarısız oldu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen sadece bir kategoride arama yapınız");
                        NoAraTextBox.Text = string.Empty;
                        AdAraTextBox.Text = string.Empty;
                        SoyadAraTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen önce sınıf seçiniz!!");
                    AdAraTextBox.Text = string.Empty;
                    NoAraTextBox.Text = string.Empty;
                    SoyadAraTextBox.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Hata");
            }
            finally { Helpers.baglantiKapat(); }
        }

        // Kaydet butonu
        private void button5_Click_1(object sender, EventArgs e)
        {
            string oId, yeniSorgu;
            try
            {
                // sınav kontrolu yap
                string sinifId = Helpers.Id_Sorgu("Sinif", SinifListeleComboBox.SelectedItem.ToString());
                string dId = Helpers.Id_Sorgu("Ders", BransTextBox.Text);
                oId = Helpers.Id_Sorgu("Ogrenci", OgrenciListeDataGridView.Rows[satırIndex].Cells["No"].Value.ToString());
                SqlParameter[] parameters = new SqlParameter[3];

                yeniSorgu = "UPDATE OgrenciNot SET " + kolonAdi + " = @deger WHERE OgrenciId = @ıd AND DersId = @dId";
                parameters[0] = new SqlParameter("@deger", yeniDeger);
                parameters[1] = new SqlParameter("@ıd", oId);
                parameters[2] = new SqlParameter("@dId", dId);
                Helpers.NonQueryKomutCalistir(yeniSorgu, parameters);

                yeniSorgu = "UPDATE OgrenciNot SET Ortalama = @deger WHERE OgrenciId = @ıd AND DersId = @dId";
                SqlParameter[] parameters1 = new SqlParameter[3];
                parameters1[0] = new SqlParameter("@deger", ort);
                parameters1[1] = new SqlParameter("@ıd", oId);
                parameters1[2] = new SqlParameter("@dId", dId);
                Helpers.NonQueryKomutCalistir(yeniSorgu, parameters1);
                OgrenciListeDataGridView.Rows[satırIndex].Cells["Ortalama"].Value = ort;

                List<int> veriListesi = new List<int>();
                SqlCommand komut = new SqlCommand("SELECT ot.Ortalama FROM OgrenciNot as ot INNER JOIN Ogrenci o ON  ot.OgrenciId = o.Id AND o.SinifId =  @sId AND ot.DersId = @dId", SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@sId", sinifId);
                komut.Parameters.AddWithValue("@dId", dId);
                Helpers.baglantiAc();
                using (SqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int veri = reader.GetInt32(0);
                        veriListesi.Add(veri);
                    }
                }
                int[] veriDizisi = veriListesi.ToArray();
                ort = 0;
                int temp = 0;
                if (veriDizisi.Length > 0)
                {
                    for (int i = 0; i < veriDizisi.Length; i++)
                    {
                        if (veriDizisi[i] != 0)
                        {
                            ort += veriDizisi[i];
                            temp++;
                        }
                    }
                }
                if (ort != 0)
                {
                    ort = ort / temp;
                    SinifOrtalamaTextBox.Text = ort.ToString();
                }
                else
                { SinifOrtalamaTextBox.Text = "Notlar Girilmedi"; }
                MessageBox.Show("Güncelleme işlemi tamamlandı");
            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız! Bilgileri doğru bir şekilde giriniz!");
                OgrenciListeDataGridView.Rows[satırIndex].Cells[kolonIndex].Value = eskiBilgi;
            }
            finally { Helpers.baglantiKapat(); }
        }

        public void ortHesapla(int sinav1, int sinav2, int sinav3, int sözlü1, int sözlü2, int sözlü3, ref int ort)
        {
            int ortS, ortZ;
            if (sinav1 != 0 && sinav2 != 0 && sinav3 != 0)
                ortS = (sinav1 + sinav2 + sinav3) / 3;
            else if (sinav1 != 0 && sinav2 != 0)
                ortS = (sinav1 + sinav2) / 2;
            else if (sinav2 == 0 && sinav3 == 0)
                ortS = sinav1;
            else if (sinav2 == 0 && sinav1 == 0)
                ortS = sinav3;
            else
                ortS = sinav2;
            if (sözlü1 != 0 && sözlü2 != 0 && sözlü3 != 0)
                ortZ = (sözlü1 + sözlü2 + sözlü3) / 3;
            else if (sözlü1 != 0 && sözlü2 != 0)
                ortZ = (sözlü1 + sözlü2) / 2;
            else if (sözlü1 == 0 && sözlü2 == 0)
                ortZ = sözlü3;
            else if (sözlü1 == 0 && sözlü3 == 0)
                ortZ = sözlü2;
            else
                ortZ = sözlü1;
            if (ortS != 0 && ortZ != 0)
                ort = (ortS + ortZ) / 2;
            else if (ortZ == 0)
                ort = ortS;
            else
                ort = ortZ;
            OgrenciListeDataGridView.Rows[OgrenciListeDataGridView.CurrentCell.RowIndex].Cells["Ortalama"].Value = ort;
        }
    }
}
