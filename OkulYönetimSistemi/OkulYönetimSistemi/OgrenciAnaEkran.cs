using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    public partial class SinifTextBox : Form
    {
        private int NO;
        string oId;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        // Giriş ekranından ogrenci numarası alınır
        public SinifTextBox(int NUmara)
        {
            InitializeComponent();
            NO = NUmara;
            oId = Helpers.Id_Sorgu("Ogrenci", NO.ToString());
        }
        

        // Geri Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("AnaGiris");
            Dispose();
        }

        // Bilgi aktarimi - Not siralama
        private void OgrenciAnaEkran_Load(object sender, EventArgs e)
        {
            SqlCommand komut;
            string sorgu;
            try//Ogrenci Bilgilerinin Aktarıldıgı yer
            {
            
                komut = new SqlCommand("SELECT Adi,Soyadi,SinifId FROM Ogrenci WHERE No=@NO", SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", NO);
                da = new SqlDataAdapter(komut);
                da.Fill(dt);

                string ad = dt.Rows[0]["Adi"].ToString();
                string soyad = dt.Rows[0]["Soyadi"].ToString();
                string sinifId = dt.Rows[0]["SinifId"].ToString();

                sorgu = "SELECT Adi FROM Sinif WHERE Id=@SinifId";
                SqlParameter[] parameters = { new SqlParameter("@SinifId", sinifId) };
                string sinif = Helpers.ScalarkomutCalistir(sorgu, parameters);
                parameters = null;

            sorgu = "SELECT Resim FROM Ogrenci WHERE No = @NO";
            komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", NO);
            Helpers.baglantiAc();
            object resimObject = komut.ExecuteScalar();

            if (resimObject != null && resimObject != DBNull.Value)
            {
                if (resimObject is byte[] fotoBytes)
                {
                    if (fotoBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(fotoBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                        pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }


            NoTextBox.Text = NO.ToString();
                AdTextBox.Text = ad;
                SoyadTextBox.Text = soyad;
                textBox2.Text = sinif;
           }
            catch
            {
                MessageBox.Show("Bilgiler kısmına baglanilamadi ");
            }
            finally { SqlBaglanti.baglanti.Close(); }

            //Ogrenci Notlarinin siralnamasi           
            string sId = Helpers.Id_Sorgu("Sinif", textBox2.Text);
            sorgu = "SELECT d.Adi, ot.Sinav1, ot.Sinav2, ot.Sinav3, ot.Sözlü1, ot.Sözlü2, ot.Sözlü3, ot.Ortalama, CONCAT(o.Adi, ' ', o.Soyadi) AS Ogretmen " +
               "FROM OgrenciNot AS ot " +
               "JOIN Ders AS d ON d.Id = ot.DersId " +
               "JOIN Ogretmen AS o ON o.DersId = d.Id " +
               "JOIN DersSinifOgretmenAtama AS dso ON dso.OgretmenId = o.Id " +
               "WHERE ot.OgrenciId = " + oId + " AND dso.SinifId = " + sId + " " +
               "ORDER BY d.Adi";
            Helpers.DataGridListele(sorgu, NotDataGridView);

            try
            {
                Helpers.baglantiAc();
                List<int> veriListesi = new List<int>();
                komut = new SqlCommand("SELECT Ortalama FROM OgrenciNot WHERE OgrenciId = " + oId, SqlBaglanti.baglanti);
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
                    OrtalamaTextBox.Text = ort.ToString();
                }
                else
                    OrtalamaTextBox.Text = "Notlar Girilmedi";
            }
            catch
            {
                MessageBox.Show(" ");
            }
            finally { Helpers.baglantiKapat(); }
        }

        // Sifre degistirme ekranına gecis
        private void button2_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("SifreDegistirmeEkranı", NO.ToString(), "Ogrenci");
            Dispose();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            NotDataGridView.EndEdit();
        }

        private void OgrenciAnaEkran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }
    }
}

