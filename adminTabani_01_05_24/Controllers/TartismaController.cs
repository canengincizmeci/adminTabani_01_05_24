﻿using adminTabani_01_05_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminTabani_01_05_24.Controllers
{
    public class TartismaController : Controller
    {
        // GET: Tartisma
        public ActionResult Index()
        {
            db_Context model = new db_Context();

            var veriler = model.Tartismalar.Where(p => p.onay == true).Select(p => new Tartisma
            {
                TartismaID = p.TartismaID,
                Baslik = p.Baslik,
                aktiflik = p.aktiflik,
                icerik = p.icerik,
                KullaniciAd = p.Kullanicilar.Ad,
                kullanici_id = p.kullanici_id,
                onay = p.onay,
                tarih = p.tarih
            }).ToList();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult TartismaDetay(int tartisma_id)
        {
            db_Context model = new db_Context();
            TartismaDetayPage tartismaDetay = new TartismaDetayPage();
            tartismaDetay.tartisma = model.Tartismalar.Where(p => p.TartismaID == tartisma_id).Select(p => new Tartisma
            {
                TartismaID = p.TartismaID,
                Baslik = p.Baslik,
                aktiflik = p.aktiflik,
                icerik = p.icerik,
                KullaniciAd = p.Kullanicilar.Ad,
                kullanici_id = p.kullanici_id,
                onay = p.onay,
                tarih = p.tarih
            }).FirstOrDefault();
            tartismaDetay.tartisma_yorumlari = model.TartismaYorumlar.Where(p => p.tartismaID == tartisma_id & p.onay == true).OrderByDescending(p => p.tartismaYorumID).Select(p => new TartismaYorumlari
            {
                _onay = p.onay,
                _tarih = p.tarih,
                _tartismaID = p.tartismaID,
                _tartismaYorumID = p.tartismaYorumID,
                _yorum = p.yorum,
                _yorumcuID = p.yorumcuID,
                yorumcu_ad = p.Kullanicilar.Ad
            }).ToList();
            return View(tartismaDetay);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YorumYap(string _yorum, int _tartisma_id)
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            model.TartismaYorumlar.Add(new TartismaYorumlar
            {
                onay = false,
                tarih = DateTime.Now,
                yorum = _yorum,
                tartismaID = _tartisma_id,
                yorumcuID = id
            });
            model.SaveChanges();
            return RedirectToAction("TartismaDetay", new { tartisma_id = _tartisma_id });
        }
        [HttpGet]
        public ActionResult Bildir(int _tartismaID)
        {
            ViewBag.TartismaID = _tartismaID;


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bildir(int tartismaID, string _sebep)
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            model.TartismaSikayetler.Add(new TartismaSikayetler
            {
                sebep = _sebep,
                tarih = DateTime.Now,
                tartisma_id = tartismaID,
                sikayetci_id = id
            });
            model.SaveChanges();
            return RedirectToAction("TartismaSikayetTamam", new { _tartismaID = tartismaID });
        }
        public ActionResult TartismaSikayetTamam(int _tartismaID)
        {
            int id = (int)Session["kullanici_id"];
            db_Context model = new db_Context();
            string baslik = model.Tartismalar.Find(_tartismaID).Baslik;
            string kisi_ad = model.Kullanicilar.Find(id).Ad;
            ViewBag.Baslik = baslik;
            ViewBag.KullaniciAd = kisi_ad;
            ViewBag.TartismaID = _tartismaID;
            return View();
        }
    }
}