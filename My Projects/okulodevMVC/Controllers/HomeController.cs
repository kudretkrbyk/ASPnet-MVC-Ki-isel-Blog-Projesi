using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using okulodevMVC.Models;
using okulodevMVC.Models.Siniflar;

namespace okulodevMVC.Controllers
{
    public class HomeController : Controller

    {
        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
        Context c = new Context();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var degerler = c.ForImages.ToList();
            return View(degerler);
        }
        [Authorize(Roles ="Admin")]
        public ActionResult Iletisim()
        {
            ViewBag.Message = "İletişim Sayfası Sadece Yöneticiler Görebilir.";

            return View();
        }
        [Authorize]
        public ActionResult YemeIcme()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult Parttial1()
        {
            Context k = new Context();
            var degerler = k.yenis.ToList();
            return PartialView(degerler);
        }
    }
}