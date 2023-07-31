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
using System.IO;

namespace OkulYönetimSistemi
{
    public partial class Öğrenci_Kayıt_ve_Güncelleme : Form
    {
        public string ad, eskiBilgi, oId, impath = null;
        string sorgu1 = "SELECT O.No,O.Adi,O.Soyadi,O.Telefon,O.Adres,s.Adi AS Sınıf FROM Ogrenci AS O, Sinif AS s WHERE O.SinifId = s.Id ORDER BY O.No";
        bool kontrol;
        byte[] resim;
        SqlCommand komut;
        OpenFileDialog ofd = new OpenFileDialog();

        public Öğrenci_Kayıt_ve_Güncelleme(string AD)
        {
            InitializeComponent();
            ad = AD;
        }

        // Geri butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.ekranDegistirme("IdareciAnaEkranı", ad);
            Dispose();
        }
        
        // Kaydet/Guncelle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu;
                string sId = Helpers.Id_Sorgu("Sinif", SinifComboBox.SelectedItem.ToString());
                if (!string.IsNullOrEmpty(Helpers.Id_Sorgu("Ogrenci", NoTextBox.Text)))
                {
                    if (SinifComboBox.SelectedIndex != -1 && AdTextBox.Text != "" && SoyadTextBox.Text != "")
                    {                      
                        if (Helpers.IsValidMobilePhoneNumber(TelefonTextBox.Text))
                        {
                            sorgu = "UPDATE Ogrenci SET No = @no , SinifId = @sId , Adi = @ad , Soyadi = @sAd , Telefon = @tel , Adres = @adres" +
                                            ", Resim = @resim  WHERE Id = @oId ";
                            SqlParameter[] parameters = {new SqlParameter("@no", NoTextBox.Text), new SqlParameter("@ad", AdTextBox.Text),
                                new SqlParameter("@sAd", SoyadTextBox.Text), new SqlParameter("@tel", TelefonTextBox.Text), new SqlParameter("@adres", AdresTextBox.Text),
                                new SqlParameter("@sId", sId), new SqlParameter("@oId", oId),null };
                            
                            if (!kontrol)
                            {
                                parameters[7] = new SqlParameter("@resim", resim);
                                kontrol = false;
                            }
                            else
                            {
                                byte[] resimBytes = Helpers.resimBinaryCevirme(impath);
                                parameters[7] = new SqlParameter("@resim", SqlDbType.Image) { Value = resimBytes };
                            }
                            Helpers.NonQueryKomutCalistir(sorgu, parameters);
                            MessageBox.Show("Güncelleme işlemi tamamlandı");

                            Helpers.DataGridViewSatirSil(OgrenciListeleDataGridView);
                            Helpers.DataGridViewSatirEkle(OgrenciListeleDataGridView, NoTextBox.Text,AdTextBox.Text,SoyadTextBox.Text, TelefonTextBox.Text,AdresTextBox.Text,SinifComboBox.Text);
                            NoTextBox.Text = "";
                            AdTextBox.Text = "";
                            SoyadTextBox.Text = "";
                            TelefonTextBox.Text = "";
                            AdresTextBox.Text = "";
                            SinifComboBox.SelectedIndex = -1;
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Lütfen telofon numarasını doğru bir şekilde girinz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adı soyadı veya sınıf boş bırakamazsınız!!");
                    }

                }
                else
                {
                    if (SinifComboBox.SelectedIndex != -1 && AdTextBox.Text != "" && SoyadTextBox.Text != "")
                    {
                        string phoneNumber = TelefonTextBox.Text;
                        if (Helpers.IsValidMobilePhoneNumber(phoneNumber))
                        {
                            Random rnd = new Random();
                            int sifre = rnd.Next(1, 1001);
                            sorgu = "INSERT INTO Ogrenci (No, SinifId, Adi, Soyadi, Telefon, Adres, Sifre, Resim) " +
                                               "VALUES (@No, @SinifId, @Adi, @Soyadi, @Telefon, @Adres, @Sifre, @Resim)";
                            SqlParameter[] parameters = { new SqlParameter("@No", NoTextBox.Text), new SqlParameter("@SinifId", sId), new SqlParameter("@Adi", AdTextBox.Text),
                                new SqlParameter("@Soyadi", SoyadTextBox.Text),  new SqlParameter("@Telefon", TelefonTextBox.Text),
                                new SqlParameter("@Adres", AdresTextBox.Text), new SqlParameter("@Sifre", sifre)  };
                            byte[] resimBytes = Helpers.resimBinaryCevirme(impath);
                            parameters[7] = new SqlParameter("@resim", SqlDbType.Image) { Value = resimBytes };
                            Helpers.NonQueryKomutCalistir(sorgu, parameters);
                            for (int i = 1; i <= 4; i++)
                            {
                                // Notlar otomatik eklenir
                                sorgu = "INSERT INTO OgrenciNot (OgrenciId, DersId, Sinav1, Sinav2, Sinav3, Sözlü1, Sözlü2, Sözlü3, Ortalama)" +
                                    " VALUES (@No, @dId, @s1, @s2, @s3, @s1, @s2, @s3, @ort)";
                                SqlParameter[] parameters1 = new SqlParameter[5];
                                parameters1[0] = new SqlParameter("@No", oId);
                                parameters1[1] = new SqlParameter("@dId", i);
                                parameters1[2] = new SqlParameter("@s1", 0);
                                parameters1[3] = new SqlParameter("@s2", 0);
                                parameters1[4] = new SqlParameter("@s3", 0);
                                parameters1[5] = new SqlParameter("@ort", 0);
                                Helpers.NonQueryKomutCalistir(sorgu, parameters);
                            }
                            MessageBox.Show("Kayıt başarılı");
                            Helpers.DataGridViewSatirEkle(OgrenciListeleDataGridView, NoTextBox.Text, AdTextBox.Text, SoyadTextBox.Text, TelefonTextBox.Text, AdresTextBox.Text, SinifComboBox.Text); 
                            NoTextBox.Text = "";
                            AdTextBox.Text = "";
                            SoyadTextBox.Text = "";
                            TelefonTextBox.Text = "";
                            AdresTextBox.Text = "";
                            SinifComboBox.SelectedIndex = -1;
                            pictureBox1.Image = null;
                        }
                        else
                            MessageBox.Show("Lütfen telofon numarasını doğru bir şekilde girinz");
                    }
                    else
                    {
                        MessageBox.Show("Adı soyadı veya sınıf boş bırakamazsınız!!");
                    }

                }

            }
            catch
            {
                MessageBox.Show("Kayıt yapılamadı!! Lütfen girdiğiniz numaraya ait başka öğrenci olup olmadığını veya fotoğrafı düzgün bir şekilde yükleyip yüklemediğinizi kontrol ediniz.");
            }

            finally { Helpers.baglantiKapat(); }
        }

        // Sil butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Datagridviewda seçili satır var mı?
                if (OgrenciListeleDataGridView.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Kayıt silinecek onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Id = Helpers.Id_Sorgu("Ogrenci", OgrenciListeleDataGridView.CurrentRow.Cells["No"].Value.ToString());
                        string sorgu = "DELETE FROM OgrenciNot WHERE OgrenciId=@OgrenciId";
                        SqlParameter[] parameters = {new SqlParameter("@OgrenciId", Id)};
                        Helpers.NonQueryKomutCalistir(sorgu, parameters);
                        parameters = null;

                        sorgu = "DELETE FROM Ogrenci WHERE Id=@Id";
                        parameters[0] = new SqlParameter("@Id", Id);
                        Helpers.NonQueryKomutCalistir(sorgu, parameters);
                        MessageBox.Show("Kayıt silindi");

                        Helpers.DataGridViewSatirSil(OgrenciListeleDataGridView);
                        SinifComboBox.Text = string.Empty;
                        NoTextBox.Text = string.Empty;
                        AdTextBox.Text = string.Empty;
                        SoyadTextBox.Text = string.Empty;
                        TelefonTextBox.Text = string.Empty;
                        AdresTextBox.Text = string.Empty;
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinmedi");
                    }
                }
                else
                    MessageBox.Show("Lütfen veri silmek için bir tane satır seçiniz!!");
            }
            catch
            {
                MessageBox.Show("Kayıt silinemedi!");
            }
            finally {  }
        }
        
        // Combobox ve datagridview için gerekli veriler aktarılır
        private void Öğrenci_Kayıt_ve_Güncelleme_Load(object sender, EventArgs e)
        {
            Helpers.DataGridListele(sorgu1, OgrenciListeleDataGridView);
            Helpers.comboBoxAktarım("Sinif", SinifComboBox);
            Helpers.comboBoxAktarım("Sinif", SinifAraComboBox);
            SinifAraComboBox.SelectedIndex = 0;
            OgrenciListeleDataGridView.ReadOnly = true;
        }

        // Temizle butonu
        private void button2_Click(object sender, EventArgs e)
        {
            NoAraTextBox.Clear();
            AdAraTextBox.Clear();
            SoyadAraTextBox.Clear();
            SinifAraComboBox.SelectedIndex = 0;
            Helpers.DataGridListele(sorgu1, OgrenciListeleDataGridView);

        }

        // Resimin secildigi buton
        private void button5_Click(object sender, EventArgs e)
        {
            Helpers.resimButonGetirme(ofd, pictureBox1, ref impath);
            if (!string.IsNullOrEmpty(Helpers.Id_Sorgu("Ogrenci", NoTextBox.Text)))
                kontrol = true;
        }

        private void Öğrenci_Kayıt_ve_Güncelleme_KeyDown(object sender, KeyEventArgs e)
        {
            Helpers.formuYenile(e, this);
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }

        //Guncelleme sirasinda yanlıs deger girilmesi ihtimali icin eski bilginin tutulması
        private void dataGridView1_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            int satırIndex = OgrenciListeleDataGridView.CurrentCell.RowIndex;
            int kolonIndex = OgrenciListeleDataGridView.CurrentCell.ColumnIndex;
            eskiBilgi = OgrenciListeleDataGridView.Rows[satırIndex].Cells[kolonIndex].Value.ToString();
        }
        
        // Listele butonu
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0)
                Helpers.noAra("Ogrenci", OgrenciListeleDataGridView, NoAraTextBox.Text);
            else if (string.IsNullOrEmpty(NoAraTextBox.Text) && !string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0)
                Helpers.adAra("Ogrenci", OgrenciListeleDataGridView, AdAraTextBox.Text);
            else if (string.IsNullOrEmpty(NoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && !string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0)
                Helpers.soyadAra("Ogrenci", OgrenciListeleDataGridView, SoyadAraTextBox.Text);
            else if (string.IsNullOrEmpty(NoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex != 0)
                Helpers.sinifAra("Ogrenci", OgrenciListeleDataGridView, SinifAraComboBox.Text);
            else
            {
                MessageBox.Show("Lütfen bir kategoride arama yapınız");
                SoyadAraTextBox.Text = string.Empty;
                AdAraTextBox.Text = string.Empty;
                NoAraTextBox.Text = string.Empty;
                SinifAraComboBox.SelectedIndex = 0;
            }
        }

        // Temizle butonu
        private void button7_Click(object sender, EventArgs e)
        {
            SinifComboBox.Text = string.Empty;
            NoTextBox.Text = string.Empty;
            AdTextBox.Text = string.Empty;
            SoyadTextBox.Text = string.Empty;
            TelefonTextBox.Text = string.Empty;
            AdresTextBox.Text = string.Empty;
            pictureBox1.Image = null;
        }

        // Veriler guncellemek icin ogrenci kayit paneline bulunan satirin bilgileri aktarilir
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int satırIndex = OgrenciListeleDataGridView.CurrentCell.RowIndex;
            NoTextBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["No"].Value.ToString();
            AdTextBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["Adi"].Value.ToString();
            SoyadTextBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["Soyadi"].Value.ToString();
            TelefonTextBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["Telefon"].Value.ToString();
            AdresTextBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["Adres"].Value.ToString();
            SinifComboBox.Text = OgrenciListeleDataGridView.Rows[satırIndex].Cells["Sınıf"].Value.ToString();
            oId = Helpers.Id_Sorgu("Ogrenci", NoTextBox.Text);
            try
            {
                string sorgu = "SELECT Resim FROM Ogrenci WHERE No = @NO";
                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", NoTextBox.Text);
                Helpers.baglantiAc();
                object resimObject = komut.ExecuteScalar();
                resim = (byte[])resimObject;
                if (resim != null && resim.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(resim))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {

            }
            finally { Helpers.baglantiKapat(); }
        }

    }
}
