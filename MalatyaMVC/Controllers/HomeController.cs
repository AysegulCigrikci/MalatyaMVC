using MalatyaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalatyaMVC.Controllers
{
    public class HomeController : Controller
    {
       malatyaContext db = new malatyaContext();

        // GET: Home
        //Malatya Ürünleri
        public ActionResult Index()
        {
            //var urunlerr = db.Urunlers.Where(x => x.id > 0);
            //return View(urunlerr);

            var urunlerr = db.Urunlers.Where(x => x.KategoriID == 1).ToList();
            return View(urunlerr);
        }

        //Hediyelik Kayısı Paketleri
        public ActionResult HediyeKayisi()
        {
            var hediyekayisi = db.Urunlers.Where(x => x.KategoriID == 5).ToList();
            return View(hediyekayisi);
        }

        //Kayısı Güzellik Ürünleri
        public ActionResult KayisiGuzellik()
        {
            var kayisiguzellik = db.Urunlers.Where(x => x.KategoriID == 2).ToList();
            return View(kayisiguzellik);
        }

        //Bal ve Pekmez Güzellik Ürünleri
        public ActionResult BalPekmez()
        {
            var balpekmez = db.Urunlers.Where(x => x.KategoriID == 3).ToList();
            return View(balpekmez);
        }

        //Kurutulmuş Ürünler
        public ActionResult KuruMeyve()
        {
            var kurumeyve = db.Urunlers.Where(x => x.KategoriID == 2).ToList();
            return View(kurumeyve);
        }
    }
}