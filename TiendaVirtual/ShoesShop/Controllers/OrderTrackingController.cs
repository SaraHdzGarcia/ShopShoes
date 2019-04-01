using ShoesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class OrderTrackingController : Controller
    {
        DbContextShop dbCtx = new DbContextShop();

        // GET: OrderTracking
        public ActionResult Seguimiento()
        {
            if (Session["UserName"] != null)
            {
                List<OrderTracking> order = dbCtx.OrderTrackings.OrderBy(x => x.OrderID).ToList();
                return View(order);
            }
            else
            {
                return RedirectToAction("Index", "Index");
            }
        }
    }
}