using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesShop.ViewModels;
using ShoesShop.Models;
using ShoesShop.Helper;
using System.IO;

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
                    string encryptedPass = EncryptionDecryption.EncriptarSHA1(usm.Password);

                var isLogged = dbCtx.Usersses
                        .Where(x => x.UserName.Equals(usm.UserName)
                        && x.Password.Equals(encryptedPass))
                        .FirstOrDefault();

                    if (isLogged != null)
                    {
                        Session["UserName"] = usm.UserName.ToString();

                        var path = Server.MapPath("~") + @"Files";
                        var fileName = "/Log.txt";
                        StreamWriter sw = new StreamWriter(path + fileName, true);
                        sw.WriteLine("Login -" + DateTime.Now + " " + "El usuario : " + usm.UserName +  " ingresó");
                        sw.Close();

                        return RedirectToAction("Index", "Image");
                    }
                }
            }

            return View(usm);
        }
    }
}