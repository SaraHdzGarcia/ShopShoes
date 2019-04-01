using Highsoft.Web.Mvc.Charts;
using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Globalization;

namespace ShoesShop.Controllers
{
    public class GráficasController : Controller
    {
        DbContextShop dbCtx = new DbContextShop();

        // GET: Gráficas
        public ActionResult Top2()
        {
            if (Session["UserName"] != null)
            {
                List<int> productValues = new List<int>();

                var query = (from o in dbCtx.OrderDetails
                             group o by o.ProductID into od
                             orderby od.Count()
                             select new
                             {
                                 Producto = od.Key,
                                 Total = od.Count()
                             }).ToList().Take(10);

                foreach (var item in query)
                {
                    productValues.Add(item.Total);
                }

                List<ColumnSeriesData> productData = new List<ColumnSeriesData>();
                //

                //Con expresiones Lambda --- Llenando la infromacion a los columnData
                productValues.ForEach(p => productData.Add(new ColumnSeriesData { Y = p }));
                //

                //Sirve para transferir del c#(Controller) a la grafica (VIEW)
                ViewData["productData"] = productData;
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
        public ActionResult Dias()
        {
            if (Session["UserName"] != null)
            {
                List<int> daysValues = new List<int>();

                var query = (from o in dbCtx.Orders
                             where o.OrderDate.Day != 5
                             select new
                             {
                                 Dia = o.OrderDate.Day
                             }).ToList().Distinct();

                foreach (var item in query)
                {
                    daysValues.Add(item.Dia);
                }

                List<ColumnSeriesData> dayData = new List<ColumnSeriesData>();
                //

                //Con expresiones Lambda --- Llenando la infromacion a los columnData
                daysValues.ForEach(p => dayData.Add(new ColumnSeriesData { Y = p }));
                //

                //Sirve para transferir del c#(Controller) a la grafica (VIEW)
                ViewData["dayData"] = dayData;
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }

        public ActionResult Temp()
        {
            if (Session["UserName"] != null)
            {
                List<int> tempValues = new List<int>();

                var query = (from o in dbCtx.Orders
                             where (o.OrderDate.Day >= 21 && o.OrderDate.Day <= 20 && o.OrderDate.Month == 3 || o.OrderDate.Month == 4
                             || o.OrderDate.Month == 5 || o.OrderDate.Month == 6 || o.OrderDate.Month == 7 || o.OrderDate.Month == 8 || o.OrderDate.Month == 9)
                             select new
                             {
                                 Tempo = o.OrderDate,
                                 Vendidos = o.TotalProduct
                             }).ToList();

                foreach (var item in query)
                {
                    tempValues.Add(item.Vendidos);
                }

                List<ColumnSeriesData> tempoData = new List<ColumnSeriesData>();
                //

                //Con expresiones Lambda --- Llenando la infromacion a los columnData
                tempValues.ForEach(p => tempoData.Add(new ColumnSeriesData { Y = p }));
                //

                //Sirve para transferir del c#(Controller) a la grafica (VIEW)
                ViewData["tempoData"] = tempoData;
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
    }
}