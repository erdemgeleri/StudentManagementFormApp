using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class OgrenciDersIslemleri : Form
    {
        Ogrenciler ogrenci;
        public OgrenciDersIslemleri(Ogrenciler ogrenci)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            using (var ctx = new FinalDBContext())
            {
                var ogrenciDersler = ctx.OgrenciDersler
                                        .Where(od => od.OgrenciId == ogrenci.OgrenciId)
                                        .Select(od => od.Ders)
                                        .ToList();

                StringBuilder dersListesi = new StringBuilder();

                foreach (var ders in ogrenciDersler)
                {
                    dersListesi.AppendLine(ders.DersAd);
                }

                if (dersListesi.Length > 0)
                {
                    lbl_dersler.Text = dersListesi.ToString();
                }
                else
                {
                    lbl_dersler.Text = "Öğrencinin kaydolduğu ders yok.";
                }
            }
        }

        private void OgrenciDersIslemleri_Load(object sender, EventArgs e)
        {
            using (var ctx = new FinalDBContext())
            {
                lblAd.Text = ogrenci.Ad;
                lblSoyad.Text = ogrenci.Soyad;
                lblNumara.Text = ogrenci.Numara.ToString();
                var seciliSinifItem = ctx.Siniflar
                            .FirstOrDefault(s => s.SinifId == ogrenci.SinifId);
                lblSinif.Text = seciliSinifItem.SinifAd;



                var dersler = ctx.Dersler.Select(d => new
                {
                    d.DersId,
                    d.DersAd
                }).ToList();
                if (dersler.Count > 0)
                {
                    dataGridView1.DataSource = dersler;
                    dataGridView1.Columns["DersId"].Visible = true;
                }
                else
                {
                    MessageBox.Show("Dersler bulunamadı.");
                }

            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var dersId = (int)row.Cells["DersId"].Value;

                        var ogrenciDers = new tblOgrenciDers
                        {
                            OgrenciId = ogrenci.OgrenciId,
                            DersId = dersId
                        };

                        ctx.OgrenciDersler.Add(ogrenciDers);
                    }

                    ctx.SaveChanges();
                    var ogrenciDersler = ctx.OgrenciDersler
                                                .Where(od => od.OgrenciId == ogrenci.OgrenciId)
                                                .Select(od => od.Ders)
                                                .ToList();

                    StringBuilder dersListesi = new StringBuilder();

                    foreach (var ders in ogrenciDersler)
                    {
                        dersListesi.AppendLine(ders.DersAd);
                    }

                    if (dersListesi.Length > 0)
                    {
                        lbl_dersler.Text = dersListesi.ToString();
                    }
                    else
                    {
                        lbl_dersler.Text = "Öğrencinin kaydolduğu ders yok.";
                    }

                }

                MessageBox.Show("Seçilen dersler başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aynı ders iki kez eklenemez!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new FinalDBContext())
            {
                var ogrenciDersler = ctx.OgrenciDersler
                                        .Where(od => od.OgrenciId == ogrenci.OgrenciId)
                                        .Select(od => od.Ders)
                                        .ToList();

                StringBuilder dersListesi = new StringBuilder();

                foreach (var ders in ogrenciDersler)
                {
                    dersListesi.AppendLine(ders.DersAd);
                }

                if (dersListesi.Length > 0)
                {
                    lbl_dersler.Text = dersListesi.ToString();
                }
                else
                {
                    lbl_dersler.Text = "Öğrencinin kaydolduğu ders yok.";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new FinalDBContext())
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var dersId = (int)row.Cells["DersId"].Value;

                        var ogrenciDers = ctx.OgrenciDersler
                                              .FirstOrDefault(od => od.OgrenciId == ogrenci.OgrenciId && od.DersId == dersId);

                        if (ogrenciDers != null)
                        {
                            ctx.OgrenciDersler.Remove(ogrenciDers);
                            MessageBox.Show("Seçilen dersler başarıyla silindi.");
                        }
                    }

                    ctx.SaveChanges();

                    var ogrenciDersler = ctx.OgrenciDersler
                                            .Where(od => od.OgrenciId == ogrenci.OgrenciId)
                                            .Select(od => od.Ders)
                                            .ToList();

                    StringBuilder dersListesi = new StringBuilder();

                    foreach (var ders in ogrenciDersler)
                    {
                        dersListesi.AppendLine(ders.DersAd);
                    }

                    if (dersListesi.Length > 0)
                    {
                        lbl_dersler.Text = dersListesi.ToString();
                    }
                    else
                    {
                        lbl_dersler.Text = "Öğrencinin kaydolduğu ders yok.";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
            this.Hide();
            ogrenciIslemleri.Show();
        }
    }
}
