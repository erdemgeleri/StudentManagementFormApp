using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class tblOgrenciDers
    {
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenciler Ogrenci { get; set; }
        public tblDersler Ders { get; set; }
    }
}
