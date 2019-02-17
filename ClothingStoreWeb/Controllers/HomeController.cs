using ClothingStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Buy(int productId, int number)
        {
            var service = new StoreService();
            var product = service.GetProduct(productId);
            if (product != null)
            {
                service.Buy(productId, number);
            }
            return PartialView("~/Views/Partials/_ProductTable.cshtml");
        }

        [HttpPost]
        public ActionResult Sale(int productId, int number)
        {
            var service = new StoreService();
            var product = service.GetProduct(productId);
            if (product != null)
            {
                service.Sale(productId, number);
            }
            return PartialView("~/Views/Partials/_ProductTable.cshtml");
        }
    }
}