using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class Öğretmen_Kayıt_ve_Güncelleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeriButton = new System.Windows.Forms.Button();
            this.KayıtPanel = new System.Windows.Forms.Panel();
            this.Temizle1Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResimButton = new System.Windows.Forms.Button();
            this.BransCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KaydetGuncelleButton = new System.Windows.Forms.Button();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.SicilNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListePanel = new System.Windows.Forms.Panel();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.TemizleButton = new System.Windows.Forms.Button();
            this.DersAraComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SicilNoAraTextBox = new System.Windows.Forms.TextBox();
            this.AdAraTextBox = new System.Windows.Forms.TextBox();
            this.SoyadAraTextBox = new System.Windows.Forms.TextBox();
            this.OgretmenDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.KayıtPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ListePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgretmenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(1072, 749);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 37);
            this.GeriButton.TabIndex = 14;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // KayıtPanel
            // 
            this.KayıtPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.KayıtPanel.Controls.Add(this.Temizle1Button);
            this.KayıtPanel.Controls.Add(this.panel3);
            this.KayıtPanel.Controls.Add(this.ResimButton);
            this.KayıtPanel.Controls.Add(this.BransCombobox);
            this.KayıtPanel.Controls.Add(this.label9);
            this.KayıtPanel.Controls.Add(this.KaydetGuncelleButton);
            this.KayıtPanel.Controls.Add(this.AdresTextBox);
            this.KayıtPanel.Controls.Add(this.TelefonTextBox);
            this.KayıtPanel.Controls.Add(this.SoyadTextBox);
            this.KayıtPanel.Controls.Add(this.AdTextBox);
            this.KayıtPanel.Controls.Add(this.SicilNoTextBox);
            this.KayıtPanel.Controls.Add(this.label7);
            this.KayıtPanel.Controls.Add(this.label6);
            this.KayıtPanel.Controls.Add(this.label5);
            this.KayıtPanel.Controls.Add(this.label4);
            this.KayıtPanel.Controls.Add(this.label3);
            this.KayıtPanel.Controls.Add(this.label2);
            this.KayıtPanel.Location = new System.Drawing.Point(3, 12);
            this.KayıtPanel.Name = "KayıtPanel";
            this.KayıtPanel.Size = new System.Drawing.Size(667, 289);
            this.KayıtPanel.TabIndex = 94;
            // 
            // Temizle1Button
            // 
            this.Temizle1Button.BackColor = System.Drawing.SystemColors.Control;
            this.Temizle1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Temizle1Button.Location = new System.Drawing.Point(360, 27);
            this.Temizle1Button.Name = "Temizle1Button";
            this.Temizle1Button.Size = new System.Drawing.Size(76, 29);
            this.Temizle1Button.TabIndex = 98;
            this.Temizle1Button.Text = "Temizle";
            this.Temizle1Button.UseVisualStyleBackColor = false;
            this.Temizle1Button.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(480, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 156);
            this.panel3.TabIndex = 93;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // ResimButton
            // 
            this.ResimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResimButton.Location = new System.Drawing.Point(524, 183);
            this.ResimButton.Name = "ResimButton";
            this.ResimButton.Size = new System.Drawing.Size(45, 32);
            this.ResimButton.TabIndex = 97;
            this.ResimButton.Text = "...";
            this.ResimButton.UseVisualStyleBackColor = true;
            this.ResimButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // BransCombobox
            // 
            this.BransCombobox.FormattingEnabled = true;
            this.BransCombobox.Location = new System.Drawing.Point(117, 202);
            this.BransCombobox.Name = "BransCombobox";
            this.BransCombobox.Size = new System.Drawing.Size(121, 24);
            this.BransCombobox.TabIndex = 6;
            this.BransCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 92;
            this.label9.Text = "Branş:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KaydetGuncelleButton
            // 
            this.KaydetGuncelleButton.Location = new System.Drawing.Point(454, 249);
            this.KaydetGuncelleButton.Name = "KaydetGuncelleButton";
            this.KaydetGuncelleButton.Size = new System.Drawing.Size(201, 37);
            this.KaydetGuncelleButton.TabIndex = 7;
            this.KaydetGuncelleButton.Text = "KAYDET/GÜNCELLE";
            this.KaydetGuncelleButton.UseVisualStyleBackColor = true;
            this.KaydetGuncelleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(117, 174);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(319, 22);
            this.AdresTextBox.TabIndex = 5;
            this.AdresTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.Location = new System.Drawing.Point(117, 146);
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(319, 22);
            this.TelefonTextBox.TabIndex = 4;
            this.TelefonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(117, 118);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(319, 22);
            this.SoyadTextBox.TabIndex = 3;
            this.SoyadTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(117, 90);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(319, 22);
            this.AdTextBox.TabIndex = 2;
            this.AdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // SicilNoTextBox
            // 
            this.SicilNoTextBox.Location = new System.Drawing.Point(117, 62);
            this.SicilNoTextBox.Name = "SicilNoTextBox";
            this.SicilNoTextBox.Size = new System.Drawing.Size(319, 22);
            this.SicilNoTextBox.TabIndex = 1;
            this.SicilNoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SicilNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Adres:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 82;
            this.label6.Text = "Telefon:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 81;
            this.label5.Text = "Soyad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Ad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "Sicil No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 78;
            this.label2.Text = "Öğretmen Kayıt";
            // 
            // ListePanel
            // 
            this.ListePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListePanel.Controls.Add(this.ListeleButton);
            this.ListePanel.Controls.Add(this.SilButton);
            this.ListePanel.Controls.Add(this.TemizleButton);
            this.ListePanel.Controls.Add(this.DersAraComboBox);
            this.ListePanel.Controls.Add(this.label12);
            this.ListePanel.Controls.Add(this.label11);
            this.ListePanel.Controls.Add(this.label10);
            this.ListePanel.Controls.Add(this.label8);
            this.ListePanel.Controls.Add(this.SicilNoAraTextBox);
            this.ListePanel.Controls.Add(this.AdAraTextBox);
            this.ListePanel.Controls.Add(this.SoyadAraTextBox);
            this.ListePanel.Controls.Add(this.OgretmenDataGridView);
            this.ListePanel.Controls.Add(this.label1);
            this.ListePanel.Location = new System.Drawing.Point(3, 307);
            this.ListePanel.Name = "ListePanel";
            this.ListePanel.Size = new System.Drawing.Size(1270, 424);
            this.ListePanel.TabIndex = 93;
            // 
            // ListeleButton
            // 
            this.ListeleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListeleButton.Location = new System.Drawing.Point(1064, 259);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(201, 27);
            this.ListeleButton.TabIndex = 100;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(1064, 372);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(201, 37);
            this.SilButton.TabIndex = 13;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // TemizleButton
            // 
            this.TemizleButton.Location = new System.Drawing.Point(1064, 292);
            this.TemizleButton.Name = "TemizleButton";
            this.TemizleButton.Size = new System.Drawing.Size(201, 29);
            this.TemizleButton.TabIndex = 12;
            this.TemizleButton.Text = "Temizle";
            this.TemizleButton.UseVisualStyleBackColor = true;
            this.TemizleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DersAraComboBox
            // 
            this.DersAraComboBox.FormattingEnabled = true;
            this.DersAraComboBox.Items.AddRange(new object[] {
            "Tüm"});
            this.DersAraComboBox.Location = new System.Drawing.Point(1064, 229);
            this.DersAraComboBox.Name = "DersAraComboBox";
            this.DersAraComboBox.Size = new System.Drawing.Size(123, 24);
            this.DersAraComboBox.TabIndex = 11;
            this.DersAraComboBox.Text = "Tüm";
            this.DersAraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1069, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 23);
            this.label12.TabIndex = 96;
            this.label12.Text = "Ders:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1064, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 97;
            this.label11.Text = "Soyad:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1064, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 98;
            this.label10.Text = "Ad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1064, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 99;
            this.label8.Text = "SicilNo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SicilNoAraTextBox
            // 
            this.SicilNoAraTextBox.Location = new System.Drawing.Point(1064, 76);
            this.SicilNoAraTextBox.Name = "SicilNoAraTextBox";
            this.SicilNoAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.SicilNoAraTextBox.TabIndex = 8;
            this.SicilNoAraTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.SicilNoAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // AdAraTextBox
            // 
            this.AdAraTextBox.Location = new System.Drawing.Point(1064, 127);
            this.AdAraTextBox.Name = "AdAraTextBox";
            this.AdAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.AdAraTextBox.TabIndex = 9;
            this.AdAraTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.AdAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // SoyadAraTextBox
            // 
            this.SoyadAraTextBox.Location = new System.Drawing.Point(1064, 178);
            this.SoyadAraTextBox.Name = "SoyadAraTextBox";
            this.SoyadAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.SoyadAraTextBox.TabIndex = 10;
            this.SoyadAraTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.SoyadAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // OgretmenDataGridView
            // 
            this.OgretmenDataGridView.AllowUserToResizeColumns = false;
            this.OgretmenDataGridView.AllowUserToResizeRows = false;
            this.OgretmenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OgretmenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgretmenDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgretmenDataGridView.Location = new System.Drawing.Point(27, 50);
            this.OgretmenDataGridView.Name = "OgretmenDataGridView";
            this.OgretmenDataGridView.RowHeadersWidth = 51;
            this.OgretmenDataGridView.RowTemplate.Height = 24;
            this.OgretmenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OgretmenDataGridView.Size = new System.Drawing.Size(1031, 359);
            this.OgretmenDataGridView.TabIndex = 94;
            this.OgretmenDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.OgretmenDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.OgretmenDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 78;
            this.label1.Text = "Öğretmen Kayıt Listesi";
            // 
            // Öğretmen_Kayıt_ve_Güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 798);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.KayıtPanel);
            this.Controls.Add(this.ListePanel);
            this.KeyPreview = true;
            this.Name = "Öğretmen_Kayıt_ve_Güncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Kayıt ve Güncelleme";
            this.Load += new System.EventHandler(this.Öğretmen_Kayıt_ve_Güncelleme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Öğretmen_Kayıt_ve_Güncelleme_KeyDown);
            this.KayıtPanel.ResumeLayout(false);
            this.KayıtPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ListePanel.ResumeLayout(false);
            this.ListePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgretmenDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Panel KayıtPanel;
        private System.Windows.Forms.Button KaydetGuncelleButton;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.TextBox SicilNoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ListePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.DataGridView OgretmenDataGridView;
        private System.Windows.Forms.ComboBox BransCombobox;
        private System.Windows.Forms.Button TemizleButton;
        private System.Windows.Forms.ComboBox DersAraComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SicilNoAraTextBox;
        private System.Windows.Forms.TextBox AdAraTextBox;
        private System.Windows.Forms.TextBox SoyadAraTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ResimButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.Button Temizle1Button;
    }
}