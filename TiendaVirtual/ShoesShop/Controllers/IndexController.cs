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

        //buscar
        public ActionResult Caballero2(string palabra)
        {
            ViewBag.ruta = Server.MapPath("~") +  @"Images" + (".jpg");
            IEnumerable<Products> Producto;


            var product = from p in dbCtx.Products select p;

                if (!String.IsNullOrEmpty(palabra))
                {
                    product = product.Where(l => l.ProductName.ToUpper().Contains(palabra.ToUpper()) && (l.CategoryID==1)).OrderBy(x=>x.BarCode);
                }

                Producto = product.ToList();
            

            return View(Producto);
            //return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 1 || x.ProductName.Contains(palabra)).OrderBy(x => x.BarCode));
        }


        public ActionResult Dama()
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
                product = product.Where(l => l.ProductName.ToUpper().Contains(palabra.ToUpper()) && (l.CategoryID == 2)).OrderBy(x => x.BarCode);
            }

            Producto = product.ToList();


            return View(Producto);
            //return View(dbCtx.Products.ToList().Where(x => x.CategoryID == 1 || x.ProductName.Contains(palabra)).OrderBy(x => x.BarCode));
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
        public ActionResult Buscar(string palabra)
        {
            IEnumerable<Products> Producto;

            using (var bd = new DbContextShop())
            {
                Producto = bd.Products;

                if (!String.IsNullOrEmpty(palabra))
                {
                    Producto = Producto.Where(l => l.ProductName.ToUpper().Contains(palabra.ToUpper()));
                }

                Producto = Producto.ToList();
            }

            return View(Producto);
        }
    }
}