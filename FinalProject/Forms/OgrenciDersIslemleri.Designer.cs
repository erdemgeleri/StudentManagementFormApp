﻿namespace FinalProject.Forms
{
    partial class OgrenciDersIslemleri
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
            dataGridView1 = new DataGridView();
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            lblSinif = new Label();
            lbl_ad = new Label();
            lbl_soyad = new Label();
            lbl_numara = new Label();
            lbl_sinif = new Label();
            lblDersler = new Label();
            btnKaydet = new Button();
            button1 = new Button();
            lbl_dersler = new Label();
            button2 = new Button();
            label1 = new Label();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(555, 220);
            dataGridView1.TabIndex = 0;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(170, 45);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(0, 15);
            lblAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(170, 73);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(0, 15);
            lblSoyad.TabIndex = 2;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(170, 99);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(0, 15);
            lblNumara.TabIndex = 3;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(170, 126);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(0, 15);
            lblSinif.TabIndex = 4;
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(108, 45);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(25, 15);
            lbl_ad.TabIndex = 5;
            lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(108, 73);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(42, 15);
            lbl_soyad.TabIndex = 6;
            lbl_soyad.Text = "Soyad:";
            // 
            // lbl_numara
            // 
            lbl_numara.AutoSize = true;
            lbl_numara.Location = new Point(108, 99);
            lbl_numara.Name = "lbl_numara";
            lbl_numara.Size = new Size(53, 15);
            lbl_numara.TabIndex = 7;
            lbl_numara.Text = "Numara:";
            // 
            // lbl_sinif
            // 
            lbl_sinif.AutoSize = true;
            lbl_sinif.Location = new Point(108, 126);
            lbl_sinif.Name = "lbl_sinif";
            lbl_sinif.Size = new Size(33, 15);
            lbl_sinif.TabIndex = 8;
            lbl_sinif.Text = "Sınıf:";
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(108, 154);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(43, 15);
            lblDersler.TabIndex = 9;
            lblDersler.Text = "Dersler";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(191, 398);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(367, 23);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(191, 425);
            button1.Name = "button1";
            button1.Size = new Size(367, 23);
            button1.TabIndex = 11;
            button1.Text = "Öğrencinin Derslerini Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_dersler
            // 
            lbl_dersler.AutoSize = true;
            lbl_dersler.Location = new Point(733, 147);
            lbl_dersler.Name = "lbl_dersler";
            lbl_dersler.Size = new Size(0, 15);
            lbl_dersler.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(191, 451);
            button2.Name = "button2";
            button2.Size = new Size(367, 23);
            button2.TabIndex = 13;
            button2.Text = "Öğrencinin Derslerini Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(687, 116);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 14;
            label1.Text = "Alınan Dersler";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 29);
            btnGeri.TabIndex = 15;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // OgrenciDersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 554);
            Controls.Add(btnGeri);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(lbl_dersler);
            Controls.Add(button1);
            Controls.Add(btnKaydet);
            Controls.Add(lblDersler);
            Controls.Add(lbl_sinif);
            Controls.Add(lbl_numara);
            Controls.Add(lbl_soyad);
            Controls.Add(lbl_ad);
            Controls.Add(lblSinif);
            Controls.Add(lblNumara);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(dataGridView1);
            Name = "OgrenciDersIslemleri";
            Text = "OgrenciDersIslemleri";
            Load += OgrenciDersIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblNumara;
        private Label lblSinif;
        private Label lbl_ad;
        private Label lbl_soyad;
        private Label lbl_numara;
        private Label lbl_sinif;
        private Label lblDersler;
        private Button btnKaydet;
        private Button button1;
        private Label lbl_dersler;
        private Button button2;
        private Label label1;
        private Button btnGeri;
    }
}