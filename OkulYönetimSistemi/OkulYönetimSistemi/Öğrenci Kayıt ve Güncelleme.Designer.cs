using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class Öğrenci_Kayıt_ve_Güncelleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Temizle1Button = new System.Windows.Forms.Button();
            this.ResimButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SinifComboBox = new System.Windows.Forms.ComboBox();
            this.KaydetGuncelleButton = new System.Windows.Forms.Button();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.NoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.OgrenciListeleDataGridView = new System.Windows.Forms.DataGridView();
            this.TemizleButton = new System.Windows.Forms.Button();
            this.SinifAraComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoAraTextBox = new System.Windows.Forms.TextBox();
            this.AdAraTextBox = new System.Windows.Forms.TextBox();
            this.SoyadAraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.Temizle1Button);
            this.panel2.Controls.Add(this.ResimButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SinifComboBox);
            this.panel2.Controls.Add(this.KaydetGuncelleButton);
            this.panel2.Controls.Add(this.AdresTextBox);
            this.panel2.Controls.Add(this.TelefonTextBox);
            this.panel2.Controls.Add(this.SoyadTextBox);
            this.panel2.Controls.Add(this.AdTextBox);
            this.panel2.Controls.Add(this.NoTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 278);
            this.panel2.TabIndex = 1;
            // 
            // Temizle1Button
            // 
            this.Temizle1Button.BackColor = System.Drawing.SystemColors.Control;
            this.Temizle1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Temizle1Button.Location = new System.Drawing.Point(360, 27);
            this.Temizle1Button.Name = "Temizle1Button";
            this.Temizle1Button.Size = new System.Drawing.Size(76, 29);
            this.Temizle1Button.TabIndex = 97;
            this.Temizle1Button.Text = "Temizle";
            this.Temizle1Button.UseVisualStyleBackColor = false;
            this.Temizle1Button.Click += new System.EventHandler(this.button7_Click);
            // 
            // ResimButton
            // 
            this.ResimButton.BackColor = System.Drawing.SystemColors.Control;
            this.ResimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResimButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResimButton.Location = new System.Drawing.Point(527, 189);
            this.ResimButton.Name = "ResimButton";
            this.ResimButton.Size = new System.Drawing.Size(45, 32);
            this.ResimButton.TabIndex = 97;
            this.ResimButton.Text = "...";
            this.ResimButton.UseVisualStyleBackColor = false;
            this.ResimButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(478, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 155);
            this.panel3.TabIndex = 94;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // SinifComboBox
            // 
            this.SinifComboBox.FormattingEnabled = true;
            this.SinifComboBox.Location = new System.Drawing.Point(117, 202);
            this.SinifComboBox.Name = "SinifComboBox";
            this.SinifComboBox.Size = new System.Drawing.Size(123, 24);
            this.SinifComboBox.TabIndex = 6;
            this.SinifComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // KaydetGuncelleButton
            // 
            this.KaydetGuncelleButton.BackColor = System.Drawing.SystemColors.Control;
            this.KaydetGuncelleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KaydetGuncelleButton.Location = new System.Drawing.Point(442, 227);
            this.KaydetGuncelleButton.Name = "KaydetGuncelleButton";
            this.KaydetGuncelleButton.Size = new System.Drawing.Size(201, 37);
            this.KaydetGuncelleButton.TabIndex = 7;
            this.KaydetGuncelleButton.Text = "KAYDET/GÜNCELLE";
            this.KaydetGuncelleButton.UseVisualStyleBackColor = false;
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
            // NoTextBox
            // 
            this.NoTextBox.Location = new System.Drawing.Point(117, 62);
            this.NoTextBox.Name = "NoTextBox";
            this.NoTextBox.Size = new System.Drawing.Size(319, 22);
            this.NoTextBox.TabIndex = 1;
            this.NoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(52, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "Sınıf:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(35, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Adres:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(27, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 82;
            this.label6.Text = "Telefon:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(35, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 81;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(61, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Ad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(62, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 78;
            this.label2.Text = "Öğrenci Kayıt";
            // 
            // GeriButton
            // 
            this.GeriButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GeriButton.BackColor = System.Drawing.SystemColors.Control;
            this.GeriButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeriButton.Location = new System.Drawing.Point(1076, 730);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 37);
            this.GeriButton.TabIndex = 92;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = false;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SilButton
            // 
            this.SilButton.BackColor = System.Drawing.SystemColors.Control;
            this.SilButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SilButton.Location = new System.Drawing.Point(1064, 378);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(201, 37);
            this.SilButton.TabIndex = 91;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = false;
            this.SilButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ListeleButton);
            this.panel1.Controls.Add(this.OgrenciListeleDataGridView);
            this.panel1.Controls.Add(this.TemizleButton);
            this.panel1.Controls.Add(this.SinifAraComboBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NoAraTextBox);
            this.panel1.Controls.Add(this.AdAraTextBox);
            this.panel1.Controls.Add(this.SoyadAraTextBox);
            this.panel1.Controls.Add(this.SilButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 429);
            this.panel1.TabIndex = 97;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ListeleButton
            // 
            this.ListeleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListeleButton.Location = new System.Drawing.Point(1064, 272);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(201, 27);
            this.ListeleButton.TabIndex = 96;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // OgrenciListeleDataGridView
            // 
            this.OgrenciListeleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OgrenciListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OgrenciListeleDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.OgrenciListeleDataGridView.Location = new System.Drawing.Point(27, 40);
            this.OgrenciListeleDataGridView.Name = "OgrenciListeleDataGridView";
            this.OgrenciListeleDataGridView.RowHeadersWidth = 51;
            this.OgrenciListeleDataGridView.RowTemplate.Height = 24;
            this.OgrenciListeleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OgrenciListeleDataGridView.Size = new System.Drawing.Size(1031, 375);
            this.OgrenciListeleDataGridView.TabIndex = 95;
            this.OgrenciListeleDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit_1);
            this.OgrenciListeleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.OgrenciListeleDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            this.OgrenciListeleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit_1);
            this.OgrenciListeleDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // TemizleButton
            // 
            this.TemizleButton.BackColor = System.Drawing.SystemColors.Control;
            this.TemizleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TemizleButton.Location = new System.Drawing.Point(1064, 305);
            this.TemizleButton.Name = "TemizleButton";
            this.TemizleButton.Size = new System.Drawing.Size(201, 29);
            this.TemizleButton.TabIndex = 94;
            this.TemizleButton.Text = "Temizle";
            this.TemizleButton.UseVisualStyleBackColor = false;
            this.TemizleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SinifAraComboBox
            // 
            this.SinifAraComboBox.FormattingEnabled = true;
            this.SinifAraComboBox.Items.AddRange(new object[] {
            "Tüm"});
            this.SinifAraComboBox.Location = new System.Drawing.Point(1064, 231);
            this.SinifAraComboBox.Name = "SinifAraComboBox";
            this.SinifAraComboBox.Size = new System.Drawing.Size(123, 24);
            this.SinifAraComboBox.TabIndex = 85;
            this.SinifAraComboBox.Text = "Tüm";
            this.SinifAraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.SinifAraComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(1064, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 85;
            this.label12.Text = "Sınıf:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1064, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 85;
            this.label11.Text = "Soyad:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1064, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 23);
            this.label10.TabIndex = 85;
            this.label10.Text = "Ad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1064, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 85;
            this.label9.Text = "No:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoAraTextBox
            // 
            this.NoAraTextBox.Location = new System.Drawing.Point(1064, 78);
            this.NoAraTextBox.Name = "NoAraTextBox";
            this.NoAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.NoAraTextBox.TabIndex = 85;
            this.NoAraTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.NoAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // AdAraTextBox
            // 
            this.AdAraTextBox.Location = new System.Drawing.Point(1064, 129);
            this.AdAraTextBox.Name = "AdAraTextBox";
            this.AdAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.AdAraTextBox.TabIndex = 86;
            this.AdAraTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.AdAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // SoyadAraTextBox
            // 
            this.SoyadAraTextBox.Location = new System.Drawing.Point(1064, 180);
            this.SoyadAraTextBox.Name = "SoyadAraTextBox";
            this.SoyadAraTextBox.Size = new System.Drawing.Size(193, 22);
            this.SoyadAraTextBox.TabIndex = 87;
            this.SoyadAraTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.SoyadAraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 78;
            this.label1.Text = "Öğrenci Kayıt Listesi";
            // 
            // Öğrenci_Kayıt_ve_Güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KeyPreview = true;
            this.Name = "Öğrenci_Kayıt_ve_Güncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt ve Güncelleme";
            this.Load += new System.EventHandler(this.Öğrenci_Kayıt_ve_Güncelleme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Öğrenci_Kayıt_ve_Güncelleme_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciListeleDataGridView)).EndInit();
            this.ResumeLayout(false);

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

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }



        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.TextBox NoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SinifComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoAraTextBox;
        private System.Windows.Forms.TextBox AdAraTextBox;
        private System.Windows.Forms.TextBox SoyadAraTextBox;
        private System.Windows.Forms.Button TemizleButton;
        private System.Windows.Forms.ComboBox SinifAraComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ResimButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button KaydetGuncelleButton;
        private System.Windows.Forms.DataGridView OgrenciListeleDataGridView;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.Button Temizle1Button;
    }
}