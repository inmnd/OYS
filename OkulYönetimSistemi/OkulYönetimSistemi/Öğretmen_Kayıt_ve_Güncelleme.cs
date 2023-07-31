using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulYönetimSistemi
{
    public partial class Öğretmen_Kayıt_ve_Güncelleme : Form
    {
        string ad, eskiBilgi, oId;
        string sorgu1 = "SELECT o.SicilNo, o.Adi ,o.Soyadi ,o.Telefon,o.Adres,d.Adi AS Branş FROM Ogretmen AS o , Ders AS d " +
                    "WHERE d.Id = o.DersId ORDER BY SicilNo";
        bool kontrol, kontrol2;
        byte[] resim;
        OpenFileDialog ofd = new OpenFileDialog();
        string impath = null;

        public Öğretmen_Kayıt_ve_Güncelleme(string AD)
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

        // Kaydet/Guncelle Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu;

                if (!string.IsNullOrEmpty(oId))
                {
                    kontrol2 = true;
                    if (DersAraComboBox.SelectedIndex != -1 && AdTextBox.Text != "" && SoyadTextBox.Text != "")
                    {
                        bool kontrol1 = Helpers.IsValidMobilePhoneNumber(TelefonTextBox.Text);
                        if (kontrol1)
                        {
                            sorgu = "UPDATE Ogretmen SET SicilNo = @no , Adi = @ad , Soyadi = @sAd , Telefon = @tel , Adres = @adres" +
                                            ", Resim = @resim  WHERE Id = @oId ";
                            SqlParameter[] parameters = new SqlParameter[7];
                            parameters[0] = new SqlParameter("@no", SicilNoTextBox.Text);
                            parameters[1] = new SqlParameter("@ad", AdTextBox.Text);
                            parameters[2] = new SqlParameter("@sAd", SoyadTextBox.Text);
                            parameters[3] = new SqlParameter("@tel", TelefonTextBox.Text);
                            parameters[4] = new SqlParameter("@adres", AdresTextBox.Text);
                            parameters[5] = new SqlParameter("@oId", oId);
                            if (!kontrol)
                            {
                                parameters[6] = new SqlParameter("@resim", resim);
                                kontrol = false;
                            }
                            else
                            {
                                byte[] resimBytes = Helpers.resimBinaryCevirme(impath);
                                parameters[6] = new SqlParameter("@resim", SqlDbType.Image) { Value = resimBytes };
                            }
                            Helpers.NonQueryKomutCalistir(sorgu, parameters);
                            MessageBox.Show("Güncelleme işlemi tamamlandı");

                            oId = null;
                            Helpers.DataGridViewSatirSil(OgretmenDataGridView);
                            Helpers.DataGridViewSatirEkle(OgretmenDataGridView, SicilNoTextBox.Text, AdTextBox.Text, SoyadTextBox.Text, TelefonTextBox.Text, AdresTextBox.Text, BransCombobox.Text);
                            SicilNoTextBox.Text = " ";
                            AdTextBox.Text = " ";
                            SoyadTextBox.Text = " ";
                            TelefonTextBox.Text = " ";
                            AdresTextBox.Text = " ";
                            BransCombobox.Text = " ";
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
                    kontrol2 = false;
                    BransCombobox.Enabled = true;
                    kontrol = false;
                }
                else
                {
                    if (BransCombobox.SelectedIndex != -1 && AdTextBox.Text != "" && SoyadTextBox.Text != "")
                    {
                        string phoneNumber = TelefonTextBox.Text;
                        bool isValid = Helpers.IsValidMobilePhoneNumber(phoneNumber);
                        if (isValid)
                        {
                            // Ders Secimi
                            sorgu = "SELECT Id FROM Ders WHERE Adi=@adi";
                            SqlParameter[] parameters = new SqlParameter[8];
                            parameters[0] = new SqlParameter("@adi", BransCombobox.SelectedItem.ToString());
                            int dId = Convert.ToInt32(Helpers.ScalarkomutCalistir(sorgu, parameters));
                            Random rnd = new Random();
                            int sifre = rnd.Next(1, 1001);


                            sorgu = "INSERT INTO Ogretmen (SicilNo, DersId, Adi, Soyadi, Telefon, Adres, Sifre, Resim) " +
                                       "VALUES (@SicilNo, @DersId, @Adi, @Soyadi, @Telefon, @Adres, @Sifre, @Resim)";
                            parameters[0] = new SqlParameter("@SicilNo", Convert.ToInt32(SicilNoTextBox.Text));
                            parameters[1] = new SqlParameter("@DersId", dId);
                            parameters[2] = new SqlParameter("@Adi", AdTextBox.Text);
                            parameters[3] = new SqlParameter("@Soyadi", SoyadTextBox.Text);
                            parameters[4] = new SqlParameter("@Telefon", TelefonTextBox.Text);
                            parameters[5] = new SqlParameter("@Adres", AdresTextBox.Text);
                            parameters[6] = new SqlParameter("@Sifre", sifre);
                            byte[] resimBytes = Helpers.resimBinaryCevirme(impath);
                            parameters[7] = new SqlParameter("@resim", SqlDbType.Image) { Value = resimBytes };
                            Helpers.NonQueryKomutCalistir(sorgu, parameters);

                            MessageBox.Show("Kayıt başarılı");
                            Helpers.DataGridViewSatirEkle(OgretmenDataGridView, SicilNoTextBox.Text, AdTextBox.Text, SoyadTextBox.Text, TelefonTextBox.Text, AdresTextBox.Text, BransCombobox.Text);
                            SicilNoTextBox.Text = " ";
                            AdTextBox.Text = " ";
                            SoyadTextBox.Text = " ";
                            TelefonTextBox.Text = " ";
                            AdresTextBox.Text = " ";
                            BransCombobox.Text = " ";
                        }
                        else
                            MessageBox.Show("Lütfen telofon numarasını doğru bir şekilde girinz");
                    }
                    else
                    {
                        MessageBox.Show("Dersi seçiniz");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kayıt yapılamadı!! Lütfen girdiğiniz sicilno'ya sahip başka öğretmen bulunup bulunmadığını kontrol ediniz:");
            }
            finally { }
        }

        // Datagridview ve comboboxlara veri aktarımı
        private void Öğretmen_Kayıt_ve_Güncelleme_Load(object sender, EventArgs e)
        {
            Helpers.DataGridListele(sorgu1, OgretmenDataGridView);
            Helpers.comboBoxAktarım("Ders", BransCombobox);
            Helpers.comboBoxAktarım("Ders", DersAraComboBox);
            DersAraComboBox.SelectedIndex = 0;
            OgretmenDataGridView.ReadOnly = true;
        }

        // Silme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (OgretmenDataGridView.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Kayıt silinecek onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Id = Helpers.Id_Sorgu("Ogretmen", OgretmenDataGridView.CurrentRow.Cells["SicilNo"].Value.ToString());
                        string sorgu = "DELETE FROM DersSinifOgretmenAtama WHERE OgretmenId=@OgretmenId";
                        SqlParameter[] parameters = { new SqlParameter("@OgretmenId", Id) };
                        Helpers.NonQueryKomutCalistir(sorgu, parameters);

                        sorgu = "DELETE FROM Ogretmen WHERE Id=@Id";
                        parameters[0] = new SqlParameter("@Id", Id);
                        Helpers.NonQueryKomutCalistir(sorgu, parameters);
                        MessageBox.Show("Kayıt silindi");

                        Helpers.DataGridViewSatirSil(OgretmenDataGridView);
                        BransCombobox.Enabled = true;
                        BransCombobox.Text = string.Empty;
                        SicilNoTextBox.Text = string.Empty;
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
            finally { }
        }

        // Guncelleme verileri aktarma
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int satırIndex = OgretmenDataGridView.CurrentCell.RowIndex;
            SicilNoTextBox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["SicilNo"].Value.ToString();
            AdTextBox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["Adi"].Value.ToString();
            SoyadTextBox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["Soyadi"].Value.ToString();
            TelefonTextBox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["Telefon"].Value.ToString();
            AdresTextBox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["Adres"].Value.ToString();
            BransCombobox.Text = OgretmenDataGridView.Rows[satırIndex].Cells["Branş"].Value.ToString();
            oId = Helpers.Id_Sorgu("Ogretmen", SicilNoTextBox.Text);
            BransCombobox.Enabled = false;
            try
            {
                string sorgu = "SELECT Resim FROM Ogretmen WHERE SicilNo = @NO";
                SqlCommand komut = new SqlCommand(sorgu, SqlBaglanti.baglanti);
                komut.Parameters.AddWithValue("@NO", SicilNoTextBox.Text);
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

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BransCombobox.Focus();
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
        }

        // Temizle butonu
        private void button2_Click(object sender, EventArgs e)
        {
            SicilNoAraTextBox.Clear();
            AdAraTextBox.Clear();
            SoyadAraTextBox.Clear();
            DersAraComboBox.SelectedIndex = 0;
            Helpers.DataGridListele(sorgu1, OgretmenDataGridView);
            oId = null;
        }

        private void Öğretmen_Kayıt_ve_Güncelleme_KeyDown(object sender, KeyEventArgs e)
        {
            Helpers.formuYenile(e, this);
            if (e.KeyCode == Keys.Escape)
                button3_Click(sender, e);
        }

        // Hatali girdi yapilinca eski veriye geri donmek icin
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int satırIndex = OgretmenDataGridView.CurrentCell.RowIndex;
            int kolonIndex = OgretmenDataGridView.CurrentCell.ColumnIndex;
            eskiBilgi = OgretmenDataGridView.Rows[satırIndex].Cells[kolonIndex].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BransCombobox.Enabled = true;
            BransCombobox.Text = string.Empty;
            SicilNoTextBox.Text = string.Empty;
            AdTextBox.Text = string.Empty;
            SoyadTextBox.Text = string.Empty;
            TelefonTextBox.Text = string.Empty;
            AdresTextBox.Text = string.Empty;
            pictureBox1.Image = null;
        }

        // Resim secme butonu
        private void button5_Click(object sender, EventArgs e)
        {
            Helpers.resimButonGetirme(ofd, pictureBox1, ref impath);
            if (!string.IsNullOrEmpty(Helpers.Id_Sorgu("Ogretmen", SicilNoTextBox.Text)))
                kontrol = true;
        }

        // Listele butonu
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SicilNoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && DersAraComboBox.SelectedIndex == 0)
                Helpers.noAra("Ogretmen", OgretmenDataGridView, SicilNoAraTextBox.Text);
            else if (string.IsNullOrEmpty(SicilNoAraTextBox.Text) && !string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && DersAraComboBox.SelectedIndex == 0)
                Helpers.adAra("Ogretmen", OgretmenDataGridView, AdAraTextBox.Text);
            else if (string.IsNullOrEmpty(SicilNoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && !string.IsNullOrEmpty(SoyadAraTextBox.Text) && DersAraComboBox.SelectedIndex == 0)
                Helpers.soyadAra("Ogretmen", OgretmenDataGridView, SoyadAraTextBox.Text);
            else if (string.IsNullOrEmpty(SicilNoAraTextBox.Text) && string.IsNullOrEmpty(AdAraTextBox.Text) && string.IsNullOrEmpty(SoyadAraTextBox.Text) && DersAraComboBox.SelectedIndex != 0)
                Helpers.dersAra("Ogretmen", OgretmenDataGridView, DersAraComboBox.Text);
            else
            {
                MessageBox.Show("Lütfen bir kategoride arama yapınız");
                SoyadAraTextBox.Text = string.Empty;
                AdAraTextBox.Text = string.Empty;
                SicilNoAraTextBox.Text = string.Empty;
                DersAraComboBox.SelectedIndex = 0;
            }
        }

    }
}
