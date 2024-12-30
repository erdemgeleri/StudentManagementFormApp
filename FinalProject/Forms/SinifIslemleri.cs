using FinalProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class SinifIslemleri : Form
    {
        public SinifIslemleri()
        {
            InitializeComponent();
        }

        private void SinifIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var ctx = new FinalDBContext())
            //    {
            //        int sinifId;
            //        if (int.TryParse(tbSinifId.Text, out sinifId))
            //        {
            //            var sinif = ctx.Siniflar
            //                            .Where(s => s.SinifId == sinifId)
            //                            .FirstOrDefault();

            //            if (sinif != null)
            //            {
            //                tbSinifAdi.Text = sinif.SinifAd;
            //                tbKontenjan.Text = sinif.Kontenjan.ToString();
            //                MessageBox.Show($"{sinif.SinifId} ID'li sınıf bulunmuştur");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Kayıt bulunamadı");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var ctx = new FinalDBContext())
            //    {
            //        int sinifId;
            //        if (int.TryParse(tbSinifId.Text, out sinifId))
            //        {
            //            var sinif = ctx.Siniflar
            //                            .Where(s => s.SinifId == sinifId)
            //                            .FirstOrDefault();

            //            if (sinif != null)
            //            {
            //                // Kontenjan kontrolü
            //                if (sinif.Kontenjan < 0)
            //                {
            //                    MessageBox.Show("Kontenjan değeri geçersiz!");
            //                    return;
            //                }

            //                // Güncelleme işlemi
            //                sinif.SinifAd = tbSinifAdi.Text;
            //                sinif.Kontenjan = int.Parse(tbKontenjan.Text);
            //                ctx.SaveChanges();

            //                MessageBox.Show("Sınıf başarıyla güncellendi!");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sınıf bulunamadı");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var ctx = new FinalDBContext())
            //    {
            //        int sinifId;
            //        if (int.TryParse(tbSinifId.Text, out sinifId))
            //        {
            //            var sinif = ctx.Siniflar
            //                            .Where(s => s.SinifId == sinifId)
            //                            .FirstOrDefault();

            //            if (sinif != null)
            //            {
            //                // Öğrenci kontrolü
            //                if (sinif.Ogrenciler.Count > 0)
            //                {
            //                    MessageBox.Show("Bu sınıfta kayıtlı öğrenciler bulunmaktadır. Sınıf silinemez.");
            //                    return;
            //                }

            //                ctx.Siniflar.Remove(sinif);
            //                ctx.SaveChanges();

            //                MessageBox.Show("Sınıf başarıyla silindi.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sınıf bulunamadı");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var ctx = new FinalDBContext())
            //    {
            //        string sinifAd = tbSinifAdi.Text.Trim();
            //        int kontenjan;
            //        if (string.IsNullOrEmpty(sinifAd) || !int.TryParse(tbKontenjan.Text, out kontenjan))
            //        {
            //            MessageBox.Show("Sınıf adı ve kontenjanı doğru giriniz.");
            //            return;
            //        }

            //        var yeniSinif = new tblSiniflar
            //        {
            //            SinifAd = sinifAd,
            //            Kontenjan = kontenjan
            //        };

            //        ctx.Siniflar.Add(yeniSinif);
            //        ctx.SaveChanges();

            //        MessageBox.Show("Yeni sınıf başarıyla eklendi.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    string sinifAd = tbSinifAdi.Text.Trim();
                    int kontenjan;
                    if (string.IsNullOrEmpty(sinifAd) || !int.TryParse(tbKontenjan.Text, out kontenjan))
                    {
                        MessageBox.Show("Sınıf adı ve kontenjanı doğru giriniz.");
                        return;
                    }

                    var yeniSinif = new tblSiniflar
                    {
                        SinifAd = sinifAd,
                        Kontenjan = kontenjan
                    };

                    ctx.Siniflar.Add(yeniSinif);
                    ctx.SaveChanges();

                    MessageBox.Show("Yeni sınıf başarıyla eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    int sinifId;
                    if (int.TryParse(tbSinifId.Text, out sinifId))
                    {
                        var sinif = ctx.Siniflar
                                        .Where(s => s.SinifId == sinifId)
                                        .FirstOrDefault();

                        if (sinif != null)
                        {
                            // Öğrenci kontrolü
                            if (sinif.Ogrenciler.Count > 0)
                            {
                                MessageBox.Show("Bu sınıfta kayıtlı öğrenciler bulunmaktadır. Sınıf silinemez.");
                                return;
                            }

                            ctx.Siniflar.Remove(sinif);
                            ctx.SaveChanges();

                            MessageBox.Show("Sınıf başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Sınıf bulunamadı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    int sinifId;
                    if (int.TryParse(tbSinifId.Text, out sinifId))
                    {
                        var sinif = ctx.Siniflar
                                        .Where(s => s.SinifId == sinifId)
                                        .FirstOrDefault();

                        if (sinif != null)
                        {
                            // Kontenjan kontrolü
                            if (sinif.Kontenjan < 0)
                            {
                                MessageBox.Show("Kontenjan değeri geçersiz!");
                                return;
                            }

                            // Güncelleme işlemi
                            sinif.SinifAd = tbSinifAdi.Text;
                            sinif.Kontenjan = int.Parse(tbKontenjan.Text);
                            ctx.SaveChanges();

                            MessageBox.Show("Sınıf başarıyla güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("Sınıf bulunamadı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnBul_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    int sinifId;
                    if (int.TryParse(tbSinifId.Text, out sinifId))
                    {
                        var sinif = ctx.Siniflar
                                        .Where(s => s.SinifId == sinifId)
                                        .FirstOrDefault();

                        if (sinif != null)
                        {
                            tbSinifAdi.Text = sinif.SinifAd;
                            tbKontenjan.Text = sinif.Kontenjan.ToString();
                            MessageBox.Show($"{sinif.SinifId} ID'li sınıf bulunmuştur");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir Sınıf ID'si giriniz!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void tbSinifAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
