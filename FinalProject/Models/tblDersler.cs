using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class tblDersler
    {
        public int DersId { get; set; }
        public int DersKod { get; set; }
        public string DersAd { get; set; }
        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; }

    }
}
