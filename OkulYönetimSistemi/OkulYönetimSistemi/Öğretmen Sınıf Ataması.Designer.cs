using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class Öğretmen_Sınıf_Ataması
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdAtaComboBox = new System.Windows.Forms.ComboBox();
            this.DersAtaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AtaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.SicilNoTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SinifAtaComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.DersAraComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TemizleButton = new System.Windows.Forms.Button();
            this.SinifAraComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AdAraTextBox = new System.Windows.Forms.TextBox();
            this.SoyadAraTextBox = new System.Windows.Forms.TextBox();
            this.SilButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.GeriButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.AdAtaComboBox);
            this.panel1.Controls.Add(this.DersAtaComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AtaButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SoyadTextBox);
            this.panel1.Controls.Add(this.SicilNoTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.SinifAtaComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 264);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdAtaComboBox
            // 
            this.AdAtaComboBox.FormattingEnabled = true;
            this.AdAtaComboBox.Location = new System.Drawing.Point(113, 108);
            this.AdAtaComboBox.Name = "AdAtaComboBox";
            this.AdAtaComboBox.Size = new System.Drawing.Size(163, 24);
            this.AdAtaComboBox.TabIndex = 100;
            this.AdAtaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // DersAtaComboBox
            // 
            this.DersAtaComboBox.FormattingEnabled = true;
            this.DersAtaComboBox.Location = new System.Drawing.Point(113, 53);
            this.DersAtaComboBox.Name = "DersAtaComboBox";
            this.DersAtaComboBox.Size = new System.Drawing.Size(121, 24);
            this.DersAtaComboBox.TabIndex = 99;
            this.DersAtaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 32);
            this.label3.TabIndex = 97;
            this.label3.Text = "Öğretmen Sınıf Ataması";
            // 
            // AtaButton
            // 
            this.AtaButton.Location = new System.Drawing.Point(436, 197);
            this.AtaButton.Name = "AtaButton";
            this.AtaButton.Size = new System.Drawing.Size(171, 39);
            this.AtaButton.TabIndex = 96;
            this.AtaButton.Text = "ATA";
            this.AtaButton.UseVisualStyleBackColor = true;
            this.AtaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "Sınıf:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "Ders:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Enabled = false;
            this.SoyadTextBox.Location = new System.Drawing.Point(113, 138);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(319, 22);
            this.SoyadTextBox.TabIndex = 93;
            // 
            // SicilNoTextBox
            // 
            this.SicilNoTextBox.Enabled = false;
            this.SicilNoTextBox.Location = new System.Drawing.Point(113, 83);
            this.SicilNoTextBox.Name = "SicilNoTextBox";
            this.SicilNoTextBox.Size = new System.Drawing.Size(319, 22);
            this.SicilNoTextBox.TabIndex = 91;
            this.SicilNoTextBox.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(36, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 23);
            this.label14.TabIndex = 90;
            this.label14.Text = "Soyad:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(42, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 23);
            this.label15.TabIndex = 89;
            this.label15.Text = "Ad:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(3, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 23);
            this.label16.TabIndex = 88;
            this.label16.Text = "Sicil No:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SinifAtaComboBox
            // 
            this.SinifAtaComboBox.FormattingEnabled = true;
            this.SinifAtaComboBox.Location = new System.Drawing.Point(113, 166);
            this.SinifAtaComboBox.Name = "SinifAtaComboBox";
            this.SinifAtaComboBox.Size = new System.Drawing.Size(121, 24);
            this.SinifAtaComboBox.TabIndex = 1;
            this.SinifAtaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.KaydetButton);
            this.panel2.Controls.Add(this.ListeleButton);
            this.panel2.Controls.Add(this.DersAraComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TemizleButton);
            this.panel2.Controls.Add(this.SinifAraComboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.AdAraTextBox);
            this.panel2.Controls.Add(this.SoyadAraTextBox);
            this.panel2.Controls.Add(this.SilButton);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 441);
            this.panel2.TabIndex = 94;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(892, 392);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(198, 36);
            this.KaydetButton.TabIndex = 108;
            this.KaydetButton.Text = "KAYDET";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ListeleButton
            // 
            this.ListeleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListeleButton.Location = new System.Drawing.Point(889, 261);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(201, 27);
            this.ListeleButton.TabIndex = 107;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // DersAraComboBox
            // 
            this.DersAraComboBox.FormattingEnabled = true;
            this.DersAraComboBox.Items.AddRange(new object[] {
            "Tüm"});
            this.DersAraComboBox.Location = new System.Drawing.Point(887, 231);
            this.DersAraComboBox.Name = "DersAraComboBox";
            this.DersAraComboBox.Size = new System.Drawing.Size(123, 24);
            this.DersAraComboBox.TabIndex = 105;
            this.DersAraComboBox.Text = "Tüm";
            this.DersAraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(887, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 106;
            this.label5.Text = "Ders:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TemizleButton
            // 
            this.TemizleButton.Location = new System.Drawing.Point(889, 294);
            this.TemizleButton.Name = "TemizleButton";
            this.TemizleButton.Size = new System.Drawing.Size(201, 29);
            this.TemizleButton.TabIndex = 104;
            this.TemizleButton.Text = "Temizle";
            this.TemizleButton.UseVisualStyleBackColor = true;
            this.TemizleButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SinifAraComboBox
            // 
            this.SinifAraComboBox.FormattingEnabled = true;
            this.SinifAraComboBox.Items.AddRange(new object[] {
            "Tüm"});
            this.SinifAraComboBox.Location = new System.Drawing.Point(887, 178);
            this.SinifAraComboBox.Name = "SinifAraComboBox";
            this.SinifAraComboBox.Size = new System.Drawing.Size(123, 24);
            this.SinifAraComboBox.TabIndex = 96;
            this.SinifAraComboBox.Text = "Tüm";
            this.SinifAraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(887, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 23);
            this.label12.TabIndex = 97;
            this.label12.Text = "Sınıf:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(887, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 98;
            this.label11.Text = "Soyad:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(887, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 99;
            this.label10.Text = "Ad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdAraTextBox
            // 
            this.AdAraTextBox.Location = new System.Drawing.Point(887, 76);
            this.AdAraTextBox.Name = "AdAraTextBox";
            this.AdAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.AdAraTextBox.TabIndex = 102;
            this.AdAraTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.AdAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // SoyadAraTextBox
            // 
            this.SoyadAraTextBox.Location = new System.Drawing.Point(887, 127);
            this.SoyadAraTextBox.Name = "SoyadAraTextBox";
            this.SoyadAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.SoyadAraTextBox.TabIndex = 103;
            this.SoyadAraTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.SoyadAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(892, 350);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(198, 36);
            this.SilButton.TabIndex = 95;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 377);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 35);
            this.label4.TabIndex = 78;
            this.label4.Text = "Öğretmen Sınıf Ataması Kayıt Listesi";
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(930, 754);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 37);
            this.GeriButton.TabIndex = 96;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Öğretmen_Sınıf_Ataması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1134, 792);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Öğretmen_Sınıf_Ataması";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Sınıf Ataması";
            this.Load += new System.EventHandler(this.Öğretmen_Sınıf_Ataması_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Öğretmen_Sınıf_Ataması_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SinifAtaComboBox;
        private System.Windows.Forms.Button AtaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox SicilNoTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button TemizleButton;
        private System.Windows.Forms.ComboBox SinifAraComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AdAraTextBox;
        private System.Windows.Forms.TextBox SoyadAraTextBox;
        private System.Windows.Forms.ComboBox DersAtaComboBox;
        private System.Windows.Forms.ComboBox AdAtaComboBox;
        private System.Windows.Forms.ComboBox DersAraComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.Button KaydetButton;
    }
}