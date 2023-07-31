using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class İdareci_Ana_Ekranı
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
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.StatuTextBox = new System.Windows.Forms.TextBox();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrenciKayitButton = new System.Windows.Forms.Button();
            this.OgretmenKayitButton = new System.Windows.Forms.Button();
            this.GeriButton = new System.Windows.Forms.Button();
            this.OgretmenSinifAtamaButton = new System.Windows.Forms.Button();
            this.SifreDegistirButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Enabled = false;
            this.SoyadTextBox.Location = new System.Drawing.Point(220, 48);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(180, 22);
            this.SoyadTextBox.TabIndex = 40;
            // 
            // StatuTextBox
            // 
            this.StatuTextBox.Enabled = false;
            this.StatuTextBox.Location = new System.Drawing.Point(220, 76);
            this.StatuTextBox.Name = "StatuTextBox";
            this.StatuTextBox.Size = new System.Drawing.Size(180, 22);
            this.StatuTextBox.TabIndex = 39;
            // 
            // AdTextBox
            // 
            this.AdTextBox.Enabled = false;
            this.AdTextBox.Location = new System.Drawing.Point(220, 16);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(180, 22);
            this.AdTextBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Statü:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OgrenciKayitButton
            // 
            this.OgrenciKayitButton.BackColor = System.Drawing.SystemColors.Control;
            this.OgrenciKayitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgrenciKayitButton.Location = new System.Drawing.Point(12, 185);
            this.OgrenciKayitButton.Name = "OgrenciKayitButton";
            this.OgrenciKayitButton.Size = new System.Drawing.Size(264, 61);
            this.OgrenciKayitButton.TabIndex = 1;
            this.OgrenciKayitButton.Text = "Öğrenci Kayıt/Güncelleme";
            this.OgrenciKayitButton.UseVisualStyleBackColor = false;
            this.OgrenciKayitButton.Click += new System.EventHandler(this.button1_Click);
            this.OgrenciKayitButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // OgretmenKayitButton
            // 
            this.OgretmenKayitButton.BackColor = System.Drawing.SystemColors.Control;
            this.OgretmenKayitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgretmenKayitButton.Location = new System.Drawing.Point(12, 269);
            this.OgretmenKayitButton.Name = "OgretmenKayitButton";
            this.OgretmenKayitButton.Size = new System.Drawing.Size(264, 61);
            this.OgretmenKayitButton.TabIndex = 2;
            this.OgretmenKayitButton.Text = "Öğretmen Kayıt/Güncelleme";
            this.OgretmenKayitButton.UseVisualStyleBackColor = false;
            this.OgretmenKayitButton.Click += new System.EventHandler(this.button2_Click);
            this.OgretmenKayitButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // GeriButton
            // 
            this.GeriButton.BackColor = System.Drawing.SystemColors.Control;
            this.GeriButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeriButton.Location = new System.Drawing.Point(647, 374);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(141, 37);
            this.GeriButton.TabIndex = 5;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = false;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // OgretmenSinifAtamaButton
            // 
            this.OgretmenSinifAtamaButton.BackColor = System.Drawing.SystemColors.Control;
            this.OgretmenSinifAtamaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgretmenSinifAtamaButton.Location = new System.Drawing.Point(282, 185);
            this.OgretmenSinifAtamaButton.Name = "OgretmenSinifAtamaButton";
            this.OgretmenSinifAtamaButton.Size = new System.Drawing.Size(264, 61);
            this.OgretmenSinifAtamaButton.TabIndex = 3;
            this.OgretmenSinifAtamaButton.Text = "Öğretmen Sınıf Atama\r\n";
            this.OgretmenSinifAtamaButton.UseVisualStyleBackColor = false;
            this.OgretmenSinifAtamaButton.Click += new System.EventHandler(this.button4_Click);
            this.OgretmenSinifAtamaButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button4_KeyDown);
            // 
            // SifreDegistirButton
            // 
            this.SifreDegistirButton.BackColor = System.Drawing.SystemColors.Control;
            this.SifreDegistirButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SifreDegistirButton.Location = new System.Drawing.Point(515, 374);
            this.SifreDegistirButton.Name = "SifreDegistirButton";
            this.SifreDegistirButton.Size = new System.Drawing.Size(126, 37);
            this.SifreDegistirButton.TabIndex = 4;
            this.SifreDegistirButton.Text = "Şifre Değiştir";
            this.SifreDegistirButton.UseVisualStyleBackColor = false;
            this.SifreDegistirButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // İdareci_Ana_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SifreDegistirButton);
            this.Controls.Add(this.OgretmenSinifAtamaButton);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.OgretmenKayitButton);
            this.Controls.Add(this.OgrenciKayitButton);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.StatuTextBox);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "İdareci_Ana_Ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İdareci_Ana_Ekranı";
            this.Load += new System.EventHandler(this.İdareci_Ana_Ekranı_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.İdareci_Ana_Ekranı_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox StatuTextBox;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OgrenciKayitButton;
        private System.Windows.Forms.Button OgretmenKayitButton;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button OgretmenSinifAtamaButton;
        private System.Windows.Forms.Button SifreDegistirButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}