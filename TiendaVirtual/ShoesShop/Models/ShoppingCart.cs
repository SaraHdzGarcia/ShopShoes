using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartID { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Range(0,int.MaxValue,ErrorMessage ="Acepta valores enteros")]
        public int Quantity { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [DataType(DataType.Currency)]
        public Decimal Total { get; set; }

        [ForeignKey("Products")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int ProductID { get; set; }
        public Products Products { get; set; }

        [ForeignKey("Userss")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Acepta valores enteros")]
        public int UserID { get; set; }
        public Userss Userss { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }
    }
}