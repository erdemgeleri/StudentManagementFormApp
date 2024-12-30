namespace FinalProject.Forms
{
    partial class SinifIslemleri
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
            tbSinifAdi = new TextBox();
            tbKontenjan = new TextBox();
            tbSinifId = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnMenu = new Button();
            btnBul = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbSinifAdi
            // 
            tbSinifAdi.Location = new Point(194, 97);
            tbSinifAdi.Name = "tbSinifAdi";
            tbSinifAdi.Size = new Size(92, 23);
            tbSinifAdi.TabIndex = 0;
            tbSinifAdi.TextChanged += tbSinifAdi_TextChanged;
            // 
            // tbKontenjan
            // 
            tbKontenjan.Location = new Point(194, 126);
            tbKontenjan.Name = "tbKontenjan";
            tbKontenjan.Size = new Size(92, 23);
            tbKontenjan.TabIndex = 1;
            // 
            // tbSinifId
            // 
            tbSinifId.Location = new Point(194, 68);
            tbSinifId.Name = "tbSinifId";
            tbSinifId.Size = new Size(92, 23);
            tbSinifId.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkCyan;
            btnEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(194, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(92, 37);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkCyan;
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(194, 208);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 37);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkCyan;
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(194, 251);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(92, 37);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.DarkCyan;
            btnMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(92, 37);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Ana Menü";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click_1;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.DarkCyan;
            btnBul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBul.ForeColor = Color.White;
            btnBul.Location = new Point(96, 208);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(92, 37);
            btnBul.TabIndex = 7;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(49, 67);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 8;
            label1.Text = "Sınıf ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(49, 96);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 9;
            label2.Text = "Sınıf Adi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(49, 125);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 10;
            label3.Text = "Sinif Kontenjanı";
            // 
            // SinifIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBul);
            Controls.Add(btnMenu);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(tbSinifId);
            Controls.Add(tbKontenjan);
            Controls.Add(tbSinifAdi);
            Name = "SinifIslemleri";
            Text = "SinifIslemleri";
            Load += SinifIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSinifAdi;
        private TextBox tbKontenjan;
        private TextBox tbSinifId;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnMenu;
        private Button btnBul;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}