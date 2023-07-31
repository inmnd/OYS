using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class AnaGiris
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
            this.OgrenciGirisButton = new System.Windows.Forms.Button();
            this.OgretmenGirisButton = new System.Windows.Forms.Button();
            this.IdareGirisButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciGirisButton
            // 
            this.OgrenciGirisButton.BackColor = System.Drawing.SystemColors.Control;
            this.OgrenciGirisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgrenciGirisButton.Location = new System.Drawing.Point(226, 134);
            this.OgrenciGirisButton.Name = "OgrenciGirisButton";
            this.OgrenciGirisButton.Size = new System.Drawing.Size(442, 59);
            this.OgrenciGirisButton.TabIndex = 0;
            this.OgrenciGirisButton.Text = "ÖĞRENCİ GİRİŞ";
            this.OgrenciGirisButton.UseVisualStyleBackColor = false;
            this.OgrenciGirisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgretmenGirisButton
            // 
            this.OgretmenGirisButton.BackColor = System.Drawing.SystemColors.Control;
            this.OgretmenGirisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OgretmenGirisButton.Location = new System.Drawing.Point(226, 223);
            this.OgretmenGirisButton.Name = "OgretmenGirisButton";
            this.OgretmenGirisButton.Size = new System.Drawing.Size(442, 59);
            this.OgretmenGirisButton.TabIndex = 1;
            this.OgretmenGirisButton.Text = "ÖĞRETMEN GİRİŞ";
            this.OgretmenGirisButton.UseVisualStyleBackColor = false;
            this.OgretmenGirisButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdareGirisButton
            // 
            this.IdareGirisButton.BackColor = System.Drawing.SystemColors.Control;
            this.IdareGirisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IdareGirisButton.Location = new System.Drawing.Point(226, 318);
            this.IdareGirisButton.Name = "IdareGirisButton";
            this.IdareGirisButton.Size = new System.Drawing.Size(442, 59);
            this.IdareGirisButton.TabIndex = 2;
            this.IdareGirisButton.Text = "İDARE GİRİŞ";
            this.IdareGirisButton.UseVisualStyleBackColor = false;
            this.IdareGirisButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(319, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "OKUL KULLANICI GİRİŞ";
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdareGirisButton);
            this.Controls.Add(this.OgretmenGirisButton);
            this.Controls.Add(this.OgrenciGirisButton);
            this.KeyPreview = true;
            this.Name = "AnaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullancı Giriş Ekranı";
            this.Load += new System.EventHandler(this.AnaGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaGiris_KeyDown);
            this.ResumeLayout(false);

        }

        private void AnaGiris_KeyDown(object sender, KeyEventArgs e)
        {

        }


        #endregion

        private System.Windows.Forms.Button OgrenciGirisButton;
        private System.Windows.Forms.Button OgretmenGirisButton;
        private System.Windows.Forms.Button IdareGirisButton;
        private System.Windows.Forms.Label label1;
    }
}

