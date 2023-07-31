using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class OgretmenGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SicilNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.GosterGizleChecBox = new System.Windows.Forms.CheckBox();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(267, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(240, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sicil No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SicilNoTextBox
            // 
            this.SicilNoTextBox.Location = new System.Drawing.Point(373, 223);
            this.SicilNoTextBox.Name = "SicilNoTextBox";
            this.SicilNoTextBox.Size = new System.Drawing.Size(201, 22);
            this.SicilNoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(298, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "ÖĞRETMEN GİRİŞ";
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.Location = new System.Drawing.Point(307, 303);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(267, 40);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "GİRİŞ";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GosterGizleChecBox
            // 
            this.GosterGizleChecBox.AutoSize = true;
            this.GosterGizleChecBox.Location = new System.Drawing.Point(592, 263);
            this.GosterGizleChecBox.Name = "GosterGizleChecBox";
            this.GosterGizleChecBox.Size = new System.Drawing.Size(69, 20);
            this.GosterGizleChecBox.TabIndex = 3;
            this.GosterGizleChecBox.Text = "Göster";
            this.GosterGizleChecBox.UseVisualStyleBackColor = true;
            this.GosterGizleChecBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(710, 486);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(201, 30);
            this.GeriButton.TabIndex = 5;
            this.GeriButton.Text = "GERİ";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(373, 261);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(201, 22);
            this.SifreTextBox.TabIndex = 2;
            this.SifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // OgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.GosterGizleChecBox);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.SicilNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "OgretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögretmen Gİriş Ekranı";
            this.Load += new System.EventHandler(this.OgretmenGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OgretmenGiris_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


 

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SicilNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.CheckBox GosterGizleChecBox;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.TextBox SifreTextBox;
    }
}