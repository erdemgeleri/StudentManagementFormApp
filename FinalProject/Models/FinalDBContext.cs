using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    internal class FinalDBContext : DbContext
    {
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<tblSiniflar> Siniflar { get; set; }
        public DbSet<tblDersler> Dersler { get; set; }
        public DbSet<tblOgrenciDers> OgrenciDersler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=FinalExam;Integrated Security=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenciler>()
                .HasKey(o => o.OgrenciId);
            modelBuilder.Entity<Ogrenciler>()
                .Property(o => o.OgrenciId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<Ogrenciler>()
                .Property(o => o.Ad)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Soyad)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Numara)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.SinifId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<tblOgrenciDers>()
                .HasKey(od => new { od.OgrenciId, od.DersId });
            modelBuilder.Entity<tblOgrenciDers>().Property(d => d.DersId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<tblOgrenciDers>().Property(d => d.OgrenciId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<tblDersler>()
                .HasKey(f => f.DersId);
            modelBuilder.Entity<tblDersler>().Property(f => f.DersId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<tblDersler>().Property(f => f.DersKod)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<tblDersler>().Property(f => f.DersAd)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<tblSiniflar>()
                .HasKey(g => g.SinifId);
            modelBuilder.Entity<tblSiniflar>().Property(g => g.SinifId)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<tblSiniflar>().Property(g =>g.SinifAd)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();
            modelBuilder.Entity<tblSiniflar>().Property(g => g.Kontenjan)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ogrenci) 
                .WithMany(o => o.OgrenciDersler)  
                .HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ders)  
                .WithMany(d => d.OgrenciDersler)  
                .HasForeignKey(od => od.DersId);

            modelBuilder.Entity<Ogrenciler>()
                .HasOne(o => o.Sinif)  
                .WithMany(s => s.Ogrenciler)  
                .HasForeignKey(o => o.SinifId);
        }
    }
}
