using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesShop.ViewModels;
using ShoesShop.Models;
using ShoesShop.Helper;

namespace ShoesShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(UserModel usm)
        {
            if (ModelState.IsValid)
            {
                using (DbContextShop dbCtx = new DbContextShop())
                {
                    
                }
            }

            return View();
        }
    }
}