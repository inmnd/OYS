using System;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    partial class Şifre_Değiştirme_Ekranı
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
            this.Yeni2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yeni1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DegistirButton = new System.Windows.Forms.Button();
            this.GeriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yeni2TextBox
            // 
            this.Yeni2TextBox.Location = new System.Drawing.Point(307, 218);
            this.Yeni2TextBox.Name = "Yeni2TextBox";
            this.Yeni2TextBox.Size = new System.Drawing.Size(198, 22);
            this.Yeni2TextBox.TabIndex = 2;
            this.Yeni2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(123, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tekrar Yeni Şifre:";
            // 
            // Yeni1TextBox
            // 
            this.Yeni1TextBox.Location = new System.Drawing.Point(307, 189);
            this.Yeni1TextBox.Name = "Yeni1TextBox";
            this.Yeni1TextBox.Size = new System.Drawing.Size(198, 22);
            this.Yeni1TextBox.TabIndex = 1;
            this.Yeni1TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Yeni1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.Yeni1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(191, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Şifre:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(274, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre Değiştir";
            // 
            // DegistirButton
            // 
            this.DegistirButton.Location = new System.Drawing.Point(307, 246);
            this.DegistirButton.Name = "DegistirButton";
            this.DegistirButton.Size = new System.Drawing.Size(107, 35);
            this.DegistirButton.TabIndex = 3;
            this.DegistirButton.Text = "Değiştir";
            this.DegistirButton.UseVisualStyleBackColor = true;
            this.DegistirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeriButton
            // 
            this.GeriButton.Location = new System.Drawing.Point(649, 406);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(139, 32);
            this.GeriButton.TabIndex = 4;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Şifre_Değiştirme_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.DegistirButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Yeni1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Yeni2TextBox);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "Şifre_Değiştirme_Ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre_Değiştirme_Ekranı";
            this.Load += new System.EventHandler(this.Şifre_Değiştirme_Ekranı_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Şifre_Değiştirme_Ekranı_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        #endregion
        private System.Windows.Forms.TextBox Yeni2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Yeni1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DegistirButton;
        private System.Windows.Forms.Button GeriButton;
    }
}