using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class IndexController : Controller
    {
        private static DbContextShop dbCtx = new DbContextShop();

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Caballero()
        {
            return View(dbCtx.Products.ToList().Where(x=>x.CategoryID==1).OrderBy(x=>x.BarCode));
        }
    }
}