using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class ProductController : Controller
    {
        DataTable dt = new DataTable();
        DbContextShop dbCtx = new DbContextShop();

        // GET: Product
        public ActionResult AgregarCarrito(string barcode)
        {
            Products p = dbCtx.Products.Where(x => x.BarCode == barcode).SingleOrDefault();

            //fila
            var row = dt.NewRow();

            //columnas
            row["Codigo"] = p.BarCode;
            row["Producto"] = p.ProductName;
            row["Precio"] = p.ProductPrice;

            dt.Rows.Add(row);
            return View();
        }
    }
}