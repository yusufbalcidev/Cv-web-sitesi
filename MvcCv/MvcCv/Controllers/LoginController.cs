using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCvEntities1 db = new DbCvEntities1();
            var bilgi = db.TblAdmin.FirstOrDefault(x => x.KullanıcıAdi == p.KullanıcıAdi && x.Sifre==p.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullanıcıAdi,false);
                Session["KullaniciAdi"]= bilgi.KullanıcıAdi.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
                
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

    }
}