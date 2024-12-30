namespace FinalProject.Forms
{
    partial class DersIslemleri
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
            tbDersId = new TextBox();
            tbDersAd = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAnaMenu = new Button();
            SuspendLayout();
            // 
            // tbDersId
            // 
            tbDersId.Location = new Point(121, 62);
            tbDersId.Name = "tbDersId";
            tbDersId.Size = new Size(100, 23);
            tbDersId.TabIndex = 0;
            // 
            // tbDersAd
            // 
            tbDersAd.Location = new Point(121, 91);
            tbDersAd.Name = "tbDersAd";
            tbDersAd.Size = new Size(100, 23);
            tbDersAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkCyan;
            btnEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(121, 125);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 35);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkCyan;
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(121, 166);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkCyan;
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(121, 207);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 35);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.DarkCyan;
            btnBul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBul.ForeColor = Color.White;
            btnBul.Location = new Point(12, 166);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(86, 35);
            btnBul.TabIndex = 5;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "DersID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Ders Adı";
            // 
            // btnAnaMenu
            // 
            btnAnaMenu.BackColor = Color.DarkCyan;
            btnAnaMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAnaMenu.ForeColor = Color.White;
            btnAnaMenu.Location = new Point(12, 12);
            btnAnaMenu.Name = "btnAnaMenu";
            btnAnaMenu.Size = new Size(112, 35);
            btnAnaMenu.TabIndex = 8;
            btnAnaMenu.Text = "Ana Menü";
            btnAnaMenu.UseVisualStyleBackColor = false;
            btnAnaMenu.Click += button1_Click;
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 296);
            Controls.Add(btnAnaMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBul);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(tbDersAd);
            Controls.Add(tbDersId);
            Name = "DersIslemleri";
            Text = "DersIslemleri";
            Load += DersIslemleri_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDersId;
        private TextBox tbDersAd;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnBul;
        private Label label1;
        private Label label2;
        private Button btnAnaMenu;
    }
}