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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace OkulYönetimSistemi
{
    public partial class Öğretmen_Sınıf_Ataması : Form
    {
        string eskiBilgi;//Guncelleme sirasinda hatali bir girdi olursa eski bilgiye geri donmek icin
        public string ad, oAd, oSd, sAd;
        string sorgu1 = "SELECT Ogretmen.Adi, Ogretmen.Soyadi, Ders.Adi AS Ders, Sinif.Adi AS Sinif " +
               "FROM DersSinifOgretmenAtama " +
               "JOIN Ogretmen ON DersSinifOgretmenAtama.OgretmenId = Ogretmen.Id " +
               "JOIN Sinif ON DersSinifOgretmenAtama.SinifId = Sinif.ID " +
               "JOIN Ders ON DersSinifOgretmenAtama.DersId = Ders.Id " +
               "ORDER BY Sinif.Adi";
        
        public Öğretmen_Sınıf_Ataması(string AD)
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
        
        // Ata butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (DersAtaComboBox.SelectedIndex != -1)
                {
                    if (AdAtaComboBox.SelectedIndex != -1)
                    {
                        if (SinifAtaComboBox.SelectedIndex != -1)
                        {
                            string oId = Helpers.Id_Sorgu("Ogretmen", SicilNoTextBox.Text);
                            string dId = Helpers.Id_Sorgu("Ders", DersAtaComboBox.SelectedItem.ToString());
                            string sId = Helpers.Id_Sorgu("Sinif", SinifAtaComboBox.SelectedItem.ToString());
                            string sorgu = "SELECT Id FROM DersSinifOgretmenAtama WHERE DersId = @dId AND SinifId = @sId";
                            SqlParameter[] parameters = { new SqlParameter("@dId", dId), new SqlParameter("@sId", sId) };
                            if (string.IsNullOrEmpty(Helpers.ScalarkomutCalistir(sorgu, parameters)))
                            {
                                sorgu = "INSERT INTO DersSinifOgretmenAtama (SinifId, DersId, OgretmenId) VALUES (@SinifId, @DersId, @OgretmenId)";
                                SqlParameter[] parameters1 = { new SqlParameter("@SinifId", sId), new SqlParameter("@DersId", dId), new SqlParameter("@OgretmenId", oId) };
                                Helpers.NonQueryKomutCalistir(sorgu, parameters1);

                                MessageBox.Show("Atama Başarılı");
                                Helpers.DataGridViewSatirEkle(dataGridView1, AdAtaComboBox.Text, SoyadTextBox.Text, DersAtaComboBox.Text, SinifAtaComboBox.Text, null, null);
                                SoyadTextBox.Clear();
                                SicilNoTextBox.Clear();
                                AdAtaComboBox.Text = " ";
                                DersAtaComboBox.Text = " ";
                                SinifAtaComboBox.Text = " ";
                            }
                            else
                                MessageBox.Show(SinifAtaComboBox.SelectedItem.ToString() + " Sınfı İçin Zaten " + DersAtaComboBox.SelectedItem.ToString() + " Dersine Bir Öğretmen Atanmıştır.");
                        }
                        else
                            MessageBox.Show("Lütfen sınıfı seçiniz.");
                    }
                    else
                        MessageBox.Show("Lütfen öğretmen seçiniz.");
                }
                else
                    MessageBox.Show("Lütfen ders seçiniz.");
           }
            catch
            {
                MessageBox.Show("Atama Başarısız");
            }
            finally {  }

        }

        private void Öğretmen_Sınıf_Ataması_Load(object sender, EventArgs e)
        {

        }
        
        // Temizle butonu
        private void button4_Click(object sender, EventArgs e)
        {
            AdAraTextBox.Clear();
            SoyadAraTextBox.Clear();
            SinifAraComboBox.SelectedIndex = 0;
            DersAraComboBox.SelectedIndex = 0;
            Helpers.DataGridListele(sorgu1, dataGridView1);
            //dataGridView1.Rows[0].Cells[1].Value = "AHMET";
        }

        // Guncelleme sirasinda hatali girilme durumunda eski bilgi getirmek icin
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int satırIndex = dataGridView1.CurrentCell.RowIndex;
            int kolonIndex = dataGridView1.CurrentCell.ColumnIndex;
            eskiBilgi = dataGridView1.Rows[satırIndex].Cells[kolonIndex].Value.ToString();
        }
        
        // Atanacak Ogretmenin Dersi Secilir
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string dId = Helpers.Id_Sorgu("Ders", DersAtaComboBox.SelectedItem.ToString());
                SqlCommand komut = new SqlCommand("SELECT Adi FROM Ogretmen WHERE DersId = @dId", SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@dId", dId);
                Helpers.baglantiAc();
                SqlDataReader dr = komut.ExecuteReader();

                // Önceki verileri temizle
                AdAtaComboBox.Items.Clear(); 

                while (dr.Read())
                {
                    AdAtaComboBox.Items.Add(dr["Adi"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Öğretmenler getirilemedi!");
            }
            finally
            {
                Helpers.baglantiKapat();
            }
        }
        
        // Atanacak ogretmen secilir
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu;
                SqlParameter[] parameters = new SqlParameter[1];
                string dId = Helpers.Id_Sorgu("Ders", DersAtaComboBox.SelectedItem?.ToString());
                sorgu = "SELECT SicilNo FROM Ogretmen WHERE Adi = @ad ";
                parameters[0] = new SqlParameter("@ad", AdAtaComboBox.SelectedItem.ToString());
                string no = Helpers.ScalarkomutCalistir(sorgu, parameters);

                sorgu = "SELECT Soyadi FROM Ogretmen WHERE Adi = @ad AND DersId = @dId";
                SqlParameter[] parameters1 = new SqlParameter[2];
                parameters1[0] = new SqlParameter("@ad", AdAtaComboBox.SelectedItem.ToString());
                parameters1[1] = new SqlParameter("@dId", dId);
                string soyad = Helpers.ScalarkomutCalistir(sorgu, parameters1);

                SoyadTextBox.Text = soyad;
                SicilNoTextBox.Text = no;
            }
            catch
            {
                MessageBox.Show("Ogretmen secilemedi");
            }
            finally {  }
        }
        
        // Esc tusu ile geri butonu calistirilir
        private void Öğretmen_Sınıf_Ataması_KeyDown(object sender, KeyEventArgs e)
        {
            Helpers.formuYenile(e, this);
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }
        
        // Kaydet butonu
        private void button5_Click(object sender, EventArgs e)
        {
            int satırIndex = dataGridView1.CurrentCell.RowIndex;
            int kolonIndex = dataGridView1.CurrentCell.ColumnIndex;
            try
            {
                string sorgu;
                SqlParameter[] parameters = new SqlParameter[1];
                string kolonAdi = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;
                string sId = Helpers.Id_Sorgu("Sinif", dataGridView1.Rows[satırIndex].Cells[kolonIndex].Value.ToString());
                string dId = Helpers.Id_Sorgu("Ders", dataGridView1.Rows[satırIndex].Cells["Ders"].Value.ToString());
                sorgu = "SELECT Id FROM DersSinifOgretmenAtama WHERE DersId = @dId AND SinifId = @sId";
                parameters[0] = new SqlParameter("@dId", dId);
                parameters[1] = new SqlParameter("@sId", sId);
                string kontrolId = Helpers.ScalarkomutCalistir(sorgu, parameters);

                if (string.IsNullOrEmpty(kontrolId))
                {
                    sorgu = "SELECT Id FROM Ogretmen WHERE Adi = @ad AND Soyadi = @soyad";
                    parameters[0] = new SqlParameter("@ad", dataGridView1.Rows[satırIndex].Cells["Adi"].Value.ToString());
                    parameters[1] = new SqlParameter("@soyad", dataGridView1.Rows[satırIndex].Cells["Soyadi"].Value.ToString());
                    string Id = Helpers.ScalarkomutCalistir(sorgu, parameters);

                    sorgu = "SELECT Id FROM DersSinifOgretmenAtama WHERE OgretmenId = @oId AND DersId = @dId";
                    SqlParameter[] parameters1 = new SqlParameter[1];
                    parameters1[1] = new SqlParameter("@oId", Id);
                    parameters1[0] = new SqlParameter("@dId", dId);
                    string aId = Helpers.ScalarkomutCalistir(sorgu, parameters1);

                    sorgu = "UPDATE DersSinifOgretmenAtama SET SinifId = @deger WHERE Id = @ıd";
                    SqlParameter[] parameters2 = new SqlParameter[1];
                    parameters2[1] = new SqlParameter("@deger", sId);
                    parameters2[0] = new SqlParameter("@ıd", aId);
                    Helpers.NonQueryKomutCalistir(sorgu, parameters2);
                    MessageBox.Show("Bilgi kaydedilmiştir");
                    Helpers.DataGridListele(sorgu1, dataGridView1);
                }
                else
                {
                    MessageBox.Show(dataGridView1.Rows[satırIndex].Cells[kolonIndex].Value.ToString() + " Sınfı İçin Zaten " + dataGridView1.Rows[satırIndex].Cells["Ders"].Value.ToString() + " Dersine Bir Öğretmen Atanmıştır.");
                    dataGridView1.Rows[satırIndex].Cells[kolonIndex].Value = eskiBilgi;
                }
            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız! Bilgileri doğru bir şekilde giriniz!");
                dataGridView1.Rows[satırIndex].Cells[kolonIndex].Value = eskiBilgi;
            }
            finally {  }
        }

        // Listele butonu
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0 && DersAraComboBox.SelectedIndex == 0)
                Helpers.adAra("DersSinifOgretmenAtama", dataGridView1, AdAraTextBox.Text);
            else if (string.IsNullOrEmpty(AdAraTextBox.Text) && !string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0 && DersAraComboBox.SelectedIndex == 0)
                Helpers.soyadAra("DersSinifOgretmenAtama", dataGridView1, SoyadAraTextBox.Text);
            else if (string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex != 0 && DersAraComboBox.SelectedIndex == 0)
                Helpers.sinifAra("DersSinifOgretmenAtama", dataGridView1, SinifAraComboBox.Text);
            else if (string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && SinifAraComboBox.SelectedIndex == 0 && DersAraComboBox.SelectedIndex != 0)
                Helpers.dersAra("DersSinifOgretmenAtama", dataGridView1, DersAraComboBox.Text);
            else
            {
                MessageBox.Show("Lütfen tek kategoride arama yapınız");
                AdAraTextBox.Text = string.Empty;
                SoyadAraTextBox.Text = string.Empty;
                DersAraComboBox.SelectedIndex = 0;
                SinifAraComboBox.SelectedIndex = 0;
            }
        }
        
        // Ilk giriste datagridview ve comboboxlara veri aktarımı
        private void Öğretmen_Sınıf_Ataması_Load_1(object sender, EventArgs e)
        {
            Helpers.DataGridListele(sorgu1, dataGridView1);
            Helpers.comboBoxAktarım("Sinif", SinifAtaComboBox);
            Helpers.comboBoxAktarım("Sinif", SinifAraComboBox);
            Helpers.comboBoxAktarım("Ders", DersAraComboBox);
            Helpers.comboBoxAktarım("Ders", DersAtaComboBox);
            dataGridView1.Columns["Ders"].ReadOnly = true;
            dataGridView1.Columns["Adi"].ReadOnly = true;
            dataGridView1.Columns["Soyadi"].ReadOnly = true;
            SinifAraComboBox.SelectedIndex = 0;
            DersAraComboBox.SelectedIndex = 0;
        }
        
        // Silme islemi
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Bulundugu satirdaki verileri alir
                oAd = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
                sAd = dataGridView1.CurrentRow.Cells["Sinif"].Value.ToString();
                oSd = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
                string sId = Helpers.Id_Sorgu("Sinif", sAd);
                if (MessageBox.Show("İşaretlenen satırdaki veri silinecek onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sorgu = "SELECT Id FROM Ogretmen WHERE Adi=@ad AND Soyadi=@soyad";
                    SqlParameter[] parameters = { new SqlParameter("@ad", oAd), new SqlParameter("@soyad", oSd) };
                    string oId = Helpers.ScalarkomutCalistir(sorgu, parameters);

                    sorgu = "DELETE FROM DersSinifOgretmenAtama WHERE OgretmenId=@oId AND SinifId=@sId";
                    parameters[0] = new SqlParameter("@oId", oId);
                    parameters[1] = new SqlParameter("@sId", sId);
                    Helpers.NonQueryKomutCalistir(sorgu, parameters);
                    MessageBox.Show("Belirtilen satır silindi");
                    Helpers.DataGridViewSatirSil(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Kayıt silinmedi");
                }
            }
            catch
            {
                MessageBox.Show("Kayıt silinemedi!");
            }
            finally {  }
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
