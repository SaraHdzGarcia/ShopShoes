using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class ImageController : Controller
    {
        private readonly DbContextShop dbCtx = new DbContextShop();

        // GET: Image
        public ActionResult Index()
        {
            List<Products> products = dbCtx.Products.OrderBy(x => x.ProductName).ToList();

            return View(products);
            //if (Session["UserName"] != null)
            //{
            //Esta linea sirve para guardar en una lista las rutas de las fotos
            //List<string> listaRutaImages = new List<string>();

            //Esta linea sirve para obtener la ruta completa donde tengo
            //guardadas todas mis fotos
            //var carpeta = Server.MapPath("~") + @"Images";

            //Instanciamos el objeto para crear los directorios
            //DirectoryInfo d = new DirectoryInfo(carpeta);

            //obtener todos los archivos que tienen la extension .jpg
            //FileInfo[] Files = d.GetFiles("*.jpg");

            //Recorremos la carpeta donde guardamos las fotos
            //foreach (FileInfo file in Files)
            //{
            //Agregamos la foto completa a la lista (nombre de la foto)
            //    listaRutaImages.Add(file.Name);
            //}

            //Es un tipo de variable que nos sirve para transportar informacion a la vista
            //ViewBag.lista = listaRutaImages;
            //return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Login");
            //}
        }
    }
}