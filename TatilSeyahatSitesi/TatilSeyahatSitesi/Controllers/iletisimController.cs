using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    [AllowAnonymous]

    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(iletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.iletisims.Add(t);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}