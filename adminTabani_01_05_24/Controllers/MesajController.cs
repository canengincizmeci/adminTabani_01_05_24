﻿using adminTabani_01_05_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace adminTabani_01_05_24.Controllers
{
    public class MesajController : Controller
    {
        // GET: Mesaj
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UyeAdminMesaj()
        {


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UyeAdminMesaj(string icerik)
        {
            db_Context model = new db_Context();
            int id = (int)Session["kullanici_id"];
            var kisi = model.Kullanicilar.FirstOrDefault(p => p.kullanici_id == id);
            model.AdminMesajlar.Add(new AdminMesajlar
            {
                mesaj = icerik,
                gonderen_id = id,
                tarih = DateTime.Now
            });
            model.SaveChanges();



            return RedirectToAction("UyeAdminMesajTamam");
        }
        public ActionResult UyeAdminMesajTamam()
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            string ad = model.Kullanicilar.Find(id).Ad;
            ViewBag.Ad = ad;
            return View();
        }
        public ActionResult KullancilarArasiMesaj()
        {

            db_Context model = new db_Context();
            var kisiler = model.Kullanicilar.Select(p => new Kullanici
            {
                Ad = p.Ad,
                kullanici_id = p.kullanici_id,
            }).ToList();
            return View(kisiler);
        }
        [HttpGet]
        public ActionResult KullaniciMesaj(int alici_id)
        {
            ViewBag.AliciId = alici_id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KullaniciMesaj(string _mesaj, int Alici_id)
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            model.KullaniciMesajlar.Add(new KullaniciMesajlar
            {
                alici_id = Alici_id,
                gonderen_id = id,
                mesaj = _mesaj,
                tarih = DateTime.Now
            });
            model.SaveChanges();
            return RedirectToAction("KullaniciMesajTamam", new { alici_id = Alici_id });
        }
        public ActionResult KullaniciMesajTamam(int alici_id)
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            string gonderenAd = model.Kullanicilar.Find(id).Ad;
            string aliciAd = model.Kullanicilar.Find(alici_id).Ad;
            ViewBag.Gonderici = gonderenAd;
            ViewBag.Alici = aliciAd;
            return View();
        }
        public ActionResult Mesajlarim()
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            KullaniciMesajlarimPage mesajlarimPage = new KullaniciMesajlarimPage();
            mesajlarimPage.gelenler = model.KullaniciMesajlar.Where(p => p.alici_id == id).OrderByDescending(p => p.k_mesaj_id).Select(p => new KullaniciMesaj
            {
                gonderen_id = p.gonderen_id,
                alici_id = p.alici_id,
                mesaj = p.mesaj,
                tarih = p.tarih,
                k_mesaj_id = p.k_mesaj_id,
                aliciAd = p.Kullanicilar1.Ad,
                GonderenAd = p.Kullanicilar.Ad
            }).ToList();
            mesajlarimPage.gidenler = model.KullaniciMesajlar.Where(p => p.gonderen_id == id).OrderByDescending(p => p.k_mesaj_id).Select(p => new KullaniciMesaj
            {
                k_mesaj_id = p.k_mesaj_id,
                gonderen_id = p.gonderen_id,
                aliciAd = p.Kullanicilar1.Ad,
                alici_id = p.alici_id,
                GonderenAd = p.Kullanicilar.Ad,
                mesaj = p.mesaj,
                tarih = p.tarih
            }).ToList();
            return View(mesajlarimPage);
        }
        public ActionResult UyeMesajDetay(int mesaj_id)
        {
            db_Context model = new db_Context();
            var mesaj = model.KullaniciMesajlar.Find(mesaj_id);
            ViewBag.Mesaj = mesaj.mesaj;
            ViewBag.Tarih = mesaj.tarih;
            ViewBag.Gonderen = mesaj.Kullanicilar.Ad;
            return View();
        }
        //[HttpGet]
        //public ActionResult MesajBildir(int mesajID)
        //{
        //    ViewBag.MesajID = mesajID;
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult MesajBildir(int mesajID, string Sebep)
        //{




        //}
    }
}

