using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class tblSiniflar
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenciler> Ogrenciler { get; set; }

    }
}
