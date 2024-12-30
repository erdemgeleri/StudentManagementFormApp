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
            SuspendLayout();
            // 
            // tbDersId
            // 
            tbDersId.Location = new Point(69, 42);
            tbDersId.Name = "tbDersId";
            tbDersId.Size = new Size(100, 23);
            tbDersId.TabIndex = 0;
            // 
            // tbDersAd
            // 
            tbDersAd.Location = new Point(69, 71);
            tbDersAd.Name = "tbDersAd";
            tbDersAd.Size = new Size(100, 23);
            tbDersAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(183, 42);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(183, 71);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(183, 100);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(94, 100);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(75, 23);
            btnBul.TabIndex = 5;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "DersID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Ders Adı";
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}