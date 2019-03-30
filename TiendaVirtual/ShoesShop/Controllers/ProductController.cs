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
        private readonly DbContextShop dbCtx = new DbContextShop();

        // GET: Product
        public ActionResult Index()
        {
            List<Products> products = dbCtx.Products.OrderBy(x=>x.ProductName).ToList(); 

            //Products p = dbCtx.Products.Where(x => x.BarCode == barcode).SingleOrDefault();

            ////fila
            //var row = dt.NewRow();

            ////columnas
            //row["Codigo"] = p.BarCode;
            //row["Producto"] = p.ProductName;
            //row["Precio"] = p.ProductPrice;

            //dt.Rows.Add(row);
            return View(products);
        }

        public ActionResult EliminarCarrito(string barcode)
        {
            Products p = dbCtx.Products.Where(x=>x.BarCode==barcode).FirstOrDefault();
            dbCtx.Products.Remove(p);
            dbCtx.SaveChanges();
            return View();
        }
    }
}


//var re = (from p in dbCtx.Products
//          join s in dbCtx.ShoppingCarts on p.ProductID equals s.ProductID
//          where p.BarCode == barcode
//          select new
//          {
//              Codigo = p.BarCode,
//              Producto = p.ProductName,
//              Precio = p.ProductPrice,
//              Cantidad = s.Quantity,
//              Total = s.Total
//          }).ToList();

////Products p = dbCtx.Products.Where(x => x.BarCode == barcode).SingleOrDefault();

//dt.Columns.AddRange(new DataColumn[]{
//                                new DataColumn("Codigo", typeof(string)),
//                                new DataColumn("Producto", typeof(string)),
//                                new DataColumn("Precio", typeof(string)),
//                                new DataColumn("Cantidad", typeof(string)),
//                                new DataColumn("Total", typeof(string)),
//                            });

//            //Guardar los datos recuperados en una fila del DataTable
//            re.ToList().ForEach(x =>
//            {
//    //Crear una fila nueva
//    var row = dt.NewRow();

//    //Cargar los datos de la fila
//    row["Codigo"] = x.Codigo;
//    row["Producto"] = x.Producto;
//    row["Precio"] = x.Precio;
//    row["Cantidad"] = x.Cantidad;
//    row["Total"] = x.Cantidad;

//    dt.Rows.Add(row);
//});
//            return View();