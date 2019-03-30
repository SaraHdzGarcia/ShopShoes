using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult AgregarCarrito(int productID)
        {
            if (Session["UserName"] == null)
            {

            }
            else
            {

            }

            return View();
        }
    }
}