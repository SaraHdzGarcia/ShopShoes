using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class ContactModel
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name = "Telefono")]
        public string Telephone { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name = "Mensaje")]
        [DataType(DataType.Text)]
        public string Message { get; set; }
    }
}