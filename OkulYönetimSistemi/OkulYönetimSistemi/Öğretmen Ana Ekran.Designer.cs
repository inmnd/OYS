using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class Öğretmen_Ekran
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
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.SicilNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GeriButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.SinifOrtalamaTextBox = new System.Windows.Forms.TextBox();
            this.TemizleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoAraTextBox = new System.Windows.Forms.TextBox();
            this.AdAraTextBox = new System.Windows.Forms.TextBox();
            this.SoyadAraTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OgrenciListeDataGridView = new System.Windows.Forms.DataGridView();
            this.SinifListeleComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BransTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SifreDegistirButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonYazdir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciListeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdTextBox
            // 
            this.AdTextBox.Enabled = false;
            this.AdTextBox.Location = new System.Drawing.Point(238, 44);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(180, 22);
            this.AdTextBox.TabIndex = 31;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Enabled = false;
            this.SoyadTextBox.Location = new System.Drawing.Point(238, 72);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(180, 22);
            this.SoyadTextBox.TabIndex = 30;
            // 
            // SicilNoTextBox
            // 
            this.SicilNoTextBox.Enabled = false;
            this.SicilNoTextBox.Location = new System.Drawing.Point(238, 12);
            this.SicilNoTextBox.Name = "SicilNoTextBox";
            this.SicilNoTextBox.Size = new System.Drawing.Size(180, 22);
            this.SicilNoTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sicil No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(1231, 831);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(141, 37);
            this.GeriButton.TabIndex = 56;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.ButtonYazdir);
            this.panel2.Controls.Add(this.KaydetButton);
            this.panel2.Controls.Add(this.ListeleButton);
            this.panel2.Controls.Add(this.SinifOrtalamaTextBox);
            this.panel2.Controls.Add(this.TemizleButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.NoAraTextBox);
            this.panel2.Controls.Add(this.AdAraTextBox);
            this.panel2.Controls.Add(this.SoyadAraTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.OgrenciListeDataGridView);
            this.panel2.Controls.Add(this.SinifListeleComboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(9, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 643);
            this.panel2.TabIndex = 57;
            // 
            // KaydetButton
            // 
            this.KaydetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KaydetButton.Location = new System.Drawing.Point(1145, 586);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(206, 47);
            this.KaydetButton.TabIndex = 107;
            this.KaydetButton.Text = "Kaydet";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // ListeleButton
            // 
            this.ListeleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListeleButton.Location = new System.Drawing.Point(1144, 206);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(201, 27);
            this.ListeleButton.TabIndex = 105;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // SinifOrtalamaTextBox
            // 
            this.SinifOrtalamaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SinifOrtalamaTextBox.Enabled = false;
            this.SinifOrtalamaTextBox.Location = new System.Drawing.Point(942, 611);
            this.SinifOrtalamaTextBox.Name = "SinifOrtalamaTextBox";
            this.SinifOrtalamaTextBox.Size = new System.Drawing.Size(192, 22);
            this.SinifOrtalamaTextBox.TabIndex = 98;
            this.SinifOrtalamaTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TemizleButton
            // 
            this.TemizleButton.Location = new System.Drawing.Point(1144, 239);
            this.TemizleButton.Name = "TemizleButton";
            this.TemizleButton.Size = new System.Drawing.Size(201, 29);
            this.TemizleButton.TabIndex = 104;
            this.TemizleButton.Text = "Temizle";
            this.TemizleButton.UseVisualStyleBackColor = true;
            this.TemizleButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(942, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 97;
            this.label5.Text = "Sınıf Ortalaması:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1144, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 98;
            this.label11.Text = "Soyad:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1144, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 23);
            this.label10.TabIndex = 99;
            this.label10.Text = "Ad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1144, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 23);
            this.label9.TabIndex = 100;
            this.label9.Text = "No:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NoAraTextBox
            // 
            this.NoAraTextBox.Location = new System.Drawing.Point(1144, 76);
            this.NoAraTextBox.Name = "NoAraTextBox";
            this.NoAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.NoAraTextBox.TabIndex = 101;
            this.NoAraTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            this.NoAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // AdAraTextBox
            // 
            this.AdAraTextBox.Location = new System.Drawing.Point(1144, 127);
            this.AdAraTextBox.Name = "AdAraTextBox";
            this.AdAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.AdAraTextBox.TabIndex = 102;
            this.AdAraTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            this.AdAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // SoyadAraTextBox
            // 
            this.SoyadAraTextBox.Location = new System.Drawing.Point(1144, 178);
            this.SoyadAraTextBox.Name = "SoyadAraTextBox";
            this.SoyadAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.SoyadAraTextBox.TabIndex = 103;
            this.SoyadAraTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged_1);
            this.SoyadAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(943, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Listele:";
            // 
            // OgrenciListeDataGridView
            // 
            this.OgrenciListeDataGridView.AllowUserToResizeColumns = false;
            this.OgrenciListeDataGridView.AllowUserToResizeRows = false;
            this.OgrenciListeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OgrenciListeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgrenciListeDataGridView.Location = new System.Drawing.Point(27, 50);
            this.OgrenciListeDataGridView.Name = "OgrenciListeDataGridView";
            this.OgrenciListeDataGridView.RowHeadersWidth = 51;
            this.OgrenciListeDataGridView.RowTemplate.Height = 24;
            this.OgrenciListeDataGridView.Size = new System.Drawing.Size(1111, 526);
            this.OgrenciListeDataGridView.TabIndex = 93;
            this.OgrenciListeDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.OgrenciListeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.OgrenciListeDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.OgrenciListeDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // SinifListeleComboBox
            // 
            this.SinifListeleComboBox.FormattingEnabled = true;
            this.SinifListeleComboBox.Location = new System.Drawing.Point(1018, 18);
            this.SinifListeleComboBox.Name = "SinifListeleComboBox";
            this.SinifListeleComboBox.Size = new System.Drawing.Size(121, 24);
            this.SinifListeleComboBox.TabIndex = 94;
            this.SinifListeleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(22, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 35);
            this.label12.TabIndex = 78;
            this.label12.Text = "Öğrenci Not Listesi";
            // 
            // BransTextBox
            // 
            this.BransTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BransTextBox.Enabled = false;
            this.BransTextBox.Location = new System.Drawing.Point(238, 99);
            this.BransTextBox.Name = "BransTextBox";
            this.BransTextBox.Size = new System.Drawing.Size(180, 22);
            this.BransTextBox.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(141, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 29);
            this.label16.TabIndex = 59;
            this.label16.Text = "Branş:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SifreDegistirButton
            // 
            this.SifreDegistirButton.Location = new System.Drawing.Point(1099, 831);
            this.SifreDegistirButton.Name = "SifreDegistirButton";
            this.SifreDegistirButton.Size = new System.Drawing.Size(126, 37);
            this.SifreDegistirButton.TabIndex = 61;
            this.SifreDegistirButton.Text = "Şifre Değiştir";
            this.SifreDegistirButton.UseVisualStyleBackColor = true;
            this.SifreDegistirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonYazdir
            // 
            this.ButtonYazdir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonYazdir.Location = new System.Drawing.Point(1145, 533);
            this.ButtonYazdir.Name = "ButtonYazdir";
            this.ButtonYazdir.Size = new System.Drawing.Size(206, 47);
            this.ButtonYazdir.TabIndex = 108;
            this.ButtonYazdir.Text = "Yazdır";
            this.ButtonYazdir.UseVisualStyleBackColor = true;
            this.ButtonYazdir.Click += new System.EventHandler(this.ButtonYazdir_Click);
            // 
            // Öğretmen_Ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 885);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SifreDegistirButton);
            this.Controls.Add(this.BransTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.SicilNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Öğretmen_Ekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Ekran";
            this.Load += new System.EventHandler(this.Öğretmen_Ekran_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Öğretmen_Ekran_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciListeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

      

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox SicilNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView OgrenciListeDataGridView;
        private System.Windows.Forms.TextBox BransTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SinifListeleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SifreDegistirButton;
        private System.Windows.Forms.Button TemizleButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoAraTextBox;
        private System.Windows.Forms.TextBox AdAraTextBox;
        private System.Windows.Forms.TextBox SoyadAraTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SinifOrtalamaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.Button KaydetButton;
        private Button ButtonYazdir;
    }
}