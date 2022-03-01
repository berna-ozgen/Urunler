using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Urunler.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi{ get; set; }
        public string UrunAciklama { get; set; }
        public double Fiyat { get; set; }
        public bool SatisDurumu { get; set; }

      
    }
}