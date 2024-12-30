using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Ogrenciler
    {

        public int OgrenciId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Numara { get; set; }

        public int SinifId { get; set; }

        public string Sifre { get; set; }

        public tblSiniflar Sinif { get; set; }

        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; }
    }
}
