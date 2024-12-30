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
            tbSinifAdi.Location = new Point(164, 97);
            tbSinifAdi.Name = "tbSinifAdi";
            tbSinifAdi.Size = new Size(100, 23);
            tbSinifAdi.TabIndex = 0;
            tbSinifAdi.TextChanged += tbSinifAdi_TextChanged;
            // 
            // tbKontenjan
            // 
            tbKontenjan.Location = new Point(164, 126);
            tbKontenjan.Name = "tbKontenjan";
            tbKontenjan.Size = new Size(100, 23);
            tbKontenjan.TabIndex = 1;
            // 
            // tbSinifId
            // 
            tbSinifId.Location = new Point(164, 68);
            tbSinifId.Name = "tbSinifId";
            tbSinifId.Size = new Size(100, 23);
            tbSinifId.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(189, 164);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(189, 193);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(189, 222);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Menü";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click_1;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(281, 193);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(75, 23);
            btnBul.TabIndex = 7;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 76);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Sınıf ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Sınıf Adi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 134);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 10;
            label3.Text = "SinifKontenjan";
            // 
            // SinifIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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