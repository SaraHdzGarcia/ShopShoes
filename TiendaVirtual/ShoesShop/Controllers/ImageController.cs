﻿using ShoesShop.Models;
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
            if (Session["UserName"] != null)
            {
                List<Products> products = dbCtx.Products.OrderBy(x => x.ProductName).ToList();

                return View(products);
            }
            else
            {
                return RedirectToAction("Index", "Index");
            }
        }
    }
}