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
    public class PurchaseDetailController : Controller
    {
        DbContextShop dbCtx = new DbContextShop();

        //GET: PurchaseDetail
        public ActionResult PurchaseDetail()
        {
            return View();
        }

        //Post: PurchaseDetail
        [HttpPost]
        public ActionResult PurchaseDetail(PurchaseDModel purchase)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int row = dbCtx.PurchaseDetails.Count();
                    if ((row == 0) || (row > 0))
                    {
                        PurchaseDetail pd = new PurchaseDetail()
                        {
                            FirstName = purchase.Name,
                            LastName = purchase.LastName,
                            Address = purchase.Address,
                            State = purchase.State,
                            Country = purchase.Country,
                            Telephone = purchase.Telephone,
                            PostalCode = purchase.PostalCode,
                            Email = purchase.Email,
                            Payment = purchase.Payment,
                            Shipping = purchase.Shipping

                        };
                        dbCtx.PurchaseDetails.Add(pd);
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

            return View(purchase);
        }

        public ActionResult pediddo()
        {
            List<ShoppingCartModel> shoppingCart = new List<ShoppingCartModel>();

            return View(shoppingCart);
        }
    }
}
