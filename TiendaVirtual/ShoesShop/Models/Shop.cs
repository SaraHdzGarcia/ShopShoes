using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [StringLength(30,ErrorMessage ="Longitud maxima de 30")]
        public String Name { get; set; }

        [StringLength(60, ErrorMessage = "Longitud maxima de 60")]
        public String Address { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String City { get; set; }

        [StringLength(15, ErrorMessage = "Longitud maxima de 15")]
        public String Country { get; set; }

        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public String PostalCode { get; set; }

        [ForeignKey("Orders")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int OrderID { get; set; }
        public Orders Orders { get; set; }

        [ForeignKey("Employees")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int EmployeeID { get; set; }
        public Employees Employees { get; set; }

        [ForeignKey("Products")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int ProductID { get; set; }
        public Products Products { get; set; }
    }
}