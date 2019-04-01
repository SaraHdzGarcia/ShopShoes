using ShoesShop.Models;
using ShoesShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly DbContextShop dbCtx = new DbContextShop();

        // GET: Carrito
        public ActionResult AgregarCarrito(int productID)
        {
                if (Session["shoppingCart"] == null)
                {
                    List<ShoppingCartModel> shoppingCart = new List<ShoppingCartModel>();

                    var productEntity = dbCtx.Products.Find(productID);

                    ShoppingCartModel item = new ShoppingCartModel(productEntity)
                    {
                        BarCode = productEntity.BarCode,
                        Description = productEntity.ProductName,
                        Price = productEntity.ProductPrice,
                        Quantity = 1,
                        Total = productEntity.ProductPrice * 1
                    };

                    shoppingCart.Add(item);

                    Session["shoppingCart"] = shoppingCart;
                }
                else
                {
                    List<ShoppingCartModel> shoppingCart = (List<ShoppingCartModel>)Session["shoppingCart"];

                    int IndexExistente = getIndex(productID);

                    if (IndexExistente == -1)
                    {
                        var productEntity = dbCtx.Products.Find(productID);

                        ShoppingCartModel item = new ShoppingCartModel(productEntity)
                        {
                            BarCode = productEntity.BarCode,
                            Description = productEntity.ProductName,
                            Price = productEntity.ProductPrice,
                            Quantity = 1,
                            Total = productEntity.ProductPrice * 1
                        };

                        shoppingCart.Add(item);
                    }
                    else
                    {
                        shoppingCart[IndexExistente].Quantity++;
                    }

                    Session["shoppingCart"] = shoppingCart;
                }
            

            return View();
        }

        public ActionResult Delete(int id)
        {
            List<ShoppingCartModel> shoppingCart = (List<ShoppingCartModel>)Session["shoppingCart"];
            shoppingCart.RemoveAt(getIndex(id));
            Session["shoppingCart"] = shoppingCart;
            return View("AgregarCarrito");
        }

        private int getIndex(int id)
        {
            List<ShoppingCartModel> shoppingCart = (List<ShoppingCartModel>)Session["shoppingCart"];

            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Products.ProductID == id)
                    return i;
            }

            return -1;
        }
    }
}