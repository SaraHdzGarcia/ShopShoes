using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseDetailID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud maxima de 20")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(60, ErrorMessage = "Longitud maxima de 60")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String State { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Country { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String PostalCode { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(24, ErrorMessage = "Longitud maxima de 24")]
        public String Telephone { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(70, ErrorMessage = "Longitud maxima de 70")]
        public String Email { get; set; }

        [StringLength(70,ErrorMessage ="Longitud maxima de 70")]
        public String MothersLastName { get; set; }

        [StringLength(60,ErrorMessage ="Longitud maxima de 60")]
        public String Payment { get; set; }

        [StringLength(60,ErrorMessage ="Longitud maxima de 60")]
        public String Shipping { get; set; }
    }
}