using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.ViewModels
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name ="Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name ="Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}