using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class UsersModel
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Numero exterior")]
        public string ExtNumber { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Ciudad")]
        public string City { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Código Postal")]
        public string Code { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Pais")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Telefono")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }
    }
}