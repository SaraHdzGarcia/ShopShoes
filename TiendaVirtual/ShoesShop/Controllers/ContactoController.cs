using ShoesShop.Models;
using ShoesShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop.Controllers
{
    public class ContactoController : Controller
    {
        DbContextShop dbCtx = new DbContextShop();

        // GET: Contacto
        public ActionResult Contact()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Contact(ContactModel cnt)
        {
            if (Session["UserName"] != null)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        int row = dbCtx.Contacts.Count();
                        if ((row == 0) || (row > 0))
                        {
                            Contact cn = new Contact()
                            {
                                Name = cnt.Name,
                                Email = cnt.Email,
                                Telephone = cnt.Telephone,
                                Message = cnt.Message
                            };
                            dbCtx.Contacts.Add(cn);
                            dbCtx.SaveChanges();
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
                
            }
            else
            {
                return RedirectToAction("Index", "Image");
            }
            return View();
        }
    }
}