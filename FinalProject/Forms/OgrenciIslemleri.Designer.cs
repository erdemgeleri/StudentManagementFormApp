namespace FinalProject
{
    partial class OgrenciIslemleri
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            lblSinifSecimi = new Label();
            groupBox1 = new GroupBox();
            cbSinifSecimi = new ComboBox();
            tbNumara = new TextBox();
            tbSoyad = new TextBox();
            tbAd = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnOItoMenu = new Button();
            btnOgrenciDers = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAd.Location = new Point(17, 28);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoyad.Location = new Point(17, 57);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumara.Location = new Point(17, 86);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(66, 20);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSinifSecimi
            // 
            lblSinifSecimi.AutoSize = true;
            lblSinifSecimi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSinifSecimi.Location = new Point(17, 115);
            lblSinifSecimi.Name = "lblSinifSecimi";
            lblSinifSecimi.Size = new Size(91, 20);
            lblSinifSecimi.TabIndex = 3;
            lblSinifSecimi.Text = "Sınıf Seçiniz";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSinifSecimi);
            groupBox1.Controls.Add(tbNumara);
            groupBox1.Controls.Add(tbSoyad);
            groupBox1.Controls.Add(tbAd);
            groupBox1.Controls.Add(lblSinifSecimi);
            groupBox1.Controls.Add(lblNumara);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Location = new Point(56, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 197);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbSinifSecimi
            // 
            cbSinifSecimi.BackColor = SystemColors.Info;
            cbSinifSecimi.FormattingEnabled = true;
            cbSinifSecimi.Location = new Point(128, 115);
            cbSinifSecimi.Name = "cbSinifSecimi";
            cbSinifSecimi.Size = new Size(123, 23);
            cbSinifSecimi.TabIndex = 7;
            cbSinifSecimi.SelectedIndexChanged += cbSinifSecimi_SelectedIndexChanged;
            // 
            // tbNumara
            // 
            tbNumara.BackColor = SystemColors.Info;
            tbNumara.Location = new Point(128, 83);
            tbNumara.Name = "tbNumara";
            tbNumara.Size = new Size(123, 23);
            tbNumara.TabIndex = 6;
            // 
            // tbSoyad
            // 
            tbSoyad.BackColor = SystemColors.Info;
            tbSoyad.Location = new Point(128, 54);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(123, 23);
            tbSoyad.TabIndex = 5;
            // 
            // tbAd
            // 
            tbAd.BackColor = SystemColors.Info;
            tbAd.Location = new Point(128, 25);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(123, 23);
            tbAd.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkCyan;
            btnEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEkle.Location = new Point(360, 250);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 34);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkCyan;
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.Location = new Point(360, 290);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 34);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkCyan;
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuncelle.Location = new Point(363, 330);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(72, 34);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.DarkCyan;
            btnBul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBul.Location = new Point(286, 290);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(68, 34);
            btnBul.TabIndex = 8;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // btnOItoMenu
            // 
            btnOItoMenu.BackColor = Color.DarkCyan;
            btnOItoMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOItoMenu.Location = new Point(12, 12);
            btnOItoMenu.Name = "btnOItoMenu";
            btnOItoMenu.Size = new Size(83, 29);
            btnOItoMenu.TabIndex = 9;
            btnOItoMenu.Text = "Menü";
            btnOItoMenu.UseVisualStyleBackColor = false;
            btnOItoMenu.Click += btnOItoMenu_Click;
            // 
            // btnOgrenciDers
            // 
            btnOgrenciDers.BackColor = Color.DarkCyan;
            btnOgrenciDers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOgrenciDers.Location = new Point(360, 12);
            btnOgrenciDers.Name = "btnOgrenciDers";
            btnOgrenciDers.Size = new Size(82, 29);
            btnOgrenciDers.TabIndex = 10;
            btnOgrenciDers.Text = "Ders İşlemleri";
            btnOgrenciDers.UseVisualStyleBackColor = false;
            btnOgrenciDers.Click += btnOgrenciDers_Click;
            // 
            // OgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 391);
            Controls.Add(btnOgrenciDers);
            Controls.Add(btnOItoMenu);
            Controls.Add(btnBul);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Name = "OgrenciIslemleri";
            Text = "OgrenciIslemleri";
            Load += OgrenciIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblNumara;
        private Label lblSinifSecimi;
        private GroupBox groupBox1;
        private ComboBox cbSinifSecimi;
        private TextBox tbNumara;
        private TextBox tbSoyad;
        private TextBox tbAd;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnOItoMenu;
        private Button btnOgrenciDers;
    }
}