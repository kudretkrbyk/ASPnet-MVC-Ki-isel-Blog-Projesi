using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using okulodevMVC.Models.Siniflar;

namespace okulodevMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var degerler = c.yenis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult yeniIcerik()
        {
            return View();

        }
        [HttpPost]
        public ActionResult yeniIcerik(yeni p)
        {
            c.yenis.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult İcerikSil(int ID)
        {
            var b = c.yenis.Find(ID);
            c.yenis.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult IcerikGetir(int ID)
        {
            var b1 = c.yenis.Find(ID);
            return View("IcerikGetir", b1);

        }
        public ActionResult IcerikGuncelle(yeni b)
        {
            var icerik = c.yenis.Find(b.ID);
            icerik.ResimAlt = b.ResimAlt;
            icerik.ResimYolu = b.ResimYolu;
            c.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}