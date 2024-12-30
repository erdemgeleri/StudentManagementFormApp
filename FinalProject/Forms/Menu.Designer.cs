namespace FinalProject
{
    partial class Menu
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
            btnOgrenci = new Button();
            btnDers = new Button();
            btnSinif = new Button();
            SuspendLayout();
            // 
            // btnOgrenci
            // 
            btnOgrenci.Location = new Point(87, 12);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(197, 23);
            btnOgrenci.TabIndex = 0;
            btnOgrenci.Text = "Öğrenci İşlemleri";
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnDers
            // 
            btnDers.Location = new Point(87, 41);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(197, 23);
            btnDers.TabIndex = 1;
            btnDers.Text = "Ders İşlemleri";
            btnDers.UseVisualStyleBackColor = true;
            btnDers.Click += btnDers_Click;
            // 
            // btnSinif
            // 
            btnSinif.Location = new Point(87, 70);
            btnSinif.Name = "btnSinif";
            btnSinif.Size = new Size(197, 23);
            btnSinif.TabIndex = 2;
            btnSinif.Text = "Sınıf İşlemleri";
            btnSinif.UseVisualStyleBackColor = true;
            btnSinif.Click += btnSinif_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 197);
            Controls.Add(btnSinif);
            Controls.Add(btnDers);
            Controls.Add(btnOgrenci);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOgrenci;
        private Button btnDers;
        private Button btnSinif;
    }
}