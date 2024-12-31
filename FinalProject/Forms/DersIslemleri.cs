using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class DersIslemleri : Form
    {
        public DersIslemleri()
        {
            InitializeComponent();
        }

        private void DersIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string dersAd = tbDersAd.Text.Trim();
                if (string.IsNullOrEmpty(dersAd))
                {
                    MessageBox.Show("Lütfen ders adını giriniz!");
                    return;
                }

                using (var ctx = new FinalDBContext())
                {
                    var mevcutDers = ctx.Dersler.FirstOrDefault(d => d.DersAd == dersAd);
                    if (mevcutDers != null)
                    {
                        MessageBox.Show("Bu ders zaten mevcut!");
                        return;
                    }

                    var yeniDers = new tblDersler
                    {
                        DersAd = dersAd
                    };

                    ctx.Dersler.Add(yeniDers);
                    ctx.SaveChanges();

                    MessageBox.Show("Ders başarıyla eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int dersId;
                if (!int.TryParse(tbDersId.Text, out dersId))
                {
                    MessageBox.Show("Geçerli bir Ders ID'si giriniz!");
                    return;
                }

                using (var ctx = new FinalDBContext())
                {
                    var ders = ctx.Dersler
                        .Where(d => d.DersId == dersId)
                        .Include(d => d.OgrenciDersler)
                        .FirstOrDefault();

                    if (ders != null)
                    {
                        if (ders.OgrenciDersler != null && ders.OgrenciDersler.Count > 0)
                        {
                            MessageBox.Show("Bu derse kayıtlı öğrenciler olduğu için ders silinemez.");
                        }
                        else
                        {
                            ctx.Dersler.Remove(ders);
                            ctx.SaveChanges();
                            MessageBox.Show("Ders başarıyla silindi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ders bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                int dersId;
                if (!int.TryParse(tbDersId.Text, out dersId))
                {
                    MessageBox.Show("Geçerli bir Ders ID'si giriniz!");
                    return;
                }

                using (var ctx = new FinalDBContext())
                {
                    var ders = ctx.Dersler
                        .FirstOrDefault(d => d.DersId == dersId);
                    if (ders != null)
                    {
                        tbDersAd.Text = ders.DersAd;
                        MessageBox.Show($"Ders bulundu: {ders.DersAd}");
                    }
                    else
                    {
                        MessageBox.Show("Ders bulunamadı.");
                    }
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
                int dersId;
                if (!int.TryParse(tbDersId.Text, out dersId))
                {
                    MessageBox.Show("Geçerli bir Ders ID'si giriniz!");
                    return;
                }

                using (var ctx = new FinalDBContext())
                {
                    var ders = ctx.Dersler.FirstOrDefault(d => d.DersId == dersId);
                    if (ders != null)
                    {
                        ders.DersAd = tbDersAd.Text.Trim();
                        ctx.SaveChanges();

                        MessageBox.Show("Ders başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Ders bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void DersIslemleri_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}

