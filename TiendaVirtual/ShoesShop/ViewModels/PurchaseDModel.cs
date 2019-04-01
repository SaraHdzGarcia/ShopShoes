using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class PurchaseDModel
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Apellido Paterno")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Pais")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Codigo Postal")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Telefono")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }        

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name ="Forma de Pago")]
        public string Payment { get; set; }
    }
}