using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Urunler.Models;

namespace Urunler.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunId=1 ,UrunAdi="Samsung S6" ,UrunAciklama="idare eder",Fiyat=1000,SatisDurumu=true },
                new Urun(){UrunId=2 ,UrunAdi="Samsung S7 " ,UrunAciklama="idare eder",Fiyat=2000,SatisDurumu=false },
                new Urun(){UrunId=3 ,UrunAdi="Samsung S8 " ,UrunAciklama="idare eder",Fiyat=3000,SatisDurumu=true },
                new Urun(){UrunId=4 ,UrunAdi="Samsung S9" ,UrunAciklama="idare eder",Fiyat=4000,SatisDurumu=false },
                new Urun(){UrunId=5 ,UrunAdi="Samsung Note6" ,UrunAciklama="idare eder",Fiyat=5000 ,SatisDurumu=true },
                new Urun(){UrunId=6 ,UrunAdi="Samsung Note8" ,UrunAciklama="idare eder",Fiyat=6000 ,SatisDurumu=false },

                
        };
            List<Kategori> kategori = new List<Kategori>()
            {
                new Kategori(){KategoriID=1 ,KategoriAdi="TELEFON"},
                new Kategori(){KategoriID=2,KategoriAdi="TABLET"},
                new Kategori(){KategoriID=3,KategoriAdi="LAPTOP"},
                new Kategori(){KategoriID=4,KategoriAdi="BİLGİSAYAR"}

            };


            ViewBag.UrunSayisi = urunler.Count();
            ViewBag.Kategori = kategori;
            return View(urunler);
        }
    }
}