using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Userss
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud maxima de 20")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String FirstName { get; set; }

        [StringLength(60, ErrorMessage = "Longitud maxima de 60")]
        public String Address { get; set; }

        [StringLength(8, ErrorMessage = "Longitud maxima de 60")]
        public String ExtNumber { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String City { get; set; }

        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Country { get; set; }

        [StringLength(24, ErrorMessage = "Longitud maxima de 24")]
        public String Telephone { get; set; }

        [StringLength(70,ErrorMessage ="Longitud maxima de 70")]
        [Required(ErrorMessage ="Campo obligatorio")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud maxima de 50")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud maxima de 50")]
        public String Password { get; set; }

        /*public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }*/
    }
}