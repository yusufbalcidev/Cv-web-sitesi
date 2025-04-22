using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repesitories;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim

        DeneyimRepesitory repo=new DeneyimRepesitory();
        public ActionResult Index()
        {
            var deneyimler = repo.List();
            return View(deneyimler);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeneyimSil(int id)
        {
            TblDeneyimlerim t = repo.Find(x=> x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyimlerim t = repo.Find(x=> x.ID == id);
            return View(t);

        }
        [HttpPost]
        public ActionResult DeneyimGetir(TblDeneyimlerim p)
        {
            TblDeneyimlerim t = repo.Find(x=> x.ID == p.ID);
            t.Baslik= p.Baslik;
            t.AltBaslik= p.AltBaslik;
            t.tarih= p.tarih;
            t.Aciklama= p.Aciklama;
            repo.Update(t);

            return RedirectToAction("Index");

        }

    }
}