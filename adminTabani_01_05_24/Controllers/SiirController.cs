﻿using adminTabani_01_05_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminTabani_01_05_24.Controllers
{
    public class SiirController : Controller
    {
        // GET: Siir
        public ActionResult ZiyaretciIndex()
        {
            dbContext model = new dbContext();
            var siirler = model.Siirler.OrderByDescending(p => p.siirID).Where(p => p.onay == true).Select(p => new Siir
            {
                siirID = p.siirID,
                icerik = p.icerik,
                siirBaslik = p.siirBaslik,
                tarih = p.tarih,
                yazar = p.yazar,
                YazarAd = p.Kullanicilar.Ad,
                _onay = p.onay
            }).ToList();
            return View(siirler);
        }
        public ActionResult ZiyaretciSiirDetay(int siir_id)
        {
            dbContext model = new dbContext();
            ZiyaretciSiirDetayPage detayPage = new ZiyaretciSiirDetayPage();
            detayPage.siir = model.Siirler.Where(p => p.siirID == siir_id).Select(p => new Siir
            {
                siirID = p.siirID,
                icerik = p.icerik,
                siirBaslik = p.siirBaslik,
                tarih = p.tarih,
                yazar = p.yazar,
                YazarAd = p.Kullanicilar.Ad,
                _onay = p.onay
            }).FirstOrDefault();
            detayPage.siir_yorumlari = model.SiirYorumlar.OrderByDescending(p => p.SiirYorumID).Where(p => p.onay == true).Select(p => new SiirYorumlari
            {
                _SiirYorumID = p.SiirYorumID,
                _icerik = p.icerik,
                _onay = p.onay,
                _siirID = p.siirID,
                _tarih = p.tarih,
                _yorumcuID = p.yorumcuID,
                YorumcuAd = p.Kullanicilar.Ad
            }).ToList();
            return View(detayPage);
        }
        public ActionResult UyeSiirIndex()
        {
            dbContext model = new dbContext();
            var veriler = model.Siirler.Where(p => p.onay == true).OrderByDescending(p => p.siirID).Select(p => new Siir
            {
                siirID = p.siirID,
                icerik = p.icerik,
                siirBaslik = p.siirBaslik,
                tarih = p.tarih,
                yazar = p.yazar,
                YazarAd = p.Kullanicilar.Ad,
                _onay = p.onay
            }).ToList();
            return View(veriler);
        }
        public ActionResult UyeSiirDetay(int siir_id)
        {
            int id = (int)Session["kullanici_id"];
            dbContext model = new dbContext();
            ZiyaretciSiirDetayPage detayPage = new ZiyaretciSiirDetayPage();
            detayPage.siir = model.Siirler.Where(p => p.siirID == siir_id).Select(p => new Siir
            {
                siirID = p.siirID,
                icerik = p.icerik,
                siirBaslik = p.siirBaslik,
                tarih = p.tarih,
                yazar = p.yazar,
                YazarAd = p.Kullanicilar.Ad,
                _onay = p.onay
            }).FirstOrDefault();
            detayPage.siir_yorumlari = model.SiirYorumlar.OrderByDescending(p => p.SiirYorumID).Where(p => p.onay == true).Select(p => new SiirYorumlari
            {
                _SiirYorumID = p.SiirYorumID,
                _onay = p.onay,
                YorumcuAd = p.Kullanicilar.Ad,
                _icerik = p.icerik,
                _siirID = p.siirID,
                _tarih = p.tarih,
                _yorumcuID = p.yorumcuID
            }).ToList();
            return View(detayPage);
        }
        [HttpGet]
        public ActionResult Bildir(int siir_id)
        {
            ViewBag.SiirID = siir_id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bildir(int _siirID, string _sebep)
        {
            int id = (int)Session["kullanici_id"];
            dbContext model = new dbContext();
            model.SiirSikayetler.Add(new SiirSikayetler
            {
                sebep = _sebep,
                siir_id = _siirID,
                sikayetci_id = id,
                tarih = DateTime.Now,

            });
            model.SaveChanges();
            return RedirectToAction("SiirSikayetTamam", new { siir_id = _siirID });
        }
        public ActionResult SiirSikayetTamam(int siir_id)
        {
            int id = (int)Session["kullanici_id"];
            dbContext model = new dbContext();
            var baslik = model.Siirler.Find(siir_id).siirBaslik;
            var yazarAd = model.Kullanicilar.Find(id).Ad;
            ViewBag.Baslik = baslik;
            ViewBag.Yazar = yazarAd;
            ViewBag.SiirID = siir_id;
            return View();
        }
    }
}