﻿using System;
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
                        sw.WriteLine("Login -" + DateTime.Now + " " + "El usuario : " + usm.UserName + " ingresó");
                        sw.Close();

                        return RedirectToAction("Index", "Image");
                    }

                }
            }

            return View(usm);
        }

        public ActionResult ModificarPerfil()
        {

            return View();
        }

        //GET
        public ActionResult Registrar()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Registrar(RegistrationModel userss)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (DbContextShop dbCtx = new DbContextShop())
                    {
                        int row = dbCtx.Usersses.Count();
                        if (row > 0)
                        {
                            Userss us = new Userss()
                            {
                                LastName = "",
                                FirstName = "",
                                Email = "",
                                UserName = "",
                                Password = EncryptionDecryption.EncriptarSHA1("")
                            };
                            dbCtx.Usersses.Add(us);
                            dbCtx.SaveChanges();
                            var path = Server.MapPath("~") + @"Files";
                            var fileName = "/Log2.txt";
                            StreamWriter sw = new StreamWriter(path + fileName, true);
                            sw.WriteLine("Metodo Registrar -" + DateTime.Now + "Se registró el cliente:" + userss.FirstName + "" + userss.LastName);
                            sw.Close();

                            return RedirectToAction("Index", "Image");
                        }


                    }
                }
            }
            catch
            {

            }
            return View(userss);
        }
    }
}