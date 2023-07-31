using System;

namespace OkulYönetimSistemi
{
    partial class SinifTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SifreDegistirButton = new System.Windows.Forms.Button();
            this.NotDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrtalamaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(114, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(114, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınıf:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoTextBox
            // 
            this.NoTextBox.Enabled = false;
            this.NoTextBox.Location = new System.Drawing.Point(211, 10);
            this.NoTextBox.Name = "NoTextBox";
            this.NoTextBox.Size = new System.Drawing.Size(180, 22);
            this.NoTextBox.TabIndex = 12;
            this.NoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(211, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 13;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Enabled = false;
            this.SoyadTextBox.Location = new System.Drawing.Point(211, 70);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(180, 22);
            this.SoyadTextBox.TabIndex = 14;
            // 
            // AdTextBox
            // 
            this.AdTextBox.Enabled = false;
            this.AdTextBox.Location = new System.Drawing.Point(211, 42);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(180, 22);
            this.AdTextBox.TabIndex = 15;
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(1184, 469);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(141, 37);
            this.GeriButton.TabIndex = 56;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SifreDegistirButton
            // 
            this.SifreDegistirButton.Location = new System.Drawing.Point(1052, 469);
            this.SifreDegistirButton.Name = "SifreDegistirButton";
            this.SifreDegistirButton.Size = new System.Drawing.Size(126, 37);
            this.SifreDegistirButton.TabIndex = 62;
            this.SifreDegistirButton.Text = "Şifre Değiştir";
            this.SifreDegistirButton.UseVisualStyleBackColor = true;
            this.SifreDegistirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NotDataGridView
            // 
            this.NotDataGridView.AllowUserToResizeColumns = false;
            this.NotDataGridView.AllowUserToResizeRows = false;
            this.NotDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotDataGridView.Enabled = false;
            this.NotDataGridView.Location = new System.Drawing.Point(3, 170);
            this.NotDataGridView.Name = "NotDataGridView";
            this.NotDataGridView.RowHeadersWidth = 51;
            this.NotDataGridView.RowTemplate.Height = 24;
            this.NotDataGridView.Size = new System.Drawing.Size(1321, 228);
            this.NotDataGridView.TabIndex = 63;
            this.NotDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // OrtalamaTextBox
            // 
            this.OrtalamaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OrtalamaTextBox.Enabled = false;
            this.OrtalamaTextBox.Location = new System.Drawing.Point(1144, 406);
            this.OrtalamaTextBox.Name = "OrtalamaTextBox";
            this.OrtalamaTextBox.Size = new System.Drawing.Size(180, 22);
            this.OrtalamaTextBox.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(969, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 97;
            this.label5.Text = "Genel Ortalama:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SinifTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 509);
            this.Controls.Add(this.OrtalamaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotDataGridView);
            this.Controls.Add(this.SifreDegistirButton);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "SinifTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ana Ekranı";
            this.Load += new System.EventHandler(this.OgrenciAnaEkran_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OgrenciAnaEkran_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.NotDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button SifreDegistirButton;
        private System.Windows.Forms.DataGridView NotDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox OrtalamaTextBox;
        private System.Windows.Forms.Label label5;
    }
}