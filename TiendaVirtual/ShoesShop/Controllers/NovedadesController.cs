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
    public class NovedadesController : Controller
    {
        DbContextShop dbCtx = new DbContextShop();

        // GET: Novedades
        public ActionResult Novedades()
        {
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Novedades (NewsModel news)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int row = dbCtx.Subscriptions.Count();
                    if ((row == 0) || (row > 0))
                    {
                        Subscriptions sb = new Subscriptions()
                        {
                            Email = news.Email
                        };
                        dbCtx.Subscriptions.Add(sb);
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

            return View();
        }
    }
}