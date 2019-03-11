﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesShop.ViewModels;
using ShoesShop.Models;
using ShoesShop.Helper;
using System.IO;
using System.Data.Entity.Validation;

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
                                Password = EncryptionDecryption.EncriptarSHA1(""),
                                Address = "Av. Aztlan",
                                ExtNumber = "789",
                                City = "Monterrey",
                                Country = "Mexico",
                                PostalCode = "66069",
                                Telephone = "55 555 555 5555"

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
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                //throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

            return View(userss);
        }
    }
}