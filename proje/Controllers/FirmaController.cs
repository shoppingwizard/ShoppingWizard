using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proje.Models;
using System.Drawing;

namespace proje.Controllers
{
    public class FirmaController : Controller
    {
        // GET: Firma
        private Context db = new Context();
        public ActionResult FirmaEkle()
        {
            List<Kategoriler> kategori = db.Kategoriler.ToList();
            return View(kategori);
        }

        [HttpPost]
        public ActionResult FirmaEkle(string firma, string adres,string telefon, string email, string aciklama, int kategori)
        {


            
            Firmalar firmalar = new Firmalar();
            firmalar.firmaAdi = firma;
            firmalar.email = email;
            firmalar.aciklama = aciklama;
            firmalar.KategoriId = kategori;
            firmalar.kullaniciId = 1;//Session[""];
            db.Firmalar.Add(firmalar);
            db.SaveChanges();


            firmaAdres f1Adres = new firmaAdres();
            f1Adres.adres = adres;
            db.firmaAdres.Add(f1Adres);
            db.SaveChanges();

            TelefonNo f1tel = new TelefonNo();
            f1tel.telefonNo = telefon;
            db.TelefonNo.Add(f1tel);
            db.SaveChanges();

          

            return RedirectToAction("Index", "Home");

        }



        public ActionResult Index()
        {
            return View();
        }
    }
}