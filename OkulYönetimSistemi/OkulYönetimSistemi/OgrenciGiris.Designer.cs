using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class OgrenciGiris
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
            this.NoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GosterGizleCheckBox = new System.Windows.Forms.CheckBox();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.Location = new System.Drawing.Point(304, 297);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(267, 36);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "GİRİŞ";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoTextBox
            // 
            this.NoTextBox.Location = new System.Drawing.Point(362, 216);
            this.NoTextBox.Name = "NoTextBox";
            this.NoTextBox.Size = new System.Drawing.Size(201, 22);
            this.NoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(322, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "ÖĞRENCİ GİRİŞ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(298, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "NO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GosterGizleCheckBox
            // 
            this.GosterGizleCheckBox.AutoSize = true;
            this.GosterGizleCheckBox.Location = new System.Drawing.Point(573, 253);
            this.GosterGizleCheckBox.Name = "GosterGizleCheckBox";
            this.GosterGizleCheckBox.Size = new System.Drawing.Size(69, 20);
            this.GosterGizleCheckBox.TabIndex = 3;
            this.GosterGizleCheckBox.Text = "Göster";
            this.GosterGizleCheckBox.UseVisualStyleBackColor = true;
            this.GosterGizleCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(710, 479);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 37);
            this.GeriButton.TabIndex = 5;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(362, 251);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(197, 22);
            this.SifreTextBox.TabIndex = 2;
            this.SifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.GosterGizleCheckBox);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.NoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "OgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögrenci Giriş Ekranı";
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OgrenciGiris_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

       

        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.TextBox NoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GosterGizleCheckBox;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.TextBox SifreTextBox;
    }
}