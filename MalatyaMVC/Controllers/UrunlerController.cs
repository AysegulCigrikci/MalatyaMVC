using MalatyaMVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace MalatyaMVC.Controllers
{
    public class UrunlerController : Controller
    {
        malatyaContext db = new malatyaContext();

        // GET: Urunler
        public ActionResult Index()
        {
            return View();
        }
        [Route("Detay")]
        public ActionResult Detay(int id)
        {
           return View(db.Urunlers.FirstOrDefault(x => x.id == id));
        }
    }
}