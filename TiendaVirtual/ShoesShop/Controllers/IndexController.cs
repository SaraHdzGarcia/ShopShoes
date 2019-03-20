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

        #region CABALLERO
        public ActionResult Caballero3()
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x=>x.CategoryID==1).OrderBy(x=>x.BarCode));
        }

        //buscar
        public ActionResult Caballero2(string palabra)
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            IEnumerable<Products> Producto;
            
            var product = from p in dbCtx.Products select p;

            if (!String.IsNullOrEmpty(palabra))
            {
                product = product.Where(l => l.ProductName.Contains(palabra)&& l.CategoryID==1);
            }

            Producto = product.ToList();

            return View(Producto);
        }
        #endregion

        #region DAMA
        public ActionResult Dama3()
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x=>x.CategoryID==2).OrderBy(x=>x.BarCode));
        }

        //buscar
        public ActionResult Dama2(string palabra)
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            IEnumerable<Products> Producto;
            
            var product = from p in dbCtx.Products select p;

            if (!String.IsNullOrEmpty(palabra))
            {
                product = product.Where(l => l.ProductName.Contains(palabra) && l.CategoryID==2);
            }

            Producto = product.ToList();


            return View(Producto);
        }
        #endregion

        #region NIÑO
        public ActionResult Niño3()
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 3).OrderBy(x => x.BarCode));
        }

        public ActionResult Niño2(string palabra)
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            IEnumerable<Products> Producto;
            
            var product = from p in dbCtx.Products select p;

            if (!String.IsNullOrEmpty(palabra))
            {
                product = product.Where(l => l.ProductName.Contains(palabra) && l.CategoryID == 3);
            }

            Producto = product.ToList();


            return View(Producto);
        }
        #endregion

        #region NIÑA
        public ActionResult Niña3()
        {
            ViewBag.ruta= Server.MapPath("~") + @"Images" + (".jpg");
            return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 4).OrderBy(x => x.BarCode));
        }

        public ActionResult Niña2(string palabra)
        {
            ViewBag.ruta = Server.MapPath("~") + @"Images" + (".jpg");
            IEnumerable<Products> Producto;

            var product = from p in dbCtx.Products select p;

            if (!String.IsNullOrEmpty(palabra))
            {
                product = product.Where(l => l.ProductName.Contains(palabra) && l.CategoryID == 4);
            }

            Producto = product.ToList();


            return View(Producto);
        }
        #endregion

    }
}