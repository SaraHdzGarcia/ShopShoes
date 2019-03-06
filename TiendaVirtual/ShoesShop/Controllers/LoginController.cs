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
        public ActionResult Login(UserModel usm,string user, string pass)
        {
            if (ModelState.IsValid)
            {
                using (DbContextShop dbCtx = new DbContextShop())
                {
                    //int rows = dbCtx.Usersses.Count();
                    //if (rows >= 0)
                    //{
                    //    Userss usem = new Userss()
                    //    {
                    //        LastName = "Hernandez Garcia",
                    //        FirstName = "Sara",
                    //        Address="Av. La Unidad",
                    //        ExtNumber="539",
                    //        City="Escobedo",
                    //        PostalCode="64060",
                    //        Country="Mexico",
                    //        Telephone = "8124913721",
                    //        UserName = "SaraNhm",
                    //        Password = EncryptionDecryption.EncriptarSHA1("Sobrinos5"),
                    //    };
                    //    dbCtx.Usersses.Add(usem);
                    //    dbCtx.SaveChanges();
                //}
                string encryptedPass = EncryptionDecryption.EncriptarSHA1(usm.Password);

                var isLogged = dbCtx.Usersses
                        .Where(x => x.UserName.Equals(usm.UserName)
                        && x.Password.Equals(encryptedPass))
                        .FirstOrDefault();

                    if (isLogged != null)
                    {
                        Session["UserName"] = usm.UserName.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View(usm);
        }
    }
}