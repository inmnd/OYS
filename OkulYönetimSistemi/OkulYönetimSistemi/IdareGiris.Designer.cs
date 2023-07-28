using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class IdareGiris
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
            this.GirisButton = new System.Windows.Forms.Button();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GizleGosterCheckBox = new System.Windows.Forms.CheckBox();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.SystemColors.Control;
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GirisButton.Location = new System.Drawing.Point(313, 309);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(246, 38);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "GİRİŞ";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(342, 192);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(201, 22);
            this.AdTextBox.TabIndex = 0;
            this.AdTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.AdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(326, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "İDARE GİRİŞ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(275, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "AD:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(342, 241);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(201, 22);
            this.SoyadTextBox.TabIndex = 1;
            this.SoyadTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(242, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "SOYAD:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GizleGosterCheckBox
            // 
            this.GizleGosterCheckBox.AutoSize = true;
            this.GizleGosterCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.GizleGosterCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GizleGosterCheckBox.Location = new System.Drawing.Point(549, 281);
            this.GizleGosterCheckBox.Name = "GizleGosterCheckBox";
            this.GizleGosterCheckBox.Size = new System.Drawing.Size(69, 20);
            this.GizleGosterCheckBox.TabIndex = 3;
            this.GizleGosterCheckBox.Text = "Göster";
            this.GizleGosterCheckBox.UseVisualStyleBackColor = false;
            this.GizleGosterCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GeriButton
            // 
            this.GeriButton.BackColor = System.Drawing.SystemColors.Control;
            this.GeriButton.ForeColor = System.Drawing.Color.Black;
            this.GeriButton.Location = new System.Drawing.Point(710, 479);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 37);
            this.GeriButton.TabIndex = 5;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = false;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(342, 279);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(201, 22);
            this.SifreTextBox.TabIndex = 2;
            this.SifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // IdareGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.GizleGosterCheckBox);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "IdareGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İdare Giriş Ekranı";
            this.Load += new System.EventHandler(this.IdareGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdareGiris_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox GizleGosterCheckBox;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.TextBox SifreTextBox;
    }
}