﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repesitories;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{

    public class SosyalMedyaController : Controller
    {
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        DbCvEntities1 db = new DbCvEntities1();
        // GET: SosyalMedya
        public ActionResult Index()
        {
            var veriler = repo.List();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(TblSosyalMedya p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.Ad = p.Ad;
            hesap.Link = p.Link;
            hesap.Durum = true;
            hesap.İkon = p.İkon;
            repo.Update(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {

            var hesap = repo.Find(x => x.ID == id);
            hesap.Durum = false;
            repo.Update(hesap);

            return RedirectToAction("Index");
        }
    }
}