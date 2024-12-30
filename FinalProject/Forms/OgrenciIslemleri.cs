using FinalProject.Forms;
using FinalProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
            using (var ctx = new FinalDBContext())
            {
                var siniflar = ctx.Siniflar.ToList();
                cbSinifSecimi.DataSource = siniflar;
                cbSinifSecimi.DisplayMember = "SinifAd";
                cbSinifSecimi.ValueMember = "SinifId";
                cbSinifSecimi.SelectedIndex = -1;
            }

            tbAd.TextChanged += TextBox_TextChanged;
            tbSoyad.TextChanged += TextBox_TextChanged;
            tbNumara.TextChanged += TextBox_TextChanged;
        }

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    var ogrenci = ctx.Ogrenciler
                        .Where(u => u.Numara == int.Parse(tbNumara.Text))
                        .Select(o => new
                        {
                            o.Ad,
                            o.Soyad,
                            o.Numara,
                            o.SinifId,
                            SinifAd = o.Sinif.SinifAd
                        }).FirstOrDefault();

                    if (ogrenci != null)
                    {
                        tbAd.Text = ogrenci.Ad;
                        tbSoyad.Text = ogrenci.Soyad;
                        tbNumara.Text = ogrenci.Numara.ToString();
                        var siniflar = ctx.Siniflar.ToList();
                        cbSinifSecimi.DataSource = siniflar;
                        cbSinifSecimi.DisplayMember = "SinifAd";
                        cbSinifSecimi.ValueMember = "SinifId";

                        var seciliSinifItem = ctx.Siniflar
                            .FirstOrDefault(s => s.SinifId == ogrenci.SinifId);
                        if (seciliSinifItem != null)
                        {
                            cbSinifSecimi.SelectedItem = seciliSinifItem;
                        }

                        MessageBox.Show($"Öğrenci bulundu. Sınıfı: {ogrenci.SinifAd}");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Öğrencinin numarasını girip bul butonuna tıkladığınıza emin olun!");
                if (string.IsNullOrEmpty(tbAd.Text))
                {
                    tbAd.BackColor = System.Drawing.Color.Red;
                }
                if (string.IsNullOrEmpty(tbSoyad.Text))
                {
                    tbSoyad.BackColor = System.Drawing.Color.Red;
                }
                if (string.IsNullOrEmpty(tbNumara.Text))
                {
                    tbNumara.BackColor = System.Drawing.Color.Red;
                }
                if (cbSinifSecimi.SelectedIndex == -1)
                {
                    cbSinifSecimi.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int numara;
            if (!int.TryParse(tbNumara.Text, out numara))
            {
                MessageBox.Show("İlgili numaralı öğrenci bulunamadı.");
                return;
            }
            using (var ctx = new FinalDBContext())
            {
                var ogrenci = ctx.Ogrenciler.FirstOrDefault(f => f.Numara == numara);
                if (ogrenci != null)
                {
                    ctx.Ogrenciler.Remove(ogrenci);
                    ctx.SaveChanges();
                    MessageBox.Show($"Öğrenci (No: {numara}) başarıyla silindi.");
                    var sinif = ctx.Siniflar.FirstOrDefault(p => p.SinifId == ogrenci.SinifId);
                    sinif!.Kontenjan -= 1;
                    ctx.SaveChanges();
                    MessageBox.Show($"Sınıf(ID:{sinif.SinifId}) kontenjanı güncellendi: {sinif.Kontenjan}");
                }
                else
                {
                    MessageBox.Show("İlgili numaralı öğrenci bulunamadı.");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = tbAd.Text.Trim();
            string soyad = tbSoyad.Text.Trim();
            int numara;
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || !int.TryParse(tbNumara.Text, out numara))
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru bir şekilde doldurun!");
                return;
            }
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    var seciliSinif = cbSinifSecimi.SelectedItem as dynamic;
                    if (seciliSinif != null)
                    {
                        int sinifId = seciliSinif.SinifId;
                        var sinif = ctx.Siniflar.FirstOrDefault(p => p.SinifId == sinifId);
                        if (sinif!.Kontenjan <= 0)
                        {
                            MessageBox.Show("Seçilen sınıfın kontenjanı dolmuş, öğrenci kaydedilemez.");
                            return;
                        }
                        var yeniOgrenci = new Ogrenciler
                        {
                            Ad = ad,
                            Soyad = soyad,
                            Numara = numara,
                            Sifre = "123",
                            SinifId = sinif.SinifId
                        };
                        ctx.Ogrenciler.Add(yeniOgrenci);
                        ctx.SaveChanges();

                        sinif.Kontenjan += 1;
                        ctx.SaveChanges();

                        MessageBox.Show($"Öğrenci başarıyla eklendi ve {sinif.SinifAd} sınıfına kaydedildi! Kontenjan: {sinif.Kontenjan}");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir sınıf seçin.");
                    }

                    tbAd.Text = "";
                    tbSoyad.Text = "";
                    tbNumara.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int numara = int.Parse(tbNumara.Text);
                using (var ctx = new FinalDBContext())
                {
                    var seciliSinif = cbSinifSecimi.SelectedItem as dynamic;
                    if (seciliSinif != null)
                    {
                        int sinifId = seciliSinif.SinifId;
                        var sinif = ctx.Siniflar.FirstOrDefault(p => p.SinifId == sinifId);
                        var temp_sinif = seciliSinif.SinifId;

                        if (sinif!.Kontenjan <= 0)
                        {
                            MessageBox.Show("Seçilen sınıfın kontenjanı dolmuş, farklı bir sınıf seçiniz.");
                            return;
                        }

                        var lst = ctx.Ogrenciler.FirstOrDefault(k => k.Numara == numara);
                        if (lst != null)
                        {
                            var eskiSinif = ctx.Siniflar.FirstOrDefault(s => s.SinifId == lst.SinifId);
                            if (eskiSinif != sinif)
                            {
                                sinif.Kontenjan += 1;
                                eskiSinif!.Kontenjan -= 1;
                                MessageBox.Show("Kayıt güncellendi. Kontenjanlar güncellendi.");
                            }

                            lst.Ad = tbAd.Text;
                            lst.Soyad = tbSoyad.Text;
                            lst.SinifId = sinifId;
                            ctx.SaveChanges();
                            MessageBox.Show("Güncelleme işlemi başarılı");

                        }
                        else
                        {

                            MessageBox.Show("İlgili Kayıt Bulunamadı");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numara alanını doğru girdiğinizden veya alanları boş bırakmadığınızdan emin olun");
            }
        }

        private void btnOItoMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnOgrenciDers_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    var ogrenci = ctx.Ogrenciler.FirstOrDefault(f => f.Ad == tbAd.Text && f.Soyad == tbSoyad.Text && f.Numara == int.Parse(tbNumara.Text));
                    if (ogrenci != null)
                    {
                        OgrenciDersIslemleri ogrenciDersIslemleri = new OgrenciDersIslemleri(ogrenci);
                        this.Hide();
                        ogrenciDersIslemleri.Show();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri yanlış.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txt.BackColor = System.Drawing.Color.White;
            }
        }
        private void cbSinifSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSinifSecimi.SelectedIndex != -1)
            {
                cbSinifSecimi.BackColor = System.Drawing.Color.White;
            }
        }
    }
}