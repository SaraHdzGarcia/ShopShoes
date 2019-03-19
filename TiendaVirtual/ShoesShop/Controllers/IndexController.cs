using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x=>x.CategoryID==1).OrderBy(x=>x.BarCode));
        }


        public ActionResult Dama()
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x=>x.CategoryID==2).OrderBy(x=>x.BarCode));
        }

        public ActionResult Niño()
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 3).OrderBy(x => x.BarCode));
        }

        public ActionResult Niña()
        {
            ViewBag.ruta= Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 4).OrderBy(x => x.BarCode));
        }


    }
}